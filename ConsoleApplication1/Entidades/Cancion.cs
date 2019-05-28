using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class Cancion
    {
        private String nombreCancion;
        private int duracionSegundos;

        public Cancion(String nombreCancion, int duracionSegundos)
        {
            this.nombreCancion = nombreCancion;
            this.duracionSegundos = duracionSegundos;
        }

        public String NombreCancion
        {
            get { return nombreCancion; }
            set { nombreCancion = value; }
        }

        public int DuracionSegundos
        {
            get { return duracionSegundos; }
            set { duracionSegundos = value; }
        }

    }
}
