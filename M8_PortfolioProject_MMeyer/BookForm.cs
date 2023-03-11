﻿// Author: Molly Meyer
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

        //Create a Global Book Object
        private M8_PortfolioProject_MMeyer.Book selectedBookObject;

        //Create a BindingList to store multiple Books 
        private BindingList<Book> bookList = new BindingList<Book>();

        //Class level Object - Book 
        private M8_PortfolioProject_MMeyer.Book bookObject = new M8_PortfolioProject_MMeyer.Book();

        // Class Level variable
        int bookLastNumber = 0;


        private void addButton_Click(object sender, EventArgs e)
        {
            //Declare Variables
            int intCheck;

            //Declare Object

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
            else if (int.TryParse(publishYearTextBox.Text, out intCheck) == false)
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
                //Assigning book information from the form to a bookObject
                bookObject.Title = titleTextBox.Text;
                bookObject.Author = authorTextBox.Text;
                bookObject.BindingType = bindingTypeComboBox.SelectedItem.ToString();
                bookObject.PublishYear = int.Parse(publishYearTextBox.Text);
                bookObject.Description = descriptionRichTextBox.Text;


                //Set the selectedBookObject to the bookObject
                selectedBookObject= bookObject;
                bookList.Add(bookObject);
                bookListBox.SelectedItem = bookObject;

                //Add new book object to list
                //bookList.Add(bookObject);
                //bookList.SelectedIndex = bookListBox.Items.Count - 1;
                //bookList.SelectedItem = bookObject;


                if (addButton.Text == "Add Book")
                {
                    bookList.Add(bookObject);
                    InsertBook();
                }
                else if (addButton.Text == "Edit Book")
                {
                    UpdateBook();
                    bookList.Clear();
                    Reload_Books();
                }
                else if (addButton.Text == "Delete Book")
                {
                    DeleteBook();
                    bookList.Clear();
                    Reload_Books();
                }
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
                //Display selected book information
                titleOutputLabel.Text = selectedBookObject.Title;
                authorOutputLabel.Text = selectedBookObject.Author;
                descriptionOutputLabel.Text = selectedBookObject.Description;
                publishYearOutputLabel.Text = selectedBookObject.PublishYear.ToString();
                bindingTypeOutputLabel.Text = selectedBookObject.BindingType;


                //If record selected show delete checkbox
                deleteCheckBox.Visible = true;

                //Change add book button to Edit Book
                addButton.Text = "Edit Book";
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

        // Database Methods 
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

        private void InsertBook()
        {
            // Open Database
            var connection = OpenDBConnection();

            // Create SQL String
            string SQL = "Insert into BookInfoTable (Title, Author, Binding, Year, Description) values (@Title, @Author, @Binding, @Year, @Description)";
            Msg(SQL.ToString());
            // Create Command
            var insertCommand = new SqlCommand(SQL, connection);

            // Populate Parameters of the Insert
            insertCommand.Parameters.AddWithValue("Title", bookList.Last().Title);
            insertCommand.Parameters.AddWithValue("Author", bookList.Last().Author);
            insertCommand.Parameters.AddWithValue("Binding", bookList.Last().BindingType);
            insertCommand.Parameters.AddWithValue("Year", bookList.Last().PublishYear);
            insertCommand.Parameters.AddWithValue("Description", bookList.Last().Description);

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
                    var storedBookObject = new M8_PortfolioProject_MMeyer.Book(bookReader["Id"].ToString());
                    storedBookObject.Title = bookReader["Title"].ToString();
                    storedBookObject.Description = bookReader["Description"].ToString();
                    storedBookObject.Author = bookReader["Author"].ToString();
                    storedBookObject.PublishYear = (int)bookReader["Year"];
                    storedBookObject.BindingType = bookReader["Binding"].ToString();

                    // Update userLastNumber
                    if (storedBookObject.BookID > bookLastNumber)
                    {
                        bookLastNumber = storedBookObject.BookID;
                    }
                    Msg(bookLastNumber.ToString());
                    bookList.Add(storedBookObject);
                }
            }
            connection.Close();
            connection.Dispose();
        }

        public void UpdateBook()
        {
            // Open Database
            var dbConnection = OpenDBConnection();

            // Create SQL String
            string SQL = "Update bookInfoTable set Title ='" + titleTextBox.Text + "', Author = '" +
           authorTextBox.Text + "', Binding_Type='" + bindingTypeComboBox.Text + "',Publish_Year='" + publishYearTextBox.Text + "', Description='" +
           descriptionRichTextBox.Text +"'";
            Msg(SQL);

            // Create Command
            var updateCommand = new SqlCommand(SQL, dbConnection);
            int intRowsAffected = updateCommand.ExecuteNonQuery();
            if (intRowsAffected == 1)
            {
                Msg(bookObject.Title + " was updated");
            }
        }


        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayBook(); 
        }

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "Book Management Application", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        } 

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }   
}
