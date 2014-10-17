using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplexForms.Models
{
    public class ComplexVM
    {
        public SimpleFirstVM simpleFirstVM { get; set; }
        public SimpleSecondVM simpleSecondVM { get; set; }

        public bool Flag { get; set; }
    }
}