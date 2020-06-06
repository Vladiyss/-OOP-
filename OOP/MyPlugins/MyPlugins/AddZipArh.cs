using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyPlugins
{
    public static class AddZipArh
    {
        public static Button ButtonZip()
        {
            var location = new Point(10, 410);
            var buttonSize = new Point(100, 40);
            Size size = new Size(buttonSize);
            Button Result = new Button() { Text = "Архивировать в zip файл", Size = size, Visible = true, Location = location };
            Result.Click += ButtonZip_Click;
            return Result;
        }

        static void ButtonZip_Click(object sender, EventArgs e)
        {
            ZipArhivation.ZipProcess("space.bin");
        }

        public static Button ButtonDeZip()
        {
            var location = new Point(150, 410);
            var buttonSize = new Point(120, 40);
            Size size = new Size(buttonSize);
            Button Result = new Button() { Text = "Деархивировать zip", Size = size, Visible = true, Location = location };
            Result.Click += ButtonDeZip_Click;
            return Result;
        }

        static void ButtonDeZip_Click(object sender, EventArgs e)
        {
            ZipArhivation.DeZipProcess("space.zip");
        }
    }
}
