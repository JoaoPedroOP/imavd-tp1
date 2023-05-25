using IMAVD_TP1.DTO;
using IMAVD_TP1.Enums;
using IMAVD_TP1.Helpers;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace IMAVD_TP1
{
    public partial class UI : Form
    {
        private Bitmap originalImage;
        private ColorSearchDTO colorSearchInfo;
        private string fileName;
        private ImageProcessor imageProcessor = new ImageProcessor();

        //undo settings
        private List<Image> transformedImageStatus = new List<Image>();
        private bool canUndo = false;

        public UI()
        {
            InitializeComponent();
            transformedImageStatus.Clear();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void imgLoadBtn_Click(object sender, EventArgs e)
        {
            Color fundColorToRemove = new Color();
            if (chromaKeyOpt.Checked)
            {
                fundColorToRemove = chooseColorToRemove();
            }

            this.imageBox.Image = null;
            var openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.fileName = openFile.FileName;
                var fileImage = new Bitmap(openFile.FileName);

                if (chromaKeyOpt.Checked)
                {
                    fileImage = ImageColorer.getImageWithNoColor(fileImage, fundColorToRemove);
                }

                imageBox.Image = fileImage;
                this.originalImage = fileImage;
                SetImagePropertiesLabels(openFile);
                LoadImageToBeEdited();
                PrepareImageForResolutionEditing();
            }
            this.canUndo = false;
            this.checkUndoStatus();
        }

        private Color chooseColorToRemove()
        {
            if (colorSearchDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorSearchDialog.Color;
                if (selectedColor != null)
                {
                    return selectedColor;
                }
            }

            MessageBox.Show("Please select a color!", "Invalid!");
            return new Color();
        }

        private void LoadImageToBeEdited()
        {
            this.transformedImageBox.Image = imageBox.Image;
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
            gpu.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                if (zoomBar.Value > 0)
                {
                    this.transformedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    this.transformedImageBox.Image = ZoomPicture(
                        this.originalImage,
                        new Size(zoomBar.Value, zoomBar.Value));
                }
                else
                {
                    this.transformedImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else Logger.WarnToLoadImage();
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "Red", new Color());
            }
            else Logger.WarnToLoadImage();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "Green", new Color());
            }
            else Logger.WarnToLoadImage();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "Blue", new Color());
            }
            else Logger.WarnToLoadImage();
        }

        private void searchColorBtn_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                if (inChromaKeyMode)
                {

                    Color selectedColor = pixelColor.Value;
                    if (selectedColor != null)
                    {
                        colorSearchInfo = ImageSearcher.searchColor(this.imageBox.Image, selectedColor);

                        colorExistsLabel.Visible = true;
                        if (colorSearchInfo.colorExists)
                        {
                            colorExistsLabel.Text = "Color Found!";
                        }
                        else colorExistsLabel.Text = "Color NOT Found!";

                        nrPixelsWithColorLabel.Visible = true;
                        nrPixelsWithColorLabel.Text = colorSearchInfo.numberOfSameColorPixels.ToString();
                    }

                }else Logger.NoChromaKeySelected();

            }
            else Logger.WarnToLoadImage();
        }

        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageColorer.transform(this.imageBox.Image, "InvertColors", new Color());
            }
            else Logger.WarnToLoadImage();
        }

        private void brightBar_Scroll(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = this.imageProcessor.ImageProcessing(
                    this.fileName,
                    Operation.Brightness,
                    this.brightBar.Value);

            }
            else Logger.WarnToLoadImage();
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.originalImage != null)
            {
                this.transformedImageBox.Image = this.imageProcessor.ImageProcessing(
                    this.fileName,
                    Operation.Gamma,
                    this.numericUpDown1.Value);
            }
            else Logger.WarnToLoadImage();

        }

        private void saveImgBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.transformedImageBox.Image.Save(saveFileDialog.FileName,
                    System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImgBtn.PerformClick();
        }

        private void PrepareImageForResolutionEditing()
        {
            this.imgHorResCounter.Value = this.transformedImageBox.Width;
            this.imgVertResCounter.Value = this.transformedImageBox.Height;
        }

        private void imgHorResCounter_ValueChanged(object sender, EventArgs e)
        {
            saveLastImageStatus();
            this.transformedImageBox.Width = (int)this.imgHorResCounter.Value;
        }

        private void imgVertResCounter_ValueChanged(object sender, EventArgs e)
        {
            saveLastImageStatus();
            this.transformedImageBox.Height = (int)this.imgVertResCounter.Value;
        }

        private void contrastBar_Scroll(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = this.imageProcessor.ImageProcessing(
                    this.fileName,
                    Operation.Contrast,
                    this.contrastBar.Value);
            }
            else Logger.WarnToLoadImage();
        }

        #region UNDO
        private void checkUndoStatus()
        {
            if (canUndo)
            {
                this.undoToolStripMenuItem.Enabled = true;
            }
            else this.undoToolStripMenuItem.Enabled = false;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.transformedImageBox.Image = this.transformedImageStatus[this.transformedImageStatus.Count - 1];
            this.transformedImageStatus.Remove(this.transformedImageStatus[this.transformedImageStatus.Count - 1]);

            if (this.transformedImageStatus.Count == 0)
            {
                this.canUndo = false;
                checkUndoStatus();
            }
        }

        private void saveLastImageStatus()
        {
            this.canUndo = true;
            this.transformedImageStatus.Add(this.transformedImageBox.Image);

            checkUndoStatus();
        }
        #endregion

        #region Split Image
        private void fourAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageCroper.crop(
                    this.imageBox.Image, "Four Areas");
            }
            else Logger.WarnToLoadImage();
        }

        private void twoAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageCroper.crop(
                    this.imageBox.Image, "Two Areas");
            }
            else Logger.WarnToLoadImage();
        }

        private void topLeftCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageCroper.crop(
                    this.imageBox.Image, "Top Left Corner");
            }
            else Logger.WarnToLoadImage();
        }

        private void lowRightCornerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = ImageCroper.crop(
                    this.imageBox.Image, "Low Right Corner");
            }
            else Logger.WarnToLoadImage();

        }
        #endregion


        #region Flip Image
        private void flipHorizontalBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = this.imageProcessor.ImageProcessing(
                    this.fileName,
                    Operation.Flip,
                    false);
            }
            else Logger.WarnToLoadImage();
        }

        private void flipVerticallyBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = this.imageProcessor.ImageProcessing(
                    this.fileName,
                    Operation.Flip,
                    true);
            }
            else Logger.WarnToLoadImage();
        }

        private void resetFlipBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                this.transformedImageBox.Image = this.imageBox.Image;
            }
            else Logger.WarnToLoadImage();
        }
        #endregion

        #region Crop Image


        int crpX, crpY, rectW, rectH;
        bool isSelectMode = false;
        public Pen crpPen = new Pen(Color.White);

        private void cropBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (this.imageBox.Image != null)
            {
                if (rectW != 0 && rectH != 0)
                {
                    Bitmap original = new Bitmap(imageBox.Width, imageBox.Height);
                    imageBox.DrawToBitmap(original, imageBox.ClientRectangle);

                    Bitmap cropped = new Bitmap(rectW, rectH);
                    for (int i = 0; i < rectW; i++)
                    {
                        for (int y = 0; y < rectH; y++)
                        {
                            Color pxlclr = original.GetPixel(crpX + i, crpY + y);
                            cropped.SetPixel(i, y, pxlclr);
                        }
                    }
                    transformedImageBox.Image = (System.Drawing.Image)cropped;
                    transformedImageBox.SizeMode = PictureBoxSizeMode.CenterImage;

                    //Reset Graphics
                    imageBox.Refresh();
                    selectAreaBtn.BackColor = SystemColors.Control;
                    isSelectMode = false;
                    crpX = 0;
                    crpY = 0;
                    rectW = 0;
                    rectH = 0;
                }
                else
                {
                    Logger.WarnToSelectArea();
                }

            }
            else Logger.WarnToLoadImage();

        }

        private void SelectAreaInImage()
        {
            if (this.imageBox.Image != null)
            {
                if (!isSelectMode)
                {
                    imageBox.MouseDown += new MouseEventHandler(imageBox_MouseDown);
                    imageBox.MouseMove += new MouseEventHandler(imageBox_MouseMove);
                    imageBox.MouseEnter += new EventHandler(imageBox_MouseEnter);
                    isSelectMode = true;
                    selectAreaBtn.BackColor = Color.LightGreen;
                }
                else
                {
                    imageBox.Refresh();
                    selectAreaBtn.BackColor = SystemColors.Control;
                    isSelectMode = false;
                    crpX = 0;
                    crpY = 0;
                    rectW = 0;
                    rectH = 0;
                }
            }
            else Logger.WarnToLoadImage();
        }

        private void imageBox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (isSelectMode)
                {
                    Cursor = Cursors.Cross;
                    crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                    crpX = e.X;
                    crpY = e.Y;
                }
            }
        }

        private void imageBox_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (isSelectMode)
                {
                    imageBox.Refresh();
                    rectW = e.X - crpX;
                    rectH = e.Y - crpY;
                    Graphics g = imageBox.CreateGraphics();
                    g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                    g.Dispose();
                }
            }
        }

        private void imageBox_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            if (isSelectMode)
            {
                Cursor = Cursors.Cross;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        private void duplicateVertical_ValueChanged(object sender, EventArgs e)
        {
            RenderDuplicateHorizontalVerticalImage();
        }

        private void duplicateHorizontal_ValueChanged(object sender, EventArgs e)
        {
            RenderDuplicateHorizontalVerticalImage();
        }

        private void RenderDuplicateHorizontalVerticalImage()
        {
            if (this.originalImage != null)
            {
                var image = this.originalImage;

                var newImage = new Bitmap(image.Width * (int)this.duplicateHorizontal.Value, image.Height * (int)this.duplicateVertical.Value);

                using (var g = Graphics.FromImage(newImage))
                {
                    for (int i = 0; i < this.duplicateHorizontal.Value; i++)
                    {
                        for (int j = 0; j < (int)this.duplicateVertical.Value; j++)
                        {
                            g.DrawImage(image, i * image.Width, j * image.Height);
                        }
                    }
                }
                this.transformedImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.transformedImageBox.Image = newImage;
            }
            else Logger.WarnToLoadImage();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                if (colorSearchDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorSearchDialog.Color;
                    if (selectedColor != null)
                    {
                        this.transformedImageBox.Image = ImageColorer.transform(
                        this.imageBox.Image,
                        "Customize", selectedColor
                        );
                    }
                }
            }
            else Logger.WarnToLoadImage();
        }

        #endregion

        #region Add text or image 
        private void selectAreaBtn_Click(object sender, EventArgs e)
        {
            SelectAreaInImage();
        }

        private void addTextOverImageBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (rectW != 0 && rectH != 0)
            {
                string input = Interaction.InputBox("Enter your text:", "Add Text to Image", "");

                Bitmap transform = new Bitmap(transformedImageBox.Image);

                using (Graphics g = Graphics.FromImage(transform))
                {
                    Font font = new Font("Arial", 30);
                    Brush brush = new SolidBrush(Color.Black);

                    g.DrawString(input, font, brush, crpX * 2, crpY * 2);
                }

                transformedImageBox.Image = transform;

                //Reset Graphics
                imageBox.Refresh();
                selectAreaBtn.BackColor = SystemColors.Control;
                isSelectMode = false;
                crpX = 0;
                crpY = 0;
                rectW = 0;
                rectH = 0;
            }
            else
            {
                Logger.WarnToSelectArea();
            }

        }

        private void addImageOverImageBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();

            if (rectW != 0 && rectH != 0)
            {
                var openFile = new OpenFileDialog();

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    var fileImage = new Bitmap(openFile.FileName);

                    Bitmap transform = new Bitmap(transformedImageBox.Image);

                    Bitmap mergedImage = new Bitmap(transformedImageBox.Image);

                    using (Graphics g = Graphics.FromImage(mergedImage))
                    {
                        g.DrawImage(transform, new Point(0, 0));

                        g.DrawImage(fileImage, new Rectangle(crpX, crpY, rectW, rectH));
                    }
                    transformedImageBox.Image = mergedImage;

                    //Reset Graphics
                    imageBox.Refresh();
                    selectAreaBtn.BackColor = SystemColors.Control;
                    isSelectMode = false;
                    crpX = 0;
                    crpY = 0;
                    rectW = 0;
                    rectH = 0;

                }
            }
            else
            {
                Logger.WarnToSelectArea();
            }
        }


        #endregion

        #region ChromaKey

        private Color? pixelColor = null;
        private int tolerance;
        private bool inChromaKeyMode = false;

        private void imageBox_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;

                pixelColor = null;

                pixelColor = ((Bitmap)imageBox.Image).GetPixel(x, y);
                eyeDropperBtn.BackColor = pixelColor.Value;
                imageBox.MouseMove -= new MouseEventHandler(imageBox_MouseMove2);
            }
        }

        private void imageBox_MouseMove2(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int x = e.X;
            int y = e.Y;

            Bitmap bitmap = imageBox.Image as Bitmap;
            if (bitmap != null && x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
            {
                pixelColor = bitmap.GetPixel(x, y);
                eyeDropperBtn.BackColor = pixelColor.Value;
            }
            else
            {
                pixelColor = null;
            }
        }

        private void toleranceCK_ValueChanged(object sender, EventArgs e)
        {
            tolerance = (int)this.toleranceCK.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void eyeDropperBtn_Click(object sender, EventArgs e)
        {
            if (this.imageBox.Image != null)
            {
                if (!inChromaKeyMode)
                {
                    imageBox.Refresh();
                    inChromaKeyMode = true;
                    imageBox.MouseMove += new MouseEventHandler(imageBox_MouseMove2);
                    imageBox.MouseClick += new MouseEventHandler(imageBox_MouseClick);
                }
                else Logger.AlreadyInChromaKey();
            }
            else Logger.WarnToLoadImage();
        }

        private void chromaKeyBtn_Click(object sender, EventArgs e)
        {
            saveLastImageStatus();
            if (this.imageBox.Image != null)
            {
                if (inChromaKeyMode)
                {
                    imageBox.MouseMove -= new MouseEventHandler(imageBox_MouseMove2);
                    imageBox.MouseClick -= new MouseEventHandler(imageBox_MouseClick);

                    Bitmap originalImage = new Bitmap(imageBox.Image);
                    var newImage = EnableChromaKey(originalImage, pixelColor.Value, tolerance);
                    transformedImageBox.Image = newImage;
                    inChromaKeyMode = false;
                    eyeDropperBtn.BackColor = Color.Transparent;
                }
                else Logger.NoChromaKeySelected();

            }
            else Logger.WarnToLoadImage();
        }

        private Bitmap EnableChromaKey(Bitmap bitmap, Color color, int tolerance)
        {
            Bitmap transparentImage = new Bitmap(bitmap);

            for (int i = transparentImage.Size.Width - 1; i >= 0; i--)
            {
                for (int j = transparentImage.Size.Height - 1; j >= 0; j--)
                {
                    var currentColor = transparentImage.GetPixel(i, j);
                    if (Math.Abs(color.R - currentColor.R) < tolerance &&
                      Math.Abs(color.G - currentColor.G) < tolerance &&
                      Math.Abs(color.B - currentColor.B) < tolerance)
                        transparentImage.SetPixel(i, j, color);
                }
            }

            transparentImage.MakeTransparent(color);
            return transparentImage;
        }
        #endregion
    }
}
