using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Editing;
using Movies.web.Models;
using System.Collections.Generic;


namespace Movies.web.Controllers
{
    public class salesController : Controller
    {
        // GET: salesController
        public ActionResult Index()
        {
            IEnumerable<Movies.web.Models.sales> Sales = new List<sales>() {
                new sales {
                    id=1,
                    name_client = "Alberto Sanchez",
                    movie = "Rapidos y furiosos",
                    price =3000,
                    date = DateTime.Now
                },
                new sales {
                    id=2,
                    name_client = "Carlos Vargaz",
                    movie = "X-Men",
                    price =1500,
                    date = DateTime.Now
                },
                new sales {
                    id=2,
                    name_client = "Angela Veloz",
                    movie = "Los pitufos",
                    price =2000,
                    date = DateTime.Now
                },
                new sales {
                    id=2,
                    name_client = "Andrea Perez",
                    movie = "X-Men",
                    price =1500,
                    date = DateTime.Now
                },
                new sales {
                    id=2,
                    name_client = "Selena Dominguez",
                    movie ="Los pitufos",
                    price =2000,
                    date = DateTime.Now
                },
                new sales {
                    id=2,
                    name_client = "Keyla santos",
                    movie ="After",
                    price =1800,
                    date = DateTime.Now
                },

            };

            return View(Sales);
        }

        // GET: salesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: salesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: salesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.sales sales)
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

        // GET: salesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: salesController/Edit/5
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

        // GET: salesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: salesController/Delete/5
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
