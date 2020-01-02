using BLL;

namespace PL
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
            if (parentForm != null)
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
            this.buttonApiBack = new System.Windows.Forms.Button();
            this.buttonApiGet = new System.Windows.Forms.Button();
            this.textBoxApiGetHash = new System.Windows.Forms.TextBox();
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
            // buttonApiBack
            // 
            this.buttonApiBack.Location = new System.Drawing.Point(212, 96);
            this.buttonApiBack.Name = "buttonApiBack";
            this.buttonApiBack.Size = new System.Drawing.Size(87, 42);
            this.buttonApiBack.TabIndex = 3;
            this.buttonApiBack.Text = "Cancel";
            this.buttonApiBack.UseVisualStyleBackColor = true;
            this.buttonApiBack.Click += new System.EventHandler(this.buttonApiBack_Click);
            // 
            // buttonApiGet
            // 
            this.buttonApiGet.Location = new System.Drawing.Point(66, 96);
            this.buttonApiGet.Name = "buttonApiGet";
            this.buttonApiGet.Size = new System.Drawing.Size(96, 42);
            this.buttonApiGet.TabIndex = 4;
            this.buttonApiGet.Text = "GET";
            this.buttonApiGet.UseVisualStyleBackColor = true;
            this.buttonApiGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBoxApiGetHash
            // 
            this.textBoxApiGetHash.Location = new System.Drawing.Point(152, 37);
            this.textBoxApiGetHash.Name = "textBoxApiGetHash";
            this.textBoxApiGetHash.Size = new System.Drawing.Size(128, 22);
            this.textBoxApiGetHash.TabIndex = 2;
            this.textBoxApiGetHash.Text = "xtoLyW2";
            // 
            // labelApiError
            // 
            this.labelApiError.ForeColor = System.Drawing.Color.Red;
            this.labelApiError.Location = new System.Drawing.Point(81, 141);
            this.labelApiError.Name = "labelApiError";
            this.labelApiError.Size = new System.Drawing.Size(333, 30);
            this.labelApiError.TabIndex = 5;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 158);
            this.Controls.Add(this.labelApiError);
            this.Controls.Add(this.buttonApiGet);
            this.Controls.Add(this.buttonApiBack);
            this.Controls.Add(this.textBoxApiGetHash);
            this.Controls.Add(this.labelApiUrlGet);
            this.MaximumSize = new System.Drawing.Size(380, 205);
            this.MinimumSize = new System.Drawing.Size(380, 205);
            this.Name = "ApiForm";
            this.Text = "Load from API";
            this.Load += new System.EventHandler(this.ApiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelApiUrlGet;
        private System.Windows.Forms.Button buttonApiBack;
        private System.Windows.Forms.Button buttonApiGet;
        private System.Windows.Forms.TextBox textBoxApiGetHash;
        private System.Windows.Forms.Label labelApiError;
    }
}