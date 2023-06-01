using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.animation
{
    public class Action
    {
        public string name;
        public long start;
        public long duration;
        
        public bool activeTransformObject;
        public bool activeTransformFace;
        public bool rotateRespectScene;

        public List<string> faces;

        public Transform transformObject;
        public Transform transformFace;

        public static Action DeserializeJsonFile(string path)
        {
            string jsonString = new StreamReader(path).ReadToEnd();
            return JsonConvert.DeserializeObject<Action>(jsonString);
        }

        public static void SerializeJsonFile(string path, Action action)
        {
            string objetoString = JsonConvert.SerializeObject(action);
            File.WriteAllText(path, objetoString);
        }
    }
}
