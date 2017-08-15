using ReviewFood.DAL;
using ReviewFood.Models;
using ReviewFood.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.BLL
{
    public class ReviewManager
    {
        private IReviewRepository _repository;

        public ReviewManager()
        {
            _repository = new ReviewRepository();
        }

        public ReviewManager(IReviewRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Review review)
        {
            return _repository.Add(review);
        }

        public ICollection<Review> GetAll()
        {
            return _repository.GetAll();
        }

        public Review GetById(long id)
        {
            return _repository.GetById(id);
        }

        public bool Remove(long id)
        {
            var review = GetById(id);
            if (review == null)
            {
                return false;
            }

            return _repository.Remove(review);
        }

        public bool Update(Review review)
        {
            return _repository.Update(review);
        }
    }
}