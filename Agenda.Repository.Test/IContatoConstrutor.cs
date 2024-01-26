using Agenda.Domain;
using System;

namespace Agenda.Repository.Test
{
    public class IContatoConstrutor : BaseConstrutor<IContato>
    {
        protected IContatoConstrutor() : base (){}
        public static IContatoConstrutor Um()
        {
            return new IContatoConstrutor();
        }

        public IContatoConstrutor ComNome(string nome)
        {
            _mock.SetupGet(o => o.Nome).Returns(nome);
            return this;
        }

        public IContatoConstrutor ComId(Guid id)
        {
            _mock.SetupGet(o => o.Id).Returns(id);
            return this;
        }
    }
}
