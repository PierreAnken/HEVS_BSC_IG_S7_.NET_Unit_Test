﻿using FiltersEdgeDetection.Classes;

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
            this.labelApiUrlGet = new System.Windows.Forms.Label();
            this.textBoxApiPostUrl = new System.Windows.Forms.TextBox();
            this.buttonApiBack = new System.Windows.Forms.Button();
            this.buttonApiGetPost = new System.Windows.Forms.Button();
            this.textBoxApiGetHash = new System.Windows.Forms.TextBox();
            this.labelApiUrlPost = new System.Windows.Forms.Label();
            this.labelApiError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelApiUrlGet
            // 
            this.labelApiUrlGet.Location = new System.Drawing.Point(12, 32);
            this.labelApiUrlGet.Name = "labelApiUrlGet";
            this.labelApiUrlGet.Size = new System.Drawing.Size(123, 32);
            this.labelApiUrlGet.TabIndex = 1;
            this.labelApiUrlGet.Text = "imgur image hash";
            this.labelApiUrlGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxApiPostUrl
            // 
            this.textBoxApiPostUrl.Location = new System.Drawing.Point(152, 38);
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
            // textBoxApiGetHash
            // 
            this.textBoxApiGetHash.Location = new System.Drawing.Point(152, 37);
            this.textBoxApiGetHash.Name = "textBoxApiGetHash";
            this.textBoxApiGetHash.Size = new System.Drawing.Size(262, 22);
            this.textBoxApiGetHash.TabIndex = 2;
            this.textBoxApiGetHash.Text = "xtoLyW2";
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
            // labelApiError
            // 
            this.labelApiError.ForeColor = System.Drawing.Color.Red;
            this.labelApiError.Location = new System.Drawing.Point(81, 141);
            this.labelApiError.Name = "labelApiError";
            this.labelApiError.Size = new System.Drawing.Size(333, 30);
            this.labelApiError.TabIndex = 5;
            this.labelApiError.Click += new System.EventHandler(this.labelApiError_Click);
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 180);
            this.Controls.Add(this.labelApiError);
            this.Controls.Add(this.buttonApiGetPost);
            this.Controls.Add(this.buttonApiBack);
            this.Controls.Add(this.textBoxApiPostUrl);
            this.Controls.Add(this.textBoxApiGetHash);
            this.Controls.Add(this.labelApiUrlGet);
            this.Controls.Add(this.labelApiUrlPost);
            this.Name = "ApiForm";
            this.Text = "Load from API";
            this.Load += new System.EventHandler(this.ApiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelApiUrlGet;
        private System.Windows.Forms.TextBox textBoxApiPostUrl;
        private System.Windows.Forms.Button buttonApiBack;
        private System.Windows.Forms.Button buttonApiGetPost;
        private System.Windows.Forms.TextBox textBoxApiGetHash;
        private System.Windows.Forms.Label labelApiUrlPost;
        private System.Windows.Forms.Label labelApiError;
    }
}