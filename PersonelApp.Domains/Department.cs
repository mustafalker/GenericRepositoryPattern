﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Personels = new List<Personel>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
