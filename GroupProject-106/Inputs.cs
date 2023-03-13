using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Inputs
    {
        [DisplayName("inputs")]
        public double Value { get; set; }
        public override string ToString() {
            return $"{Value}";
        }
        
    }
}
