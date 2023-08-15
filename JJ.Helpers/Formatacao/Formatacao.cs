﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EstoqueProdutos.Formatacao
{
    public static class Formatacao
    {
        public static string? LimparTexto(this TextBox textBox) 
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Replace("'", "''");
                return textBox.Text.Trim();
            }
            else 
            {
                return "";
            }
        }

        public static string? TextoFormatoLikeSQL(this TextBox textBox)
        {
            if (textBox.Text.Length > 0)
            {
                return $"%{textBox.LimparTexto().Replace("'","")}%";
            }
            else
            {
                return "";
            }
        }

        public static decimal? ParaDecimal(this TextBox? textBox) 
        {
            if (textBox.Text.Length > 0)
            {
                return decimal.Parse(textBox.Text);
            }
            else 
            {
                return null;
            }
        }

        public static DateTime? ParaDataPequena(this DateTimePicker? dtp) 
        {
            if (dtp.Enabled)
            {
                return dtp.Value.Date;
            }
            else 
            { 
                return null;
            }
        }

        public static int? ObterValorInt(this ComboBox comboBox) 
        {
            if (comboBox.Enabled && (int)comboBox.SelectedValue > 0)
            {
                return (int)comboBox.SelectedValue;
            }
            else 
            {
                return null;
            }
        }
    }
}
