using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class ArbolController : Controller
    {
        // GET: Arbol
        public ActionResult Index()
        {
            Pais pais = new Pais();

            var path = @"D:\Descargas\dataPaises.json";
            var contenido = System.IO.File.ReadAllText(path);

            //Recibe un objeto generico, agarramos la cadena de texto de Json
            // y lo convertimos en un objeto

            var arbol = JsonConvert.DeserializeObject<Arbol<Pais>>(contenido);

            Data.DataPais.Instance.arbol = arbol;

            var cadena = JsonConvert.SerializeObject(arbol);

            TempData["Arbol"] = cadena;
            

            return View();
        }

        public ActionResult Insertar_Nodo(string TBNombrePais, String TBGrupoPais)
        {
            Pais pais = new Pais();

            pais.nombre = TBNombrePais;
            pais.Grupo = TBGrupoPais;

            var raiz = Data.DataPais.Instance.arbol;

            Data.DataPais.Instance.arbol.Insertar(raiz, pais);

            var cadena = JsonConvert.SerializeObject(Data.DataPais.Instance.arbol);

            TempData["Arbol"] = cadena;



            return View("Index");
        }

        public ActionResult Orden()
        {
            Pais pais = new Pais();
            
            
            var raiz = Data.DataPais.Instance.arbol;

            Data.DataPais.Instance.arbol.InOrden(raiz);


            var cadena = JsonConvert.SerializeObject(Data.DataPais.Instance.arbol);

            TempData["Orden"] = cadena;



            return View("Index");
        }






        public ActionResult Eliminar_Nodo(string TBNombreEliminar,string TBGrupoEliminar)
        {
            Pais pais = new Pais();

            pais.nombre = TBNombreEliminar;
            pais.Grupo = TBGrupoEliminar;

           
            var raiz = Data.DataPais.Instance.arbol;

            Data.DataPais.Instance.arbol.Eliminar(raiz, pais);

            var cadena = JsonConvert.SerializeObject(Data.DataPais.Instance.arbol);

            TempData["Arbol"] = cadena;


            return View("Index");
        }

        



        // GET: Arbol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Arbol/Create
        public ActionResult Create()
        {
            ViewBag.showSuccessAlert = false;

            return View();
        }

        // POST: Arbol/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.showSuccessAlert = true;

            return View();
        }

        // GET: Arbol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Arbol/Edit/5
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

        // GET: Arbol/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        
        

        // POST: Arbol/Delete/5
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
