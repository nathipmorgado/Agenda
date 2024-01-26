using System;
using System.Collections.Generic;
using Agenda.Domain;
using Agenda.DAL;
using NUnit.Framework;
using Moq;

namespace Agenda.Repository.Test
{
    [TestFixture]
    public class RepositoryContatoTeste
    {
       Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositoryContatos _repositoryContatos;
        
        public void SetUp()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositoryContatos = new RepositoryContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefonica()
        {
           var telefoneId = Guid.NewGuid();
           var contatoId = Guid.NewGuid();
           var lstTelefone = new List<ITelefone>();

            var mContato = IContatoConstrutor.Um().ComId(contatoId).ComNome("João").Obter();
            mContato.SetupSet(o => o.Telefones = It.IsAny<List<ITelefone>>())
                .Callback<List<ITelefone>>(p => lstTelefone = p);
            _contatos.Setup(o => o.Obter(contatoId)).Returns(mContato.Object);

            var mockTelefone = ITelefoneConstrutor.Um().Padrao().ComId(telefoneId)
               .ComContatoId(contatoId).Construir();
           
            _telefones.Setup(o => o.ObterTodosDoContato(contatoId))
                .Returns(new List<ITelefone> { mockTelefone });
            
           var contatoResultado = _repositoryContatos.ObterPorId(contatoId);
            mContato.SetupGet(o => o.Telefones).Returns(lstTelefone);

            Assert.AreEqual(mContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(1, contatoResultado.Telefones.Count);
            Assert.AreEqual(mockTelefone.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mockTelefone.Id, contatoResultado.Telefones[0].Id);
            Assert.AreEqual(mContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _telefones = null;
            _repositoryContatos = null;
        }
    }
}
