using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.IO;
using Microsoft.Office.Interop.Excel;
using NyilvLib.Entities;

namespace Nyilv
{
    public static class MyXlsImporter
    {
        public static void ImportAlapadatok(List<string> filepathces)
        {
            foreach (string file in filepathces)
            {
               Application xlApp = new Application();

                Workbook xlWorkbook = xlApp.Workbooks.Open(@file, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
                {
                    _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[i];

                    List<Alapadatok> adatok = new List<Alapadatok>();

                    int j = 0;
                    while( (string)(xlWorksheet.Cells[j,0] as Range).Value != "")
                    {
                        Alapadatok adat = new Alapadatok();
                        adat.CegID = Int32.Parse((string)(xlWorksheet.Cells[j, 0] as Range).Value);
                        adat.Szamlazas = (string)((xlWorksheet.Cells[j, 1] as Range).Value);
                        adat.Felelos = (string)((xlWorksheet.Cells[j, 2] as Range).Value);
                        adat.Cegnev = (string)((xlWorksheet.Cells[j, 3] as Range).Value);
                        adat.Ceg_forma = (string)((xlWorksheet.Cells[j, 4] as Range).Value);
                        adat.Hivatkozas = (string)((xlWorksheet.Cells[j, 5] as Range).Value);
                        adat.Felfuggesztett = ((string)((xlWorksheet.Cells[j, 4] as Range).Value) == "True") ? true : false;
                    }
                }
            }
        }

    }
}