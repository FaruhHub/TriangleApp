using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TriangleApp.Models;

namespace TriangleApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/FindHypotenuse
        [HttpGet]
        public ActionResult FindHypotenuse()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost] // метод будет вызываться только при POST запросах
        public ActionResult FindHypotenuse(Triangle triangle)
        {
            ViewBag.Hypotenuse = Math.Sqrt(Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2));

            return View(triangle);
        }

        [System.Web.Mvc.HttpGet] // метод будет вызываться только при POST запросах
        public ActionResult FindCathetus()
        {
            return View();
        }

        [HttpPost] // метод будет вызываться только при POST запросах
        public ActionResult FindCathetus(Triangle triangle)
        {
            if (ModelState.IsValid)
            {
                double result = Math.Sqrt(Math.Pow(triangle.C, 2) - Math.Pow(triangle.B, 2));
                if (!Double.IsNaN(result))
                {
                    ViewBag.Cathetus = result;
                }
                else
                {
                    ViewBag.Cathetus = "Значение гипотенузы должно быть больше значения катета";
                }

            }
            return View();
        }

        public ActionResult CalculateArea()
        {
            return View();
        }

        [HttpPost] // метод будет вызываться только при POST запросах
        public ActionResult CalculateArea(Triangle triangle)
        {
            if (ModelState.IsValid)
            {
                if (triangle.A + triangle.B < triangle.C ||
                triangle.A + triangle.C < triangle.B ||
                triangle.B + triangle.C < triangle.A)
                {
                    ViewBag.Msg = @"Данный треугольник является не равным. Попробуйте другие значения.";
                }
                else
                {
                    ViewBag.Msg = @"Данный треугольник является равным";

                    double p = (triangle.A + triangle.B + triangle.C) / 2.0;
                    double s = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
                    ViewBag.Area = s;
                }
            }
            
            return View();
        }
    }
}
