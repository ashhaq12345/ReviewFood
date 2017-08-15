using ReviewFood.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewFood.Models;
using ReviewFood.DAL;

namespace ReviewFood.BLL
{
    public class FoodManager : IFoodManager
    {
        private IFoodRepository _repository;

        public FoodManager()
        {
            _repository = new FoodRepository();
        }

        public FoodManager(IFoodRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Food entity)
        {
            return _repository.Add(entity);
        }

        public ICollection<Food> GetAll()
        {
            return _repository.GetAll();
        }

        public Food GetById(long id)
        {
            return _repository.GetById(id);
        }

        public bool Remove(long id)
        {
            var entity = GetById(id);
            if(entity == null)
            {
                return false;
            }
            return _repository.Remove(entity);
        }

        public bool Update(Food entity)
        {
            return _repository.Update(entity);
        }
    }
}