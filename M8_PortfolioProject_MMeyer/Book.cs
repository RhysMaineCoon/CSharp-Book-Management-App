﻿// Author: Molly Meyer
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
        //Declare variables 
        private int mBookID;
        private string mTitle;
        private string mDescription;
        private string mAuthor;
        private int mPublishYear;
        private string mBindingType;
        private Image mCover;

        //Attributes 
        public int BookID
        {
            get { return mBookID; }
            set { mBookID = value; }
        }
        public string Title
        {
            get; //{ return mTitle; } C# does not require the following sections 
            set; //{ mTitle = value; }
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
        public Image Cover
        {
            get { return mCover; }
            set { mCover = value; }
        }


        //Default Constructor 
        public Book()
        {
            this.BookID = 0;
            this.Title = string.Empty;
            this.Description = string.Empty;
            this.Author = string.Empty;
            this.PublishYear = 0;
            this.BindingType = string.Empty;
            //this.Cover = 
        }

        //Overloaded Constructor 
        public Book(string title)
        {
            this.BookID= 0;
            this.Title = title;
            this.Description = string.Empty;
            this.Author = string.Empty;
            this.PublishYear = 0;
            this.BindingType = string.Empty;
        }
    }
}
