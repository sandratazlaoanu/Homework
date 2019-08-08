using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tema3_ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //public override string ToString()
        //{
        //    return $"Product info: {Id + " " + Name + " " + Description}";
        //}
    }
}
