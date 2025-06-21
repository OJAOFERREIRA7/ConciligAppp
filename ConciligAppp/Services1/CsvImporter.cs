using CsvHelper;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration;
using System.Text;
using ConciligAppp.Data1;
using ConciligAppp.Models1;
using System;
using System.Linq;

public class CsvImporter
{
    private readonly AppDbContext _context;

    public CsvImporter(AppDbContext context)
    {
        _context = context;
    }

    public void Importar(string caminhoArquivo, int usuarioId)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";",
            Encoding = Encoding.GetEncoding("ISO-8859-1"),
            HasHeaderRecord = true
        };

        var nomeArquivo = Path.GetFileName(caminhoArquivo);

        var arquivo = new ArquivoImportado
        {
            NomeArquivo = nomeArquivo,
            UsuarioId = usuarioId
        };

        using (var reader = new StreamReader(caminhoArquivo, Encoding.GetEncoding("ISO-8859-1")))
        using (var csv = new CsvReader(reader, config))
        {
            var registros = csv.GetRecords<ContratoCsvModel>().ToList();

            foreach (var r in registros)
            {
                var contrato = new Contrato
                {
                    NomeCliente = r.Nome,
                    CPF = r.CPF,
                    NumeroContrato = r.Contrato,
                    Produto = r.Produto,
                    DataVencimento = DateTime.ParseExact(r.Vencimento, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Valor = decimal.Parse(r.Valor.Replace(",", "."), CultureInfo.InvariantCulture),
                    ArquivoImportado = arquivo
                };

                _context.Contratos.Add(contrato);
            }

            _context.ArquivosImportados.Add(arquivo);
            _context.SaveChanges();
        }
    }
}

public class ContratoCsvModel
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Contrato { get; set; }
    public string Produto { get; set; }
    public string Vencimento { get; set; }
    public string Valor { get; set; }
}