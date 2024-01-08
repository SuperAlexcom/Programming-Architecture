using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proxy
{
    public partial class Form1 : Form
    {
        private MyPictureBox mpb;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Drag;
        }
        public void Drag(Object Sender, MouseEventArgs args)
        {
            if (mpb == null)
            {
                mpb = new MyPictureBox(new Proxy("C:/Users/mrcan/source/repos/proxy/proxy/TestImage.jpg"), args.X, args.Y, 320, 240);
                this.Controls.Add(mpb);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   }
    }
}
