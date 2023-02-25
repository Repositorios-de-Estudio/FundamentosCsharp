using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    internal interface IFigura
    {
        int Id { get; set; }

        // metodo, como es abstracto no se requiere get y set, todo por defecto es abstracto
        double CalcularArea();
    }
}
