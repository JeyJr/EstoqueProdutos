﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estoque.Telas_Mensagens.FrmMensagem;

namespace Estoque.Enums
{
    public class EstoqueEnums
    {

    }

    public enum ModoBotoes
    {
        Inicial,
        Edicao,
        Exclusao,
    }

    public enum NomeBotoes
    {
        Alterar,
        Excluir,
        Cadastrar,
        Pesquisar,
        Cancelar,
        Limpar,
        Salvar
    }

    public enum ModoCRUD
    {
        Select,
        Insert,
        Update,
        Delete
    }

    public enum Alertas
    {
        Erro,
        Aviso,
        Confirmacao,
        Informacao
    }

    public enum TipoMensagem 
    { 
        Pergunta, 
        Erro 
    }

    public enum RespostaCaixaDialogo 
    { 
        Nenhuma, 
        Sim,
        Não
    }

}
