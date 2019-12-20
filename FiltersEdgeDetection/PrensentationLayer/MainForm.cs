using FiltersEdgeDetection.classes;
using FiltersEdgeDetection.Interfaces;
using ImageEdgeDetection;
using PictureBox.Image.Testes;
using System;
using System.Drawing;
using System.Windows.Forms;
using FiltersEdgeDetection.Classes;

namespace FiltersEdgeDetection.PrensentationLayer
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap;
        private Bitmap previewBitmap;

        private void ApplyFilter()
        {
            if (originalBitmap == null)
            {
                return;
            }

            Toolbox.SetFormControlsEnabled(this, false);
            Bitmap resultBitmap = new Bitmap(originalBitmap);

            // First apply filter
            if (comboBoxFilters.SelectedItem != null)
            {
                string selectedFilter = comboBoxFilters.SelectedItem.ToString();
                switch (selectedFilter)
                {
                    case "Black and White":
                        resultBitmap = ImageFilters.ApplyBlackWhite(resultBitmap);
                        break;
                    case "Crazy Filter":
                        resultBitmap = ImageFilters.ApplyFilterCrazy(resultBitmap);
                        break;
                    case "Magic Mosaic":
                        resultBitmap = ImageFilters.ApplyFilterMagicMosaic(resultBitmap);
                        break;
                    default:
                        break;
                }
            }
            // Then apply Edge detection
            if (comboBoxEdge.SelectedItem != null)
            {
                string selectedEdgeDetection = comboBoxEdge.SelectedItem.ToString();
                switch (selectedEdgeDetection)
                {
                    case "Laplacian 3x3":
                        resultBitmap = ExtBitmap.LaplacianFilter(resultBitmap, Matrix.Laplacian3x3);
                        break;
                    case "Prewitt":
                        resultBitmap = ExtBitmap.DoubleMatrixFilter(resultBitmap, Matrix.Prewitt3x3Horizontal, Matrix.Prewitt3x3Vertical);
                        break;
                    case "Kirsch":
                        resultBitmap = ExtBitmap.DoubleMatrixFilter(resultBitmap, Matrix.Kirsch3x3Horizontal, Matrix.Kirsch3x3Vertical);
                        break;
                    default:
                        break;
                }
            }

            //finaly generate preview
            imgPreview.Image = resultBitmap.AdaptToSquareCanvas(imgPreview.Width);

            Toolbox.SetFormControlsEnabled(this, true);
        }

        public bool IsApiMode
        {
            get{
                return radioButtonAPI.Checked;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (IsApiMode)
            {
                ApiForm apiForm = new ApiForm(true, this);
                apiForm.Show();
            }
            else {
                IImageManager imageManager = new LocalImage();

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select an image file.";
                ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalBitmap = imageManager.LoadImage(ofd.FileName);
                    imgPreview.Image = ExtBitmap.AdaptToSquareCanvas(originalBitmap, imgPreview.Width);
                    ApplyFilter();
                }
            }
        }

        private void buttonSavePost_Click(object sender, EventArgs e)
        {
            if (IsApiMode)
            {
                ApiForm apiForm = new ApiForm(false, this);
                apiForm.Show();
            }
            else
            {
                
            }            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                //api mode
                buttonLoad.Text = "GET";
                buttonSavePost.Text = "POST";
            }
            else
            {
                //local mode
                buttonLoad.Text = "Load";
                buttonSavePost.Text = "Save";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonLocal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void imgPreview_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
