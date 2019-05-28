using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Entidades;

namespace ConsoleApplication1.Builder
{
    public class MaterialDiscograficoBuilder : IMaterialDiscograficoBuilder
    {
        private String nombre;
        private Double precio;
        private int stock;

        private Genero genero;
        private Autor autor;
        private TipoMaterialDiscografico tipoMaterialDiscografico;
        private List<Cancion> canciones;

        public MaterialDiscograficoBuilder ConNombre(String nombre)
        {
            this.nombre = nombre;
            return this;
        }

        public MaterialDiscograficoBuilder TienePrecio(Double precio)
        {
            this.precio = precio;
            return this;
        }

        public MaterialDiscograficoBuilder EnStock(int stock)
        {
            this.stock = stock;
            return this;
        }

        public MaterialDiscograficoBuilder ComoGenero(Genero genero)
        {
            this.genero = genero;
            return this;
        }

        public MaterialDiscograficoBuilder ComoAutor(Autor autor)
        {
            this.autor = autor;
            return this;
        }

        public MaterialDiscograficoBuilder ComoTipoMaterialDiscografico(TipoMaterialDiscografico tipoMaterialDiscografico)
        {
            this.tipoMaterialDiscografico = tipoMaterialDiscografico;
            return this;
        }

        public MaterialDiscograficoBuilder ComoCanciones(List<Cancion> canciones)
        {
            this.canciones = canciones;
            return this;
        }

        private int calcularDuracionTotalSegundos()
        {
            int duracionTotal = 0;

            foreach(Cancion cancion in canciones)
            {
                duracionTotal += cancion.DuracionSegundos;
            }

            return duracionTotal;
        }

        public MaterialDiscografico BuildMaterialDiscografico()
        {
            


            return new MaterialDiscografico()
            {

                Nombre = this.nombre,
                Precio = this.precio,
                Stock = this.stock,
                DuracionTotalSegundos = calcularDuracionTotalSegundos(),
                Genero = this.genero,
                Autor = this.autor,
                TipoMaterialDiscografico = this.tipoMaterialDiscografico,
                Canciones = this.canciones
                
            };
        }
    }
}
