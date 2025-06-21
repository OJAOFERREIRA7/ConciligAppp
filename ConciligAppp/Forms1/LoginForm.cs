using System;
using System.Linq;
using System.Windows.Forms;
using ConciligAppp.Data1;  // namespace onde está seu AppDbContext

namespace ConciligAppp.Forms1
{
    public partial class LoginForm : Form
    {
        // Declarando o contexto do banco
        private readonly AppDbContext _context = new AppDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email && u.SenhaHash == senha);

            if (usuario == null)
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Login correto
            this.Hide();
            MainForm main = new MainForm(usuario);
            main.Show();
        }

        // Outros eventos gerados pelo designer, podem ficar vazios ou implementar o que desejar
        private void label1_Click(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e) 
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
