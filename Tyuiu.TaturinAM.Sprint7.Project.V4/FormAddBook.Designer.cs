
namespace Tyuiu.TaturinAM.Sprint7.Project.V4
{
    partial class FormAddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBook));
            this.buttonAddNewBook_TAM = new System.Windows.Forms.Button();
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
            // buttonAddNewBook_TAM
            // 
            this.buttonAddNewBook_TAM.Location = new System.Drawing.Point(114, 326);
            this.buttonAddNewBook_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNewBook_TAM.Name = "buttonAddNewBook_TAM";
            this.buttonAddNewBook_TAM.Size = new System.Drawing.Size(110, 34);
            this.buttonAddNewBook_TAM.TabIndex = 24;
            this.buttonAddNewBook_TAM.Text = "Добавить";
            this.buttonAddNewBook_TAM.UseVisualStyleBackColor = true;
            this.buttonAddNewBook_TAM.Click += new System.EventHandler(this.buttonAddNewBook_TAM_Click);
            // 
            // labelIsBookNew_TAM
            // 
            this.labelIsBookNew_TAM.AutoSize = true;
            this.labelIsBookNew_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelIsBookNew_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsBookNew_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIsBookNew_TAM.Location = new System.Drawing.Point(12, 270);
            this.labelIsBookNew_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIsBookNew_TAM.Name = "labelIsBookNew_TAM";
            this.labelIsBookNew_TAM.Size = new System.Drawing.Size(101, 13);
            this.labelIsBookNew_TAM.TabIndex = 22;
            this.labelIsBookNew_TAM.Text = "Новое издание:";
            // 
            // labelGenre_TAM
            // 
            this.labelGenre_TAM.AutoSize = true;
            this.labelGenre_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelGenre_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenre_TAM.Location = new System.Drawing.Point(64, 218);
            this.labelGenre_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre_TAM.Name = "labelGenre_TAM";
            this.labelGenre_TAM.Size = new System.Drawing.Size(44, 13);
            this.labelGenre_TAM.TabIndex = 21;
            this.labelGenre_TAM.Text = "Жанр:";
            // 
            // labelYear_TAM
            // 
            this.labelYear_TAM.AutoSize = true;
            this.labelYear_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelYear_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelYear_TAM.Location = new System.Drawing.Point(27, 167);
            this.labelYear_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear_TAM.Name = "labelYear_TAM";
            this.labelYear_TAM.Size = new System.Drawing.Size(86, 13);
            this.labelYear_TAM.TabIndex = 20;
            this.labelYear_TAM.Text = "Год выпуска:";
            // 
            // labelAuthor_TAM
            // 
            this.labelAuthor_TAM.AutoSize = true;
            this.labelAuthor_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAuthor_TAM.Location = new System.Drawing.Point(64, 117);
            this.labelAuthor_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthor_TAM.Name = "labelAuthor_TAM";
            this.labelAuthor_TAM.Size = new System.Drawing.Size(46, 13);
            this.labelAuthor_TAM.TabIndex = 19;
            this.labelAuthor_TAM.Text = "Автор:";
            // 
            // labelBook_Name
            // 
            this.labelBook_Name.AutoSize = true;
            this.labelBook_Name.BackColor = System.Drawing.Color.Transparent;
            this.labelBook_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBook_Name.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBook_Name.Location = new System.Drawing.Point(44, 72);
            this.labelBook_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBook_Name.Name = "labelBook_Name";
            this.labelBook_Name.Size = new System.Drawing.Size(69, 13);
            this.labelBook_Name.TabIndex = 18;
            this.labelBook_Name.Text = "Название:";
            // 
            // labelArticle_TAM
            // 
            this.labelArticle_TAM.AutoSize = true;
            this.labelArticle_TAM.BackColor = System.Drawing.Color.Transparent;
            this.labelArticle_TAM.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelArticle_TAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle_TAM.ForeColor = System.Drawing.SystemColors.Control;
            this.labelArticle_TAM.Location = new System.Drawing.Point(53, 33);
            this.labelArticle_TAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArticle_TAM.Name = "labelArticle_TAM";
            this.labelArticle_TAM.Size = new System.Drawing.Size(59, 13);
            this.labelArticle_TAM.TabIndex = 17;
            this.labelArticle_TAM.Text = "Артикул:";
            // 
            // comboBoxIsBookNew_TAM
            // 
            this.comboBoxIsBookNew_TAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsBookNew_TAM.FormattingEnabled = true;
            this.comboBoxIsBookNew_TAM.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.comboBoxIsBookNew_TAM.Location = new System.Drawing.Point(114, 267);
            this.comboBoxIsBookNew_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIsBookNew_TAM.Name = "comboBoxIsBookNew_TAM";
            this.comboBoxIsBookNew_TAM.Size = new System.Drawing.Size(166, 21);
            this.comboBoxIsBookNew_TAM.TabIndex = 16;
            this.comboBoxIsBookNew_TAM.TabStop = false;
            // 
            // textBoxBookGenre_TAM
            // 
            this.textBoxBookGenre_TAM.Location = new System.Drawing.Point(114, 215);
            this.textBoxBookGenre_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookGenre_TAM.Name = "textBoxBookGenre_TAM";
            this.textBoxBookGenre_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookGenre_TAM.TabIndex = 11;
            // 
            // textBoxBookYear_TAM
            // 
            this.textBoxBookYear_TAM.Location = new System.Drawing.Point(114, 164);
            this.textBoxBookYear_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookYear_TAM.Name = "textBoxBookYear_TAM";
            this.textBoxBookYear_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookYear_TAM.TabIndex = 12;
            // 
            // textBoxBookAuthor_TAM
            // 
            this.textBoxBookAuthor_TAM.Location = new System.Drawing.Point(114, 114);
            this.textBoxBookAuthor_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookAuthor_TAM.Name = "textBoxBookAuthor_TAM";
            this.textBoxBookAuthor_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookAuthor_TAM.TabIndex = 13;
            // 
            // textBoxBookName_TAM
            // 
            this.textBoxBookName_TAM.Location = new System.Drawing.Point(114, 69);
            this.textBoxBookName_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookName_TAM.Name = "textBoxBookName_TAM";
            this.textBoxBookName_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookName_TAM.TabIndex = 14;
            // 
            // textBoxBookArticle_TAM
            // 
            this.textBoxBookArticle_TAM.Location = new System.Drawing.Point(114, 30);
            this.textBoxBookArticle_TAM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBookArticle_TAM.Name = "textBoxBookArticle_TAM";
            this.textBoxBookArticle_TAM.Size = new System.Drawing.Size(166, 20);
            this.textBoxBookArticle_TAM.TabIndex = 15;
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(315, 396);
            this.Controls.Add(this.buttonAddNewBook_TAM);
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
            this.Name = "FormAddBook";
            this.Text = "Добавление книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewBook_TAM;
        private System.Windows.Forms.Label labelIsBookNew_TAM;
        private System.Windows.Forms.Label labelGenre_TAM;
        private System.Windows.Forms.Label labelYear_TAM;
        private System.Windows.Forms.Label labelAuthor_TAM;
        private System.Windows.Forms.Label labelBook_Name;
        private System.Windows.Forms.Label labelArticle_TAM;
        private System.Windows.Forms.ComboBox comboBoxIsBookNew_TAM;
        private System.Windows.Forms.TextBox textBoxBookGenre_TAM;
        private System.Windows.Forms.TextBox textBoxBookYear_TAM;
        private System.Windows.Forms.TextBox textBoxBookAuthor_TAM;
        private System.Windows.Forms.TextBox textBoxBookName_TAM;
        private System.Windows.Forms.TextBox textBoxBookArticle_TAM;
    }
}