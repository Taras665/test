using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes
{
    public partial class ListControl : UserControl
    {
        public ListControl(Bitmap bitmap)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = bitmap;
        }

        public string Context { get => label1.Text; set => label1.Text = value; }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Program.param.auth == false)
            {
                if (Program.param.userRow.IdRole == 1)
                    редактироватьToolStripMenuItem.Visible = true;
                else
                    редактироватьToolStripMenuItem.Visible = true;
            }            
        }
    }
}
