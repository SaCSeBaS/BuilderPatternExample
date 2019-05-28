using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class Genero
    {
        private String descripcionGenero;

        public Genero(String descripcionGenero)
        {
            this.descripcionGenero = descripcionGenero;
        }

        public String DescripcionGenero
        {
            get { return descripcionGenero; }
            set { descripcionGenero = value; }
        }
    }
}
