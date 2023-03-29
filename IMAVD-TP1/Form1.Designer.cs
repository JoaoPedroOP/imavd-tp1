namespace IMAVD_TP1
{
    partial class UI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgLoadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelExtension = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchColorBtn = new System.Windows.Forms.Button();
            this.colorSearchDialog = new System.Windows.Forms.ColorDialog();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.opcaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.ZoomLabel = new System.Windows.Forms.Label();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.brightBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.chromaKeyOpt = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.imgHorResCounter = new System.Windows.Forms.NumericUpDown();
            this.imgVertResCounter = new System.Windows.Forms.NumericUpDown();
            this.transformedImageBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nrPixelsWithColorLabel = new System.Windows.Forms.Label();
            this.colorExistsLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveGBox = new System.Windows.Forms.GroupBox();
            this.saveImgBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHorResCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVertResCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformedImageBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.saveGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLoadBtn
            // 
            this.imgLoadBtn.Location = new System.Drawing.Point(11, 26);
            this.imgLoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgLoadBtn.Name = "imgLoadBtn";
            this.imgLoadBtn.Size = new System.Drawing.Size(162, 56);
            this.imgLoadBtn.TabIndex = 0;
            this.imgLoadBtn.Text = "Load...";
            this.imgLoadBtn.UseVisualStyleBackColor = true;
            this.imgLoadBtn.Click += new System.EventHandler(this.imgLoadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extension:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.labelSize);
            this.groupBox1.Controls.Add(this.labelDimensions);
            this.groupBox1.Controls.Add(this.labelLocation);
            this.groupBox1.Controls.Add(this.labelExtension);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1084, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(429, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Properties";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(132, 248);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(77, 20);
            this.labelDate.TabIndex = 12;
            this.labelDate.Text = "labelDate";
            this.labelDate.Visible = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(86, 204);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(73, 20);
            this.labelSize.TabIndex = 11;
            this.labelSize.Text = "labelSize";
            this.labelSize.Visible = false;
            // 
            // labelDimensions
            // 
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimensions.Location = new System.Drawing.Point(110, 168);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(125, 20);
            this.labelDimensions.TabIndex = 10;
            this.labelDimensions.Text = "labelDimensions";
            this.labelDimensions.Visible = false;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(84, 128);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(103, 20);
            this.labelLocation.TabIndex = 9;
            this.labelLocation.Text = "labelLocation";
            this.labelLocation.Visible = false;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtension.Location = new System.Drawing.Point(93, 84);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(112, 20);
            this.labelExtension.TabIndex = 8;
            this.labelExtension.Text = "labelExtension";
            this.labelExtension.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(62, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "labelForName";
            this.labelName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Creation Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Size(Kb):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dimensions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location:";
            // 
            // searchColorBtn
            // 
            this.searchColorBtn.Location = new System.Drawing.Point(1101, 736);
            this.searchColorBtn.Name = "searchColorBtn";
            this.searchColorBtn.Size = new System.Drawing.Size(152, 46);
            this.searchColorBtn.TabIndex = 4;
            this.searchColorBtn.Text = "Search Color";
            this.searchColorBtn.UseVisualStyleBackColor = true;
            this.searchColorBtn.Click += new System.EventHandler(this.searchColorBtn_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox.Location = new System.Drawing.Point(12, 71);
            this.imageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(971, 369);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1548, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcaiToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1548, 33);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // opcaiToolStripMenuItem
            // 
            this.opcaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crioToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.invertColorToolStripMenuItem});
            this.opcaiToolStripMenuItem.Name = "opcaiToolStripMenuItem";
            this.opcaiToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.opcaiToolStripMenuItem.Text = "Options";
            // 
            // crioToolStripMenuItem
            // 
            this.crioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.crioToolStripMenuItem.Name = "crioToolStripMenuItem";
            this.crioToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.crioToolStripMenuItem.Text = "Crop";
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(161, 34);
            this.applyToolStripMenuItem.Text = "Apply";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEDToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.customizeToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // rEDToolStripMenuItem
            // 
            this.rEDToolStripMenuItem.Name = "rEDToolStripMenuItem";
            this.rEDToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.rEDToolStripMenuItem.Text = "Red";
            this.rEDToolStripMenuItem.Click += new System.EventHandler(this.rEDToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(197, 34);
            this.customizeToolStripMenuItem.Text = "Customize";
            // 
            // invertColorToolStripMenuItem
            // 
            this.invertColorToolStripMenuItem.Name = "invertColorToolStripMenuItem";
            this.invertColorToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.invertColorToolStripMenuItem.Text = "Invert Color";
            this.invertColorToolStripMenuItem.Click += new System.EventHandler(this.invertColorToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // zoomBar
            // 
            this.zoomBar.Location = new System.Drawing.Point(21, 936);
            this.zoomBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(233, 69);
            this.zoomBar.TabIndex = 9;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = true;
            this.ZoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomLabel.Location = new System.Drawing.Point(68, 884);
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(123, 46);
            this.ZoomLabel.TabIndex = 10;
            this.ZoomLabel.Text = "Zoom";
            // 
            // contrastBar
            // 
            this.contrastBar.Location = new System.Drawing.Point(310, 936);
            this.contrastBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contrastBar.Maximum = 100;
            this.contrastBar.Minimum = -100;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(233, 69);
            this.contrastBar.TabIndex = 12;
            this.contrastBar.Scroll += new System.EventHandler(this.contrastBar_Scroll);
            // 
            // brightBar
            // 
            this.brightBar.LargeChange = 100;
            this.brightBar.Location = new System.Drawing.Point(594, 936);
            this.brightBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brightBar.Maximum = 100;
            this.brightBar.Minimum = -100;
            this.brightBar.Name = "brightBar";
            this.brightBar.Size = new System.Drawing.Size(233, 69);
            this.brightBar.SmallChange = 5;
            this.brightBar.TabIndex = 13;
            this.brightBar.TickFrequency = 10;
            this.brightBar.Scroll += new System.EventHandler(this.brightBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 884);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 46);
            this.label7.TabIndex = 11;
            this.label7.Text = "Contrast";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(597, 885);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 46);
            this.label8.TabIndex = 14;
            this.label8.Text = "Brightness";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1296, 730);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 58);
            this.button3.TabIndex = 15;
            this.button3.Text = "Resize";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chromaKeyOpt
            // 
<<<<<<< HEAD
            this.chromaKeyOpt.AutoSize = true;
            this.chromaKeyOpt.Location = new System.Drawing.Point(35, 72);
            this.chromaKeyOpt.Name = "chromaKeyOpt";
            this.chromaKeyOpt.Size = new System.Drawing.Size(99, 20);
            this.chromaKeyOpt.TabIndex = 16;
            this.chromaKeyOpt.Text = "chroma key";
            this.chromaKeyOpt.UseVisualStyleBackColor = true;
=======
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(39, 90);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "chroma key";
            this.checkBox1.UseVisualStyleBackColor = true;
>>>>>>> b157e9e569f3885d2801e8e88e3aa0d49ab7ef9d
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chromaKeyOpt);
            this.groupBox2.Controls.Add(this.imgLoadBtn);
            this.groupBox2.Location = new System.Drawing.Point(1084, 369);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(188, 126);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load Image";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.imgHorResCounter);
            this.groupBox5.Controls.Add(this.imgVertResCounter);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1072, 815);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(390, 191);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "Vertical";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(124, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Resolution";
            this.label10.UseMnemonic = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 32);
            this.label12.TabIndex = 19;
            this.label12.Text = "Horizontal";
            // 
            // imgHorResCounter
            // 
            this.imgHorResCounter.Location = new System.Drawing.Point(222, 86);
            this.imgHorResCounter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgHorResCounter.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.imgHorResCounter.Name = "imgHorResCounter";
            this.imgHorResCounter.Size = new System.Drawing.Size(145, 39);
            this.imgHorResCounter.TabIndex = 17;
            this.imgHorResCounter.ValueChanged += new System.EventHandler(this.imgHorResCounter_ValueChanged);
            // 
            // imgVertResCounter
            // 
            this.imgVertResCounter.Location = new System.Drawing.Point(222, 136);
            this.imgVertResCounter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgVertResCounter.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.imgVertResCounter.Name = "imgVertResCounter";
            this.imgVertResCounter.Size = new System.Drawing.Size(145, 39);
            this.imgVertResCounter.TabIndex = 18;
            this.imgVertResCounter.ValueChanged += new System.EventHandler(this.imgVertResCounter_ValueChanged);
            // 
            // transformedImageBox
            // 
            this.transformedImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transformedImageBox.Location = new System.Drawing.Point(12, 469);
            this.transformedImageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transformedImageBox.Name = "transformedImageBox";
            this.transformedImageBox.Size = new System.Drawing.Size(971, 369);
            this.transformedImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.transformedImageBox.TabIndex = 19;
            this.transformedImageBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nrPixelsWithColorLabel);
            this.groupBox3.Controls.Add(this.colorExistsLabel);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(1088, 530);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(425, 174);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Search";
            // 
            // nrPixelsWithColorLabel
            // 
            this.nrPixelsWithColorLabel.AutoSize = true;
            this.nrPixelsWithColorLabel.Location = new System.Drawing.Point(276, 126);
            this.nrPixelsWithColorLabel.Name = "nrPixelsWithColorLabel";
            this.nrPixelsWithColorLabel.Size = new System.Drawing.Size(132, 20);
            this.nrPixelsWithColorLabel.TabIndex = 3;
            this.nrPixelsWithColorLabel.Text = "nrPixelsWithColor";
            this.nrPixelsWithColorLabel.Visible = false;
            // 
            // colorExistsLabel
            // 
            this.colorExistsLabel.AutoSize = true;
            this.colorExistsLabel.Location = new System.Drawing.Point(276, 52);
            this.colorExistsLabel.Name = "colorExistsLabel";
            this.colorExistsLabel.Size = new System.Drawing.Size(85, 20);
            this.colorExistsLabel.TabIndex = 2;
            this.colorExistsLabel.Text = "colorExists";
            this.colorExistsLabel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pixels with Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Color exists?";
            // 
            // saveGBox
            // 
            this.saveGBox.Controls.Add(this.saveImgBtn);
            this.saveGBox.Location = new System.Drawing.Point(1296, 375);
            this.saveGBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveGBox.Name = "saveGBox";
            this.saveGBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveGBox.Size = new System.Drawing.Size(217, 109);
            this.saveGBox.TabIndex = 23;
            this.saveGBox.TabStop = false;
            this.saveGBox.Text = "Save Image";
            // 
            // saveImgBtn
            // 
            this.saveImgBtn.Location = new System.Drawing.Point(32, 26);
            this.saveImgBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveImgBtn.Name = "saveImgBtn";
            this.saveImgBtn.Size = new System.Drawing.Size(162, 56);
            this.saveImgBtn.TabIndex = 17;
            this.saveImgBtn.Text = "Save Image";
            this.saveImgBtn.UseVisualStyleBackColor = true;
            this.saveImgBtn.Click += new System.EventHandler(this.saveImgBtn_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 1055);
            this.Controls.Add(this.saveGBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.transformedImageBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.brightBar);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ZoomLabel);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.searchColorBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UI";
            this.Text = "Image Editor";
            this.Load += new System.EventHandler(this.UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHorResCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVertResCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transformedImageBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.saveGBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imgLoadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchColorBtn;
        private System.Windows.Forms.ColorDialog colorSearchDialog;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem opcaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crioToolStripMenuItem;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Label ZoomLabel;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.TrackBar brightBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chromaKeyOpt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown imgHorResCounter;
        private System.Windows.Forms.NumericUpDown imgVertResCounter;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelDimensions;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.PictureBox transformedImageBox;
        private System.Windows.Forms.ToolStripMenuItem invertColorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label nrPixelsWithColorLabel;
        private System.Windows.Forms.Label colorExistsLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox saveGBox;
        private System.Windows.Forms.Button saveImgBtn;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    }
}

