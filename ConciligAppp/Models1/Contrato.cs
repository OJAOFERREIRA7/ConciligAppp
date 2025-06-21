using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConciligAppp.Models1
{
    public class Contrato
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string NumeroContrato { get; set; }
        public string Produto { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }

        public int ArquivoImportadoId { get; set; }
        public ArquivoImportado ArquivoImportado { get; set; }
    }
}
