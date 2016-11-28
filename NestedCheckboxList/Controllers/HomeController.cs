using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var grList = new List<Group>();
            
            var group = new Group();
            group.Id = 1;
            group.Name = "Главная группа";

            var o1 = new Option()
            {
                Name = "Группа 1",
                Id = 11               
            };
            var o2 = new Option()
            {
                Name = "Группа 2",
                Id = 22
            };
                        
            group.Options.Add(o1);
            group.Options.Add(o2);

            var v1 = new Value()
            {
                Name = "Опция 1",
                Id = 111
            };
            var v2 = new Value()
            {                
                Name = "Опция 2",
                Id = 112
            };
            var v3 = new Value()
            {                
                Name = "Опция 3",
                Id = 211
            };
            var v4 = new Value()
            {                
                Name = "Опция 4",
                Id = 212
            };
                       
            o1.Values.Add(v1);
            o1.Values.Add(v2);
            o2.Values.Add(v3);
            o2.Values.Add(v4);

            grList.Add(group);

            return View(grList);
        }

        [HttpPost]
        public ActionResult Index(List<Group> model)
        {
            return View(model);
        }
    }
}