using AppGrafica.extra;
using Newtonsoft.Json;
using OpenTK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extructura
{
    public class Objeto : ITransform
    {
        public Punto origen;
        public Dictionary<string, Face> faces;

        private Punto origenScene;

        public Objeto()
        {
        }


        public void draw()
        {
            foreach (var face in faces.Values)
            {
                face.draw();
            }
        }

        public void rotate(float x, float y, float z)
        {
            foreach (var face in faces.Values)
            {
                face.rotateObjeto(x, y, z);
            }
        }


        public void rotateScene(float x, float y, float z)
        {
            foreach (var face in faces.Values)
            {
                face.rotateObjeto(x, y, z);
            }
            float anglex = MathHelper.DegreesToRadians(x);
            float angley = MathHelper.DegreesToRadians(y);
            float anglez = MathHelper.DegreesToRadians(z);
            Matrix3 mrotate = Matrix3.CreateRotationX(anglex) * Matrix3.CreateRotationY(angley) * Matrix3.CreateRotationZ(anglez);
            origen.setVector(origen.toVector3() * mrotate);
        }

        public void scale(float x, float y, float z)
        {
            foreach (var face in faces.Values)
            {
                face.scaleObjeto(x, y, z);
            }
        }

        public void translate(float x, float y, float z)
        {
            origen.setVector(origen.toVector3() + new Vector3(x, y, z));
        }

        public void setOrigenScene(Punto origenScene)
        {
            this.origenScene = origenScene;
            foreach (var face in faces.Values)
            {
                face.setOrigenObjeto(origen);
                face.setOrigenScene(origenScene);
            }
        }


        public static Objeto DeserializeJsonFile(string path)
        {
            string jsonString = new StreamReader(path).ReadToEnd();
            return JsonConvert.DeserializeObject<Objeto>(jsonString);
        }

        public static void SerializeJsonFile(string path, Objeto objeto)
        {
            string objetoString = JsonConvert.SerializeObject(objeto);
            File.WriteAllText(path, objetoString);
        }
    }
}
