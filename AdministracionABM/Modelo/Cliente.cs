using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionABM.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public Double Saldo { get; set; }
        public Domicilio DomicilioCliente { get; set; }
    }
}
