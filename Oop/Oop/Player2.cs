using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Player2
    {
        // Topic: Private Attribute
        public string name = "Laiba";
        
        // Protection:
        private int health = 77; // isy easily access nahi kr skty.Isy method k through build krna hoga.

        // private var ko access k liyay method.
        public int GetHealth()

        {
            return health;
        }
    }
}
