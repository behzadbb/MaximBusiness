using System;
using System.Collections.Generic;
using System.Text;

namespace Maxim.Core.DataAccess
{
    interface IPersonRepository : IDisposable
    {
        List<Person> GetAll();
        void Insert(Person person);
        void Save();
    }
}
