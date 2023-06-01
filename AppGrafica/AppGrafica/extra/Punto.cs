using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extra
{
    public class Punto
    {
        public float X;
        public float Y;
        public float Z;

        public Punto()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public Punto(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3 toVector3()
        {
            return new Vector3(this.X, this.Y, this.Z);
        }

        public void setVector(Vector3 vector)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = vector.Z;
        }
    }
}
