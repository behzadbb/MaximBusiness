using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maxim.Core.DataAccess
{
    public class BusinessEntities : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}