namespace PASTELARIA
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnMovimento = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Controls.Add(this.btnRelatorios);
            this.panel1.Controls.Add(this.btnMovimento);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 828);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 99);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cadastrar Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(-10, 586);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(315, 99);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Location = new System.Drawing.Point(-10, 509);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(315, 99);
            this.btnSobre.TabIndex = 14;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click_1);
            this.btnSobre.MouseEnter += new System.EventHandler(this.btnSobre_MouseEnter);
            this.btnSobre.MouseLeave += new System.EventHandler(this.btnSobre_MouseLeave);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(-10, 432);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(315, 99);
            this.btnRelatorios.TabIndex = 13;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click_1);
            this.btnRelatorios.MouseEnter += new System.EventHandler(this.btnRelatorios_MouseEnter);
            this.btnRelatorios.MouseLeave += new System.EventHandler(this.btnRelatorios_MouseLeave);
            // 
            // btnMovimento
            // 
            this.btnMovimento.FlatAppearance.BorderSize = 0;
            this.btnMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimento.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimento.ForeColor = System.Drawing.Color.White;
            this.btnMovimento.Location = new System.Drawing.Point(-10, 355);
            this.btnMovimento.Name = "btnMovimento";
            this.btnMovimento.Size = new System.Drawing.Size(315, 99);
            this.btnMovimento.TabIndex = 12;
            this.btnMovimento.Text = "Pedido";
            this.btnMovimento.UseVisualStyleBackColor = true;
            this.btnMovimento.Click += new System.EventHandler(this.btnMovimento_Click_1);
            this.btnMovimento.MouseEnter += new System.EventHandler(this.btnMovimento_MouseEnter);
            this.btnMovimento.MouseLeave += new System.EventHandler(this.btnMovimento_MouseLeave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 198);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(315, 99);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar Cliente";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1589, 828);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMenu_Paint);
            this.MouseEnter += new System.EventHandler(this.btnCadastros_Click);
            this.MouseLeave += new System.EventHandler(this.btnCadastros_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnMovimento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}