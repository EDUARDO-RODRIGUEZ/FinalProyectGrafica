using AppGrafica.extra;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extructura
{
    public class Scene : ITransform
    {
        public Punto origen;
        public Dictionary<string, Objeto> objects;

        public Scene(Punto origen)
        {
            this.origen = origen;
            this.objects = new Dictionary<string, Objeto>();
        }

        public void draw()
        {
            foreach (var obj in objects.Values)
            {
                obj.draw();
            }
        }

        public void rotate(float x, float y, float z)
        {
            foreach (var obj in objects.Values)
            {
                obj.rotateScene(x, y, z);
            }
        }

        public void scale(float x, float y, float z)
        {
            foreach (var obj in objects.Values)
            {
                obj.scale(x, y, z);
            }
        }

        public void translate(float x, float y, float z)
        {
            origen.setVector(origen.toVector3() + new Vector3(x, y, z));
        }

    }
}
