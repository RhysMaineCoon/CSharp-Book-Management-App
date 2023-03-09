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
        private Book selectedBookObject;
        //Create a BindingList to store multiple Books 
        private BindingList<Book> bookList = new BindingList<Book>();
        //Class level Variable 
        //?

    }
}
