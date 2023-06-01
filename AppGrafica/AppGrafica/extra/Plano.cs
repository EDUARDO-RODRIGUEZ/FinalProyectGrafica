using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extra
{
    public class Plano
    {
        private float ancho;
        private float alto;
        private float profundidad;
        private Punto origen;

        public Plano(Punto origen, float ancho, float alto, float profundidad)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.profundidad = profundidad;
            this.origen = origen;
        }

        public void draw()
        {
            PrimitiveType primitiveType = PrimitiveType.Lines;
            ejeX(primitiveType);
            ejeY(primitiveType);
            ejeZ(primitiveType);
        }

        public void ejeX(PrimitiveType primitiveType)
        {
            GL.Color3(new Vector3(1, 0, 0));
            GL.Begin(primitiveType);
            GL.Vertex3(origen.X + ancho, origen.Y, origen.Z);
            GL.Vertex3(origen.X - ancho, origen.Y, origen.Z);
            GL.End();
        }

        public void ejeY(PrimitiveType primitiveType)
        {
            GL.Color3(new Vector3(0, 1, 0));
            GL.Begin(primitiveType);
            GL.Vertex3(origen.X, origen.Y + alto, origen.Z);
            GL.Vertex3(origen.X, origen.Y - alto, origen.Z);
            GL.End();
        }

        public void ejeZ(PrimitiveType primitiveType)
        {
            GL.Color3(new Vector3(0, 0, 1));
            GL.Begin(primitiveType);
            GL.Vertex3(origen.X, origen.Y, origen.Z + profundidad);
            GL.Vertex3(origen.X, origen.Y, origen.Z - profundidad);
            GL.End();

        }
    }
}
