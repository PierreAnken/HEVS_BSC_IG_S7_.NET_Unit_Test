using FiltersEdgeDetection.Classes;

namespace FiltersEdgeDetection.PrensentationLayer
{
    partial class ApiForm
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
            if(parentForm != null)
                Toolbox.SetFormControlsEnabled(parentForm, true);

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
            this.labelApiUrlPost = new System.Windows.Forms.Label();
            this.labelApiUrlGet = new System.Windows.Forms.Label();
            this.textBoxApiGetUrl = new System.Windows.Forms.TextBox();
            this.textBoxApiPostUrl = new System.Windows.Forms.TextBox();
            this.buttonApiBack = new System.Windows.Forms.Button();
            this.buttonApiGetPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelApiUrlPost
            // 
            this.labelApiUrlPost.Location = new System.Drawing.Point(12, 37);
            this.labelApiUrlPost.Name = "labelApiUrlPost";
            this.labelApiUrlPost.Size = new System.Drawing.Size(112, 23);
            this.labelApiUrlPost.TabIndex = 1;
            this.labelApiUrlPost.Text = "API POST URL";
            this.labelApiUrlPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelApiUrlGet
            // 
            this.labelApiUrlGet.Location = new System.Drawing.Point(23, 37);
            this.labelApiUrlGet.Name = "labelApiUrlGet";
            this.labelApiUrlGet.Size = new System.Drawing.Size(101, 17);
            this.labelApiUrlGet.TabIndex = 1;
            this.labelApiUrlGet.Text = "API GET URL";
            this.labelApiUrlGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxApiGetUrl
            // 
            this.textBoxApiGetUrl.Location = new System.Drawing.Point(152, 37);
            this.textBoxApiGetUrl.Name = "textBoxApiGetUrl";
            this.textBoxApiGetUrl.Size = new System.Drawing.Size(262, 22);
            this.textBoxApiGetUrl.TabIndex = 2;
            // 
            // textBoxApiPostUrl
            // 
            this.textBoxApiPostUrl.Location = new System.Drawing.Point(152, 37);
            this.textBoxApiPostUrl.Name = "textBoxApiPostUrl";
            this.textBoxApiPostUrl.Size = new System.Drawing.Size(262, 22);
            this.textBoxApiPostUrl.TabIndex = 2;
            // 
            // buttonApiBack
            // 
            this.buttonApiBack.Location = new System.Drawing.Point(327, 80);
            this.buttonApiBack.Name = "buttonApiBack";
            this.buttonApiBack.Size = new System.Drawing.Size(87, 42);
            this.buttonApiBack.TabIndex = 3;
            this.buttonApiBack.Text = "Back";
            this.buttonApiBack.UseVisualStyleBackColor = true;
            this.buttonApiBack.Click += new System.EventHandler(this.buttonApiBack_Click);
            // 
            // buttonApiGetPost
            // 
            this.buttonApiGetPost.Location = new System.Drawing.Point(152, 80);
            this.buttonApiGetPost.Name = "buttonApiGetPost";
            this.buttonApiGetPost.Size = new System.Drawing.Size(96, 42);
            this.buttonApiGetPost.TabIndex = 4;
            this.buttonApiGetPost.Text = "GET/POST";
            this.buttonApiGetPost.UseVisualStyleBackColor = true;
            this.buttonApiGetPost.Click += new System.EventHandler(this.buttonGetPost_Click);
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 150);
            this.Controls.Add(this.buttonApiGetPost);
            this.Controls.Add(this.buttonApiBack);
            this.Controls.Add(this.textBoxApiPostUrl);
            this.Controls.Add(this.textBoxApiGetUrl);
            this.Controls.Add(this.labelApiUrlGet);
            this.Controls.Add(this.labelApiUrlPost);
            this.Name = "ApiForm";
            this.Text = "Load from API";
            this.Load += new System.EventHandler(this.ApiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelApiUrlPost;
        private System.Windows.Forms.Label labelApiUrlGet;
        private System.Windows.Forms.TextBox textBoxApiGetUrl;
        private System.Windows.Forms.TextBox textBoxApiPostUrl;
        private System.Windows.Forms.Button buttonApiBack;
        private System.Windows.Forms.Button buttonApiGetPost;
    }
}