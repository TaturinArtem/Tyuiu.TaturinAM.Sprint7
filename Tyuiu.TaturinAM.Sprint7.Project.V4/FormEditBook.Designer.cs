
namespace Tyuiu.TaturinAM.Sprint7.Project.V4
{
    partial class FormEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBook));
            this.buttonEditNewBook_TAM = new System.Windows.Forms.Button();
            this.labelIsBookNew_TAM = new System.Windows.Forms.Label();
            this.labelGenre_TAM = new System.Windows.Forms.Label();
            this.labelYear_TAM = new System.Windows.Forms.Label();
            this.labelAuthor_TAM = new System.Windows.Forms.Label();
            this.labelBook_Name = new System.Windows.Forms.Label();
            this.labelArticle_TAM = new System.Windows.Forms.Label();
            this.comboBoxIsBookNew_TAM = new System.Windows.Forms.ComboBox();
            this.textBoxBookGenre_TAM = new System.Windows.Forms.TextBox();
            this.textBoxBookYear_TAM = new System.Windows.Forms.TextBox();
            this.textBoxBookAuthor_TAM = new System.Windows.Forms.TextBox();
            this.textBoxBookName_TAM = new System.Windows.Forms.TextBox();
            this.textBoxBookArticle_TAM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEditNewBook_TAM
            // 
            this.buttonEditNewBook_TAM.Location = new System.Drawing.Point(240, 167);
            this.buttonEditNewBook_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditNewBook_TAM.Name = "buttonEditNewBook_TAM";
            this.buttonEditNewBook_TAM.Size = new System.Drawing.Size(110, 34);
            this.buttonEditNewBook_TAM.TabIndex = 39;
            this.buttonEditNewBook_TAM.Text = "Редактировать";
            this.buttonEditNewBook_TAM.UseVisualStyleBackColor = true;
            this.buttonEditNewBook_TAM.Click += new System.EventHandler(this.buttonEditNewBook_TAM_Click);
            // 
            // labelIsBookNew_TAM
            // 
            this.labelIsBookNew_TAM.AutoSize = true;
            this.labelIsBookNew_TAM.Location = new System.Drawing.Point(263, 121);
            this.labelIsBookNew_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsBookNew_TAM.Name = "labelIsBookNew_TAM";
            this.labelIsBookNew_TAM.Size = new System.Drawing.Size(87, 13);
            this.labelIsBookNew_TAM.TabIndex = 37;
            this.labelIsBookNew_TAM.Text = "Новое издание:";
            // 
            // labelGenre_TAM
            // 
            this.labelGenre_TAM.AutoSize = true;
            this.labelGenre_TAM.Location = new System.Drawing.Point(311, 66);
            this.labelGenre_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre_TAM.Name = "labelGenre_TAM";
            this.labelGenre_TAM.Size = new System.Drawing.Size(39, 13);
            this.labelGenre_TAM.TabIndex = 36;
            this.labelGenre_TAM.Text = "Жанр:";
            // 
            // labelYear_TAM
            // 
            this.labelYear_TAM.AutoSize = true;
            this.labelYear_TAM.Location = new System.Drawing.Point(56, 119);
            this.labelYear_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear_TAM.Name = "labelYear_TAM";
            this.labelYear_TAM.Size = new System.Drawing.Size(74, 13);
            this.labelYear_TAM.TabIndex = 35;
            this.labelYear_TAM.Text = "Год выпуска:";
            // 
            // labelAuthor_TAM
            // 
            this.labelAuthor_TAM.AutoSize = true;
            this.labelAuthor_TAM.Location = new System.Drawing.Point(67, 71);
            this.labelAuthor_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor_TAM.Name = "labelAuthor_TAM";
            this.labelAuthor_TAM.Size = new System.Drawing.Size(40, 13);
            this.labelAuthor_TAM.TabIndex = 34;
            this.labelAuthor_TAM.Text = "Автор:";
            // 
            // labelBook_Name
            // 
            this.labelBook_Name.AutoSize = true;
            this.labelBook_Name.Location = new System.Drawing.Point(290, 14);
            this.labelBook_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBook_Name.Name = "labelBook_Name";
            this.labelBook_Name.Size = new System.Drawing.Size(60, 13);
            this.labelBook_Name.TabIndex = 33;
            this.labelBook_Name.Text = "Название:";
            // 
            // labelArticle_TAM
            // 
            this.labelArticle_TAM.AutoSize = true;
            this.labelArticle_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelArticle_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArticle_TAM.Location = new System.Drawing.Point(47, 18);
            this.labelArticle_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArticle_TAM.Name = "labelArticle_TAM";
            this.labelArticle_TAM.Size = new System.Drawing.Size(59, 13);
            this.labelArticle_TAM.TabIndex = 32;
            this.labelArticle_TAM.Text = "Артикул:";
            // 
            // comboBoxIsBookNew_TAM
            // 
            this.comboBoxIsBookNew_TAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_TAM.FormattingEnabled = true;
            this.comboBoxIsBookNew_TAM.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.comboBoxIsBookNew_TAM.Location = new System.Drawing.Point(352, 119);
            this.comboBoxIsBookNew_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIsBookNew_TAM.Name = "comboBoxIsBookNew_TAM";
            this.comboBoxIsBookNew_TAM.Size = new System.Drawing.Size(166, 21);
            this.comboBoxIsBookNew_TAM.TabIndex = 31;
            this.comboBoxIsBookNew_TAM.TabStop = false;
            // 
            // textBoxBookGenre_TAM
            // 
            this.textBoxBookGenre_TAM.Location = new System.Drawing.Point(352, 64);
            this.textBoxBookGenre_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookGenre_TAM.Name = "textBoxBookGenre_TAM";
            this.textBoxBookGenre_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookGenre_TAM.TabIndex = 26;
            // 
            // textBoxBookYear_TAM
            // 
            this.textBoxBookYear_TAM.Location = new System.Drawing.Point(131, 116);
            this.textBoxBookYear_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookYear_TAM.Name = "textBoxBookYear_TAM";
            this.textBoxBookYear_TAM.Size = new System.Drawing.Size(118, 20);
            this.textBoxBookYear_TAM.TabIndex = 27;
            // 
            // textBoxBookAuthor_TAM
            // 
            this.textBoxBookAuthor_TAM.Location = new System.Drawing.Point(112, 68);
            this.textBoxBookAuthor_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookAuthor_TAM.Name = "textBoxBookAuthor_TAM";
            this.textBoxBookAuthor_TAM.Size = new System.Drawing.Size(137, 20);
            this.textBoxBookAuthor_TAM.TabIndex = 28;
            // 
            // textBoxBookName_TAM
            // 
            this.textBoxBookName_TAM.Location = new System.Drawing.Point(351, 11);
            this.textBoxBookName_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookName_TAM.Name = "textBoxBookName_TAM";
            this.textBoxBookName_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookName_TAM.TabIndex = 29;
            // 
            // textBoxBookArticle_TAM
            // 
            this.textBoxBookArticle_TAM.Location = new System.Drawing.Point(110, 16);
            this.textBoxBookArticle_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookArticle_TAM.Name = "textBoxBookArticle_TAM";
            this.textBoxBookArticle_TAM.Size = new System.Drawing.Size(139, 20);
            this.textBoxBookArticle_TAM.TabIndex = 30;
            // 
            // FormEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 222);
            this.Controls.Add(this.buttonEditNewBook_TAM);
            this.Controls.Add(this.labelIsBookNew_TAM);
            this.Controls.Add(this.labelGenre_TAM);
            this.Controls.Add(this.labelYear_TAM);
            this.Controls.Add(this.labelAuthor_TAM);
            this.Controls.Add(this.labelBook_Name);
            this.Controls.Add(this.labelArticle_TAM);
            this.Controls.Add(this.comboBoxIsBookNew_TAM);
            this.Controls.Add(this.textBoxBookGenre_TAM);
            this.Controls.Add(this.textBoxBookYear_TAM);
            this.Controls.Add(this.textBoxBookAuthor_TAM);
            this.Controls.Add(this.textBoxBookName_TAM);
            this.Controls.Add(this.textBoxBookArticle_TAM);
            this.Name = "FormEditBook";
            this.Text = "Редактирование книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditNewBook_TAM;
        private System.Windows.Forms.Label labelIsBookNew_TAM;
        private System.Windows.Forms.Label labelGenre_TAM;
        private System.Windows.Forms.Label labelYear_TAM;
        private System.Windows.Forms.Label labelAuthor_TAM;
        private System.Windows.Forms.Label labelBook_Name;
        private System.Windows.Forms.Label labelArticle_TAM;
        public System.Windows.Forms.ComboBox comboBoxIsBookNew_TAM;
        public System.Windows.Forms.TextBox textBoxBookGenre_TAM;
        public System.Windows.Forms.TextBox textBoxBookYear_TAM;
        public System.Windows.Forms.TextBox textBoxBookAuthor_TAM;
        public System.Windows.Forms.TextBox textBoxBookName_TAM;
        public System.Windows.Forms.TextBox textBoxBookArticle_TAM;
    }
}