﻿using EstoqueProdutos.Ajudantes.Bind;
using EstoqueProdutos.Ajudantes.Componentes;
using EstoqueProdutos.Ajudantes.Formatacao;
using EstoqueProdutos.SQLServer.Conexao;
using EstoqueProdutos.SQLServer.Procedures;
using SqlData.Core.CommonSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;



namespace EstoqueProdutos.Telas_Produtos
{
    public partial class FrmPesquisar : Form
    {
        public FrmPesquisar()
        {
            InitializeComponent();
        }

        #region Metodos

        #region Carregar dados dos Componentes

        private void CarregarDadosDosComponentes()
        {
            //Tabela.ObterData(Pr_ObterUnidadeMedida.Obter(), cboUnidadeMedida, btnPesquisar);
            //Tabela.ObterData(Pr_ObterFornecedor.Obter(), cboFornecedor, btnPesquisar);
            //Tabela.ObterData(pr_ObterCategoria.Obter(), cboCategoria, btnPesquisar);
            //Tabela.ObterData(Pr_ObterEmbalagem.Obter(), cboEmbalagem, btnPesquisar);
            //Tabela.ObterData(Pr_ObterOperador.OperadorSimples(), cboOperadorPreco, btnPesquisar);
            //Tabela.ObterData(Pr_ObterOperador.OperadorSimples(), cboOperadorVolume, btnPesquisar);

            HabilitarComponente.DesabilitarBtnCadastrar(btnPesquisar);
        }

        #endregion Carregar dados dos Componentes

        private void HabilitarBtnCadastrar()
        {
            btnPesquisar.DesabilitarBtnCadastrar();

            if (String.IsNullOrEmpty(txtNome.Text))
                return;

            if (String.IsNullOrEmpty(txtPreco.Text))
                return;

            if (String.IsNullOrEmpty(txtVolume.Text))
                return;

            btnPesquisar.HabilitarBtnCadastrar();
        }

        #endregion Metodos

        #region Eventos


        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarDadosDosComponentes();
        }

        private void MascaraCasasDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((TextBox)sender).AplicarMascaraNumerosComCasasDecimais(e);
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).AplicarMascaraDinheiro();
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).RemoverMascarDinheiro();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control componente in gpbDadosProduto.Controls)
            {
                if (componente is TextBox)
                    ((TextBox)componente).Clear();

                if (componente is ComboBox)
                    ((ComboBox)componente).SelectedIndex = 0;
            }
        }

        private void txtVolume_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.LimitarCasasDecimais(2);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCadastrar();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnCadastrar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        #endregion Eventos
    }
}
