using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Excel = Microsoft.Office.Interop.Excel;

namespace UnitTestExample.selenium
{
    [TestFixture]
    class Execleread
    {
        Excel.Application xlapp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        Excel.Range xlr;

        [Test]
        public void Excelread1()
        {
            xlapp = new Excel.Application();
            xlWorkbook = xlapp.Workbooks.Open("C:/Users/CTEAMYSLP0027/Documents/Visual Studio 2015/Projects/UnitTestExample/UnitTestExample/testdata/calariecal.xlsx");
            xlWorksheet = xlWorkbook.Worksheets[1];
            xlr = xlWorksheet.UsedRange;
            int rowc = xlr.Rows.Count;
            int colc = xlr.Columns.Count;
            for(int row=1;row<rowc;row++)
            {
                for(int col=1;col<colc;col++)
                {
                    Console.Write("\t"+xlr.Cells[row,col].value2.ToString());
                }
                Console.WriteLine("\n");
            }
        }
    }
}
