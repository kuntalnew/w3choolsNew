using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using ExcelDataReader;
using System.Data;

namespace W3SchoolsNew
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                FileStream fis = new FileStream(@".\project_literals.xlsx", FileMode.Open, FileAccess.Read);
                IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fis);
                DataTable table = reader.AsDataSet().Tables["Url_links"];
                //string contents;
                //contents = Convert.ToString(table.Rows[1][0]);
                Console.WriteLine(table.Rows[1][0]);

        }
    }
}
