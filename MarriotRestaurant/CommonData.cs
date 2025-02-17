using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace MarriotRestaurant
{
    internal class CommonData
    {
        static DataSet _ds;//indicating property associated with this field and also it is private field
        static DateTime  _dt;
        static double _totalItemPrice, _SGST, _CGST;
        

        public static DataSet commonDS
        {
            set { _ds = value; }
            get { return _ds; }
        }
        public static DateTime BillingOrderDateTime
        {
            set { _dt = value; }
            get { return _dt; }
        }
        public static double totalItemPrice
        {
            set { _totalItemPrice = value; }
            get { return _totalItemPrice; }
        }
        public static double SGSTPrice
        {
            set { _SGST = value; }
            get { return _SGST; }
        }
        public static double CGSTPrice
        {
            set { _CGST = value; }
            get { return _CGST; }
        }

    }
}
