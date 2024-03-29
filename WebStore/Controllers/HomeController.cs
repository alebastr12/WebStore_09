﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id=1,
                FirstName = "Иван",
                LastName = "Пузиков",
                Patronymic =  "Александрович",
                Age = 22
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Владислав",
                LastName = "Петров",
                Patronymic = "Иванович",
                Age = 35
            }
        };

        // GET: Home
        public ActionResult Index()
        {
            //return Content("Привет. Я твой первый контроллер");
            return View(_employees);
        }

        public ActionResult Details(int id)
        {
            //return Content("Привет. Я твой первый контроллер");
            return View(_employees.FirstOrDefault(x => x.Id == id));
        }

    }
}