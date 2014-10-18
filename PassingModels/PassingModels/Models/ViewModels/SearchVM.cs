using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PassingModels.Models.ViewModels
{
    public class SearchVM
    {
        public string Setting { get; set; }
        public string Setting2 { get; set; }
        public string Query { get; set; }
        public List<DbModel> Results { get; set; }
    }
}