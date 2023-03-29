using IMAVD_TP1.Enums;
using IMAVD_TP1.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMAVD_TP1
{
    public partial class RotationForm : Form
    {
        private ImageProcessor imageProcessor;
        private Image originalImage;
        private string fileName;
        private PictureBox transformedImageBox;

        public RotationForm(
            ImageProcessor imageProcessor,
            Image originalImage,
            string fileName,
            PictureBox transformedImageBox)
        {
            InitializeComponent();
            this.imageProcessor = imageProcessor;
            this.originalImage = originalImage;
            this.fileName = fileName;
            this.transformedImageBox = transformedImageBox;
        }

        private void rotationBar_Scroll(object sender, EventArgs e)
        {
            if (this.originalImage != null)
            {
                this.transformedImageBox.Image = this.imageProcessor.ImageProcessing(
                    this.fileName,
                    Operation.Rotate,
                    this.rotationBar.Value);
            }
            else Logger.WarnToLoadImage();
        }
    }
}
