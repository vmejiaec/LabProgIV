using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibujar
{
    public enum FiguraTipo { CIRCULO, RECTANGULO, TRIANGULO }

    [Serializable]
    public class regFigura
    {
        public String tipo;
        public String texto;
        public String props;

        public regFigura( String tipo, String texto, String props)
        {
            this.tipo = tipo;
            this.texto = texto;
            this.props = props;
        }
    }
}
