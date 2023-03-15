// Author: Molly Meyer
// Date: 3/8/2023
// Program: Book Managment Application 
// Version 1.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace M8_PortfolioProject_MMeyer
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        //Create a BindingList to store multiple Books 
        private BindingList<Book> bookList = new BindingList<Book>();

        //Class level Object - Book 
        private Book bookObject = new Book();

        // Class Level variable
        int bookLastNumber = 0;

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Book Management Application", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        } 

        private void addButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            int valueINT;

            //Validate Inputs 
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Book Title cannot be blank.");
                this.titleTextBox.Focus();
                return;
            }
            else if (authorTextBox.Text == "")
            {
                MessageBox.Show("Author cannot be blank.");
                this.authorTextBox.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(bindingTypeComboBox.Text))
            {
                MessageBox.Show("Binding Type cannot be blank.");
                this.bindingTypeComboBox.Focus();
                return;
            }
            else if (int.TryParse(publishYearTextBox.Text, out valueINT) == false)
            {
                MessageBox.Show("Publication Year cannot be blank.");
                this.publishYearTextBox.Focus();
                return;
            }
            else if (descriptionRichTextBox.Text == "")
            {
                MessageBox.Show("Description cannot be blank.");
                this.descriptionRichTextBox.Focus();
                return;
            }
            else
            {

                //Assign Book Properties
                /*
                if (bookIDTextBox.Text == string.Empty)
                 {
                     // If new record increment bookLastNumber
                     bookLastNumber++;
                     bookObject.BookID = Convert.ToInt32(bookLastNumber.ToString());
                }
                 else
                 {
                     bookObject.BookID = int.Parse(bookIDTextBox.Text);
                 }
                */

                //Assigning book information from the form to a bookObject
                bookObject.Title = titleTextBox.Text;
                bookObject.Author = authorTextBox.Text;
                bookObject.BindingType = bindingTypeComboBox.SelectedItem.ToString();
                bookObject.PublishYear = valueINT;
                bookObject.Description = descriptionRichTextBox.Text;

                if (addButton.Text == "Add Book")
                {
                    bookList.Add(bookObject);
                    InsertBook();
                    bookList.Clear();
                    Reload_Books();
                }
                else if (addButton.Text == "Edit Book")
                {
                    UpdateBook(); // Issue with updating book info. 
                    bookList.Clear();
                    Reload_Books();
                }
                else if (addButton.Text == "Delete Book")
                {
                    DeleteBook();
                    bookList.Clear();
                    Reload_Books();
                }

                ClearLabels();
            }
        }
        private void BookForm_Load(object sender, EventArgs e)
        {
            //Add binding type options to Combobox
            bindingTypeComboBox.Items.Add("Paperback");
            bindingTypeComboBox.Items.Add("Hardcover");
            bindingTypeComboBox.Items.Add("Spiral Bound");
            bindingTypeComboBox.SelectedIndex = 0;

            // Connect  Listbox properties to Binding list object 
            bookListBox.DataSource = bookList;
            bookListBox.DisplayMember = "Title";

            // Load books from Database
            Reload_Books();

            if (bookListBox.Items.Count > 0)
            {
                bookListBox.SelectedIndex = bookListBox.Items.Count - 1;
                DisplayBook();
            }
        }
        private SqlConnection OpenDBConnection()
        {
            //This gives the full path into the bin/debug folder.
            string path = Application.StartupPath;
            int pathLength = path.Length;
            //This strips off the bin/debug folder to point to the project folder
            path = path.Substring(0, pathLength - 25);

            //Create a connection string
            string connection = @"Server=(LocalDB)\MSSQLLOcalDB;Integrated Security=true;AttachDbFileName=" + path + "BookInfo.mdf";

            // Create a Connection Object to the database
            var dbConnection = new System.Data.SqlClient.SqlConnection(connection);

            // Open Database
            dbConnection.Open();

            return dbConnection;
        }
        private void Reload_Books()
        {
            // Clear Listbox
            bookListBox.ClearSelected();
            //Open Database
            var connection = OpenDBConnection();
            //Create a Command Object
            var selectCommand = new SqlCommand("SELECT * FROM BookInfoTable;", connection);
            
            // Execute Command into a DataReader
            var bookReader = selectCommand.ExecuteReader();

            if (bookReader.HasRows)
            {
                while (bookReader.Read())
                {
                    var storedBookObject = new Book(bookReader["BookID"].ToString());
                    
                    try
                    {
                        storedBookObject.Title = bookReader["Title"].ToString();
                        storedBookObject.Description = bookReader["Description"].ToString();
                        storedBookObject.Author = bookReader["Author"].ToString();
                        storedBookObject.PublishYear = int.Parse(bookReader["Year"].ToString());
                        storedBookObject.BindingType = bookReader["Binding"].ToString();
                    }
                    catch 
                    {
                        MessageBox.Show("Invalid data was entered.");
                    }

                    // Update bookLastNumber
                    if (storedBookObject.BookID > bookLastNumber)
                    {
                        bookLastNumber = storedBookObject.BookID;
                    }
                    //Msg(bookLastNumber.ToString());
                    bookList.Add(storedBookObject);
                }
            }
            connection.Close();
            connection.Dispose();
        }
        
        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBook(); 
        }
        private void InsertBook()
        {
            // Open Database
            var connection = OpenDBConnection();

            // Create SQL String
            string SQL = "Insert into BookInfoTable (Title, Author, Binding, Year, Description, Cover) values (@Title, @Author, @Binding, @Year, @Description, @Cover)";
            Msg(SQL.ToString());

            // Create Command
            var insertCommand = new SqlCommand(SQL, connection);

            // Populate Parameters of the Insert
            insertCommand.Parameters.AddWithValue("Title", bookList.Last().Title);
            insertCommand.Parameters.AddWithValue("Author", bookList.Last().Author);
            insertCommand.Parameters.AddWithValue("Binding", bookList.Last().BindingType);
            insertCommand.Parameters.AddWithValue("Year", bookList.Last().PublishYear);
            insertCommand.Parameters.AddWithValue("Description", bookList.Last().Description);
            insertCommand.Parameters.AddWithValue("Cover", bookList.Last().Cover);

            int intRowsAffected = insertCommand.ExecuteNonQuery();

            if (intRowsAffected == 1)
            {
                Msg(bookList.Last().Title + " was inserted");
            }
            else
            {
                Msg("The insert failed.");
            }
        }

        public void UpdateBook()
        {
            // Open Database
            var dbConnection = OpenDBConnection();

            // Create SQL String
            string SQL = "Update bookInfoTable set Title ='" + titleTextBox.Text + "', Author = '" +
           authorTextBox.Text + "', Binding='" + bindingTypeComboBox.Text + "',Year='" + publishYearTextBox.Text + "', Description='" +
           descriptionRichTextBox.Text + "' Cover = '" + coverPictureBox + "', where BookID=  '" + bookIDTextBox.Text + "'";
           Msg(SQL);

            // Create Command
            var updateCommand = new SqlCommand(SQL, dbConnection);
            int intRowsAffected = updateCommand.ExecuteNonQuery();
            if (intRowsAffected == 1)
            {
                Msg(bookObject.Title + " was updated");
            }
        }

        private void DeleteBook()
        {
            //Open Database
            var dbConnection = OpenDBConnection();

            // Create SQL String
            string SQL = "Delete from BookInfoTable where Title = '" + bookObject.Title + "'";
            MessageBox.Show(SQL);

            //Create Command
            var deleteCommand = new SqlCommand(SQL, dbConnection);
            var intRowsAffected = deleteCommand.ExecuteNonQuery();
            if (intRowsAffected == 1)
            {
                Msg("Record was deleted");
            }
        }
        private void DisplayBook()
        {
            //Display the Full Name of the object selected in the Listbox
            M8_PortfolioProject_MMeyer.Book selectedBookObject = (M8_PortfolioProject_MMeyer.Book)bookListBox.SelectedItem;

            //Refresh Output Labels
            if (bookListBox.SelectedIndex >= 0)
            {
                //Display selected book information to output labels
                titleOutputLabel.Text = selectedBookObject.Title;
                authorOutputLabel.Text = selectedBookObject.Author;
                descriptionOutputLabel.Text = selectedBookObject.Description;
                publishYearOutputLabel.Text = selectedBookObject.PublishYear.ToString();
                bindingTypeOutputLabel.Text = selectedBookObject.BindingType;
                //coverPictureBox = selectedBookObject.Cover; 

                //Populate Textboxes with the selected book
                bookIDTextBox.Text = selectedBookObject.BookID.ToString();
                titleTextBox.Text = selectedBookObject.Title;
                authorTextBox.Text = selectedBookObject.Author;
                bindingTypeComboBox.Text = selectedBookObject.BindingType;
                publishYearTextBox.Text = selectedBookObject.PublishYear.ToString();
                descriptionRichTextBox.Text = selectedBookObject.Description;

                //If record selected show delete checkbox
                deleteCheckBox.Visible = true;

                //Change save button to Edit Book
                addButton.Text = "Edit Book";
            }
        }
        private void ClearLabels()
        {
            //Clear textbox text
            titleTextBox.Text = string.Empty; 
            authorTextBox.Text = string.Empty;
            publishYearTextBox.Text = string.Empty;
            descriptionRichTextBox.Text = string.Empty;

            foreach (Control ctrl in this.Controls)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                {
                    tb.Clear();
                }
            }

            //Prepare for new record
            deleteCheckBox.Checked = false;
            deleteCheckBox.Visible = false;
            titleOutputLabel.Text = string.Empty;
            authorOutputLabel.Text = string.Empty;
            descriptionOutputLabel.Text = string.Empty;
            publishYearOutputLabel.Text = string.Empty;
            bindingTypeOutputLabel.Text = string.Empty;
            //--clear picturebox
            titleTextBox.Focus();
            addButton.Text = "Add Book";
        }

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteCheckBox.Checked = true)
            { 
                addButton.Text = "Delete Book";
            }
            else
            {
                addButton.Text = "Edit Book";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearLabels();
        }

        //Picture Box for book cover

        private void coverPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the Image";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif)|*.png;*.jpg;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                coverPictureBox.Image = new Bitmap(ofd.FileName);
            }
            //resize image to fit the picturebox size
        }

        private byte[] SaveCover()
        {
            MemoryStream ms = new MemoryStream();
            coverPictureBox.Image.Save(ms, coverPictureBox.Image.RawFormat);
            return ms.GetBuffer();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            coverPictureBox.Image = Image.FromFile(filePath);
        }
    }
}
