using System.Data;

using TelaProdutos.Models.DataLayer;

namespace TelaProdutos.Telas
{
    public partial class FormLogin : Form
    {
        public bool LoginSucesso { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuário";
            txtSenha.Text = "Senha";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (OuroContext Context = new OuroContext())
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                try
                {
                    TabUsuario usuarioDoBanco = Context.TabUsuarios.Where(x => x.Usuario == usuario && x.Senha == senha).FirstOrDefault();

                    if (usuarioDoBanco != null)
                    {
                        LoginSucesso = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário/Senha inválidos, por favor tente novamente!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Restaura o texto padrão se estiver vazio
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.ForeColor = SystemColors.GrayText;
                txtUsuario.Text = "Usuário";

            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            // Limpa o texto e define o PasswordChar quando o foco é obtido
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = SystemColors.ControlText;
                txtSenha.PasswordChar = '*';
            }

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            // Restaura o texto padrão se estiver vazio
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.ForeColor = SystemColors.GrayText;
                txtSenha.Text = "Senha";
                txtSenha.PasswordChar = '\0';
            }
        }

    }
}
