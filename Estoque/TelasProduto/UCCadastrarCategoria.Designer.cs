﻿namespace Estoque.Telas_Produto
{
    partial class UCCadastrarCategoria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tlpCentral = new TableLayoutPanel();
            dtgCategoria = new DataGridView();
            colPK_Categoria = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            tlpCargo = new TableLayoutPanel();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            tlpBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnLimpar = new Button();
            tblSetor = new TableLayoutPanel();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            tblPrincipal = new TableLayoutPanel();
            pBarraStatus = new Panel();
            lblTotalPesquisado = new Label();
            lblTotalRegistrado = new Label();
            tlpCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCategoria).BeginInit();
            tlpCargo.SuspendLayout();
            tlpBotoes.SuspendLayout();
            tblSetor.SuspendLayout();
            tblPrincipal.SuspendLayout();
            pBarraStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(dtgCategoria, 0, 5);
            tlpCentral.Controls.Add(tlpCargo, 0, 0);
            tlpCentral.Controls.Add(tlpBotoes, 0, 3);
            tlpCentral.Controls.Add(tblSetor, 0, 1);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 15);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 6;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.Size = new Size(560, 530);
            tlpCentral.TabIndex = 0;
            // 
            // dtgCategoria
            // 
            dtgCategoria.AllowUserToDeleteRows = false;
            dtgCategoria.AllowUserToOrderColumns = true;
            dtgCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(235, 235, 235);
            dtgCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dtgCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCategoria.BackgroundColor = Color.FromArgb(235, 235, 235);
            dtgCategoria.BorderStyle = BorderStyle.None;
            dtgCategoria.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgCategoria.ColumnHeadersHeight = 35;
            dtgCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgCategoria.Columns.AddRange(new DataGridViewColumn[] { colPK_Categoria, colNome, colDescricao });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle11.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(140, 200, 120);
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dtgCategoria.DefaultCellStyle = dataGridViewCellStyle11;
            dtgCategoria.EnableHeadersVisualStyles = false;
            dtgCategoria.GridColor = Color.White;
            dtgCategoria.Location = new Point(0, 225);
            dtgCategoria.Margin = new Padding(0);
            dtgCategoria.MultiSelect = false;
            dtgCategoria.Name = "dtgCategoria";
            dtgCategoria.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dtgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dtgCategoria.RowHeadersVisible = false;
            dtgCategoria.RowHeadersWidth = 55;
            dtgCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgCategoria.RowTemplate.Height = 25;
            dtgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCategoria.Size = new Size(560, 305);
            dtgCategoria.TabIndex = 9;
            // 
            // colPK_Categoria
            // 
            colPK_Categoria.DataPropertyName = "PK_Categoria";
            colPK_Categoria.HeaderText = "PK_Categoria";
            colPK_Categoria.MinimumWidth = 100;
            colPK_Categoria.Name = "colPK_Categoria";
            colPK_Categoria.ReadOnly = true;
            colPK_Categoria.Visible = false;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "Nome";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Padding = new Padding(10, 0, 0, 0);
            colNome.DefaultCellStyle = dataGridViewCellStyle9;
            colNome.HeaderText = "Categoria";
            colNome.MinimumWidth = 200;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colDescricao
            // 
            colDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Padding = new Padding(10, 0, 0, 0);
            colDescricao.DefaultCellStyle = dataGridViewCellStyle10;
            colDescricao.HeaderText = "Descricao";
            colDescricao.MinimumWidth = 200;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            // 
            // tlpCargo
            // 
            tlpCargo.BackColor = Color.FromArgb(60, 75, 85);
            tlpCargo.ColumnCount = 1;
            tlpCargo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCargo.Controls.Add(lblCategoria, 0, 0);
            tlpCargo.Controls.Add(txtCategoria, 0, 1);
            tlpCargo.Dock = DockStyle.Fill;
            tlpCargo.Location = new Point(0, 0);
            tlpCargo.Margin = new Padding(0);
            tlpCargo.Name = "tlpCargo";
            tlpCargo.Padding = new Padding(15, 0, 15, 0);
            tlpCargo.RowCount = 2;
            tlpCargo.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpCargo.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpCargo.Size = new Size(560, 80);
            tlpCargo.TabIndex = 16;
            // 
            // lblCategoria
            // 
            lblCategoria.Dock = DockStyle.Fill;
            lblCategoria.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.ForeColor = SystemColors.ControlLightLight;
            lblCategoria.Location = new Point(15, 0);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(530, 32);
            lblCategoria.TabIndex = 17;
            lblCategoria.Text = "Categoria:";
            lblCategoria.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.Dock = DockStyle.Fill;
            txtCategoria.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(18, 35);
            txtCategoria.MaxLength = 120;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(524, 27);
            txtCategoria.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            tlpBotoes.BackColor = Color.Transparent;
            tlpBotoes.ColumnCount = 8;
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpBotoes.Controls.Add(btnPesquisar, 0, 0);
            tlpBotoes.Controls.Add(btnExcluir, 7, 0);
            tlpBotoes.Controls.Add(btnCancelar, 1, 0);
            tlpBotoes.Controls.Add(btnSalvar, 2, 0);
            tlpBotoes.Controls.Add(btnCadastrar, 5, 0);
            tlpBotoes.Controls.Add(btnAlterar, 4, 0);
            tlpBotoes.Controls.Add(btnLimpar, 3, 0);
            tlpBotoes.Dock = DockStyle.Fill;
            tlpBotoes.Location = new Point(0, 175);
            tlpBotoes.Margin = new Padding(0);
            tlpBotoes.Name = "tlpBotoes";
            tlpBotoes.RightToLeft = RightToLeft.Yes;
            tlpBotoes.RowCount = 1;
            tlpBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoes.Size = new Size(560, 35);
            tlpBotoes.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(525, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.delete_outline_1;
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 35);
            btnExcluir.TabIndex = 8;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_outline_1;
            btnCancelar.Location = new Point(490, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(35, 35);
            btnCancelar.TabIndex = 3;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save_outline_1;
            btnSalvar.Location = new Point(455, 0);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(35, 35);
            btnSalvar.TabIndex = 4;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.new_outline_1;
            btnCadastrar.Location = new Point(350, 0);
            btnCadastrar.Margin = new Padding(0);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(35, 35);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(385, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 6;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(420, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 5;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tblSetor
            // 
            tblSetor.BackColor = Color.FromArgb(60, 75, 85);
            tblSetor.ColumnCount = 1;
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSetor.Controls.Add(txtDescricao, 0, 1);
            tblSetor.Controls.Add(lblDescricao, 0, 0);
            tblSetor.Dock = DockStyle.Fill;
            tblSetor.Location = new Point(0, 80);
            tblSetor.Margin = new Padding(0);
            tblSetor.Name = "tblSetor";
            tblSetor.Padding = new Padding(15, 0, 15, 0);
            tblSetor.RowCount = 2;
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblSetor.Size = new Size(560, 80);
            tblSetor.TabIndex = 14;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.FixedSingle;
            txtDescricao.Dock = DockStyle.Fill;
            txtDescricao.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Location = new Point(18, 35);
            txtDescricao.MaxLength = 120;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(524, 27);
            txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = SystemColors.ControlLightLight;
            lblDescricao.Location = new Point(15, 0);
            lblDescricao.Margin = new Padding(0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(530, 32);
            lblDescricao.TabIndex = 17;
            lblDescricao.Text = "Descrição:";
            lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblPrincipal
            // 
            tblPrincipal.BackColor = Color.Transparent;
            tblPrincipal.ColumnCount = 1;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblPrincipal.Controls.Add(tlpCentral, 0, 1);
            tblPrincipal.Controls.Add(pBarraStatus, 0, 2);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Margin = new Padding(0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 3;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.Size = new Size(560, 560);
            tblPrincipal.TabIndex = 1;
            // 
            // pBarraStatus
            // 
            pBarraStatus.BackColor = Color.FromArgb(16, 23, 28);
            pBarraStatus.Controls.Add(lblTotalPesquisado);
            pBarraStatus.Controls.Add(lblTotalRegistrado);
            pBarraStatus.Dock = DockStyle.Fill;
            pBarraStatus.Location = new Point(0, 545);
            pBarraStatus.Margin = new Padding(0);
            pBarraStatus.Name = "pBarraStatus";
            pBarraStatus.Size = new Size(560, 15);
            pBarraStatus.TabIndex = 1;
            // 
            // lblTotalPesquisado
            // 
            lblTotalPesquisado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPesquisado.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPesquisado.ForeColor = SystemColors.ControlLightLight;
            lblTotalPesquisado.Location = new Point(0, 0);
            lblTotalPesquisado.Margin = new Padding(0);
            lblTotalPesquisado.Name = "lblTotalPesquisado";
            lblTotalPesquisado.Padding = new Padding(15, 0, 0, 0);
            lblTotalPesquisado.Size = new Size(266, 17);
            lblTotalPesquisado.TabIndex = 14;
            lblTotalPesquisado.Text = "Pesquisado: 100000";
            lblTotalPesquisado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalRegistrado
            // 
            lblTotalRegistrado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalRegistrado.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRegistrado.ForeColor = SystemColors.ControlLightLight;
            lblTotalRegistrado.Location = new Point(266, 0);
            lblTotalRegistrado.Margin = new Padding(0);
            lblTotalRegistrado.Name = "lblTotalRegistrado";
            lblTotalRegistrado.Padding = new Padding(0, 0, 15, 0);
            lblTotalRegistrado.Size = new Size(294, 17);
            lblTotalRegistrado.TabIndex = 13;
            lblTotalRegistrado.Text = "Registrado: 100000";
            lblTotalRegistrado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCCadastrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(tblPrincipal);
            Name = "UCCadastrarCategoria";
            Size = new Size(560, 560);
            Load += UCCadastrar_Load;
            tlpCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCategoria).EndInit();
            tlpCargo.ResumeLayout(false);
            tlpCargo.PerformLayout();
            tlpBotoes.ResumeLayout(false);
            tblSetor.ResumeLayout(false);
            tblSetor.PerformLayout();
            tblPrincipal.ResumeLayout(false);
            pBarraStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tblBotoes;
        private Button btnPesquisar;
        private Button btnLimpar;
        private TableLayoutPanel tlpBotoes;
        private Button btnPesqusiar;
        private Button button2;
        private Button btnExcluir;
        private Button btnAlterar;
        private Button btnCadastrar;
        private Button btnSalvar;
        private Button btnCancelar;
        private TableLayoutPanel tblSetor;
        private Label lblDescricao;
        private Panel pBarraStatus;
        private Label lblTotalRegistrado;
        private Label lblTotalPesquisado;
        private TableLayoutPanel tlpCargo;
        private Label lblCategoria;
        private TextBox txtCategoria;
        private DataGridView dtgCategoria;
        private TextBox txtDescricao;
        private DataGridViewTextBoxColumn colPK_Categoria;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colDescricao;
    }
}
