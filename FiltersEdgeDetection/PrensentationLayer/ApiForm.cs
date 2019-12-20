using FiltersEdgeDetection.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltersEdgeDetection.PrensentationLayer
{
    public partial class ApiForm : Form
    {

        public Form parentForm;
        public ApiForm(bool buttonGet, Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Toolbox.SetFormControlsEnabled(parentForm, false);

            if (buttonGet)
            {
                textBoxApiGetUrl.Visible = labelApiUrlGet.Visible = true;
                textBoxApiPostUrl.Visible = labelApiUrlPost.Visible = false;
                buttonApiGetPost.Text = "GET Image";
            }
            else
            {
                labelApiUrlPost.Visible = true;
                textBoxApiGetUrl.Visible = labelApiUrlGet.Visible = false;
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

        private void buttonGetPost_Click(object sender, EventArgs e)
        {

        }
    }
}
