using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MockSchoolManagement.DataRepositories;
using MockSchoolManagement.Models;
using MockSchoolManagement.ViewModels;

namespace MockSchoolManagement.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;

        // 使用构造函数注入的方式注入 IStudentRepository
        public HomeController()
        {
            // _studentRepository = studentRepository;
            _studentRepository = new MockStudentRepository();
        }

        [Route("/")]
        public ViewResult Index() 
        {
            // 不推荐的做法
            /* var _studentRepository = new MockStudentRepository();
             return _studentRepository.GetStudent(1).Name; */
            //return _studentRepository.GetStudent(1).Name;
            var model = _studentRepository.GetAllStudents();
            return View(model);

        }


        public ViewResult Details(int?id) {
            Student model = _studentRepository.GetStudent(1);
            // return new ObjectResult(model);
            // return View("../Test/Details");

            // 使用ViewData将PageTitle和Student模型传递给View
            //ViewData["PageTitle"] = "Studeng Details";
            //ViewData["Student"] = model;

            // ViewBag.PageTitle = "学生详情";
            //ViewBag.Student = model;

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(id??1),
                PageTitle = "学生详情"
            };

            return View(homeDetailsViewModel);
        }

       
    }
}
