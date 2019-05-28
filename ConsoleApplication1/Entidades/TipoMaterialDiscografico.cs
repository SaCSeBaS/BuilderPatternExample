using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class TipoMaterialDiscografico
    {
        private String nombreTipoMaterialDiscografico;

        public TipoMaterialDiscografico(String nombreTipoMaterialDiscografico)
        {
            this.nombreTipoMaterialDiscografico = nombreTipoMaterialDiscografico;
        }

        public String NombreTipoMaterialDiscografico
        {
            get { return nombreTipoMaterialDiscografico; }
            set { nombreTipoMaterialDiscografico = value; }
        }
    }
}
