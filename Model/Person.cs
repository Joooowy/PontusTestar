using System;
using System.Collections.Generic;

namespace UppgifterEF
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}