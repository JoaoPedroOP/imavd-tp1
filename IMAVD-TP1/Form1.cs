using IMAVD_TP1.DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IMAVD_TP1
{
    public partial class UI : Form
    {
        private Bitmap originalImage;
        private ColorSearchDTO colorSearchInfo;
        private int brightness = 0;

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void imgLoadBtn_Click(object sender, EventArgs e)
        {
            this.imageBox.Image = null;
            var openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var fileImage = new Bitmap(openFile.FileName);
                imageBox.Image = fileImage;
                this.originalImage = fileImage;
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

        private Image ZoomPicture(Image img, Size size)
        {
            var bm = new Bitmap(img, img.Width + (img.Width * size.Width / 10),
                img.Height + (img.Height * size.Height / 10));
            var gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            if (zoomBar.Value >= 0)
            {
                imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                imageBox.Image = ZoomPicture(this.originalImage, new Size(zoomBar.Value, zoomBar.Value));
            }
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "Red");
            }
            else warnToLoadImage();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "Green");
            }
            else warnToLoadImage();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image,"Blue");
            }
            else warnToLoadImage();
        }

        public static void warnToLoadImage()
        {
            MessageBox.Show("Please load an image first!","Need Image First");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                if (colorSearchDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorSearchDialog.Color;
                    if (selectedColor != null)
                    {
                        colorSearchInfo = ImageSearcher.searchColor(this.imageBox.Image,selectedColor);

                        colorExistsLabel.Visible = true;
                        if (colorSearchInfo.colorExists) {
                            colorExistsLabel.Text = "Color Found!";
                        }else colorExistsLabel.Text = "Color NOT Found!";
                        
                        nrPixelsWithColorLabel.Visible = true;
                        nrPixelsWithColorLabel.Text = colorSearchInfo.numberOfSameColorPixels.ToString();
                    }
                }
            }
            else warnToLoadImage();
        }

        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "InvertColors");
            }
            else warnToLoadImage();
        }

        private void brightBar_Scroll(object sender, EventArgs e)
        {
            this.brightLbl.Visible = true;
            this.brightLbl.Text = this.brightBar.Value.ToString()+"%";

            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageAdjuster.transform(this.imageBox.Image,
                    "Bright",this.brightBar.Value);
            }
            else warnToLoadImage();
        }


    }
}
