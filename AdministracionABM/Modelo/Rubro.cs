using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionABM.Modelo
{
    public class Rubro
    { 
        public Rubro()
        {

        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public int RubroPadreId { get; set; }
    }
}
