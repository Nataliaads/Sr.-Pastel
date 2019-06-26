namespace PASTELARIA
{
    partial class frmProduto
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnSairP = new System.Windows.Forms.Button();
            this.btnCancelarP = new System.Windows.Forms.Button();
            this.btnGravarP = new System.Windows.Forms.Button();
            this.btnRemoverP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            this.btnInserirP = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(33, 409);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowTemplate.Height = 24;
            this.dgvProduto.Size = new System.Drawing.Size(1021, 321);
            this.dgvProduto.TabIndex = 26;
            this.dgvProduto.DoubleClick += new System.EventHandler(this.dgvProduto_DoubleClick);
            // 
            // btnSairP
            // 
            this.btnSairP.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSairP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairP.FlatAppearance.BorderSize = 0;
            this.btnSairP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairP.ForeColor = System.Drawing.Color.White;
            this.btnSairP.Location = new System.Drawing.Point(613, 293);
            this.btnSairP.Name = "btnSairP";
            this.btnSairP.Size = new System.Drawing.Size(96, 39);
            this.btnSairP.TabIndex = 25;
            this.btnSairP.Text = "Sair";
            this.btnSairP.UseVisualStyleBackColor = false;
            this.btnSairP.Click += new System.EventHandler(this.btnSairP_Click);
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCancelarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarP.FlatAppearance.BorderSize = 0;
            this.btnCancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarP.ForeColor = System.Drawing.Color.White;
            this.btnCancelarP.Location = new System.Drawing.Point(497, 293);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Size = new System.Drawing.Size(100, 39);
            this.btnCancelarP.TabIndex = 24;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.UseVisualStyleBackColor = false;
            this.btnCancelarP.Click += new System.EventHandler(this.btnCancelarP_Click);
            // 
            // btnGravarP
            // 
            this.btnGravarP.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGravarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravarP.FlatAppearance.BorderSize = 0;
            this.btnGravarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarP.ForeColor = System.Drawing.Color.White;
            this.btnGravarP.Location = new System.Drawing.Point(381, 293);
            this.btnGravarP.Name = "btnGravarP";
            this.btnGravarP.Size = new System.Drawing.Size(96, 39);
            this.btnGravarP.TabIndex = 23;
            this.btnGravarP.Text = "Gravar";
            this.btnGravarP.UseVisualStyleBackColor = false;
            this.btnGravarP.Click += new System.EventHandler(this.btnGravarP_Click);
            // 
            // btnRemoverP
            // 
            this.btnRemoverP.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRemoverP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverP.FlatAppearance.BorderSize = 0;
            this.btnRemoverP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverP.ForeColor = System.Drawing.Color.White;
            this.btnRemoverP.Location = new System.Drawing.Point(265, 293);
            this.btnRemoverP.Name = "btnRemoverP";
            this.btnRemoverP.Size = new System.Drawing.Size(98, 39);
            this.btnRemoverP.TabIndex = 22;
            this.btnRemoverP.Text = "Remover";
            this.btnRemoverP.UseVisualStyleBackColor = false;
            this.btnRemoverP.Click += new System.EventHandler(this.btnRemoverP_Click);
            // 
            // btnEditarP
            // 
            this.btnEditarP.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEditarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarP.FlatAppearance.BorderSize = 0;
            this.btnEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarP.ForeColor = System.Drawing.Color.White;
            this.btnEditarP.Location = new System.Drawing.Point(149, 293);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(96, 39);
            this.btnEditarP.TabIndex = 21;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.UseVisualStyleBackColor = false;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // btnInserirP
            // 
            this.btnInserirP.BackColor = System.Drawing.Color.MediumBlue;
            this.btnInserirP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirP.FlatAppearance.BorderSize = 0;
            this.btnInserirP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirP.ForeColor = System.Drawing.Color.White;
            this.btnInserirP.Location = new System.Drawing.Point(33, 293);
            this.btnInserirP.Name = "btnInserirP";
            this.btnInserirP.Size = new System.Drawing.Size(96, 39);
            this.btnInserirP.TabIndex = 20;
            this.btnInserirP.Text = "Inserir";
            this.btnInserirP.UseVisualStyleBackColor = false;
            this.btnInserirP.Click += new System.EventHandler(this.btnInserirP_Click);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(244, 183);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(356, 22);
            this.txtValor.TabIndex = 19;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(244, 125);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(356, 22);
            this.txtNomeProd.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(252, 72);
            this.lblId.Margin = new System.Windows.Forms.Padding(3);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 17;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(122, 183);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(64, 25);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Valor:";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProd.Location = new System.Drawing.Point(122, 125);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(116, 25);
            this.lblNomeProd.TabIndex = 15;
            this.lblNomeProd.Text = "Nome Prod:";
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduto.Location = new System.Drawing.Point(122, 72);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(37, 25);
            this.lblIdProduto.TabIndex = 14;
            this.lblIdProduto.Text = "ID:";
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.btnFiltrar);
            this.gpbPesquisa.Controls.Add(this.lblTexto);
            this.gpbPesquisa.Controls.Add(this.txtPesquisa);
            this.gpbPesquisa.Controls.Add(this.rdbNome);
            this.gpbPesquisa.Controls.Add(this.rdbId);
            this.gpbPesquisa.Controls.Add(this.rdbTodos);
            this.gpbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisa.Location = new System.Drawing.Point(749, 23);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(459, 309);
            this.gpbPesquisa.TabIndex = 27;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisar";
            this.gpbPesquisa.Visible = false;
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(39, 193);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(142, 28);
            this.lblTexto.TabIndex = 27;
            this.lblTexto.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(842, 364);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(212, 39);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(44, 224);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(388, 30);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.Visible = false;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(44, 145);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(120, 29);
            this.rdbNome.TabIndex = 2;
            this.rdbNome.Text = "Por Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(44, 103);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(87, 29);
            this.rdbId.TabIndex = 1;
            this.rdbId.Text = "Por ID";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.CheckedChanged += new System.EventHandler(this.rdbId_CheckedChanged_1);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(44, 68);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(89, 29);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged_1);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(220, 264);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(212, 39);
            this.btnFiltrar.TabIndex = 28;
            this.btnFiltrar.Text = "Procurar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 784);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSairP);
            this.Controls.Add(this.btnCancelarP);
            this.Controls.Add(this.btnGravarP);
            this.Controls.Add(this.btnRemoverP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.btnInserirP);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.lblIdProduto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btnSairP;
        private System.Windows.Forms.Button btnCancelarP;
        private System.Windows.Forms.Button btnGravarP;
        private System.Windows.Forms.Button btnRemoverP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.Button btnInserirP;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbId;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnFiltrar;
    }
}