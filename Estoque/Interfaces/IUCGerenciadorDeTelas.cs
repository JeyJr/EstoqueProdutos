﻿using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Interfaces
{
    public interface IUCGerenciadorDeTelas
    {
        List<Form> FormsInstanciados { get; }
        void AbrirTela(Type tela, IUCGerenciadorDeTelas ucGestor, bool travarTela = false, FormClosedEventHandler eFecharFilho = null);
        void FecharTela(Type tipoTela);
        object ObterObjetoGenerico();
        bool ObterStatusGenerico();
    }
}

//void AbrirTela<T>(IUCGerenciadorDeTelas ucGestor) where T : Form, new();