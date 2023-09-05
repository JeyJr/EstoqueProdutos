﻿namespace Estoque.Telas_Produto
{
    partial class UCUsuario
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
            tlpComponenteDaPesquisa = new TableLayoutPanel();
            tlpComponentesRow1 = new TableLayoutPanel();
            txtNome = new TextBox();
            lblCargo = new Label();
            cboCargo = new ComboBox();
            lblSetor = new Label();
            lblNomeUsuario = new Label();
            cboSetor = new ComboBox();
            btnPesquisar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnSetorCargo = new Button();
            btnCadastrarUsuario = new Button();
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
            tblBotoes = new TableLayoutPanel();
            btnLimpar = new Button();
            tlpComponentesRow0 = new TableLayoutPanel();
            lblDescricao = new Label();
            pnRegua = new Panel();
            tlpComponenteDaPesquisa.SuspendLayout();
            tlpComponentesRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).BeginInit();
            tblBotoes.SuspendLayout();
            tlpComponentesRow0.SuspendLayout();
            SuspendLayout();
            // 
            // tlpComponenteDaPesquisa
            // 
            tlpComponenteDaPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpComponenteDaPesquisa.BackColor = Color.FromArgb(60, 75, 85);
            tlpComponenteDaPesquisa.ColumnCount = 1;
            tlpComponenteDaPesquisa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.Controls.Add(tlpComponentesRow1, 0, 0);
            tlpComponenteDaPesquisa.Location = new Point(14, 15);
            tlpComponenteDaPesquisa.Margin = new Padding(5);
            tlpComponenteDaPesquisa.Name = "tlpComponenteDaPesquisa";
            tlpComponenteDaPesquisa.Padding = new Padding(5);
            tlpComponenteDaPesquisa.RowCount = 1;
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponenteDaPesquisa.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponenteDaPesquisa.Size = new Size(594, 71);
            tlpComponenteDaPesquisa.TabIndex = 0;
            // 
            // tlpComponentesRow1
            // 
            tlpComponentesRow1.ColumnCount = 5;
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpComponentesRow1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpComponentesRow1.Controls.Add(txtNome, 0, 1);
            tlpComponentesRow1.Controls.Add(lblCargo, 4, 0);
            tlpComponentesRow1.Controls.Add(cboCargo, 4, 1);
            tlpComponentesRow1.Controls.Add(lblSetor, 2, 0);
            tlpComponentesRow1.Controls.Add(lblNomeUsuario, 0, 0);
            tlpComponentesRow1.Controls.Add(cboSetor, 2, 1);
            tlpComponentesRow1.Dock = DockStyle.Fill;
            tlpComponentesRow1.Location = new Point(14, 5);
            tlpComponentesRow1.Margin = new Padding(9, 0, 9, 9);
            tlpComponentesRow1.Name = "tlpComponentesRow1";
            tlpComponentesRow1.RowCount = 2;
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpComponentesRow1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpComponentesRow1.Size = new Size(566, 52);
            tlpComponentesRow1.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Dock = DockStyle.Fill;
            txtNome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(3, 23);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(172, 27);
            txtNome.TabIndex = 15;
            // 
            // lblCargo
            // 
            lblCargo.Dock = DockStyle.Fill;
            lblCargo.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCargo.ForeColor = SystemColors.ControlLightLight;
            lblCargo.Location = new Point(386, 0);
            lblCargo.Margin = new Padding(0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(180, 20);
            lblCargo.TabIndex = 12;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.BottomLeft;
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
            cboCargo.Location = new Point(389, 23);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(174, 26);
            cboCargo.TabIndex = 10;
            cboCargo.SelectedIndexChanged += cboCargo_SelectedIndexChanged;
            // 
            // lblSetor
            // 
            lblSetor.Dock = DockStyle.Fill;
            lblSetor.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSetor.ForeColor = SystemColors.ControlLightLight;
            lblSetor.Location = new Point(193, 0);
            lblSetor.Margin = new Padding(0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(178, 20);
            lblSetor.TabIndex = 11;
            lblSetor.Text = "Setor:";
            lblSetor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.Dock = DockStyle.Fill;
            lblNomeUsuario.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeUsuario.ForeColor = SystemColors.ControlLightLight;
            lblNomeUsuario.Location = new Point(0, 0);
            lblNomeUsuario.Margin = new Padding(0);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(178, 20);
            lblNomeUsuario.TabIndex = 11;
            lblNomeUsuario.Text = "Nome do usuário:";
            lblNomeUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboSetor
            // 
            cboSetor.Dock = DockStyle.Fill;
            cboSetor.DropDownHeight = 200;
            cboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSetor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboSetor.FormattingEnabled = true;
            cboSetor.IntegralHeight = false;
            cboSetor.Location = new Point(196, 23);
            cboSetor.Name = "cboSetor";
            cboSetor.Size = new Size(172, 26);
            cboSetor.TabIndex = 8;
            cboSetor.SelectedIndexChanged += cboSetor_SelectedIndexChanged;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = Properties.Resources.search_1;
            btnPesquisar.Location = new Point(553, 0);
            btnPesquisar.Margin = new Padding(0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(35, 35);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = Properties.Resources.edit_outline_1;
            btnAlterar.Location = new Point(433, 0);
            btnAlterar.Margin = new Padding(0);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(35, 35);
            btnAlterar.TabIndex = 2;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
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
            // btnSetorCargo
            // 
            btnSetorCargo.Image = Properties.Resources.new_outline_2;
            btnSetorCargo.Location = new Point(473, 0);
            btnSetorCargo.Margin = new Padding(0);
            btnSetorCargo.Name = "btnSetorCargo";
            btnSetorCargo.Size = new Size(35, 35);
            btnSetorCargo.TabIndex = 4;
            btnSetorCargo.UseVisualStyleBackColor = true;
            btnSetorCargo.Click += btnSetorCargo_Click;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Image = Properties.Resources.new_outline_1;
            btnCadastrarUsuario.Location = new Point(393, 0);
            btnCadastrarUsuario.Margin = new Padding(0);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(35, 35);
            btnCadastrarUsuario.TabIndex = 5;
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // dtgUsuarios
            // 
            dtgUsuarios.AllowUserToAddRows = false;
            dtgUsuarios.AllowUserToDeleteRows = false;
            dtgUsuarios.AllowUserToOrderColumns = true;
            dtgUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 235, 235);
            dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dtgUsuarios.EnableHeadersVisualStyles = false;
            dtgUsuarios.GridColor = Color.White;
            dtgUsuarios.Location = new Point(15, 149);
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
            dtgUsuarios.Size = new Size(592, 304);
            dtgUsuarios.TabIndex = 6;
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
            colNomeCompleto.HeaderText = "Nome Completo";
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
            // tblBotoes
            // 
            tblBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            tblBotoes.Location = new Point(16, 100);
            tblBotoes.Margin = new Padding(0);
            tblBotoes.Name = "tblBotoes";
            tblBotoes.RightToLeft = RightToLeft.Yes;
            tblBotoes.RowCount = 1;
            tblBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotoes.Size = new Size(588, 35);
            tblBotoes.TabIndex = 8;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.erase_outline_1;
            btnLimpar.Location = new Point(513, 0);
            btnLimpar.Margin = new Padding(0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(35, 35);
            btnLimpar.TabIndex = 6;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // tlpComponentesRow0
            // 
            tlpComponentesRow0.ColumnCount = 8;
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6314F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3686F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tlpComponentesRow0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tlpComponentesRow0.Controls.Add(lblDescricao, 2, 0);
            tlpComponentesRow0.Location = new Point(0, 0);
            tlpComponentesRow0.Name = "tlpComponentesRow0";
            tlpComponentesRow0.RowCount = 1;
            tlpComponentesRow0.Size = new Size(200, 100);
            tlpComponentesRow0.TabIndex = 0;
            // 
            // lblDescricao
            // 
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.ForeColor = SystemColors.ControlLightLight;
            lblDescricao.Location = new Point(-22, 0);
            lblDescricao.Margin = new Padding(0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(1, 100);
            lblDescricao.TabIndex = 19;
            lblDescricao.Text = "Descrição do Produto:";
            lblDescricao.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnRegua
            // 
            pnRegua.BackColor = Color.Brown;
            pnRegua.Location = new Point(607, 0);
            pnRegua.Name = "pnRegua";
            pnRegua.Size = new Size(15, 15);
            pnRegua.TabIndex = 9;
            pnRegua.Visible = false;
            // 
            // UCUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 90, 100);
            Controls.Add(pnRegua);
            Controls.Add(tlpComponenteDaPesquisa);
            Controls.Add(tblBotoes);
            Controls.Add(dtgUsuarios);
            Margin = new Padding(15);
            MinimumSize = new Size(623, 468);
            Name = "UCUsuario";
            Padding = new Padding(15);
            Size = new Size(623, 468);
            Load += UCProdutos_Load;
            ParentChanged += UCProdutos_ParentChanged;
            tlpComponenteDaPesquisa.ResumeLayout(false);
            tlpComponentesRow1.ResumeLayout(false);
            tlpComponentesRow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarios).EndInit();
            tblBotoes.ResumeLayout(false);
            tlpComponentesRow0.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cboCargo;
        private ComboBox cboSetor;
        private Button btnPesquisar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnSetorCargo;
        private Button btnCadastrarUsuario;
        private DataGridView dtgUsuarios;
        private TableLayoutPanel tblBotoes;
        private TableLayoutPanel tlpComponentesRow1;
        private Label lblCargo;
        private Label lblSetor;
        private Label lblNomeUsuario;
        private TableLayoutPanel tlpComponenteDaPesquisa;
        private TableLayoutPanel tlpComponentesRow0;
        private Label lblDescricao;
        private TextBox txtNome;
        private Panel pnRegua;
        private Button btnLimpar;
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
