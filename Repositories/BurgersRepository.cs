using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScoreWillWork.Repositories
{
    public class BurgersRepository
    {
        private List<Burger> dbBurgers = new List<Burger>();

        public BurgersRepository()
        {
            dbBurgers.Add(new Burger("Cheese", "Tomato", "Pickle", 3, 1));
            dbBurgers.Add(new Burger("Cheese", "Tomato", "Pickle", 5, 2));
            dbBurgers.Add(new Burger("Cheese", "Tomato", "Pickle", 1, 3));
        }

        internal Burger CreateBurger(Burger burgerData)
        {
            burgerData.Id = dbBurgers[dbBurgers.Count - 1].Id + 1;
            dbBurgers.Add(new Burger(burgerData.Cheese, burgerData.Tomato, burgerData.Pickle, burgerData.Patties, burgerData.Id));
            return burgerData;
        }

        internal List<Burger> GetAllBurgers()
        {
            return dbBurgers;
        }

        internal Burger GetOneBurger(int id)
        {
            Burger burger = dbBurgers.Find(burger => burger.Id == id);
            return burger;
        }

        internal bool RemoveBurger(int burgerId)
        {
            int count = dbBurgers.RemoveAll(burger => burger.Id == burgerId);
            return count > 0;
        }
    }
}