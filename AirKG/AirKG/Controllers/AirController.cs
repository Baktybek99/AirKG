using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirKG.Controllers
{
    public class AirController : Controller
    {
        // GET: AirController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AirController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AirController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AirController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AirController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AirController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AirController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AirController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
