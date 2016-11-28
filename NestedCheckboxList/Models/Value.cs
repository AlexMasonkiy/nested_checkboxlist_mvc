using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Value
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public bool Checked { get; set; }
    }
}