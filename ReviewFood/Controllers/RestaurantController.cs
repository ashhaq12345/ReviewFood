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
using ReviewFood.BLL;

namespace ReviewFood.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantManager _restaurantManager;

        public RestaurantController()
        {
            _restaurantManager = new RestaurantManager();
        }

        // GET: Restaurant
        public ActionResult Index()
        {
            var restaurants = _restaurantManager.GetAll();
            return View(restaurants.ToList());
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurant restaurant = _restaurantManager.GetById((long)id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantManager.Add(restaurant);
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurant restaurant = _restaurantManager.GetById((long)id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _restaurantManager.Update(restaurant);
                return RedirectToAction("Index");
            }
            return View(restaurant);
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurant restaurant = _restaurantManager.GetById((long)id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            _restaurantManager.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
