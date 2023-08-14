﻿using EstoqueProdutos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace EP.Data.Interfaces
{
    public interface IImagemRepositorio
    {
        public void SalvarImagemPadraoLocalTemporario();
        public Image? ProcurarImagemLocal();
        /// <summary>
        /// Salvar a imagem na base de dados e retorna o ID da mesma
        /// </summary>
        /// <param name="img">imagem que o usuario selecionou</param>
        /// <returns></returns>
        public int SalvarImagem(Image img);
        public Imagem ObterObjetoImagemPadrao();
        public Image ObterImagemPadrao();
    }
}
