using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Maxim.Core.DataAccess
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
