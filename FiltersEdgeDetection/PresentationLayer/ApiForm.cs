using BLL;
using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PL
{
    public partial class ApiForm : Form
    {
        public MainForm parentForm;
        private static readonly BLLOriginalBitmapManager bLLBitmapManager = new BLLOriginalBitmapManager();
        public ApiForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public void SetErrorLabel(string error)
        {
            labelApiError.Text = error;
        }

        private void ApiForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonApiBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            Toolbox.SetFormControlsEnabled(parentForm, false);
            string hash = textBoxApiGetHash.Text;
            ImgurBitmapManager apiImgurImage = new ImgurBitmapManager(hash, this);
            Bitmap bitmap = apiImgurImage.GetBitmap();

            if (bitmap != null)
            {
                bLLBitmapManager.SetBitmap(bitmap);
                parentForm.ResetFilters();
                Hide();
            }
            Toolbox.SetFormControlsEnabled(parentForm, true);
        }
    }
}
