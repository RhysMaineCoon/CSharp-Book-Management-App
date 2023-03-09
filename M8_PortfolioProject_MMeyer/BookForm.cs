// Author: Molly Meyer
// Date: 3/8/2023
// Program: Book managment application 
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
                //Add new book object to list
                bookList.Add(bookObject);
                bookList.SelectedIndex = bookListBox.Items.Count - 1;
                bookList.SelectedItem = bookObject;

                //Display Book Output
                DisplayBook();


            }
        }

        private void DisplayBook()
        {
            //throw new NotImplementedException();

            //Display the Full Name of the object selected in the Listbox
            M8_PortfolioProject_MMeyer.Book selectedBookObject = (M8_PortfolioProject_MMeyer.Book)bookListBox.SelectedItem;

            //Refresh Output Labels
            if (bookListBox.SelectedIndex >= 0)
            {
                // Save measurement units
                string strWeightUnit = " lbs.";
                string strLengthUnit = " in.";

                //Display selected book information
                titleOutputLabel.Text = selectedBookObject.Title;
                authorOutputLabel.Text = selectedBookObject.Author;
                descriptionOutputLabel.Text = selectedBookObject.Description;
                publishYearOutputLabel.Text = selectedBookObject.PublishYear.ToString();
                bindingTypeOutputLabel.Text = selectedBookObject.BindingType;


                //If record selected show delete checkbox
                //deleteCheckBox.Visible = true;
            }

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            bindingTypeComboBox.Items.Add("Paperback");
            bindingTypeComboBox.Items.Add("Hardcover");
            bindingTypeComboBox.Items.Add("Spiral Bound");
            bindingTypeComboBox.SelectedIndex = 0;


        }

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

    } 
    
}
