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
    public partial class MainForm : Form
    {
        
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

        }
    }
}
