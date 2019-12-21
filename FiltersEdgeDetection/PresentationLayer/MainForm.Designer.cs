using System.Drawing;

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
            this.buttonLoadDisk = new System.Windows.Forms.Button();
            this.buttonSaveDisk = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.buttonLoadImgur = new System.Windows.Forms.Button();
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
            "",
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
            "",
            "Kirsch",
            "Laplacian 3x3",
            "Prewitt"});
            this.comboBoxEdge.Location = new System.Drawing.Point(430, 531);
            this.comboBoxEdge.Name = "comboBoxEdge";
            this.comboBoxEdge.Size = new System.Drawing.Size(157, 24);
            this.comboBoxEdge.TabIndex = 3;
            this.comboBoxEdge.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdge_SelectedIndexChanged);
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
            // buttonLoadDisk
            // 
            this.buttonLoadDisk.Location = new System.Drawing.Point(227, 625);
            this.buttonLoadDisk.Name = "buttonLoadDisk";
            this.buttonLoadDisk.Size = new System.Drawing.Size(123, 35);
            this.buttonLoadDisk.TabIndex = 6;
            this.buttonLoadDisk.Text = "Load from disk";
            this.buttonLoadDisk.UseVisualStyleBackColor = true;
            this.buttonLoadDisk.Click += new System.EventHandler(this.buttonLoadDisk_Click);
            // 
            // buttonSaveDisk
            // 
            this.buttonSaveDisk.Location = new System.Drawing.Point(477, 625);
            this.buttonSaveDisk.Name = "buttonSaveDisk";
            this.buttonSaveDisk.Size = new System.Drawing.Size(110, 35);
            this.buttonSaveDisk.TabIndex = 6;
            this.buttonSaveDisk.Text = "Save to disk";
            this.buttonSaveDisk.UseVisualStyleBackColor = true;
            this.buttonSaveDisk.Click += new System.EventHandler(this.buttonSaveDisk_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(81, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(506, 50);
            this.title.TabIndex = 1;
            this.title.Text = "Image manipulation V1.0";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // buttonLoadImgur
            // 
            this.buttonLoadImgur.Location = new System.Drawing.Point(86, 625);
            this.buttonLoadImgur.Name = "buttonLoadImgur";
            this.buttonLoadImgur.Size = new System.Drawing.Size(123, 35);
            this.buttonLoadImgur.TabIndex = 6;
            this.buttonLoadImgur.Text = "Load from imgur";
            this.buttonLoadImgur.UseVisualStyleBackColor = true;
            this.buttonLoadImgur.Click += new System.EventHandler(this.buttonLoadImgur_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(668, 691);
            this.Controls.Add(this.buttonSaveDisk);
            this.Controls.Add(this.buttonLoadImgur);
            this.Controls.Add(this.buttonLoadDisk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.comboBoxEdge);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.title);
            this.Controls.Add(this.imgPreview);
            this.MaximumSize = new System.Drawing.Size(686, 738);
            this.MinimumSize = new System.Drawing.Size(686, 738);
            this.Name = "MainForm";
            this.Text = "Image manipulation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.ComboBox comboBoxEdge;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadDisk;
        private System.Windows.Forms.Button buttonSaveDisk;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonLoadImgur;
    }
}