using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dreams.Models
{
    public struct MenuItem
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Label { get; set; }
        public List<MenuItem> DropdownItems { get; set; }
    }
}
