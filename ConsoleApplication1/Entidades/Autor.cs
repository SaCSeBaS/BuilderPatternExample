using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class Autor
    {
        private String nombreArtista;
        private String descripcionArtista;

        public Autor(String nombreArtista, String descripcionArtista)
        {
            this.nombreArtista = nombreArtista;
            this.descripcionArtista = descripcionArtista;
        }

        public String NombreArtista
        {
            get { return nombreArtista; }
            set { nombreArtista = value; }
        }
        public String DescripcionArtista
        {
            get { return descripcionArtista; }
            set { descripcionArtista = value; }
        }

    }
}
