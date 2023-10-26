using System.Data;
using TelaProdutos.Models.DataLayer;

namespace TelaProdutos
{
    public partial class FormCadastroProduto : Form
    {
        private List<TabEstoqueGrupo> _grupos = new List<TabEstoqueGrupo>();

        private List<TabEstoqueRefer�ncium> _subgrupos = new List<TabEstoqueRefer�ncium>();

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

                if (!string.IsNullOrWhiteSpace(txtFDescri��o.Text))
                {
                    query = query.Where(item => item.Descri��o.Contains(txtDescri��o.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFModelo.Text))
                {
                    query = query.Where(item => item.Modelo.Contains(txtFModelo.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFLocalizacao.Text))
                {
                    query = query.Where(item => item.Localiza��o.Contains(txtFLocalizacao.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFLocalizacao2.Text))
                {
                    query = query.Where(item => item.Localiza��o2.Contains(txtFLocalizacao2.Text));
                }

                if (!string.IsNullOrWhiteSpace(txtFCodFabrica.Text))
                {
                    query = query.Where(item => item.C�digoF�brica == txtFCodFabrica.Text);
                }

                if (!string.IsNullOrWhiteSpace(txtFCodSubs.Text))
                {
                    query = query.Where(item => item.C�digoVelho == txtFCodSubs.Text);
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
                    Descri��o = txtFDescri��o.Text,
                    Modelo = txtFModelo.Text,
                    Localiza��o = txtFLocalizacao.Text,
                    Localiza��o2 = txtFLocalizacao2.Text,
                    C�digoF�brica = txtFCodFabrica.Text,
                    C�digoVelho = txtFCodSubs.Text
                };

                _produtos = AplicarFiltro(filtro);
                tabEstoqueBindingSource.DataSource = _produtos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #region DataGridView 
            ////IQueryable<TabEstoque> consultaEstoque = ouroContext.TabEstoques;
            ////IQueryable<TabEstoqueGrupo> consultaGrupo = ouroContext.TabEstoqueGrupos;
            ////IQueryable<TabEstoqueRefer�ncium> consultaReferencia = ouroContext.TabEstoqueRefer�ncia;

            ////var consultaDataGrid = from estoque in consultaEstoque
            ////                    join grupo in consultaGrupo on estoque.Grupo equals grupo.IdGrupo
            ////                    join referencia in consultaReferencia on estoque.Refer�ncia equals referencia.IdRefer�ncia
            ////                    where referencia.IdGrupo == estoque.Grupo
            ////                    select new
            ////                    {
            ////                        IdItem = estoque.IdItem,
            ////                        Descri��o = estoque.Descri��o,
            ////                        Grupo = grupo.Grupo,
            ////                        Refer�ncia = referencia.Refer�ncia
            ////                    };

            ////lista.DataSource = consultaDataGrid.ToList();
            #endregion

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string idItem = txtCodProd.Text;

                using (OuroContext ouro = new OuroContext())
                {
                    var tabEstoque = ouro.TabEstoques.FirstOrDefault(Item => Item.IdItem == txtCodProd.Text);

                    if (tabEstoque != null)
                    {
                        tabEstoque.Descri��o = txtDescri��o.Text;
                        tabEstoque.Grupo = cbIdGrupo.Text;
                        tabEstoque.Refer�ncia = cbIdRefer�ncia.Text;
                        tabEstoque.Modelo = txtModelo.Text;
                        tabEstoque.Localiza��o = txtLocalizacao.Text;
                        tabEstoque.Localiza��o2 = txtLocalizacao2.Text;
                        tabEstoque.C�digoF�brica = txtCodFabrica.Text;
                        tabEstoque.C�digoVelho = txtCodSubs.Text;
                        tabEstoque.BitProdutoObsoleto = cbProdObs.Checked;
                        tabEstoque.BitProdutoEmFalta = cbProdFalta.Checked;

                        //tabEstoqueBindingSource.EndEdit();
                        ouro.SaveChanges();

                        MessageBox.Show("Salvo com sucesso!");

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
                            Descri��o = txtDescri��o.Text,
                            Grupo = cbIdGrupo.Text,
                            Refer�ncia = cbIdRefer�ncia.Text,
                            Modelo = txtModelo.Text,
                            Localiza��o = txtLocalizacao.Text,
                            Localiza��o2 = txtLocalizacao2.Text,
                            C�digoF�brica = txtCodFabrica.Text,
                            C�digoVelho = txtCodSubs.Text,
                            BitProdutoObsoleto = cbProdObs.Checked,
                            BitProdutoEmFalta = cbProdFalta.Checked

                        };

                        ouro.TabEstoques.Add(novoItem);
                        ouro.SaveChanges();

                        MessageBox.Show("Produto cadastrado com sucesso!");
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
                txtDescri��o.Text = string.Empty;
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
                txtFDescri��o.Text = string.Empty;
                txtFModelo.Text = string.Empty;
                txtFLocalizacao.Text = string.Empty;
                txtFLocalizacao2.Text = string.Empty;
                txtFCodFabrica.Text = string.Empty;
                txtFCodSubs.Text = string.Empty;
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
                        DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este item?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            ouro.TabEstoques.Remove(excluirItem);
                            ouro.SaveChanges();

                            MessageBox.Show("Item exclu�do com sucesso!");
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

            cbIdRefer�ncia.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
            cbRefer�ncia.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
        }

        private void cbGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            var IdGrupo = cbIdGrupo.Text;

            cbIdRefer�ncia.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
            cbRefer�ncia.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
        }

        private void cbIdGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var IdGrupo = cbIdGrupo.Text;

            cbIdRefer�ncia.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
            cbRefer�ncia.DataSource = _subgrupos.Where(a => a.IdGrupo == IdGrupo).ToList();
        }

        private void carregaCategoria()
        {
            using (OuroContext context = new OuroContext())
            {
                _grupos = context.TabEstoqueGrupo.ToList();

                cbIdGrupo.DataSource = _grupos;
                cbGrupo.DataSource = _grupos;

                cbIdGrupo.DisplayMember = "IdGrupo";
                cbIdGrupo.ValueMember = "IdGrupo";
                cbGrupo.DisplayMember = "Grupo";
                cbGrupo.ValueMember = "Grupo";

                _subgrupos = context.TabEstoqueRefer�ncia.ToList();

                cbIdRefer�ncia.DataSource = _subgrupos;
                cbRefer�ncia.DataSource = _subgrupos;

                cbIdRefer�ncia.DisplayMember = "IdRefer�ncia";
                cbIdRefer�ncia.ValueMember = "IdRefer�ncia";
                cbRefer�ncia.DisplayMember = "Refer�ncia";
                cbRefer�ncia.ValueMember = "Refer�ncia";

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

    }
}
