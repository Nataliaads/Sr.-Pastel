using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;

namespace PASTELARIA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimento_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMenu_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.Navy;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.MediumBlue;
        }

        private void btnMovimento_MouseEnter(object sender, EventArgs e)
        {
            btnMovimento.BackColor = Color.Navy;
        }

        private void btnMovimento_MouseLeave(object sender, EventArgs e)
        {
            btnMovimento.BackColor = Color.MediumBlue;
        }

        private void btnRelatorios_MouseEnter(object sender, EventArgs e)
        {
            btnRelatorios.BackColor = Color.Navy;
        }

        private void btnRelatorios_MouseLeave(object sender, EventArgs e)
        {
            btnRelatorios.BackColor = Color.MediumBlue;
        }

        private void btnSobre_MouseEnter(object sender, EventArgs e)
        {
            btnSobre.BackColor = Color.Navy;
        }

        private void btnSobre_MouseLeave(object sender, EventArgs e)
        {
            btnSobre.BackColor = Color.MediumBlue;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.Navy;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.MediumBlue;
        }


        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSobre_Click_1(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.MdiParent = this;
            frmSob.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProduto frmProd = new frmProduto();
            frmProd.MdiParent = this;
            frmProd.Show();
        }

        private void btnMovimento_Click_1(object sender, EventArgs e)
        {
            frmPedido frmPed = new frmPedido();
            frmPed.MdiParent = this;
            frmPed.Show();
        }

        private void btnRelatorios_Click_1(object sender, EventArgs e)
        {
            Relatorio.RelPedidos.impPedidos();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumBlue;
        }
    }
}
