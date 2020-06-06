using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Drawing;

namespace MyPlugins
{
    public static class AddGZArh
    {
        public static Button ButtonArhiv()
        {
            var location = new Point(10, 360);
            var buttonSize = new Point(100, 40);
            Size size = new Size(buttonSize);
            Button Result = new Button() { Text = "Архивировать в gz файл", Size = size ,  Visible=true, Location = location };
            Result.Click += ButtonArhiv_Click;
            return Result;
        }

        static void ButtonArhiv_Click(object sender, EventArgs e)
        {
            GzArhivation.Compress("space.bin", "space.gz");
        }

        public static Button ButtonDearhiv()
        {
            var location = new Point(150, 360);
            var buttonSize = new Point(120, 40);
            Size size = new Size(buttonSize);
            Button Result = new Button() { Text = "Деaрхивировать gz", Size = size, Visible = true, Location = location };
            Result.Click += ButtonDerhi_Click;
            return Result;
        }

        static void ButtonDerhi_Click(object sender, EventArgs e)
        {
            GzArhivation.Decompress( "space.gz","newspace.bin");
        }
    } 
    
}
