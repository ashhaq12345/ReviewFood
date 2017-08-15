using ReviewFood.DAL;
using ReviewFood.Models;
using ReviewFood.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.BLL
{
    public class RestaurantManager : IRestaurantManager
    {
        private IRestaurantRepository _repository;

        public RestaurantManager()
        {
            _repository = new RestaurantRepository();
        }

        public RestaurantManager(IRestaurantRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Restaurant restaurant)
        {
            return _repository.Add(restaurant);
        }

        public ICollection<Restaurant> GetAll()
        {
            return _repository.GetAll();
        }

        public Restaurant GetById(long id)
        {
            return _repository.GetById(id);
        }

        public bool Remove(long id)
        {
            var restaurant = GetById(id);
            if (restaurant == null)
            {
                return false;
            }

            return _repository.Remove(restaurant);
        }

        public bool Update(Restaurant restaurant)
        {
            return _repository.Update(restaurant);
        }
    }
}