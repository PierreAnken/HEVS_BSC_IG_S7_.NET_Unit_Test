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
            this.buttonApiGetPost = new System.Windows.Forms.Button();
            this.buttonApiLoadBack = new System.Windows.Forms.Button();
            this.labelApiUrlPost = new System.Windows.Forms.Label();
            this.labelApiUrlGet = new System.Windows.Forms.Label();
            this.textBoxApiGetUrl = new System.Windows.Forms.TextBox();
            this.textBoxApiPostUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonApiGetPost
            // 
            this.buttonApiGetPost.Location = new System.Drawing.Point(110, 134);
            this.buttonApiGetPost.Name = "buttonApiGetPost";
            this.buttonApiGetPost.Size = new System.Drawing.Size(87, 34);
            this.buttonApiGetPost.TabIndex = 0;
            this.buttonApiGetPost.Text = "Get/Post";
            this.buttonApiGetPost.UseVisualStyleBackColor = true;
            this.buttonApiGetPost.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonApiLoadBack
            // 
            this.buttonApiLoadBack.Location = new System.Drawing.Point(264, 134);
            this.buttonApiLoadBack.Name = "buttonApiLoadBack";
            this.buttonApiLoadBack.Size = new System.Drawing.Size(87, 34);
            this.buttonApiLoadBack.TabIndex = 0;
            this.buttonApiLoadBack.Text = "Back";
            this.buttonApiLoadBack.UseVisualStyleBackColor = true;
            this.buttonApiLoadBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelApiUrlPost
            // 
            this.labelApiUrlPost.Location = new System.Drawing.Point(12, 66);
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
            this.textBoxApiPostUrl.Location = new System.Drawing.Point(152, 65);
            this.textBoxApiPostUrl.Name = "textBoxApiPostUrl";
            this.textBoxApiPostUrl.Size = new System.Drawing.Size(262, 22);
            this.textBoxApiPostUrl.TabIndex = 2;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 203);
            this.Controls.Add(this.textBoxApiPostUrl);
            this.Controls.Add(this.textBoxApiGetUrl);
            this.Controls.Add(this.labelApiUrlGet);
            this.Controls.Add(this.labelApiUrlPost);
            this.Controls.Add(this.buttonApiLoadBack);
            this.Controls.Add(this.buttonApiGetPost);
            this.Name = "ApiForm";
            this.Text = "Load from API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApiGetPost;
        private System.Windows.Forms.Button buttonApiLoadBack;
        private System.Windows.Forms.Label labelApiUrlPost;
        private System.Windows.Forms.Label labelApiUrlGet;
        private System.Windows.Forms.TextBox textBoxApiGetUrl;
        private System.Windows.Forms.TextBox textBoxApiPostUrl;
    }
}