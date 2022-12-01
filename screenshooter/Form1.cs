using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace screenshooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void test1fail()
        {
            IDataObject clipdata = Clipboard.GetDataObject();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Bitmap bmp = new Bitmap("tmp.bmp");
            bmp = (Bitmap)clipdata.GetData(DataFormats.Bitmap);
            //bmp.Save(Application.StartupPath + "\\" + "screenshoot" + "_" + dt.Millisecond.ToString() + ".jpg", ImageFormat.Jpeg);
            this.BackgroundImage = bmp;
            bmp.Save("tmp.bmp");
        }

        public void test2()
        {
            Bitmap bitmap = new Bitmap("tmp.bmp");
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(0, 0, 1024, 768, new Size(1024, 768));
            Image img = (Image)bitmap;
            Clipboard.SetImage(img);
            bitmap.Save("fila.bmp", ImageFormat.Bmp);
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            test2();

        }

        
    }
}
