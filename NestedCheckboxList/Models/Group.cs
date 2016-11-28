using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class Group
    {
        public Group()
        {
            Child = new List<SelectListItem>();
            Options = new List<Option>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Checked { get; set; }
        public List<Option> Options { get; set; }
        public List<SelectListItem> Child { get; set; }
    }
}