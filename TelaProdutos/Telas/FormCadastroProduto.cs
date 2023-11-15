using System.Data;
using TelaProdutos.Models.DataLayer;

namespace TelaProdutos
{
    public partial class FormCadastroProduto : Form
    {
        private List<TabEstoqueGrupo> _grupos = new List<TabEstoqueGrupo>();

        private List<TabEstoqueReferêncium> _subgrupos = new List<TabEstoqueReferêncium>();

        private List<TabEstoque> _produtos = new List<TabEstoque>();

        private List<TabEstoque> AplicarFiltro(TabEstoque filtro)
        {
            using (var ouroContext = new OuroContext())
            {
                var query = ouroContext.TabEstoques.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtFCodProd.Text))
                {
                    query = query.Where(item => item.IdItem == txtFCodProd.Text);
                }

                if (!string.IsNullOrWhiteSpace(txtFDescrição.Text))
                {
                    query = query.Where(item => item.Descrição.Contains(txtFDescrição.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFModelo.Text))
                {
                    query = query.Where(item => item.Modelo.Contains(txtFModelo.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFLocalizacao.Text))
                {
                    query = query.Where(item => item.Localização.Contains(txtFLocalizacao.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFLocalizacao2.Text))
                {
                    query = query.Where(item => item.Localização2.Contains(txtFLocalizacao2.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFCodFabrica.Text))
                {
                    query = query.Where(item => item.CódigoFábrica == txtFCodFabrica.Text);
                }

                if (!string.IsNullOrWhiteSpace(txtFCodSubs.Text))
                {
                    query = query.Where(item => item.CódigoVelho == txtFCodSubs.Text);
                }

                return query.ToList();
            }
        }

        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            carregaCategoria();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabPage2;

                var filtro = new TabEstoque
                {
                    Descrição = txtFDescrição.Text,
                    Modelo = txtFModelo.Text,
                    Localização = txtFLocalizacao.Text,
                    Localização2 = txtFLocalizacao2.Text,
                    CódigoFábrica = txtFCodFabrica.Text,
                    CódigoVelho = txtFCodSubs.Text
                };

                _produtos = AplicarFiltro(filtro);
                tabEstoqueBindingSource.DataSource = _produtos;

                desabilitaCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #region DataGridView 
            ////IQueryable<TabEstoque> consultaEstoque = ouroContext.TabEstoques;
            ////IQueryable<TabEstoqueGrupo> consultaGrupo = ouroContext.TabEstoqueGrupos;
            ////IQueryable<TabEstoqueReferêncium> consultaReferencia = ouroContext.TabEstoqueReferência;

            ////var consultaDataGrid = from estoque in consultaEstoque
            ////                    join grupo in consultaGrupo on estoque.Grupo equals grupo.IdGrupo
            ////                    join referencia in consultaReferencia on estoque.Referência equals referencia.IdReferência
            ////                    where referencia.IdGrupo == estoque.Grupo
            ////                    select new
            ////                    {
            ////                        IdItem = estoque.IdItem,
            ////                        Descrição = estoque.Descrição,
            ////                        Grupo = grupo.Grupo,
            ////                        Referência = referencia.Referência
            ////                    };

            ////lista.DataSource = consultaDataGrid.ToList();
            #endregion

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string idItem = txtCodProd.Text;
                string descricaoItem = txtDescrição.Text;

                using (OuroContext ouro = new OuroContext())
                {
                    var tabEstoque = ouro.TabEstoques.FirstOrDefault(item => item.IdItem == txtCodProd.Text);

                    if (tabEstoque != null)
                    {
                        tabEstoque.Descrição = txtDescrição.Text;
                        tabEstoque.Grupo = cbIdGrupo.Text;
                        tabEstoque.Referência = cbIdReferência.Text;
                        tabEstoque.Modelo = txtModelo.Text;
                        tabEstoque.Localização = txtLocalizacao.Text;
                        tabEstoque.Localização2 = txtLocalizacao2.Text;
                        tabEstoque.CódigoFábrica = txtCodFabrica.Text;
                        tabEstoque.CódigoVelho = txtCodSubs.Text;
                        tabEstoque.BitProdutoObsoleto = cbProdObs.Checked;
                        tabEstoque.BitProdutoEmFalta = cbProdFalta.Checked;

                        //tabEstoqueBindingSource.EndEdit();
                        ouro.SaveChanges();


                        MessageBox.Show("Salvo com sucesso!");
                    }
                    else
                    {
                        var existingItem = ouro.TabEstoques.FirstOrDefault(item => item.Descrição == descricaoItem);

                        if (existingItem != null)
                        {
                            MessageBox.Show("A descrição já existe. Tente Novamente!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtCodProd.Text))
                            {
                                int nextId = igualarIdItemComPk(ouro);

                                txtCodProd.Text = nextId.ToString();
                            }


                            TabEstoque novoItem = new TabEstoque
                            {
                                IdItem = txtCodProd.Text,
                                Descrição = txtDescrição.Text,
                                Grupo = cbIdGrupo.Text,
                                Referência = cbIdReferência.Text,
                                Modelo = txtModelo.Text,
                                Localização = txtLocalizacao.Text,
                                Localização2 = txtLocalizacao2.Text,
                                CódigoFábrica = txtCodFabrica.Text,
                                CódigoVelho = txtCodSubs.Text,
                                BitProdutoObsoleto = cbProdObs.Checked,
                                BitProdutoEmFalta = cbProdFalta.Checked

                            };


                            ouro.TabEstoques.Add(novoItem);
                            ouro.SaveChanges();

                            MessageBox.Show("Produto cadastrado com sucesso!");
                        }
                    }
                    _produtos = ouro.TabEstoques.ToList();
                    tabEstoqueBindingSource.DataSource = _produtos;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                tabEstoqueBindingSource.Clear();
                txtCodProd.Text = string.Empty;
                txtDescrição.Text = string.Empty;
                txtModelo.Text = string.Empty;
                txtLocalizacao.Text = string.Empty;
                txtLocalizacao2.Text = string.Empty;
                txtCodFabrica.Text = string.Empty;
                txtCodSubs.Text = string.Empty;

                carregaCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.SelectedTab = tabPage1;

                tabEstoqueBindingSource.Clear();
                txtFCodProd.Text = string.Empty;
                txtFDescrição.Text = string.Empty;
                txtFModelo.Text = string.Empty;
                txtFLocalizacao.Text = string.Empty;
                txtFLocalizacao2.Text = string.Empty;
                txtFCodFabrica.Text = string.Empty;
                txtFCodSubs.Text = string.Empty;

                habilitaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ouro = new OuroContext())
                {
                    TabEstoque excluirItem = (TabEstoque)tabEstoqueBindingSource.Current;

                    if (excluirItem != null)
                    {
                        DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            ouro.TabEstoques.Remove(excluirItem);
                            ouro.SaveChanges();

                            MessageBox.Show("Item excluído com sucesso!");
                        }
                    }

                    _produtos = ouro.TabEstoques.ToList();
                    tabEstoqueBindingSource.DataSource = _produtos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lista_SelectionChanged(object sender, EventArgs e)
        {
            var IdGrupo = cbIdGrupo.Text;

            cbIdReferência.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
            cbReferência.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
        }

        private void cbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            var IdGrupo = cbIdGrupo.Text;

            cbIdReferência.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
            cbReferência.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
        }

        private void cbIdGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            var IdGrupo = cbIdGrupo.Text;

            cbIdReferência.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
            cbReferência.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
        }

        private void carregaCategoria()
        {
            try
            {
                using (OuroContext context = new OuroContext())
                {
                    _grupos = context.TabEstoqueGrupo.ToList();
                    _subgrupos = context.TabEstoqueReferência.ToList();

                    cbIdGrupo.DataSource = _grupos;
                    cbGrupo.DataSource = _grupos;

                    cbIdGrupo.DisplayMember = "IdGrupo";
                    cbIdGrupo.ValueMember = "IdGrupo";
                    cbGrupo.DisplayMember = "Grupo";
                    cbGrupo.ValueMember = "Grupo";

                    cbIdReferência.DataSource = _subgrupos;
                    cbReferência.DataSource = _subgrupos;

                    cbIdReferência.DisplayMember = "IdReferência";
                    cbIdReferência.ValueMember = "IdReferência";
                    cbReferência.DisplayMember = "Referência";
                    cbReferência.ValueMember = "Referência";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
        }

        private int igualarIdItemComPk(OuroContext context)
        {
            var pkItem = context.TabEstoques.OrderByDescending(item => item.PkIntEstoque).FirstOrDefault();
            if (pkItem != null)
            {
                int lastId = (pkItem.PkIntEstoque);
                return lastId + 1;
            }
            else
            {
                return 1;
            }
        }

        private void desabilitaCampos()
        {
            txtFCodProd.ReadOnly = true;
            txtFDescrição.ReadOnly = true;
            txtFModelo.ReadOnly = true;
            txtFLocalizacao.ReadOnly = true;
            txtFLocalizacao2.ReadOnly = true;
            txtFCodFabrica.ReadOnly = true;
            txtFCodSubs.ReadOnly = true;
            btnFiltrar.Enabled = false;
        }

        private void habilitaCampos()
        {
            txtFCodProd.ReadOnly = false;
            txtFDescrição.ReadOnly = false;
            txtFModelo.ReadOnly = false;
            txtFLocalizacao.ReadOnly = false;
            txtFLocalizacao2.ReadOnly = false;
            txtFCodFabrica.ReadOnly = false;
            txtFCodSubs.ReadOnly = false;
            btnFiltrar.Enabled = true;
        }

        private void cbReferência_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbReferência.SelectedItem != null)
            {
                string Referência = cbReferência.SelectedValue.ToString();

                foreach (var item in cbReferência.Items)
                {
                    if (item is TabEstoqueReferêncium Idreferencia && Idreferencia.Referência == Referência)
                    {
                        cbIdReferência.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void cbIdReferência_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbIdReferência.SelectedItem != null)
            {
                string IdReferência = cbIdReferência.SelectedValue.ToString();

                foreach (var item in cbIdReferência.Items)
                {
                    if (item is TabEstoqueReferêncium referencia && referencia.IdReferência == IdReferência)
                    {
                        cbReferência.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }
}