using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
           
        }
        public bool CanFly { get; set; }
        public string BirdName { get; set; }
        public bool HasFeathers { get; set; }
        public string BirdPrimaryColor { get; set; }

    }
}
