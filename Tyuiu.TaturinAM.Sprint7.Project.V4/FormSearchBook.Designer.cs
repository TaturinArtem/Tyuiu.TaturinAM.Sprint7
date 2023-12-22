
namespace Tyuiu.TaturinAM.Sprint7.Project.V4
{
    partial class FormSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchBook));
            this.buttonAddNewBook_TAM = new System.Windows.Forms.Button();
            this.labelIsBookNew_TAM = new System.Windows.Forms.Label();
            this.labelArticle_TAM = new System.Windows.Forms.Label();
            this.comboBoxIsBookNew_TAM = new System.Windows.Forms.ComboBox();
            this.textBoxBookSearch_TAM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddNewBook_TAM
            // 
            this.buttonAddNewBook_TAM.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddNewBook_TAM.Location = new System.Drawing.Point(116, 199);
            this.buttonAddNewBook_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNewBook_TAM.Name = "buttonAddNewBook_TAM";
            this.buttonAddNewBook_TAM.Size = new System.Drawing.Size(110, 34);
            this.buttonAddNewBook_TAM.TabIndex = 29;
            this.buttonAddNewBook_TAM.Text = "Найти";
            this.buttonAddNewBook_TAM.UseVisualStyleBackColor = false;
            this.buttonAddNewBook_TAM.Click += new System.EventHandler(this.buttonAddNewBook_TAM_Click);
            // 
            // labelIsBookNew_TAM
            // 
            this.labelIsBookNew_TAM.AutoSize = true;
            this.labelIsBookNew_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelIsBookNew_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsBookNew_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIsBookNew_TAM.Location = new System.Drawing.Point(44, 124);
            this.labelIsBookNew_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsBookNew_TAM.Name = "labelIsBookNew_TAM";
            this.labelIsBookNew_TAM.Size = new System.Drawing.Size(54, 13);
            this.labelIsBookNew_TAM.TabIndex = 28;
            this.labelIsBookNew_TAM.Text = "Искать:";
            this.labelIsBookNew_TAM.Click += new System.EventHandler(this.labelIsBookNew_GKU_Click);
            // 
            // labelArticle_TAM
            // 
            this.labelArticle_TAM.AutoSize = true;
            this.labelArticle_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelArticle_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArticle_TAM.Location = new System.Drawing.Point(32, 60);
            this.labelArticle_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArticle_TAM.Name = "labelArticle_TAM";
            this.labelArticle_TAM.Size = new System.Drawing.Size(66, 13);
            this.labelArticle_TAM.TabIndex = 27;
            this.labelArticle_TAM.Text = "Поиск по:";
            // 
            // comboBoxIsBookNew_TAM
            // 
            this.comboBoxIsBookNew_TAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_TAM.FormattingEnabled = true;
            this.comboBoxIsBookNew_TAM.Items.AddRange(new object[] {
            "артикулу",
            "названию",
            "автору",
            "дате издания",
            "жанру",
            "аннотации"});
            this.comboBoxIsBookNew_TAM.Location = new System.Drawing.Point(102, 57);
            this.comboBoxIsBookNew_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIsBookNew_TAM.Name = "comboBoxIsBookNew_TAM";
            this.comboBoxIsBookNew_TAM.Size = new System.Drawing.Size(166, 21);
            this.comboBoxIsBookNew_TAM.TabIndex = 26;
            this.comboBoxIsBookNew_TAM.TabStop = false;
            // 
            // textBoxBookSearch_TAM
            // 
            this.textBoxBookSearch_TAM.Location = new System.Drawing.Point(102, 121);
            this.textBoxBookSearch_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookSearch_TAM.Name = "textBoxBookSearch_TAM";
            this.textBoxBookSearch_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookSearch_TAM.TabIndex = 25;
            this.textBoxBookSearch_TAM.TextChanged += new System.EventHandler(this.textBoxBookSearch_GKU_TextChanged);
            // 
            // FormSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 268);
            this.Controls.Add(this.buttonAddNewBook_TAM);
            this.Controls.Add(this.labelIsBookNew_TAM);
            this.Controls.Add(this.labelArticle_TAM);
            this.Controls.Add(this.comboBoxIsBookNew_TAM);
            this.Controls.Add(this.textBoxBookSearch_TAM);
            this.Name = "FormSearchBook";
            this.Text = "Найти книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewBook_TAM;
        private System.Windows.Forms.Label labelIsBookNew_TAM;
        private System.Windows.Forms.Label labelArticle_TAM;
        private System.Windows.Forms.ComboBox comboBoxIsBookNew_TAM;
        private System.Windows.Forms.TextBox textBoxBookSearch_TAM;
    }
}