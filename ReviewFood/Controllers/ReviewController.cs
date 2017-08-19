using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReviewFood.Models;
using ReviewFood.Models.Interface;
using ReviewFood.BLL;

namespace ReviewFood.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewManager _reviewManager;
        private IFoodManager _foodManager;

        public ReviewController()
        {
            _reviewManager = new ReviewManager();
            _foodManager = new FoodManager();
        }

        // GET: Review
        public ActionResult Index()
        {
            var reviews = _reviewManager.GetAll();
            return View(reviews.ToList());
        }

        // GET: Review/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = _reviewManager.GetById((long)id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Review/Create
        public ActionResult Create()
        {
            ViewBag.FoodId = new SelectList(_foodManager.GetAll(), "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users.ToList(), "Id", "Email");
            return View();
        }

        // POST: Review/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,Rating,FoodId,UserId")] Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewManager.Add(review);
                return RedirectToAction("Index");
            }

            ViewBag.FoodId = new SelectList(_foodManager.GetAll(), "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users.ToList(), "Id", "Email");
            return View(review);
        }

        // GET: Review/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = _reviewManager.GetById((long)id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.FoodId = new SelectList(_foodManager.GetAll(), "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users.ToList(), "Id", "Email");
            return View(review);
        }

        // POST: Review/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,Rating,FoodId,UserId")] Review review)
        {
            if (ModelState.IsValid)
            {
                _reviewManager.Update(review);
                return RedirectToAction("Index");
            }
            ViewBag.FoodId = new SelectList(_foodManager.GetAll(), "Id", "Name");
            ViewBag.UserId = new SelectList(db.Users.ToList(), "Id", "Email");
            return View(review);
        }

        // GET: Review/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = _reviewManager.GetById((long)id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Review/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            _reviewManager.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
