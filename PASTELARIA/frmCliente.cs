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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            lblId.Text = String.Empty;
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;

            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            //dalCli.Insert(cliente);

            Camadas.BLL.Cliente cliDal = new Camadas.BLL.Cliente();
            cliDal.insert(cliente);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
            limparCampos();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvCliente.SelectedRows[0].Cells["idCliente"].Value.ToString();
            txtNome.Text = dgvCliente.SelectedRows[0].Cells["nome"].Value.ToString();
            txtEndereco.Text = dgvCliente.SelectedRows[0].Cells["endereco"].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            cliente.idCliente = Convert.ToInt32(lblId.Text);
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;

            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dalCli.Update(cliente);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(lblId.Text);
            Camadas.DAL.Cliente dalCli = new Camadas.DAL.Cliente();
            dalCli.Delete(idCliente);

            dgvCliente.DataSource = "";
            dgvCliente.DataSource = dalCli.Select();
            limparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvCliente.SelectedRows[0].Cells["idCliente"].Value.ToString();
            txtNome.Text = dgvCliente.SelectedRows[0].Cells["nome"].Value.ToString();
            txtEndereco.Text = dgvCliente.SelectedRows[0].Cells["endereco"].Value.ToString();
        }
    }
}
