using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class MaterialDiscografico
    {
        private String nombre;
        private Double precio;
        private int stock;
        private int duracionTotalSegundos;

        private Genero genero;
        private Autor autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<Cancion> canciones;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int DuracionTotalSegundos
        {
            get { return duracionTotalSegundos; }
            set { duracionTotalSegundos = value; }
        }

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public TipoMaterialDiscografico TipoMaterialDiscografico
        {
            get { return tipoMaterialDiscografico; }
            set { tipoMaterialDiscografico = value; }
        }

        public List<Cancion> Canciones
        {
            get { return canciones; }
            set { canciones = value; }
        }

        public String datosCanciones()
        {
            int numeroDeCancion = 1;
            String datos = "\nCANCIONES";

            foreach(Cancion cancion in canciones)
            {
                datos+=
                    "\nNº "+ numeroDeCancion.ToString()+
                    "\nNombre: "+ cancion.NombreCancion+
                    "\nDuracion: "+ cancion.DuracionSegundos.ToString() + " segundos";

                numeroDeCancion++;
            }

            return datos;
        }

        public String reportarDatos()
        {
            return "REPORTE DE MATERIAL" +
                   "\nNombre: " + nombre +
                   "\nPrecio: " + precio +
                   "\nStock: " + stock +
                   "\nDuracion total: " + duracionTotalSegundos + " segundos" +
                   "\n--------------------" +
                   "\nAUTOR" +
                   "\nNombre: " + autor.NombreArtista +
                   "\nDescripcion: " + autor.DescripcionArtista +
                   "\n--------------------" +
                   "\nGENERO" +
                   "\nNombre: " + genero.DescripcionGenero +
                   "\n--------------------" +
                   "\nTIPO MATERIAL DISCOGRAFICO" +
                   "\nNombre: " + tipoMaterialDiscografico.NombreTipoMaterialDiscografico +
                   "\n--------------------" +
                   datosCanciones();
        }

    }
}
