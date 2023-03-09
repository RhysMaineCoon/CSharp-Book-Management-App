namespace M8_PortfolioProject_MMeyer
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
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.addCoverLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.deleteCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enterInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.displayInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterInfoGroupBox
            // 
            this.enterInfoGroupBox.Controls.Add(this.commentLabel);
            this.enterInfoGroupBox.Controls.Add(this.commentRichTextBox);
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
            this.enterInfoGroupBox.Size = new System.Drawing.Size(477, 557);
            this.enterInfoGroupBox.TabIndex = 0;
            this.enterInfoGroupBox.TabStop = false;
            this.enterInfoGroupBox.Text = "Enter Book Info";
            // 
            // bindingTypeComboBox
            // 
            this.bindingTypeComboBox.FormattingEnabled = true;
            this.bindingTypeComboBox.Location = new System.Drawing.Point(325, 22);
            this.bindingTypeComboBox.Name = "bindingTypeComboBox";
            this.bindingTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.bindingTypeComboBox.TabIndex = 7;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(93, 59);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(93, 25);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 5;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverPictureBox.BackgroundImage")));
            this.coverPictureBox.ErrorImage = null;
            this.coverPictureBox.Location = new System.Drawing.Point(20, 128);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(202, 402);
            this.coverPictureBox.TabIndex = 4;
            this.coverPictureBox.TabStop = false;
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.Location = new System.Drawing.Point(206, 57);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(98, 15);
            this.publishYearLabel.TabIndex = 3;
            this.publishYearLabel.Text = "Publication Year: ";
            // 
            // bindingTypeLabel
            // 
            this.bindingTypeLabel.AutoSize = true;
            this.bindingTypeLabel.Location = new System.Drawing.Point(226, 25);
            this.bindingTypeLabel.Name = "bindingTypeLabel";
            this.bindingTypeLabel.Size = new System.Drawing.Size(78, 15);
            this.bindingTypeLabel.TabIndex = 2;
            this.bindingTypeLabel.Text = "Binding Type:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(18, 67);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(47, 15);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(33, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(32, 15);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.ItemHeight = 15;
            this.bookListBox.Location = new System.Drawing.Point(506, 35);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(213, 484);
            this.bookListBox.TabIndex = 1;
            // 
            // booksLabel
            // 
            this.booksLabel.AutoSize = true;
            this.booksLabel.Location = new System.Drawing.Point(516, 17);
            this.booksLabel.Name = "booksLabel";
            this.booksLabel.Size = new System.Drawing.Size(80, 15);
            this.booksLabel.TabIndex = 2;
            this.booksLabel.Text = "List of Books: ";
            // 
            // displayInfoGroupBox
            // 
            this.displayInfoGroupBox.Controls.Add(this.label1);
            this.displayInfoGroupBox.Controls.Add(this.richTextBox1);
            this.displayInfoGroupBox.Controls.Add(this.label2);
            this.displayInfoGroupBox.Controls.Add(this.textBox1);
            this.displayInfoGroupBox.Controls.Add(this.comboBox1);
            this.displayInfoGroupBox.Controls.Add(this.textBox2);
            this.displayInfoGroupBox.Controls.Add(this.textBox3);
            this.displayInfoGroupBox.Controls.Add(this.pictureBox1);
            this.displayInfoGroupBox.Controls.Add(this.label3);
            this.displayInfoGroupBox.Controls.Add(this.label4);
            this.displayInfoGroupBox.Controls.Add(this.label5);
            this.displayInfoGroupBox.Controls.Add(this.label6);
            this.displayInfoGroupBox.Location = new System.Drawing.Point(746, 20);
            this.displayInfoGroupBox.Name = "displayInfoGroupBox";
            this.displayInfoGroupBox.Size = new System.Drawing.Size(533, 549);
            this.displayInfoGroupBox.TabIndex = 3;
            this.displayInfoGroupBox.TabStop = false;
            this.displayInfoGroupBox.Text = "Display Book Info:";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(325, 57);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(121, 23);
            this.publishYearTextBox.TabIndex = 8;
            // 
            // addCoverLabel
            // 
            this.addCoverLabel.AutoSize = true;
            this.addCoverLabel.Location = new System.Drawing.Point(20, 110);
            this.addCoverLabel.Name = "addCoverLabel";
            this.addCoverLabel.Size = new System.Drawing.Size(123, 15);
            this.addCoverLabel.TabIndex = 9;
            this.addCoverLabel.Text = "Add Cover (Optional):";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(325, 511);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(506, 546);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit Book";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(590, 546);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Book";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Location = new System.Drawing.Point(244, 128);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(227, 365);
            this.commentRichTextBox.TabIndex = 10;
            this.commentRichTextBox.Text = "";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(242, 113);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(126, 15);
            this.commentLabel.TabIndex = 11;
            this.commentLabel.Text = "Comments (Optional):";
            // 
            // deleteCheckBox
            // 
            this.deleteCheckBox.AutoSize = true;
            this.deleteCheckBox.Location = new System.Drawing.Point(509, 523);
            this.deleteCheckBox.Name = "deleteCheckBox";
            this.deleteCheckBox.Size = new System.Drawing.Size(89, 19);
            this.deleteCheckBox.TabIndex = 7;
            this.deleteCheckBox.Text = "Delete Book";
            this.deleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Comments (Optional):";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(268, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 376);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add Cover (Optional):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(353, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(21, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 376);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Publication Year: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Binding Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Title:";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 581);
            this.Controls.Add(this.deleteCheckBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.displayInfoGroupBox);
            this.Controls.Add(this.booksLabel);
            this.Controls.Add(this.bookListBox);
            this.Controls.Add(this.enterInfoGroupBox);
            this.Name = "BookForm";
            this.Text = "BookForm";
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
        private Label commentLabel;
        private RichTextBox commentRichTextBox;
        private Label addCoverLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private CheckBox deleteCheckBox;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}