using AppGrafica.extra;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extructura
{
    public class Face : ITransform
    {
        public Punto origen;
        public Dictionary<string, Punto> vertices;
        public Color color;

        private Matrix3 mscale;
        private Matrix3 mrotate;
        private Punto origenObjeto;
        private Punto origenScene;

        public Face()
        {
            this.mscale = Matrix3.Identity;
            this.mrotate = Matrix3.Identity;
        }

        public void setOrigenScene(Punto p)
        {
            this.origenScene = p;
        }

        public void setOrigenObjeto(Punto p)
        {
            this.origenObjeto = p;
        }

        private void showCenter()
        {
            GL.Begin(PrimitiveType.Points);
            GL.Color3(new Vector3(1, 1, 1));
            GL.Vertex3(origenScene.X, origenScene.Y, origenScene.Z);
            GL.End();

            GL.Begin(PrimitiveType.Points);
            GL.Color3(new Vector3(1, 1, 1));
            GL.Vertex3(origenScene.X + origenObjeto.X, origenScene.Y + origenObjeto.Y, origenScene.Z + origenObjeto.Z);
            GL.End();

            GL.Begin(PrimitiveType.Points);
            GL.Color3(new Vector3(1, 1, 1));
            GL.Vertex3((origen.X + origenObjeto.X + origenScene.X), (origen.Y + origenObjeto.Y + origenScene.Y), (origen.Z + origenObjeto.Z + origenScene.Z));
            GL.End();
        }

        public void draw()
        {
            showCenter();
            GL.Color3(color.toVector3());
            GL.Begin(PrimitiveType.Polygon);
            foreach (var vertice in vertices.Values)
            {
                GL.Vertex3(
                    vertice.X + origen.X + origenObjeto.X + origenScene.X,
                    vertice.Y + origen.Y + origenObjeto.Y + origenScene.Y,
                    vertice.Z + origen.Z + origenObjeto.Z + origenScene.Z
                );
            }
            GL.End();
        }

        public void rotate(float x, float y, float z)
        {
            float anglex = MathHelper.DegreesToRadians(x);
            float angley = MathHelper.DegreesToRadians(y);
            float anglez = MathHelper.DegreesToRadians(z);
            mrotate = Matrix3.CreateRotationX(anglex) * Matrix3.CreateRotationY(angley) * Matrix3.CreateRotationZ(anglez);
            foreach (var vertice in vertices.Values)
            {
                vertice.setVector(vertice.toVector3() * mrotate);
            }
        }

        public void rotateObjeto(float x, float y, float z)
        {
            rotate(x, y, z);
            origen.setVector(origen.toVector3() * mrotate);
        }


        public void scale(float x, float y, float z)
        {
            mscale = Matrix3.CreateScale(x, y, z);
            foreach (var vertice in vertices.Values)
            {
                vertice.setVector(vertice.toVector3() * mscale);
            }
        }

        public void scaleObjeto(float x, float y, float z)
        {
            mscale = Matrix3.CreateScale(x, y, z);
            foreach (var vertice in vertices.Values)
            {
                vertice.setVector(vertice.toVector3() * mscale);
            }
            origen.setVector(origen.toVector3() * mscale);
        }

        public void translate(float x, float y, float z)
        {
            origen.setVector(origen.toVector3() + new Vector3(x, y, z));
        }
    }
}
