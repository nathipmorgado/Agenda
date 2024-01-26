using Agenda.Domain;
using System;
using System.Collections.Generic;

namespace Agenda.DAL
{
    public interface IContatos
    {
        IContato Obter(Guid id);
    }
}
