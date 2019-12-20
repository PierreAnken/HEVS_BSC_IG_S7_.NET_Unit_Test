using FiltersEdgeDetection.classes;
using FiltersEdgeDetection.Classes;
using ImageEdgeDetection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiltersEdgeDetection.PrensentationLayer
{
    public partial class ApiForm : Form
    {
        public bool isGet;
        public MainForm parentForm;
        public ApiForm(bool buttonGet, MainForm parentForm)
        {
            this.isGet = buttonGet;
            InitializeComponent();
            this.parentForm = parentForm;
            Toolbox.SetFormControlsEnabled(parentForm, false);

            if (isGet)
            {
                textBoxApiGetHash.Visible = labelApiUrlGet.Visible = true;
                textBoxApiPostUrl.Visible = labelApiUrlPost.Visible = false;
                buttonApiGetPost.Text = "GET Image";
            }
            else
            {
                labelApiUrlPost.Visible = true;
                textBoxApiGetHash.Visible = labelApiUrlGet.Visible = false;
                textBoxApiPostUrl.Visible = labelApiUrlPost.Visible = true;
                buttonApiGetPost.Text = "POST Image";
            }
        }


        private void ApiForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonApiBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonGetPost_Click(object sender, EventArgs e) {

            string hash = textBoxApiGetHash.Text;
            ApiImgurImage apiImgurImage = new ApiImgurImage(hash);
            if (isGet)
            {
                Bitmap image = apiImgurImage.LoadImage();
                if (image != null) {

                    Bitmap imagePreview = ExtBitmap.AdaptToSquareCanvas(image, parentForm.getImagePreview().Width);
                    parentForm.getImagePreview().Image = imagePreview;
                }
            }
        }
    }
}
