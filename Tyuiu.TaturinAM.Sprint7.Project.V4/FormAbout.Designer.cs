
namespace Tyuiu.TaturinAM.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxAbout_TAM = new System.Windows.Forms.TextBox();
            this.pictureBoxIcon_TAM = new System.Windows.Forms.PictureBox();
            this.buttonOK_TAM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon_TAM)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout_TAM
            // 
            this.textBoxAbout_TAM.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAbout_TAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_TAM.Location = new System.Drawing.Point(208, 11);
            this.textBoxAbout_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAbout_TAM.Multiline = true;
            this.textBoxAbout_TAM.Name = "textBoxAbout_TAM";
            this.textBoxAbout_TAM.ReadOnly = true;
            this.textBoxAbout_TAM.Size = new System.Drawing.Size(247, 217);
            this.textBoxAbout_TAM.TabIndex = 5;
            this.textBoxAbout_TAM.TabStop = false;
            this.textBoxAbout_TAM.Text = resources.GetString("textBoxAbout_TAM.Text");
            // 
            // pictureBoxIcon_TAM
            // 
            this.pictureBoxIcon_TAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon_TAM.Image")));
            this.pictureBoxIcon_TAM.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxIcon_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxIcon_TAM.Name = "pictureBoxIcon_TAM";
            this.pictureBoxIcon_TAM.Size = new System.Drawing.Size(178, 176);
            this.pictureBoxIcon_TAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon_TAM.TabIndex = 4;
            this.pictureBoxIcon_TAM.TabStop = false;
            // 
            // buttonOK_TAM
            // 
            this.buttonOK_TAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK_TAM.Location = new System.Drawing.Point(345, 232);
            this.buttonOK_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK_TAM.Name = "buttonOK_TAM";
            this.buttonOK_TAM.Size = new System.Drawing.Size(87, 28);
            this.buttonOK_TAM.TabIndex = 3;
            this.buttonOK_TAM.Text = "Ок";
            this.buttonOK_TAM.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 271);
            this.Controls.Add(this.textBoxAbout_TAM);
            this.Controls.Add(this.pictureBoxIcon_TAM);
            this.Controls.Add(this.buttonOK_TAM);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon_TAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout_TAM;
        private System.Windows.Forms.PictureBox pictureBoxIcon_TAM;
        private System.Windows.Forms.Button buttonOK_TAM;
    }
}