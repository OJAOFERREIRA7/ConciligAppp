using ConciligAppp.Data1;
using ConciligAppp.Models1;
using System;
using System.Data.Entity.SqlServer; // Necessário para SqlFunctions
using System.Linq;
using System.Windows.Forms;

namespace ConciligAppp.Forms1
{
    public partial class ConsultaForm : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private readonly Usuario _usuario; // Armazena o usuário logado

        // ✅ Novo construtor que recebe o usuário
        public ConsultaForm(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
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
                    MaiorAtrasoDias = g.Max(c => SqlFunctions.DateDiff("day", c.DataVencimento, hoje)) ?? 0
                })
                .OrderByDescending(x => x.TotalContratos)
                .ToList();

            dgvContratos.DataSource = dados;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Fecha ou esconde a tela atual
            MainForm main = new MainForm(_usuario); // Reabre o MainForm com o mesmo usuário
            main.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
