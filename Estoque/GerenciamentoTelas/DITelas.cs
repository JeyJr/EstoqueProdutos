﻿using EP.Data.Interfaces;
using Estoque.GerenciamentoTelas;
using Estoque.Interfaces;
using Estoque.Telas_Base.UC_Componentes;
using Estoque.Telas_Principal;
using EstoqueProdutos.Interfaces;
using EstoqueProdutos.Repositorios;
using EstoqueProdutos.Telas_Principal;
using JJ.Helpers.Formatacao;
using JJ.Helpers.Interfaces;
using SimpleInjector;

namespace EstoqueProdutos.Gerenciamento
{
    /// <summary>
    /// Configuração da Injeção de Dependencia
    /// </summary>
    public static class DITelas
    {
        private static readonly Container _container;

        static DITelas()
        {
            _container = new Container();
            _container.RegisterSingleton<IUCTelaPrincipalBaixo, UCTelaPrincipalBaixo>();
            _container.RegisterSingleton<IUCTelaPrincipalCima, UCTelaPrincipalCima>();
            _container.RegisterSingleton<IUCTelaPrincipalDireita, UCTelaPrincipalDireita>();
            _container.RegisterSingleton<IUsuarioLogado, UsuarioLogado>();
            _container.Register<IValidacao, Validacao>();

            _container.Options.ResolveUnregisteredConcreteTypes = true;
            _container.Verify();
        }

        public static Container Container => _container;
    }
}
