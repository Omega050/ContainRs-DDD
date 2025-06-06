using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainRs.Vendas.Propostas
{
    public class Endereco
    {
        public required string Cep { get; set; }
        public string? Referencias { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
