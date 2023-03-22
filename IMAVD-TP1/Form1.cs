using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_TP1
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void imgLoadBtn_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK) {
                imageBox.Image = new Bitmap(openFile.FileName);
            }

        }
    }
}
