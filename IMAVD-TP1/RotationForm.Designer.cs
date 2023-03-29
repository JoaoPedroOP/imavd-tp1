namespace IMAVD_TP1
{
    partial class RotationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rotationBar = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // rotationBar
            // 
            this.rotationBar.Location = new System.Drawing.Point(42, 132);
            this.rotationBar.Maximum = 360;
            this.rotationBar.Name = "rotationBar";
            this.rotationBar.Size = new System.Drawing.Size(487, 69);
            this.rotationBar.SmallChange = 45;
            this.rotationBar.TabIndex = 25;
            this.rotationBar.Scroll += new System.EventHandler(this.rotationBar_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(207, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 46);
            this.label14.TabIndex = 26;
            this.label14.Text = "Rotate";
            // 
            // RotationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.rotationBar);
            this.Controls.Add(this.label14);
            this.Name = "RotationForm";
            this.Text = "RotationForm";
            ((System.ComponentModel.ISupportInitialize)(this.rotationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar rotationBar;
        private System.Windows.Forms.Label label14;
    }
}