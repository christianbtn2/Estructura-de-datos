using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class PorFechaController : Controller
    {
        //
        // GET: /PorFecha/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /PorFecha/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PorFecha/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PorFecha/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PorFecha/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PorFecha/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PorFecha/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PorFecha/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
