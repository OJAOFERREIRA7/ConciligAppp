using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConciligAppp.Models1
{
    public class ArquivoImportado
    {
            public int Id { get; set; }
            public string NomeArquivo { get; set; }
            public DateTime DataImportacao { get; set; } = DateTime.Now;

            public int UsuarioId { get; set; }
            public Usuario Usuario { get; set; }

            public List<Contrato> Contratos { get; set; }
    }
}
