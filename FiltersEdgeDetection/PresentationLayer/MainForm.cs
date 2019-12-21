using BLL;
using DAL;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FiltersEdgeDetection.PrensentationLayer
{

    public partial class MainForm : Form
    {
        private static readonly BLLOriginalBitmapManager bLLOriginalBitmapManager = new BLLOriginalBitmapManager();
        private static readonly BLLResultBitmapManager bLLResultBitmapManager = new BLLResultBitmapManager();
        private MainFormBitmapManager mainFormBitmapManager;
        private static ApiForm apiForm;

        public MainForm()
        {
            InitializeComponent();
            apiForm = new ApiForm(this);
            mainFormBitmapManager = new MainFormBitmapManager(this);
        }

        public void ResetFilters() {
            comboBoxEdge.SelectedItem = "";
            comboBoxFilters.SelectedItem = "";
        }
        public ComboBox GetComboBoxFilters()
        {
            return comboBoxFilters;
        }

        public ComboBox GetComboBoxEdge()
        {
            return comboBoxEdge;
        }

        public ApiForm GetApiForm()
        {
            return apiForm;
        }
        public MainFormBitmapManager GetMainFormBitmapManager()
        {
            return mainFormBitmapManager;
        }

        public System.Windows.Forms.PictureBox GetImagePreview()
        {
            return imgPreview;
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
        private void buttonLoadImgur_Click(object sender, EventArgs e)
        {
            apiForm.Show();
        }
        private void buttonLoadDisk_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Title = "Select an image file.";
                ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Bitmap Images(*.bmp)|*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    IBitmapManager imageManager = new DiskBitmapManager(ofd.FileName);
                    Bitmap imgurBitmap = imageManager.GetBitmap();
                    bLLOriginalBitmapManager.SetBitmap(imgurBitmap);
                    imgPreview.Image = ExtBitmap.AdaptToSquareCanvas(imgurBitmap, imgPreview.Width);
                    ResetFilters();
                }
            }
        }

        private void buttonSaveDisk_Click(object sender, EventArgs e)
        {
            Bitmap resultBitmap = bLLResultBitmapManager.GetBitmap();
            if (resultBitmap != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Title = "Specify a file name and file path";
                    sfd.Filter = "Jpeg Images(*.jpg)|*.jpg";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                        ImageFormat imgFormat = ImageFormat.Jpeg;
                        StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                        resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
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
            App.ApplyFilters();
        }

        private void imgPreview_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.ApplyFilters();
        }
    }
}
