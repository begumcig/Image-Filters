namespace WindowsFormsApplication1
{
    partial class mainWindow
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
            this.exitButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boxBlurButton = new System.Windows.Forms.Button();
            this.sharpenButton1 = new System.Windows.Forms.Button();
            this.sharpenButton2 = new System.Windows.Forms.Button();
            this.vertEdgeButton = new System.Windows.Forms.Button();
            this.horEdgeButton = new System.Windows.Forms.Button();
            this.diagEdgeButton1 = new System.Windows.Forms.Button();
            this.gausBlurButton = new System.Windows.Forms.Button();
            this.diagEdgeButton2 = new System.Windows.Forms.Button();
            this.segmentationButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.grayscaleButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SeaShell;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Eras Light ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(897, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(28, 26);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.SeaShell;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(771, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 35);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Image";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 540);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // boxBlurButton
            // 
            this.boxBlurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxBlurButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxBlurButton.Location = new System.Drawing.Point(771, 49);
            this.boxBlurButton.Name = "boxBlurButton";
            this.boxBlurButton.Size = new System.Drawing.Size(106, 47);
            this.boxBlurButton.TabIndex = 3;
            this.boxBlurButton.Text = "Mean Filter\r\n(Box Blur)";
            this.boxBlurButton.UseVisualStyleBackColor = true;
            this.boxBlurButton.Click += new System.EventHandler(this.boxBlurButton_Click);
            // 
            // sharpenButton1
            // 
            this.sharpenButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sharpenButton1.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharpenButton1.Location = new System.Drawing.Point(771, 138);
            this.sharpenButton1.Name = "sharpenButton1";
            this.sharpenButton1.Size = new System.Drawing.Size(106, 32);
            this.sharpenButton1.TabIndex = 4;
            this.sharpenButton1.Text = "Sharpen1";
            this.sharpenButton1.UseVisualStyleBackColor = true;
            this.sharpenButton1.Click += new System.EventHandler(this.sharpenButton1_Click);
            // 
            // sharpenButton2
            // 
            this.sharpenButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sharpenButton2.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharpenButton2.Location = new System.Drawing.Point(772, 172);
            this.sharpenButton2.Name = "sharpenButton2";
            this.sharpenButton2.Size = new System.Drawing.Size(106, 32);
            this.sharpenButton2.TabIndex = 5;
            this.sharpenButton2.Text = "Sharpen 2";
            this.sharpenButton2.UseVisualStyleBackColor = true;
            this.sharpenButton2.Click += new System.EventHandler(this.sharpenButton2_Click);
            // 
            // vertEdgeButton
            // 
            this.vertEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vertEdgeButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vertEdgeButton.Location = new System.Drawing.Point(771, 206);
            this.vertEdgeButton.Name = "vertEdgeButton";
            this.vertEdgeButton.Size = new System.Drawing.Size(106, 46);
            this.vertEdgeButton.TabIndex = 6;
            this.vertEdgeButton.Text = "Vertical Edges";
            this.vertEdgeButton.UseVisualStyleBackColor = true;
            this.vertEdgeButton.Click += new System.EventHandler(this.vertEdgeButton_Click);
            // 
            // horEdgeButton
            // 
            this.horEdgeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horEdgeButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horEdgeButton.Location = new System.Drawing.Point(771, 254);
            this.horEdgeButton.Name = "horEdgeButton";
            this.horEdgeButton.Size = new System.Drawing.Size(106, 46);
            this.horEdgeButton.TabIndex = 7;
            this.horEdgeButton.Text = "Horizontal Edges";
            this.horEdgeButton.UseVisualStyleBackColor = true;
            this.horEdgeButton.Click += new System.EventHandler(this.horEdgeButton_Click);
            // 
            // diagEdgeButton1
            // 
            this.diagEdgeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diagEdgeButton1.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagEdgeButton1.Location = new System.Drawing.Point(771, 302);
            this.diagEdgeButton1.Name = "diagEdgeButton1";
            this.diagEdgeButton1.Size = new System.Drawing.Size(106, 48);
            this.diagEdgeButton1.TabIndex = 8;
            this.diagEdgeButton1.Text = "Diagonal Edges 1";
            this.diagEdgeButton1.UseVisualStyleBackColor = true;
            this.diagEdgeButton1.Click += new System.EventHandler(this.diagEdgeButton1_Click);
            // 
            // gausBlurButton
            // 
            this.gausBlurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gausBlurButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gausBlurButton.Location = new System.Drawing.Point(771, 98);
            this.gausBlurButton.Name = "gausBlurButton";
            this.gausBlurButton.Size = new System.Drawing.Size(107, 38);
            this.gausBlurButton.TabIndex = 9;
            this.gausBlurButton.Text = "Gaussian Blur";
            this.gausBlurButton.UseVisualStyleBackColor = true;
            this.gausBlurButton.Click += new System.EventHandler(this.gausBlurButton_Click);
            // 
            // diagEdgeButton2
            // 
            this.diagEdgeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diagEdgeButton2.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagEdgeButton2.Location = new System.Drawing.Point(771, 352);
            this.diagEdgeButton2.Name = "diagEdgeButton2";
            this.diagEdgeButton2.Size = new System.Drawing.Size(107, 50);
            this.diagEdgeButton2.TabIndex = 11;
            this.diagEdgeButton2.Text = "Diagonal Edges 2";
            this.diagEdgeButton2.UseVisualStyleBackColor = true;
            this.diagEdgeButton2.Click += new System.EventHandler(this.diagEdgeButton2_Click);
            // 
            // segmentationButton
            // 
            this.segmentationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.segmentationButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segmentationButton.Location = new System.Drawing.Point(771, 404);
            this.segmentationButton.Name = "segmentationButton";
            this.segmentationButton.Size = new System.Drawing.Size(107, 36);
            this.segmentationButton.TabIndex = 12;
            this.segmentationButton.Text = "Segmentation";
            this.segmentationButton.UseVisualStyleBackColor = true;
            this.segmentationButton.Click += new System.EventHandler(this.segmentationButton_Click);
            // 
            // revertButton
            // 
            this.revertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revertButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revertButton.Location = new System.Drawing.Point(772, 479);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(107, 47);
            this.revertButton.TabIndex = 13;
            this.revertButton.Text = "Revert Changes";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // grayscaleButton
            // 
            this.grayscaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayscaleButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayscaleButton.Location = new System.Drawing.Point(771, 441);
            this.grayscaleButton.Name = "grayscaleButton";
            this.grayscaleButton.Size = new System.Drawing.Size(107, 36);
            this.grayscaleButton.TabIndex = 14;
            this.grayscaleButton.Text = "Grayscale";
            this.grayscaleButton.UseVisualStyleBackColor = true;
            this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Eras Light ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(771, 527);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 30);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(931, 559);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.grayscaleButton);
            this.Controls.Add(this.revertButton);
            this.Controls.Add(this.segmentationButton);
            this.Controls.Add(this.diagEdgeButton2);
            this.Controls.Add(this.gausBlurButton);
            this.Controls.Add(this.diagEdgeButton1);
            this.Controls.Add(this.horEdgeButton);
            this.Controls.Add(this.vertEdgeButton);
            this.Controls.Add(this.sharpenButton2);
            this.Controls.Add(this.sharpenButton1);
            this.Controls.Add(this.boxBlurButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.Text = " ";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boxBlurButton;
        private System.Windows.Forms.Button sharpenButton1;
        private System.Windows.Forms.Button sharpenButton2;
        private System.Windows.Forms.Button vertEdgeButton;
        private System.Windows.Forms.Button horEdgeButton;
        private System.Windows.Forms.Button diagEdgeButton1;
        private System.Windows.Forms.Button gausBlurButton;
        private System.Windows.Forms.Button diagEdgeButton2;
        private System.Windows.Forms.Button segmentationButton;
        private System.Windows.Forms.Button revertButton;
        private System.Windows.Forms.Button grayscaleButton;
        private System.Windows.Forms.Button saveButton;
    }
}

