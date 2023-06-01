using AppGrafica.extra;
using AppGrafica.extructura;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica
{
    public class Stage : GameWindow
    {
        private Plano plano;
        private Scene scene;

        public Stage(int width, int height, string title) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, title)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.47f, 0.32f, 0.23f, 1);
            plano = new Plano(new Punto(), 100, 100, 100);
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            GL.Rotate(30,1,1,0);

            plano.draw();
            scene.draw();

            SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-100, 100, -100, 100, -100, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            GL.Disable(EnableCap.DepthTest);
            base.OnUnload(e);

        }

        public void setScene(Scene scene)
        {
            this.scene = scene;
        }

        public Scene getScene()
        {
            return this.scene;
        }

    }
}
