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
    public partial class frmPedido : Form
    {
        Camadas.MODEL.Produto produto = new Camadas.MODEL.Produto();

        public frmPedido()
        {
            InitializeComponent();
        }

        private void habilitaCampos(bool status)
        {
            txtCliente.Enabled = status;
            txtProduto.Enabled = status;
            cmbProduto.Enabled = status;
            cmbCliente.Enabled = status;
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
            dgvPedido.DataSource = bllPedido.Select();

            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            cmbProduto.DisplayMember = "nome";
            cmbProduto.ValueMember = "idProduto";
            cmbProduto.DataSource = bllProd.Select();

            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = dalCli.Select();

            txtCliente.Text = cmbCliente.SelectedValue.ToString();
            txtProduto.Text = cmbProduto.SelectedValue.ToString();
        }

        private void limparCamposPedido()
        {
            lblPedidoID.Text = "";            
            dtpPedido.Value = DateTime.Now;
        }

        private void buscarProduto(int idProduto)
        {
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            List<Camadas.MODEL.Produto> lstProd = new List<Camadas.MODEL.Produto>(); ;
            lstProd = bllProd.SelectById(idProduto);
            if (lstProd != null)
                produto = lstProd[0];
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtCliente.Text);
            }
            catch { }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCamposPedido();
            lblPedidoID.Text = "-1";            
            habilitaCampos(true);
            txtCliente.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
            Camadas.MODEL.Pedido pedido = new Camadas.MODEL.Pedido();
            //pedido.idPedido = Convert.ToInt32(lblPedidoID.Text);
            pedido.cliente = Convert.ToInt32(txtCliente.Text);
            pedido.dataPedido = dtpPedido.Value;
            pedido.produto = Convert.ToInt32(txtProduto.Text);
            //pedido.totalCompra = Convert.ToInt32(txtQuantidade.Text) *          

            bllPedido.Insert(pedido);
            limparCamposPedido();
            dgvPedido.DataSource = "";
            dgvPedido.DataSource = bllPedido.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCamposPedido();
            habilitaCampos(false);
        }

        private void dgvPedido_DoubleClick(object sender, EventArgs e)
        {
            //carrega valores nos controles
            lblPedidoID.Text = dgvPedido.SelectedRows[0].Cells["idPedido"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(dgvPedido.SelectedRows[0].Cells["nome"].Value.ToString());
            dtpPedido.Value = Convert.ToDateTime(dgvPedido.SelectedRows[0].Cells["dataPedido"].Value.ToString());           

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProduto.Text = cmbProduto.SelectedValue.ToString();           
        }

        private void cmbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtCliente.Text = cmbCliente.SelectedValue.ToString();
        }
    }
}
