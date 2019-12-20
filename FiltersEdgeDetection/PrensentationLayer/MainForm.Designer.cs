namespace FiltersEdgeDetection.PrensentationLayer
{
    partial class MainForm
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
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.comboBoxEdge = new System.Windows.Forms.ComboBox();
            this.labelFilters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSavePost = new System.Windows.Forms.Button();
            this.radioButtonAPI = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.labelMode = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPreview
            // 
            this.imgPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPreview.Location = new System.Drawing.Point(86, 108);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(501, 401);
            this.imgPreview.TabIndex = 0;
            this.imgPreview.TabStop = false;
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Items.AddRange(new object[] {
            "Black and White",
            "Crazy Filter",
            "Magic Mosaic"});
            this.comboBoxFilters.Location = new System.Drawing.Point(147, 530);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(139, 24);
            this.comboBoxFilters.TabIndex = 2;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            // 
            // comboBoxEdge
            // 
            this.comboBoxEdge.FormattingEnabled = true;
            this.comboBoxEdge.Items.AddRange(new object[] {
            "Kirsch",
            "Laplacian 3x3",
            "Prewitt"});
            this.comboBoxEdge.Location = new System.Drawing.Point(430, 531);
            this.comboBoxEdge.Name = "comboBoxEdge";
            this.comboBoxEdge.Size = new System.Drawing.Size(157, 24);
            this.comboBoxEdge.TabIndex = 3;
            // 
            // labelFilters
            // 
            this.labelFilters.Location = new System.Drawing.Point(83, 530);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(58, 23);
            this.labelFilters.TabIndex = 4;
            this.labelFilters.Text = "Filters";
            this.labelFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFilters.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(311, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Edge Detection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(176, 620);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(110, 35);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSavePost
            // 
            this.buttonSavePost.Location = new System.Drawing.Point(365, 620);
            this.buttonSavePost.Name = "buttonSavePost";
            this.buttonSavePost.Size = new System.Drawing.Size(110, 35);
            this.buttonSavePost.TabIndex = 6;
            this.buttonSavePost.Text = "Save";
            this.buttonSavePost.UseVisualStyleBackColor = true;
            this.buttonSavePost.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonAPI
            // 
            this.radioButtonAPI.AutoSize = true;
            this.radioButtonAPI.Location = new System.Drawing.Point(580, 35);
            this.radioButtonAPI.Name = "radioButtonAPI";
            this.radioButtonAPI.Size = new System.Drawing.Size(50, 21);
            this.radioButtonAPI.TabIndex = 7;
            this.radioButtonAPI.Text = "API";
            this.radioButtonAPI.UseVisualStyleBackColor = true;
            this.radioButtonAPI.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(580, 62);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(63, 21);
            this.radioButtonLocal.TabIndex = 7;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonLocal_CheckedChanged);
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.Location = new System.Drawing.Point(494, 35);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(80, 43);
            this.labelMode.TabIndex = 8;
            this.labelMode.Text = "Mode";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMode.Click += new System.EventHandler(this.label2_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(81, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(343, 50);
            this.title.TabIndex = 1;
            this.title.Text = "Image manipulation V1.0";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(668, 691);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.radioButtonLocal);
            this.Controls.Add(this.radioButtonAPI);
            this.Controls.Add(this.buttonSavePost);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.comboBoxEdge);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.title);
            this.Controls.Add(this.imgPreview);
            this.Name = "MainForm";
            this.Text = "Image manipulation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.ComboBox comboBoxEdge;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSavePost;
        private System.Windows.Forms.RadioButton radioButtonAPI;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label title;
    }
}