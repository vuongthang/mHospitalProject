using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace mHospital
{
    public class sqlHelper
    {
        public string _strCon;
        public sqlHelper()
        {
            _strCon = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }
        public string StrCon
        {
            get { return _strCon; }
            set { this._strCon = value; }
        }
    }
}
