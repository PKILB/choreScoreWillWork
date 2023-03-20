using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScoreWillWork.Models
{
    public class Burger
    {
        public Burger(string cheese, string tomato, string pickle, int patties, int id)
        {
            Cheese = cheese;
            Tomato = tomato;
            Pickle = pickle;
            Patties = patties;
            Id = id;
        }

        public string Cheese {get; set; }
        public string Tomato {get; set; }
        public string Pickle {get; set; }
        public int Patties {get; set; }
        public int Id {get; set; }
    }
}