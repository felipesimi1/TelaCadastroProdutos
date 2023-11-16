using System.Data;
using TelaProdutos.Models.DataLayer;

namespace TelaProdutos.Telas
{
    public partial class FormCadastroUsuario : Form
    {
        private List<TabUsuario> _usuarios = new List<TabUsuario>();

        private List<Cargo> _cargo = new List<Cargo>();

        private List<TabUsuario> AplicarFiltro(TabEstoque filtro)
        {
            using (var ouroContext = new OuroContext())
            {
                var query = ouroContext.TabUsuarios.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtFCodUser.Text))
                {
                    query = query.Where(a => a.IdUsuario == int.Parse(txtFCodUser.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFNome.Text))
                {
                    query = query.Where(b => b.Usuario.Contains(txtFNome.Text));
                }

                return query.ToList();
            }
        }

        public FormCadastroUsuario()
        {
            InitializeComponent();
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            carregaCargos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                tabControl1.SelectedTab = tabPage1;

                bindingSourceTabUsuarios.Clear();
                txtFCodUser.Text = string.Empty;
                txtFNome.Text = string.Empty;

                habilitaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabPage2;

                var filtro = new TabEstoque
                {
                    Descrição = txtFCodUser.Text,
                    Modelo = txtFNome.Text,

                };

                _usuarios = AplicarFiltro(filtro);
                bindingSourceTabUsuarios.DataSource = _usuarios;

                desabilitaCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desabilitaCampos()
        {
            txtFCodUser.ReadOnly = true;
            txtFNome.ReadOnly = true;

            btnFiltrar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtFCodUser.ReadOnly = false;
            txtFNome.ReadOnly = false;

            btnFiltrar.Enabled = true;
        }

        private void carregaCargos()
        {
            try
            {
                using (OuroContext context = new OuroContext())
                {
                    _cargo = context.Cargos.ToList();

                    cbIdCargo.DataSource = _cargo;
                    cbCargo.DataSource = _cargo;

                    // Certifique-se de substituir 'IdCargo' pelo nome correto da propriedade que representa o identificador do cargo
                    cbIdCargo.DisplayMember = "IdCargo";
                    cbIdCargo.ValueMember = "IdCargo";

                    // Certifique-se de substituir 'NomeCargo' pelo nome correto da propriedade que representa o nome do cargo
                    cbCargo.DisplayMember = "Cargo1";
                    cbCargo.ValueMember = "Cargo1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cargos: " + ex.Message);
            }
        }

    }

}
