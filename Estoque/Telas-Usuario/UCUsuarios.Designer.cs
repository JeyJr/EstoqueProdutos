﻿namespace Estoque.Telas_Usuario
{
    partial class UCUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpCentral = new TableLayoutPanel();
            dtgUsuarios = new DataGridView();
            colPK_Usuario = new DataGridViewTextBoxColumn();
            colNomeCompleto = new DataGridViewTextBoxColumn();
            colNomeAbreviado = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colFK_Setor = new DataGridViewTextBoxColumn();
            colNomeSetor = new DataGridViewTextBoxColumn();
            colFK_Cargo = new DataGridViewTextBoxColumn();
            colNomeCargo = new DataGridViewTextBoxColumn();
            colFK_Imagem = new DataGridViewTextBoxColumn();
            tblSetor = new TableLayoutPanel();
            txtNome = new TextBox();
            lblSetor = new Label();
            cboSetor = new ComboBox();
            cboCargo = new ComboBox();
            lblNome = new Label();
            lblCargo = new Label();
            tblBotoes = new TableLayoutPanel();
            btnPesquisar = new Button();
            btnExcluir = new Button();
            btnCadastrarUsuario = new Button();
            btnAlterar = new Button();
            btnSetorCargo = new Button();
            btnLimpar = new Button();
            tblPrincipal = new TableLayoutPanel();
            pBarraStatus = new Panel();
            lblTotalPesquisado = new Label();
            lblTotalRegistrado = new Label();
            tlpCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            tblSetor.SuspendLayout();
            tblBotoes.SuspendLayout();
            tblPrincipal.SuspendLayout();
            pBarraStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCentral
            // 
            tlpCentral.BackColor = Color.Transparent;
            tlpCentral.ColumnCount = 1;
            tlpCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCentral.Controls.Add(dtgUsuarios, 0, 4);
            tlpCentral.Controls.Add(tblSetor, 0, 0);
            tlpCentral.Controls.Add(tblBotoes, 0, 2);
            tlpCentral.Dock = DockStyle.Fill;
            tlpCentral.Location = new Point(0, 0);
            tlpCentral.Margin = new Padding(0);
            tlpCentral.Name = "tlpCentral";
            tlpCentral.RowCount = 5;
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpCentral.Size = new Size(560, 545);
            tlpCentral.TabIndex = 0;
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.AllowUserToOrderColumns = true;
            dtgUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsuarios.BackgroundColor = Color.FromArgb(235, 235, 235);
            dtgUsuarios.BorderStyle = BorderStyle.None;
            dtgUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dtgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(60, 74, 84);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 59, 67);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgUsuarios.ColumnHeadersHeight = 35;
            dtgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgUsuarios.Columns.AddRange(new DataGridViewColumn[] { colPK_Usuario, colNomeCompleto, colNomeAbreviado, colEmail, colFK_Setor, colNomeSetor, colFK_Cargo, colNomeCargo, colFK_Imagem });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(140, 200, 120);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dtgUsuarios.Dock = DockStyle.Fill;
            dtgUsuarios.EnableHeadersVisualStyles = false;
            dtgUsuarios.GridColor = Color.White;
            dtgUsuarios.Location = new Point(0, 145);
            dtgUsuarios.Margin = new Padding(0);
            dtgUsuarios.Name = "dtgUsuarios";
            dtgUsuarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(217, 217, 217);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgUsuarios.RowHeadersVisible = false;
            dtgUsuarios.RowHeadersWidth = 55;
            dtgUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgUsuarios.RowTemplate.Height = 25;
            dtgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarios.Size = new Size(560, 400);
            dtgUsuarios.TabIndex = 16;
            // 
            // colPK_Usuario
            // 
            colPK_Usuario.DataPropertyName = "PK_Usuario";
            colPK_Usuario.HeaderText = "PK_Usuario";
            colPK_Usuario.MinimumWidth = 100;
            colPK_Usuario.Name = "colPK_Usuario";
            colPK_Usuario.ReadOnly = true;
            colPK_Usuario.Visible = false;
            // 
            // colNomeCompleto
            // 
            colNomeCompleto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNomeCompleto.DataPropertyName = "NomeCompleto";
            colNomeCompleto.HeaderText = "Nome";
            colNomeCompleto.MinimumWidth = 100;
            colNomeCompleto.Name = "colNomeCompleto";
            colNomeCompleto.ReadOnly = true;
            // 
            // colNomeAbreviado
            // 
            colNomeAbreviado.DataPropertyName = "NomeAbreviado";
            colNomeAbreviado.HeaderText = "Usuário";
            colNomeAbreviado.MinimumWidth = 200;
            colNomeAbreviado.Name = "colNomeAbreviado";
            colNomeAbreviado.ReadOnly = true;
            colNomeAbreviado.Width = 200;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 200;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 200;
            // 
            // colFK_Setor
            // 
            colFK_Setor.DataPropertyName = "FK_Setor";
            colFK_Setor.HeaderText = "FK_Setor";
            colFK_Setor.Name = "colFK_Setor";
            colFK_Setor.ReadOnly = true;
            colFK_Setor.Visible = false;
            // 
            // colNomeSetor
            // 
            colNomeSetor.DataPropertyName = "NomeSetor";
            colNomeSetor.HeaderText = "Setor";
            colNomeSetor.MinimumWidth = 200;
            colNomeSetor.Name = "colNomeSetor";
            colNomeSetor.ReadOnly = true;
            colNomeSetor.Width = 200;
            // 
            // colFK_Cargo
            // 
            colFK_Cargo.DataPropertyName = "FK_Cargo";
            colFK_Cargo.HeaderText = "FK_Cargo";
            colFK_Cargo.Name = "colFK_Cargo";
            colFK_Cargo.ReadOnly = true;
            colFK_Cargo.Visible = false;
            // 
            // colNomeCargo
            // 
            colNomeCargo.DataPropertyName = "NomeCargo";
            colNomeCargo.HeaderText = "Cargo";
            colNomeCargo.MinimumWidth = 200;
            colNomeCargo.Name = "colNomeCargo";
            colNomeCargo.ReadOnly = true;
            colNomeCargo.Width = 200;
            // 
            // colFK_Imagem
            // 
            colFK_Imagem.DataPropertyName = "FK_Imagem";
            colFK_Imagem.HeaderText = "FK_Imagem";
            colFK_Imagem.Name = "colFK_Imagem";
            colFK_Imagem.ReadOnly = true;
            colFK_Imagem.Visible = false;
            // 
            // tblSetor
            // 
            tblSetor.BackColor = Color.FromArgb(60, 75, 85);
            tblSetor.ColumnCount = 5;
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tblSetor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblSetor.Controls.Add(txtNome, 0, 1);
            tblSetor.Controls.Add(lblSetor, 2, 0);
            tblSetor.Controls.Add(cboSetor, 2, 1);
            tblSetor.Controls.Add(cboCargo, 4, 1);
            tblSetor.Controls.Add(lblNome, 0, 0);
            tblSetor.Controls.Add(lblCargo, 4, 0);
            tblSetor.Dock = DockStyle.Fill;
            tblSetor.Location = new Point(0, 0);
            tblSetor.Margin = new Padding(0);
            tblSetor.Name = "tblSetor";
            tblSetor.Padding = new Padding(15, 0, 15, 0);
            tblSetor.RowCount = 2;
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblSetor.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblSetor.Size = new Size(560, 80);
            tblSetor.TabIndex = 14;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Dock = DockStyle.Fill;
            txtNome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(18, 35);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(160, 27);
            txtNome.TabIndex = 19;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(196, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(166, 32);
            lblSetor.TabIndex = 17;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownHeight = 200;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.IntegralHeight = false;
            cboSetor.Location = new Point(199, 35);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(160, 26);
            cboSetor.TabIndex = 18;
            cboSetor.SelectedIndexChanged += cboSetor_SelectedIndexChanged;
            // 
            // cboCargo
            // 
            cboCargo.BackColor = SystemColors.Window;
            cboCargo.Dock = DockStyle.Fill;
            cboCargo.DropDownHeight = 200;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCargo.FormattingEnabled = true;
            cboCargo.IntegralHeight = false;
            cboCargo.Location = new Point(380, 35);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(162, 26);
            cboCargo.TabIndex = 20;
            // 
            // lblNome
            // 
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(15, 0);
            lblNome.Margin = new Padding(0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(166, 32);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome:";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(377, 0);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(168, 32);
            lblCargo.TabIndex = 22;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblBotoes
            // 
            tblBotoes.ColumnCount = 11;
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tblBotoes.Controls.Add(btnPesquisar, 0, 0);
            tblBotoes.Controls.Add(btnExcluir, 10, 0);
            tblBotoes.Controls.Add(btnCadastrarUsuario, 8, 0);
            tblBotoes.Controls.Add(btnAlterar, 6, 0);
            tblBotoes.Controls.Add(btnSetorCargo, 4, 0);
            tblBotoes.Controls.Add(btnLimpar, 2, 0);
            tblBotoes.Dock = DockStyle.Fill;
            tblBotoes.Location = new Point(0, 95);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(560, 35);
            tblBotoes.TabIndex = 15;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(525, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
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
            btnExcluir.TabIndex = 3;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Image = Properties.Resources.new_outline_1;
            btnCadastrarUsuario.Location = new Point(365, 0);
            btnCadastrarUsuario.Margin = new Padding(0);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(35, 35);
            btnCadastrarUsuario.TabIndex = 5;
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(405, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 2;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnSetorCargo
            // 
            btnSetorCargo.Image = Properties.Resources.new_outline_2;
            btnSetorCargo.Location = new Point(445, 0);
            btnSetorCargo.Margin = new Padding(0);
            btnSetorCargo.Name = "btnSetorCargo";
            btnSetorCargo.Size = new Size(35, 35);
            btnSetorCargo.TabIndex = 4;
            btnSetorCargo.UseVisualStyleBackColor = true;
            btnSetorCargo.Click += btnSetorCargo_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(485, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 6;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tblPrincipal
            // 
            tblPrincipal.BackColor = Color.Transparent;
            tblPrincipal.ColumnCount = 1;
            tblPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPrincipal.Controls.Add(tlpCentral, 0, 0);
            tblPrincipal.Controls.Add(pBarraStatus, 0, 1);
            tblPrincipal.Dock = DockStyle.Fill;
            tblPrincipal.Location = new Point(0, 0);
            tblPrincipal.Margin = new Padding(0);
            tblPrincipal.Name = "tblPrincipal";
            tblPrincipal.RowCount = 2;
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            lblTotalPesquisado.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPesquisado.ForeColor = SystemColors.ControlLightLight;
            lblTotalPesquisado.Location = new Point(4, -2);
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
            lblTotalRegistrado.Font = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRegistrado.ForeColor = SystemColors.ControlLightLight;
            lblTotalRegistrado.Location = new Point(263, -1);
            lblTotalRegistrado.Margin = new Padding(0);
            lblTotalRegistrado.Name = "lblTotalRegistrado";
            lblTotalRegistrado.Padding = new Padding(0, 0, 15, 0);
            lblTotalRegistrado.Size = new Size(294, 17);
            lblTotalRegistrado.TabIndex = 13;
            lblTotalRegistrado.Text = "Registrado: 100000";
            lblTotalRegistrado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(tblPrincipal);
            Name = "UCUsuarios";
            Size = new Size(560, 560);
            Load += UCUsuarios_Load;
            ParentChanged += UCUsuarios_ParentChanged;
            tlpCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            tblSetor.ResumeLayout(false);
            tblSetor.PerformLayout();
            tblBotoes.ResumeLayout(false);
            tblPrincipal.ResumeLayout(false);
            pBarraStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCentral;
        private TableLayoutPanel tblPrincipal;
        private TableLayoutPanel tblBotoes;
        private Button btnPesqusiar;
        private Button button2;
        private TableLayoutPanel tblSetor;
        private Label lblSetor;
        private Panel pBarraStatus;
        private Label lblTotalRegistrado;
        private Label lblTotalPesquisado;
        private ComboBox cboSetor;
        private TextBox txtNome;
        private ComboBox cboCargo;
        private Label lblNome;
        private Label lblCargo;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Button btnCadastrarUsuario;
        private Button btnAlterar;
        private Button btnSetorCargo;
        private Button btnLimpar;
        private DataGridView dtgUsuarios;
        private DataGridViewTextBoxColumn colPK_Usuario;
        private DataGridViewTextBoxColumn colNomeCompleto;
        private DataGridViewTextBoxColumn colNomeAbreviado;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colFK_Setor;
        private DataGridViewTextBoxColumn colNomeSetor;
        private DataGridViewTextBoxColumn colFK_Cargo;
        private DataGridViewTextBoxColumn colNomeCargo;
        private DataGridViewTextBoxColumn colFK_Imagem;
    }
}