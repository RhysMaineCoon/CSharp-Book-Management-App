// Author: Molly Meyer
// Date: 3/8/2023
// Program: Manages the Book Class
// Version 1.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M8_PortfolioProject_MMeyer
{
    internal class Book
    {
        //Book information
        //Declare variables 
        private int mID;
        private string mTitle;
        private string mDescription;
        private string mAuthor;
        private int mPublishYear;
        private string mBindingType;

        //Set up getter and setter methods 
        public int BookID
        {
            get { return mID; }
            set { mID = value; }
        }

        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        public string Author
        {
            get { return mAuthor; }
            set { mAuthor = value; }
        }
        public int PublishYear
        {
            get { return mPublishYear; }
            set { mPublishYear = value; }
        }
        public string BindingType
        {
            get { return mBindingType; }
            set { mBindingType = value; }
        }

        //Default Constructor 
        public Book()
        {
            this.Title = String.Empty;
            this.Description = String.Empty;
            this.Author = String.Empty;
            this.PublishYear = 0;
            this.BindingType = String.Empty;
        }

        //Overloaded Constructor 
        public Book(string title)
        {
            this.Title = title;
            this.Description = string.Empty;
            this.Author = string.Empty;
            this.PublishYear = 0;
            this.BindingType = string.Empty;
        }

        //Method


    }
}
