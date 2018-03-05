using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class ArbolEnteroController : Controller
    {
       

        // GET: ArbolEntero
        public ActionResult Index()
        {
            Enteros ente = new Enteros();

            var path = @"D:\Descargas\dataEnteros.json";
            var contenido = System.IO.File.ReadAllText(path);

            //Recibe un objeto generico, agarramos la cadena de texto de Json
            // y lo convertimos en un objeto

            var arbol = JsonConvert.DeserializeObject<Arbol<Enteros>>(contenido);

            Data.DataEnteros.Instance.arbol = arbol;

            var cadena = JsonConvert.SerializeObject(arbol);

            TempData["Arbol"] = cadena;


            return View();

        }

        public ActionResult Eliminar_Nodo(string TBEliminar)
        {
            return View();
        }

        public ActionResult Insertar_Nodo(string TBInsertar)
        {
            Enteros ente = new Enteros();

            ente.nombre = Convert.ToInt64(TBInsertar);

            var raiz = Data.DataEnteros.Instance.arbol;

            Data.DataEnteros.Instance.arbol.Insertar(raiz, ente);

            var cadena = JsonConvert.SerializeObject(Data.DataPais.Instance.arbol);

            TempData["Arbol"] = cadena;



            return View("Index");

        }




        // GET: ArbolEntero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArbolEntero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArbolEntero/Create
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

        // GET: ArbolEntero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArbolEntero/Edit/5
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

        // GET: ArbolEntero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArbolEntero/Delete/5
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
