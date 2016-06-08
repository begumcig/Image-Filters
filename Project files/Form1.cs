using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class mainWindow : Form
    {
        Bitmap sourceImage = null;
        Bitmap oriImage = null;

        public mainWindow()
        {
            InitializeComponent();
            boxBlurButton.Enabled = false;
            diagEdgeButton1.Enabled = false;
            diagEdgeButton2.Enabled = false;
            gausBlurButton.Enabled = false;
            horEdgeButton.Enabled = false;
            vertEdgeButton.Enabled = false;
            segmentationButton.Enabled = false;
            sharpenButton1.Enabled = false;
            sharpenButton2.Enabled = false;
            grayscaleButton.Enabled = false;
            saveButton.Enabled = false;
            revertButton.Enabled = false;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.TIFF;*.PNG)|*.BMP;*.JPG;*.GIF;*.TIFF;*.PNG|"
                                   + "All files (*.*)|*.*";

            if (result == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;

                try
                {
                    sourceImage = new Bitmap(filepath);
                    oriImage = new Bitmap(filepath);

                    //  To fit a larger image on the picture box //
                    if (sourceImage.Width > pictureBox1.Width || sourceImage.Height > pictureBox1.Height)
                    {
                        this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    else
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    }

                    pictureBox1.Image = sourceImage;
                    sourceImage = new Bitmap(sourceImage);
                    oriImage = new Bitmap(oriImage);


                    boxBlurButton.Enabled = true;
                    diagEdgeButton1.Enabled = true;
                    diagEdgeButton2.Enabled = true;
                    gausBlurButton.Enabled = true;
                    horEdgeButton.Enabled = true;
                    vertEdgeButton.Enabled = true;
                    segmentationButton.Enabled = true;
                    sharpenButton1.Enabled = true;
                    sharpenButton2.Enabled = true;
                    grayscaleButton.Enabled = true;
                    saveButton.Enabled = true;
                    revertButton.Enabled = true;
                }

                //if the loaded file was not an image file, it will fail. This catch prevents the program from crashing.
                catch
                {
                    MessageBox.Show("Please load an image file (JPG, PNG, TIFF, BMP or GIF)");
                }

            }

            else
                return;

        }

        private void boxBlurButton_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.boxBlur(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void sharpenButton1_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.sharpen1(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void sharpenButton2_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.sharpen2(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void vertEdgeButton_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.vertEdges(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void gausBlurButton_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.gaussianBlur(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void horEdgeButton_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.horEdges(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void diagEdgeButton1_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.diagEdges1(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void diagEdgeButton2_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.diagEdges2(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void segmentationButton_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.segmentation(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void grayscaleButton_Click(object sender, EventArgs e)
        {
            sourceImage = Filters.Greyscale(sourceImage);
            pictureBox1.Image = sourceImage;
            pictureBox1.Refresh();
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = oriImage;
            sourceImage = new Bitmap(oriImage);
            pictureBox1.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                sourceImage.Save(dialog.FileName, ImageFormat.Jpeg);
                
            }*/

            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                          sourceImage.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        sourceImage.Save(fs,System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        sourceImage.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }



    }
}
