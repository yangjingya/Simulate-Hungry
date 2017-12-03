using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class Book
    {
        private string _bookNo = string.Empty;
        private string _classNo = string.Empty;
        private string _bookName = string.Empty;
        private string _auther = string.Empty;
        private string _publishName = string.Empty;
        private string _publishDate = string.Empty;
        private string _introduction = string.Empty;
        private string _isRented = string.Empty;
        private string _rentNo = string.Empty;

        public string bookNo
        {
            get { return _bookNo; }
            set { _bookNo = value; }
        }
        public string classNo
        {
            get { return _classNo; }
            set { _classNo = value; }
        }
        public string bookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public string auther
        {
            get { return _auther; }
            set { _auther = value; }
        }
        public string publishName
        {
            get { return _publishName; }
            set { _publishName = value; }
        }
        public string publishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }
        public string introduction
        {
            get { return _introduction; }
            set { _introduction = value; }
        }
        public string isRented
        {
            get { return _isRented; }
            set { _isRented = value; }
        }
        public string rentNo
        {
            get { return _rentNo; }
            set { _rentNo = value; }
        }
    }
}
