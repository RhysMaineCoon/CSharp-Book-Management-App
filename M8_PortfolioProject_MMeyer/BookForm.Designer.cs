﻿namespace M8_PortfolioProject_MMeyer
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.enterInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addCoverLabel = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.bindingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.bindingTypeLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.booksLabel = new System.Windows.Forms.Label();
            this.displayInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionOutputLabel = new System.Windows.Forms.Label();
            this.publishYearOutputLabel = new System.Windows.Forms.Label();
            this.bindingTypeOutputLabel = new System.Windows.Forms.Label();
            this.authorOutputLabel = new System.Windows.Forms.Label();
            this.titleOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.publishYearLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.enterInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.displayInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterInfoGroupBox
            // 
            this.enterInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.enterInfoGroupBox.Controls.Add(this.bookIDTextBox);
            this.enterInfoGroupBox.Controls.Add(this.label3);
            this.enterInfoGroupBox.Controls.Add(this.clearButton);
            this.enterInfoGroupBox.Controls.Add(this.descriptionLabel);
            this.enterInfoGroupBox.Controls.Add(this.descriptionRichTextBox);
            this.enterInfoGroupBox.Controls.Add(this.addButton);
            this.enterInfoGroupBox.Controls.Add(this.addCoverLabel);
            this.enterInfoGroupBox.Controls.Add(this.publishYearTextBox);
            this.enterInfoGroupBox.Controls.Add(this.bindingTypeComboBox);
            this.enterInfoGroupBox.Controls.Add(this.authorTextBox);
            this.enterInfoGroupBox.Controls.Add(this.titleTextBox);
            this.enterInfoGroupBox.Controls.Add(this.coverPictureBox);
            this.enterInfoGroupBox.Controls.Add(this.publishYearLabel);
            this.enterInfoGroupBox.Controls.Add(this.bindingTypeLabel);
            this.enterInfoGroupBox.Controls.Add(this.authorLabel);
            this.enterInfoGroupBox.Controls.Add(this.titleLabel);
            this.enterInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enterInfoGroupBox.Name = "enterInfoGroupBox";
            this.enterInfoGroupBox.Size = new System.Drawing.Size(291, 768);
            this.enterInfoGroupBox.TabIndex = 0;
            this.enterInfoGroupBox.TabStop = false;
            this.enterInfoGroupBox.Text = "Enter Book Info";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Enabled = false;
            this.bookIDTextBox.Location = new System.Drawing.Point(106, 27);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(167, 23);
            this.bookIDTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "BookID:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.Location = new System.Drawing.Point(141, 728);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 29);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 216);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 15);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Book Description:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(17, 244);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(217, 163);
            this.descriptionRichTextBox.TabIndex = 10;
            this.descriptionRichTextBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Silver;
            this.addButton.Location = new System.Drawing.Point(8, 728);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addCoverLabel
            // 
            this.addCoverLabel.AutoSize = true;
            this.addCoverLabel.Location = new System.Drawing.Point(17, 409);
            this.addCoverLabel.Name = "addCoverLabel";
            this.addCoverLabel.Size = new System.Drawing.Size(123, 15);
            this.addCoverLabel.TabIndex = 9;
            this.addCoverLabel.Text = "Add Cover (Optional):";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(106, 173);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(167, 23);
            this.publishYearTextBox.TabIndex = 8;
            // 
            // bindingTypeComboBox
            // 
            this.bindingTypeComboBox.FormattingEnabled = true;
            this.bindingTypeComboBox.Location = new System.Drawing.Point(106, 135);
            this.bindingTypeComboBox.Name = "bindingTypeComboBox";
            this.bindingTypeComboBox.Size = new System.Drawing.Size(167, 23);
            this.bindingTypeComboBox.TabIndex = 7;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(106, 96);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(167, 23);
            this.authorTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(106, 62);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(167, 23);
            this.titleTextBox.TabIndex = 5;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.ErrorImage = null;
            this.coverPictureBox.Location = new System.Drawing.Point(17, 427);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(199, 295);
            this.coverPictureBox.TabIndex = 4;
            this.coverPictureBox.TabStop = false;
            this.coverPictureBox.Click += new System.EventHandler(this.coverPictureBox_Click);
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Location = new System.Drawing.Point(2, 175);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(98, 15);
            this.publishYearLabel.TabIndex = 3;
            this.publishYearLabel.Text = "Publication Year: ";
            // 
            // bindingTypeLabel
            // 
            this.bindingTypeLabel.AutoSize = true;
            this.bindingTypeLabel.Location = new System.Drawing.Point(17, 138);
            this.bindingTypeLabel.Name = "bindingTypeLabel";
            this.bindingTypeLabel.Size = new System.Drawing.Size(78, 15);
            this.bindingTypeLabel.TabIndex = 2;
            this.bindingTypeLabel.Text = "Binding Type:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(44, 104);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(47, 15);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(31, 65);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(60, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Book title:";
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 15;
            this.bookListBox.Location = new System.Drawing.Point(647, 30);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(221, 679);
            this.bookListBox.TabIndex = 1;
            this.bookListBox.SelectedIndexChanged += new System.EventHandler(this.bookListBox_SelectedIndexChanged);
            // 
            // booksLabel
            // 
            this.booksLabel.AutoSize = true;
            this.booksLabel.Location = new System.Drawing.Point(647, 12);
            this.booksLabel.Name = "booksLabel";
            this.booksLabel.Size = new System.Drawing.Size(80, 15);
            this.booksLabel.TabIndex = 2;
            this.booksLabel.Text = "List of Books: ";
            // 
            // displayInfoGroupBox
            // 
            this.displayInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.displayInfoGroupBox.Controls.Add(this.descriptionOutputLabel);
            this.displayInfoGroupBox.Controls.Add(this.publishYearOutputLabel);
            this.displayInfoGroupBox.Controls.Add(this.bindingTypeOutputLabel);
            this.displayInfoGroupBox.Controls.Add(this.authorOutputLabel);
            this.displayInfoGroupBox.Controls.Add(this.titleOutputLabel);
            this.displayInfoGroupBox.Controls.Add(this.label1);
            this.displayInfoGroupBox.Controls.Add(this.pictureBox1);
            this.displayInfoGroupBox.Controls.Add(this.publishYearLabel1);
            this.displayInfoGroupBox.Controls.Add(this.label4);
            this.displayInfoGroupBox.Controls.Add(this.label5);
            this.displayInfoGroupBox.Controls.Add(this.label6);
            this.displayInfoGroupBox.Location = new System.Drawing.Point(332, 12);
            this.displayInfoGroupBox.Name = "displayInfoGroupBox";
            this.displayInfoGroupBox.Size = new System.Drawing.Size(265, 768);
            this.displayInfoGroupBox.TabIndex = 3;
            this.displayInfoGroupBox.TabStop = false;
            this.displayInfoGroupBox.Text = "Display Book Info:";
            // 
            // descriptionOutputLabel
            // 
            this.descriptionOutputLabel.Location = new System.Drawing.Point(22, 543);
            this.descriptionOutputLabel.Name = "descriptionOutputLabel";
            this.descriptionOutputLabel.Size = new System.Drawing.Size(221, 168);
            this.descriptionOutputLabel.TabIndex = 28;
            this.descriptionOutputLabel.Text = "*";
            // 
            // publishYearOutputLabel
            // 
            this.publishYearOutputLabel.AutoSize = true;
            this.publishYearOutputLabel.Location = new System.Drawing.Point(133, 480);
            this.publishYearOutputLabel.Name = "publishYearOutputLabel";
            this.publishYearOutputLabel.Size = new System.Drawing.Size(12, 15);
            this.publishYearOutputLabel.TabIndex = 27;
            this.publishYearOutputLabel.Text = "*";
            // 
            // bindingTypeOutputLabel
            // 
            this.bindingTypeOutputLabel.AutoSize = true;
            this.bindingTypeOutputLabel.Location = new System.Drawing.Point(133, 449);
            this.bindingTypeOutputLabel.Name = "bindingTypeOutputLabel";
            this.bindingTypeOutputLabel.Size = new System.Drawing.Size(12, 15);
            this.bindingTypeOutputLabel.TabIndex = 26;
            this.bindingTypeOutputLabel.Text = "*";
            // 
            // authorOutputLabel
            // 
            this.authorOutputLabel.AutoSize = true;
            this.authorOutputLabel.Location = new System.Drawing.Point(130, 410);
            this.authorOutputLabel.Name = "authorOutputLabel";
            this.authorOutputLabel.Size = new System.Drawing.Size(12, 15);
            this.authorOutputLabel.TabIndex = 25;
            this.authorOutputLabel.Text = "*";
            // 
            // titleOutputLabel
            // 
            this.titleOutputLabel.AutoSize = true;
            this.titleOutputLabel.Location = new System.Drawing.Point(133, 375);
            this.titleOutputLabel.Name = "titleOutputLabel";
            this.titleOutputLabel.Size = new System.Drawing.Size(12, 15);
            this.titleOutputLabel.TabIndex = 24;
            this.titleOutputLabel.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Description:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 332);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // publishYearLabel1
            // 
            this.publishYearLabel1.AutoSize = true;
            this.publishYearLabel1.Location = new System.Drawing.Point(22, 480);
            this.publishYearLabel1.Name = "publishYearLabel1";
            this.publishYearLabel1.Size = new System.Drawing.Size(95, 15);
            this.publishYearLabel1.TabIndex = 15;
            this.publishYearLabel1.Text = "Publication Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Binding Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Book Title:";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Silver;
            this.editButton.Location = new System.Drawing.Point(650, 751);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(86, 29);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit Book";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Silver;
            this.deleteButton.Location = new System.Drawing.Point(766, 751);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 29);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Book";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.BackColor = System.Drawing.Color.Silver;
            this.deleteCheckBox.Location = new System.Drawing.Point(647, 715);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(89, 19);
            this.deleteCheckBox.TabIndex = 7;
            this.deleteCheckBox.Text = "Delete Book";
            this.deleteCheckBox.UseVisualStyleBackColor = false;
            this.deleteCheckBox.CheckedChanged += new System.EventHandler(this.deleteCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog1";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(909, 792);
            this.Controls.Add(this.deleteCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.displayInfoGroupBox);
            this.Controls.Add(this.booksLabel);
            this.Controls.Add(this.bookListBox);
            this.Controls.Add(this.enterInfoGroupBox);
            this.Name = "BookForm";
            this.Text = "Book Managment App";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.enterInfoGroupBox.ResumeLayout(false);
            this.enterInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.displayInfoGroupBox.ResumeLayout(false);
            this.displayInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox enterInfoGroupBox;
        private PictureBox coverPictureBox;
        private Label publishYearLabel;
        private Label bindingTypeLabel;
        private Label authorLabel;
        private Label titleLabel;
        private ComboBox bindingTypeComboBox;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private ListBox bookListBox;
        private Label booksLabel;
        private GroupBox displayInfoGroupBox;
        private TextBox publishYearTextBox;
        private Label descriptionLabel;
        private RichTextBox descriptionRichTextBox;
        private Label addCoverLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private CheckBox deleteCheckBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Label publishYearLabel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label titleOutputLabel;
        private Label publishYearOutputLabel;
        private Label bindingTypeOutputLabel;
        private Label authorOutputLabel;
        private Label descriptionOutputLabel;
        private Button clearButton;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Label label3;
        private OpenFileDialog openFileDialog3;
        internal TextBox bookIDTextBox;
    }
}