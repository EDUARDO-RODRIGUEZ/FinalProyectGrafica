using AppGrafica.extructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.animation
{
    public class Animation : Executor
    {

        private Objeto objeto;
        private Action action;
        private float drotateObject, drotateFace;
        private float dscaleObject, dscaleFace;
        private float dtranslateObject, dtranslateFace;


        public Animation(long interval, long start, long duracion, Objeto objeto, Action action) : base(interval, start, duracion)
        {
            this.objeto = objeto;
            this.action = action;
            this.drotateObject = 0;
            this.dtranslateObject = 0;
            this.dscaleObject = 0;
            this.drotateFace = 0;
            this.dtranslateFace = 0;
            this.dscaleFace = 0;
        }

        public void calculateDifferential()
        {
            long jumps = base.duracion / base.interval;

            if (action.activeTransformObject)
            {
                drotateObject = action.transformObject.rotate.value / jumps;
                dtranslateObject = action.transformObject.translate.value / jumps;
                dscaleObject = action.transformObject.scale.value / jumps;
            }

            if (action.activeTransformFace)
            {
                drotateFace = action.transformFace.rotate.value / jumps;
                dtranslateFace = action.transformFace.translate.value / jumps;
                dscaleFace = action.transformFace.scale.value / jumps;
            }
        }

        public override void handle(object state)
        {
            transformObject();
            transformFace();
        }

        private void transformFace()
        {
            if (dscaleFace != 0)
            {
                if (action.transformFace.scale.x == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.scale((1 + dscaleFace), 1, 1);
                    }
                }
                if (action.transformFace.scale.y == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.scale(1, (1 + dscaleFace), 1);
                    }
                }
                if (action.transformFace.scale.z == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.scale(1, 1, (1 + dscaleFace));
                    }
                }
            }

            if (drotateFace != 0)
            {
                if (action.transformFace.rotate.x == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.rotate(drotateFace, 0, 0);
                    }
                }
                if (action.transformFace.rotate.y == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.rotate(0, drotateFace, 0);
                    }
                }
                if (action.transformFace.rotate.z == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.rotate(0, 0, drotateFace);
                    }
                }
            }

            if (dtranslateFace != 0)
            {
                if (action.transformFace.translate.x == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.translate(dtranslateFace, 0, 0);
                    }
                }
                if (action.transformFace.translate.y == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.translate(0, dtranslateFace, 0);
                    }
                }
                if (action.transformFace.translate.z == 1)
                {
                    foreach (var faceName in action.faces)
                    {
                        Face face = objeto.faces[faceName];
                        face.translate(0, 0, dtranslateFace);
                    }
                }
            }

        }
        private void transformObject()
        {
            if (dscaleObject != 0)
            {
                if (action.transformObject.scale.x == 1)
                {
                    objeto.scale((1 + dscaleObject), 1, 1);
                }
                if (action.transformObject.scale.y == 1)
                {
                    objeto.scale(1, (1 + dscaleObject), 1);
                }
                if (action.transformObject.scale.z == 1)
                {
                    objeto.scale(1, 1, (1 + dscaleObject));
                }
            }

            if (drotateObject != 0)
            {
                if (action.rotateRespectScene)
                {
                    if (action.transformObject.rotate.x == 1)
                    {
                        objeto.rotateScene(drotateObject, 0, 0);
                    }
                    if (action.transformObject.rotate.y == 1)
                    {
                        objeto.rotateScene(0, drotateObject, 0);
                    }
                    if (action.transformObject.rotate.z == 1)
                    {
                        objeto.rotateScene(0, 0, drotateObject);
                    }
                }
                else
                {
                    if (action.transformObject.rotate.x == 1)
                    {
                        objeto.rotate(drotateObject, 0, 0);
                    }
                    if (action.transformObject.rotate.y == 1)
                    {
                        objeto.rotate(0, drotateObject, 0);
                    }
                    if (action.transformObject.rotate.z == 1)
                    {
                        objeto.rotate(0, 0, drotateObject);
                    }
                }
            }

            if (dtranslateObject != 0)
            {
                if (action.transformObject.translate.x == 1)
                {
                    objeto.translate(dtranslateObject, 0, 0);
                }
                if (action.transformObject.translate.y == 1)
                {
                    objeto.translate(0, dtranslateObject, 0);
                }
                if (action.transformObject.translate.z == 1)
                {
                    objeto.translate(0, 0, dtranslateObject);
                }
            }
        }
    }
}
