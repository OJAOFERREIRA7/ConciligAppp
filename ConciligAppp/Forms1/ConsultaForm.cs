using ConciligAppp.Data1;
using System;
using System.Data.Entity.SqlServer; // Necessário para SqlFunctions
using System.Linq;
using System.Windows.Forms;

namespace ConciligAppp.Forms1
{
    public partial class ConsultaForm : Form
    {
        private readonly AppDbContext _context = new AppDbContext();

        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void ConsultaForm_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            var hoje = DateTime.Now;

            var dados = _context.Contratos
                .AsNoTracking()
                .GroupBy(c => new { c.NomeCliente, c.CPF })
                .Select(g => new
                {
                    Cliente = g.Key.NomeCliente,
                    CPF = g.Key.CPF,
                    TotalContratos = g.Sum(c => c.Valor),
                    // Usa SqlFunctions.DateDiff no EF6
                    MaiorAtrasoDias = g.Max(c => SqlFunctions.DateDiff("day", c.DataVencimento, hoje)) ?? 0
                })
                .OrderByDescending(x => x.TotalContratos)
                .ToList();

            dgvContratos.DataSource = dados;
        }
    }
}
