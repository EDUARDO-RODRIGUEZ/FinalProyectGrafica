using AppGrafica.animation;
using AppGrafica.extra;
using AppGrafica.extructura;
using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGrafica
{
    public partial class Main : Form
    {
        private Stage stage;
        private Scene scene;


        private int minRotate = 0;
        private int maxRotate = 360;

        private int minTraslate = 0;
        private int maxTraslate = 100;

        private int minScale = 0;
        private int maxScale = 30;

        public Main()
        {
            InitializeComponent();
            openGL();
            configMain();
        }

        public void openGL()
        {
            scene = new Scene(new Punto(0, 0, 0));
            
            Objeto car = Objeto.DeserializeJsonFile("car2.json");
            Objeto house = Objeto.DeserializeJsonFile("house.json");
            Objeto ave = Objeto.DeserializeJsonFile("ave.json");


            house.origen = new Punto(0,14,0); 
            car.origen = new Punto(50 , 5, 0);
            ave.origen = new Punto(0, 56, 0);

            car.setOrigenScene(scene.origen);
            house.setOrigenScene(scene.origen);
            ave.setOrigenScene(scene.origen);

            scene.objects.Add("car", car);
            scene.objects.Add("house", house);
            scene.objects.Add("ave", ave);
            
            car.scale(5, 5, 5);
            house.scale(7, 7, 7);
            ave.scale(0.5f, 0.5f, 0.5f);
            ave.rotate(-90,0,0);

            car.rotate(0,90,0);
            new Thread(runOpengl).Start();
        }

        public void runOpengl()
        {
            stage = new Stage(800, 500, "App Grafica");
            stage.setScene(scene);
            stage.Run(30);
        }

        public void configMain()
        {
            this.comboBoxObjeto.DataSource = scene.objects.Keys.Prepend("scene").ToList();
            this.comboBoxFace.DataSource = null;
            this.comboBoxTransform.DataSource = new List<string> { "rotate", "translate", "scale" };
            updateTrackBar();
        }


        private void comboBoxTransform_SelectedValueChanged(object sender, EventArgs e)
        {
            updateTrackBar();
        }

        public void updateTrackBar()
        {
            switch (comboBoxTransform.SelectedItem.ToString())
            {
                case "rotate":
                    setTrackBar(minRotate, maxRotate, 0);
                    break;
                case "translate":
                    setTrackBar(minTraslate, maxTraslate, 0);
                    break;
                case "scale":
                    setTrackBar(minScale, maxScale, 0);
                    break;
            }
        }

        public void setTrackBar(int min, int max, int value)
        {
            trackBarX.Minimum = min;
            trackBarX.Maximum = max;
            trackBarX.Value = value;

            trackBarY.Minimum = min;
            trackBarY.Maximum = max;
            trackBarY.Value = value;

            trackBarZ.Minimum = min;
            trackBarZ.Maximum = max;
            trackBarZ.Value = value;

            trackbarBeforeX = 0;
            trackbarBeforeY = 0;
            trackbarBeforeZ = 0;

        }


        private void comboBoxObjeto_SelectedValueChanged(object sender, EventArgs e)
        {
            string item = comboBoxObjeto.SelectedItem.ToString();
            if (item.Equals("scene"))
            {
                comboBoxFace.DataSource = null;
            }
            else
            {
                comboBoxFace.DataSource = scene.objects[item].faces.Keys.Prepend("objeto").ToList();
            }
        }



        private int trackbarBeforeX = 0;
        private void trackBarX_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarX.Value == 0)
            {
                return;
            }
            string transfomrSelected = comboBoxTransform.SelectedItem.ToString();
            if (transfomrSelected.Equals("rotate"))
            {
                int rotateAcumulate = (trackBarX.Value > trackbarBeforeX) ? 1 : -1;
                trackbarBeforeX = trackBarX.Value;
                rotate(new Vector3(rotateAcumulate, 0, 0));
                return;
            }
            if (transfomrSelected.Equals("translate"))
            {
                float translatecumulate = (trackBarX.Value > trackbarBeforeX) ? 1 : -1;
                trackbarBeforeX = trackBarX.Value;
                translate(new Vector3(translatecumulate, 0, 0));
                return;
            }
            if (transfomrSelected.Equals("scale"))
            {
                float scaleacumulate = (trackBarX.Value > trackbarBeforeX) ? 1.1f : 0.9f;
                trackbarBeforeX = trackBarX.Value;
                scale(new Vector3(scaleacumulate, 1, 1));
            }
        }

        private int trackbarBeforeY = 0;
        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarY.Value == 0)
            {
                return;
            }
            string transfomrSelected = comboBoxTransform.SelectedItem.ToString();
            if (transfomrSelected.Equals("rotate"))
            {
                int rotateAcumulate = (trackBarY.Value > trackbarBeforeY) ? 1 : -1;
                trackbarBeforeY = trackBarY.Value;
                rotate(new Vector3(0, rotateAcumulate, 0));
                return;
            }
            if (transfomrSelected.Equals("translate"))
            {
                float translatecumulate = (trackBarY.Value > trackbarBeforeY) ? 1 : -1;
                trackbarBeforeY = trackBarY.Value;
                translate(new Vector3(0, translatecumulate, 0));
                return;
            }
            if (transfomrSelected.Equals("scale"))
            {
                float scaleacumulate = (trackBarY.Value > trackbarBeforeY) ? 1.1f : 0.9f;
                trackbarBeforeY = trackBarY.Value;
                scale(new Vector3(1, scaleacumulate, 1));
            }
        }

        private int trackbarBeforeZ = 0;
        private void trackBarZ_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarZ.Value == 0)
            {
                return;
            }
            string transfomrSelected = comboBoxTransform.SelectedItem.ToString();
            if (transfomrSelected.Equals("rotate"))
            {
                int rotateAcumulate = (trackBarZ.Value > trackbarBeforeZ) ? 1 : -1;
                trackbarBeforeZ = trackBarZ.Value;
                rotate(new Vector3(0, 0, rotateAcumulate));
                return;
            }
            if (transfomrSelected.Equals("translate"))
            {
                float translatecumulate = (trackBarZ.Value > trackbarBeforeZ) ? 1 : -1;
                trackbarBeforeZ = trackBarZ.Value;
                translate(new Vector3(0, 0, translatecumulate));
                return;
            }
            if (transfomrSelected.Equals("scale"))
            {
                float scaleacumulate = (trackBarZ.Value > trackbarBeforeZ) ? 1.1f : 0.9f;
                trackbarBeforeZ = trackBarZ.Value;
                scale(new Vector3(1, 1, scaleacumulate));
            }

        }

        public void rotate(Vector3 rotate)
        {
            string objetoSelected = comboBoxObjeto.SelectedItem.ToString();
            if (objetoSelected.Equals("scene"))
            {
                scene.rotate(rotate.X, rotate.Y, rotate.Z);
                return;
            }
            string faceSelected = comboBoxFace.SelectedItem.ToString();
            Objeto objeto = scene.objects[objetoSelected];
            if (faceSelected.Equals("objeto"))
            {
                objeto.rotate(rotate.X, rotate.Y, rotate.Z);
                return;
            }
            Face face = objeto.faces[faceSelected];
            face.rotate(rotate.X, rotate.Y, rotate.Z);
        }

        public void translate(Vector3 translate)
        {
            string objetoSelected = comboBoxObjeto.SelectedItem.ToString();
            if (objetoSelected.Equals("scene"))
            {
                scene.translate(translate.X, translate.Y, translate.Z);
                return;
            }
            string faceSelected = comboBoxFace.SelectedItem.ToString();
            Objeto objeto = scene.objects[objetoSelected];
            if (faceSelected.Equals("objeto"))
            {
                objeto.translate(translate.X, translate.Y, translate.Z);
                return;
            }
            Face face = objeto.faces[faceSelected];
            face.translate(translate.X, translate.Y, translate.Z);
        }

        public void scale(Vector3 scale)
        {
            string objetoSelected = comboBoxObjeto.SelectedItem.ToString();
            if (objetoSelected.Equals("scene"))
            {
                scene.scale(scale.X, scale.Y, scale.Z);
                return;
            }
            string faceSelected = comboBoxFace.SelectedItem.ToString();
            Objeto objeto = scene.objects[objetoSelected];
            if (faceSelected.Equals("objeto"))
            {
                objeto.scale(scale.X, scale.Y, scale.Z);
                return;
            }
            Face face = objeto.faces[faceSelected];
            face.scale(scale.X, scale.Y, scale.Z);
        }

        private void buttonPlayAnimate_Click(object sender, EventArgs e)
        {
            Libretto libretto = new Libretto(scene.objects);
            libretto.loadActions();
            Thread thread = new Thread(libretto.execute);
            thread.Start();
        }
    }

}
