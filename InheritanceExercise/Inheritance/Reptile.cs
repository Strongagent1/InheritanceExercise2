using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public string ReptileName { get; set; }
        public string ReptileColor { get; set; }
        public bool HasScales { get; set; }
        public bool EatsInsects { get; set; }

    }
}
