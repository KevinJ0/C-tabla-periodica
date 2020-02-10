using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using MvcTablaPeriodica.Models;

namespace MvcTablaPeriodica.Controllers
{
    public class TablaPeriodicaController : Controller
    {

      
 

        // GET: TablaPeriodica
        public ActionResult Index()
        {


            List<Elemento> elements = new List<Elemento>();
            var myJsonString = System.IO.File.ReadAllText("wwwroot/dist/PeriodicTableJSON.json");
            dynamic jToken = JToken.Parse(myJsonString).ElementAt<JToken>(0).First;
            int nElementos = 0;
            foreach (var item in jToken)
            {
                nElementos++;
                elements.Add(item.Next);
            }
            ViewBag.ListElements = jToken;
            return View();
        }

        // GET: TablaPeriodica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TablaPeriodica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TablaPeriodica/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TablaPeriodica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TablaPeriodica/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TablaPeriodica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TablaPeriodica/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}