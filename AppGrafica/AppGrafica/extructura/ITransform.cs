using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGrafica.extructura
{
    public interface ITransform
    {
        void rotate(float x, float y, float z);
        void translate(float x, float y, float z);
        void scale(float x, float y, float z);
    }
}
