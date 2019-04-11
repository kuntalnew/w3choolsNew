using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsNew.ExcelReader
{
    public class Literals
    {
        public static string ReadExcel(int row, int column, string sheetName)
        {
            FileStream fis = new FileStream(@"D:\SeleniumWithCSharp\VSScripts\W3SchoolsNew\W3SchoolsNew\project_literals.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fis);
            DataTable table = reader.AsDataSet().Tables[sheetName];
            return Convert.ToString(table.Rows[row][column]);
        }   
    }
}
