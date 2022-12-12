using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string Texture { get; set; }
        public bool HasTail { get; set; }
        public bool DoesHibernate { get; set; }

        public bool IsColdBlooded { get; set; } 
    }
}
