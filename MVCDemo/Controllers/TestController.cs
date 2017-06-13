using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //ViewBag.Message = "Đây là nội dung của ViewBag.Message";
            //ViewBag.CurrentTime = DateTime.Now;
            //var user = new List<User>();
            ////
            //var user1 = new User();
            //user1.Name = "ABC";
            ////user1.address = "Dương Đình Nghệ, Yên Hòa, Cầu Giấy, Hà Nội";
            //user1.Email = "abc@gmail.com";
            ////
            //var user2 = new User();
            //user2.Name = "CDE";
            ////user2.address = "Dương Đình Nghệ, Yên Hòa, Cầu Giấy, Hà Nội";
            //user2.Email = "abc@gmail.com";
            ////
            //var user3 = new User();
            //user3.Name = "XYZ";
            ////user3.address = "Dương Đình Nghệ, Yên Hòa, Cầu Giấy, Hà Nội";
            //user3.Email = "abc@gmail.com";
            ////
            //user.Add(user1);
            //user.Add(user2);
            //user.Add(user3);
            ////
            //ViewBag.user = user;

            return View();
        }
    }
}