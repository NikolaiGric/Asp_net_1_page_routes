using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Сдать_и_сделать_.Controllers
{
    public class AboutController : Controller
    {
        // GET: About_as
        public ActionResult Index()
        {
            return View();
        }

        // GET: About_as/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: About_as/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: About_as/Create
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

        // GET: About_as/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: About_as/Edit/5
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

        // GET: About_as/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: About_as/Delete/5
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
