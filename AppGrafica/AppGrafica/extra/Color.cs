using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extra
{
    public class Color
    {
        public float r;
        public float g;
        public float b;

        public Color()
        {
            this.r = 0;
            this.g = 0;
            this.b = 0;
        }

        public Color(float red, float green, float blue)
        {
            this.r = red;
            this.g = green;
            this.b = blue;
        }

        public Vector3 toVector3()
        {
            return new Vector3(this.r, this.g, this.b);
        }
    }
}
