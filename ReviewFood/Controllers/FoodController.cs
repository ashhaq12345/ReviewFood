using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IdentitySample.Models;
using ReviewFood.Models;
using ReviewFood.Models.Interface;
using ReviewFood.BLL;
using Microsoft.AspNet.Identity;

namespace ReviewFood.Controllers
{
    public class FoodController : Controller
    {
        private IFoodManager _foodManager;
        private IRestaurantManager _restaurantManager;

        public FoodController()
        {
            _foodManager = new FoodManager();
            _restaurantManager = new RestaurantManager();
        }

        // GET: Food
        public ActionResult Index()
        {
            var foods = _foodManager.GetAll();
            return View(foods.ToList());
        }

        // GET: Food/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = _foodManager.GetById((long)id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            ViewBag.RestaurantId = new SelectList(_restaurantManager.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Food/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Picture,RestaurantId")] Food food)
        {
            if (ModelState.IsValid)
            {
                _foodManager.Add(food);
                return RedirectToAction("Index");
            }

            ViewBag.RestaurantId = new SelectList(_restaurantManager.GetAll(), "Id", "Name");
            return View(food);
        }

        // GET: Food/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = _foodManager.GetById((long)id);
            if (food == null)
            {
                return HttpNotFound();
            }
            ViewBag.RestaurantId = new SelectList(_restaurantManager.GetAll(), "Id", "Name");
            return View(food);
        }

        // POST: Food/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Picture,RestaurantId")] Food food)
        {
            if (ModelState.IsValid)
            {
                _foodManager.Update(food);
                return RedirectToAction("Index");
            }
            ViewBag.RestaurantId = new SelectList(_restaurantManager.GetAll(), "Id", "Name");
            return View(food);
        }

        // GET: Food/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Food food = _foodManager.GetById((long)id);
            if (food == null)
            {
                return HttpNotFound();
            }
            return View(food);
        }

        // POST: Food/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            _foodManager.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
