using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class Option
    {
        public Option()
        {
            Child = new List<SelectListItem>();
            Values = new List<Value>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public bool Checked { get; set; }
        public Group Group { get; set; }
        public List<Value> Values { get; set; }
        public List<SelectListItem> Child { get; set; }
    }
}