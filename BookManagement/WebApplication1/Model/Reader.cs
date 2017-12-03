using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Reader
    {
        private string _readerNo = string.Empty;
        private string _readerPwd = string.Empty;
        private string _readerName = string.Empty;
        private string _rSex = string.Empty;
        private string _rPhoneNum = string.Empty;
        private string _institute = string.Empty;
        private string _province = string.Empty;
        private string _city = string.Empty;

        public string readerNo {
            get { return _readerNo; }
            set { _readerNo = value; }
        }
        public string readerPwd
        {
            get { return _readerPwd; }
            set { _readerPwd = value; }
        }
        public string readerName
        {
            get { return _readerName; }
            set { _readerName = value; }
        }
        public string rSex
        {
            get { return _rSex; }
            set { _rSex = value; }
        }
        public string rPhoneNum
        {
            get { return _rPhoneNum; }
            set { _rPhoneNum = value; }
        }
        public string institute
        {
            get { return _institute; }
            set { _institute = value; }
        }
        public string province
        {
            get { return _province; }
            set { _province = value; }
        }
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
    }
}
