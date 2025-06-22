using ConciligAppp.Data1;
using ConciligAppp.Models1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConciligAppp.Forms1
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context = new AppDbContext();

        private readonly Usuario _usuario;
        public MainForm(Usuario usuario)
        {
            InitializeComponent();


            _usuario = usuario;

            lblBemVindo.Text = $"Bem-vindo, {_usuario.Nome}";

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImportarCsv_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var importer = new CsvImporter(_context);
                    importer.Importar(openFileDialog.FileName, _usuario.Id);

                    MessageBox.Show("Arquivo importado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao importar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var consultaForm = new ConsultaForm(_usuario);
            consultaForm.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
