﻿namespace EstoqueProdutos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlSide = new Panel();
            pnlMain = new Panel();
            lblTItulo = new Label();
            btnDeletarProduto = new Button();
            btnEditarProduto = new Button();
            btnCadastrarProduto = new Button();
            btnPesquisar = new Button();
            lblContagem = new Label();
            dtgProdutos = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colFornecedor = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colIDImagem = new DataGridViewTextBoxColumn();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSide.BackColor = Color.Gainsboro;
            pnlSide.Location = new Point(9, 12);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(70, 649);
            pnlSide.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.Gainsboro;
            pnlMain.Controls.Add(lblTItulo);
            pnlMain.Controls.Add(btnDeletarProduto);
            pnlMain.Controls.Add(btnEditarProduto);
            pnlMain.Controls.Add(btnCadastrarProduto);
            pnlMain.Controls.Add(btnPesquisar);
            pnlMain.Controls.Add(lblContagem);
            pnlMain.Controls.Add(dtgProdutos);
            pnlMain.Location = new Point(95, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1155, 649);
            pnlMain.TabIndex = 1;
            // 
            // lblTItulo
            // 
            lblTItulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTItulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTItulo.Location = new Point(363, 7);
            lblTItulo.Name = "lblTItulo";
            lblTItulo.Size = new Size(357, 54);
            lblTItulo.TabIndex = 6;
            lblTItulo.Text = "PRODUTOS";
            lblTItulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDeletarProduto
            // 
            btnDeletarProduto.Location = new Point(126, 13);
            btnDeletarProduto.Name = "btnDeletarProduto";
            btnDeletarProduto.Size = new Size(53, 45);
            btnDeletarProduto.TabIndex = 5;
            btnDeletarProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.Location = new Point(67, 13);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.Size = new Size(53, 45);
            btnEditarProduto.TabIndex = 4;
            btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProduto
            // 
            btnCadastrarProduto.Location = new Point(8, 13);
            btnCadastrarProduto.Name = "btnCadastrarProduto";
            btnCadastrarProduto.Size = new Size(53, 45);
            btnCadastrarProduto.TabIndex = 3;
            btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(878, 13);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(267, 45);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblContagem
            // 
            lblContagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblContagem.Location = new Point(0, 624);
            lblContagem.Name = "lblContagem";
            lblContagem.Size = new Size(1152, 24);
            lblContagem.TabIndex = 1;
            lblContagem.Text = "Total: 1000";
            lblContagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgProdutos
            // 
            dtgProdutos.AllowUserToAddRows = false;
            dtgProdutos.AllowUserToDeleteRows = false;
            dtgProdutos.AllowUserToResizeColumns = false;
            dtgProdutos.AllowUserToResizeRows = false;
            dtgProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProdutos.ColumnHeadersHeight = 35;
            dtgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProdutos.Columns.AddRange(new DataGridViewColumn[] { colID, colNome, colCategoria, colFornecedor, colPreco, colIDImagem });
            dtgProdutos.EnableHeadersVisualStyles = false;
            dtgProdutos.GridColor = Color.WhiteSmoke;
            dtgProdutos.Location = new Point(8, 70);
            dtgProdutos.Name = "dtgProdutos";
            dtgProdutos.ReadOnly = true;
            dtgProdutos.RowHeadersVisible = false;
            dtgProdutos.RowHeadersWidth = 100;
            dtgProdutos.RowTemplate.Height = 29;
            dtgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProdutos.Size = new Size(1138, 551);
            dtgProdutos.TabIndex = 0;
            dtgProdutos.CellValueChanged += dtgProdutos_CellValueChanged;
            // 
            // colID
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            colID.DefaultCellStyle = dataGridViewCellStyle2;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.Width = 125;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.Padding = new Padding(15, 0, 0, 0);
            colNome.DefaultCellStyle = dataGridViewCellStyle3;
            colNome.HeaderText = "NOME";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            colCategoria.DefaultCellStyle = dataGridViewCellStyle4;
            colCategoria.HeaderText = "CATEGORIA";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 230;
            // 
            // colFornecedor
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colFornecedor.DefaultCellStyle = dataGridViewCellStyle5;
            colFornecedor.HeaderText = "FORNECEDOR";
            colFornecedor.MinimumWidth = 6;
            colFornecedor.Name = "colFornecedor";
            colFornecedor.ReadOnly = true;
            colFornecedor.Width = 230;
            // 
            // colPreco
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 10, 0);
            colPreco.DefaultCellStyle = dataGridViewCellStyle6;
            colPreco.HeaderText = "PRECO";
            colPreco.MinimumWidth = 6;
            colPreco.Name = "colPreco";
            colPreco.ReadOnly = true;
            colPreco.Width = 150;
            // 
            // colIDImagem
            // 
            colIDImagem.HeaderText = "IMAGEM";
            colIDImagem.MinimumWidth = 6;
            colIDImagem.Name = "colIDImagem";
            colIDImagem.ReadOnly = true;
            colIDImagem.Visible = false;
            colIDImagem.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlMain);
            Controls.Add(pnlSide);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Estoque";
            Load += MainForm_Load;
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private Panel pnlMain;
        private Label lblContagem;
        private DataGridView dtgProdutos;
        private Button btnDeletarProduto;
        private Button btnEditarProduto;
        private Button btnCadastrarProduto;
        private Button btnPesquisar;
        private Label lblTItulo;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colFornecedor;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colIDImagem;
    }
}