﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace JJ.Helpers.Formatacao
{
    public static class Conversao
    {
        public static byte[] ConvertImageToByteArray(this Image image)
        {
            MemoryStream? stream = null;

            try
            {
                using (stream = new System.IO.MemoryStream())
                {
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao converter imagem para byte.");
            }

            return stream.ToArray();
        }
    }
}
