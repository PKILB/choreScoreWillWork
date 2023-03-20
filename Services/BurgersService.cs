using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScoreWillWork.Services
{
    public class BurgersService
    {
        private readonly BurgersRepository _repo;

        public BurgersService(BurgersRepository repo)
        {
            _repo = repo;
        }

        public List<Burger> GetAllBurgers()
        {
            return _repo.GetAllBurgers();
        }

        internal Burger CreateBurger(Burger burgerData)
        {
            Burger burger = _repo.CreateBurger(burgerData);
            return burger;
        }

        internal Burger GetOneBurger(int id)
        {
            Burger burger = _repo.GetOneBurger(id);
            if (burger == null) throw new Exception($"No burger at id:{id}");
            return burger;
        }

        internal string RemoveBurger(int burgerId)
        {
            Burger burger = this.GetOneBurger(burgerId);
            bool result = _repo.RemoveBurger(burgerId);
            if (!result) throw new Exception("Didn't delete any burgers for some reason");
            return $"{burgerId} was destroyed by the customer.";
        }
    }
}