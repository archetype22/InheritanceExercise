using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool DoesFly { get; set; }
        public int Wingspan { get; set; }
        public string BeakShape { get; set; }
        public bool IsCarrion { get; set; }
    }
}
