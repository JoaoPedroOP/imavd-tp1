using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image = new Bitmap(openFile.FileName);
                SetImagePropertiesLabels(openFile);
            }

        }

        private void SetImagePropertiesLabels(OpenFileDialog openFile)
        {
            labelName.Text = Path.GetFileNameWithoutExtension(openFile.FileName);
            labelName.Visible = true;

            labelExtension.Text = Path.GetExtension(openFile.FileName);
            labelExtension.Visible = true;

            labelLocation.Text = Path.GetDirectoryName(openFile.FileName);
            labelLocation.Visible = true;

            var img = Image.FromFile(openFile.FileName);
            labelDimensions.Text = $"Width: {img.Width} x Height: {img.Height}";
            labelDimensions.Visible = true;

            var fileInfo = new FileInfo(openFile.FileName);
            var fileSizeKB = fileInfo.Length / 1024;
            labelSize.Text = fileSizeKB.ToString();
            labelSize.Visible = true;

            labelDate.Text = fileInfo.CreationTime.ToString();
            labelDate.Visible = true;
        }
    }
}
