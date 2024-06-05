﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneClassLibrairy
{
    public  class Person
    {
        public string ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly DOB { get; set; }= default(DateOnly);

        public ICollection<Identification> identification { get; set; }
        public int CalAge()
        {
            return DateTime.Now.Year- DOB.Year;
        }
    }
}