﻿using EstoqueProdutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutos.Entidades
{
    public class UnidadeMedida
    {
        public int PK_UnidadeMedida { get; set; }
        public string? Sigla { get; set; }
        public string? Extenso { get; set; }
    }
}
 