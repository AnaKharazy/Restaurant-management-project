using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagmentCore.Utility
{
    public class Utility
    {
        //this method is For Fill Data To the LockUpEdit
        public static LookUpEdit FillToLookUpEdit(string DisplayValue,string EditValue,LookUpEdit lookUpEdit)
        {
            lookUpEdit.Properties.ValueMember = EditValue;
            lookUpEdit.Properties.DisplayMember = DisplayValue;
            return lookUpEdit;
        }
        //this method is For Convert GeorginDate to Shamsi Date
        public static string GeorgianToPersian(DateTime Date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar
                .GetYear(Date).ToString() + "/" + persianCalendar
                    .GetMonth(Date).ToString("00") + "/" + persianCalendar
                        .GetDayOfMonth(Date).ToString("00");
        }
        //this method is Encoding(Hashing) Password For Storing In data Base
        public static string EncodePasswordMd5(string pass)    
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;           
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(pass);
            encodedBytes = md5.ComputeHash(originalBytes);
          
            return BitConverter.ToString(encodedBytes);
        }
    }
}
