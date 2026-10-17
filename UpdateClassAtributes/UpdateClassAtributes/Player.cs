using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace UpdateClassAtributes
{
    internal class Player
    {
        // Attr/Properties
        public string Name;
        public int Health;

        // Method k through Attr ki value update krein gy.
        public void MaxHealth(int h)
        {
            Health = h;
        }

    }
}
