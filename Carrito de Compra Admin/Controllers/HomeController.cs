﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carrito_de_Compra_Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }  
        
        public ActionResult Marcas()
        {
            return View();
        }     
        
        public ActionResult Productos()
        {
            return View();
        }    
        
        public ActionResult Categorias()
        {
            return View();
        }

    }
}