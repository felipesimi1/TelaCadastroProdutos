using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaProdutos.Telas
{
    public partial class FormPrincipal : Form
    {
        private bool fecharAplicacao = false;

        public FormPrincipal()
        {
            InitializeComponent();

            this.Opacity = 0;
            this.ShowInTaskbar = false;

            MostrarFormLogin();

            this.FormClosed += FormPrincipal_FormClosed;

        }

        private void OpenForm<T>(T _) where T : Form, new()
        {
            try
            {
                if (Application.OpenForms.OfType<T>().Any())
                {
                    using (var tempForm = new T())
                    {
                        MessageBox.Show($"O Formulário '{tempForm.Text}' já está aberto, verifique!", Assembly.GetEntryAssembly()?.GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tempForm.Dispose();
                        return;
                    }
                }

                var openForm = new T();
                openForm.Show();

            }
            catch (Exception)
            {
                MessageBox.Show($"Ocorreu um erro no método '{MethodBase.GetCurrentMethod().Name}'\nFavor, entre em contato com o Suporte Técnico!", Assembly.GetEntryAssembly()?.GetName().Name, MessageBoxButtons.OK);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                OpenForm(new FormCadastroProduto());
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("{0}\n{1}", string.Format("Ocorreu um erro no método '{0}'", MethodBase.GetCurrentMethod().Name), "Favor, entre em contato com o Suporte Técnico!"), Assembly.GetEntryAssembly()?.GetName().Name, MessageBoxButtons.OK);
            }
        }

        private void MostrarFormLogin()
        {
            using (FormLogin formLogin = new FormLogin())
            {
                formLogin.ShowDialog();

                if (formLogin.LoginSucesso)
                {

                   this.Opacity = 1;
                   this.ShowInTaskbar = true;

                }
                else
                {
                    fecharAplicacao = true;
                }
            }
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fecharAplicacao)
            {
                Application.Exit();
            }
        }



    }
}
