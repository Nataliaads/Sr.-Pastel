using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASTELARIA
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void habilitaCampos(bool status)
        {
            btnInserirP.Enabled = !status;
            btnEditarP.Enabled = !status;
            btnRemoverP.Enabled = !status;
            btnGravarP.Enabled = status;
            btnCancelarP.Enabled = status;

            txtNomeProd.Enabled = status;
            txtValor.Enabled = status;
        }

        private void limpaCampos()
        {
            lblId.Text = "";
            txtNomeProd.Text = "";
            txtValor.Clear();

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = bllProd.Select();

            habilitaCampos(false);

        }

        private void btnInserirP_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(true);
            lblId.Text = "-1";
            txtNomeProd.Focus();

            
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                habilitaCampos(true);
                txtNomeProd.Focus();
            }
            else MessageBox.Show("Não Há registros para editar...", "Editar",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnRemoverP_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

            if (lblId.Text != string.Empty)
            {
                int idProduto = Convert.ToInt32(lblId.Text);
                DialogResult resposta;
                resposta = MessageBox.Show("Deseja Remover? ", "Remover", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                    bllProd.Delete(idProduto);


            }
            else MessageBox.Show("Não há registro para remover...");

            limpaCampos();
            habilitaCampos(false);

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();

        }

        private void btnGravarP_Click(object sender, EventArgs e)
        {
            if(txtNomeProd.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Campos não podem estar em branco!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();

                //instancia e preenche com dados o objeto produto
                Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();
                produto.idProduto = Convert.ToInt32(lblId.Text);
                produto.nome = txtNomeProd.Text;
                produto.preco = Convert.ToSingle(txtValor.Text);

                string msg;
                string titulo;
                int id = Convert.ToInt32(lblId.Text);
                if (id == -1)
                {
                    msg = "Deseja inserir os dados de Produtos?";
                    titulo = "Inserir";
                }
                else
                {
                    msg = "Deseja alterar os dados de Produtos?";
                    titulo = "Editar";
                }

                DialogResult resposta;
                resposta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                    if (id == -1)
                        bllProd.Insert(produto);
                    else bllProd.Update(produto);

                dgvProduto.DataSource = "";
                dgvProduto.DataSource = bllProd.Select();

                limpaCampos();
                habilitaCampos(false);
            }            
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos(false);
        }

        private void btnSairP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduto_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvProduto.SelectedRows[0].Cells["idProduto"].Value.ToString();
            txtNomeProd.Text = dgvProduto.SelectedRows[0].Cells["nome"].Value.ToString();
            txtValor.Text = dgvProduto.SelectedRows[0].Cells["preco"].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
         {
            lblTexto.Visible = false;
            txtPesquisa.Visible = false;
             Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
             dgvProduto.DataSource = "";
             dgvProduto.DataSource = bllProd.Select();
         }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
         {
            
            lblTexto.Visible = true;
             lblTexto.Text = "Informe o ID: ";
             txtPesquisa.Text = "";
             txtPesquisa.Visible = true;
             txtPesquisa.Focus();
         }

         private void rdbDescricao_CheckedChanged(object sender, EventArgs e)
         {
             lblTexto.Visible = true;
             lblTexto.Text = "Informe a Descrição: ";
             txtPesquisa.Text = "";
             txtPesquisa.Visible = true;
             txtPesquisa.Focus();
         }

         private void btnFiltrar_Click(object sender, EventArgs e)
         {
             
         }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvProduto.SelectedRows[0].Cells["idProduto"].Value.ToString();
            txtNomeProd.Text = dgvProduto.SelectedRows[0].Cells["nome"].Value.ToString();
            txtValor.Text = dgvProduto.SelectedRows[0].Cells["preco"].Value.ToString();
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            List<Camadas.MODEL.Produto> listaProduto = new List<Camadas.MODEL.Produto>();
            Camadas.BLL.Produto bllProduto = new Camadas.BLL.Produto();
            if (rdbTodos.Checked)
                listaProduto = bllProduto.Select();
            else if (rdbId.Checked)
                listaProduto = bllProduto.SelectById(Convert.ToInt32(txtPesquisa.Text));
            else if (rdbNome.Checked)
                listaProduto = bllProduto.SelectByNome(txtPesquisa.Text.Trim());

            dgvProduto.DataSource = "";
            dgvProduto.DataSource = listaProduto;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void rdbId_CheckedChanged_1(object sender, EventArgs e)
        {
            lblTexto.Visible = true;
            lblTexto.Text = "Informe o ID: ";
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            lblTexto.Visible = false;
            txtPesquisa.Visible = false;
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            dgvProduto.DataSource = "";
            dgvProduto.DataSource = bllProd.Select();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Visible = true;
            lblTexto.Text = "Informe a Descrição: ";
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            txtPesquisa.Focus();
        }
    }
}
