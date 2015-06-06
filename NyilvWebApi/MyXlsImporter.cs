﻿using System;
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
        static List<alapadatok> importAlapadatokResult;
        static List<cegadatok> importCegadatokResult;
        static List<dokumentumok> importDokumentumokResult;
        public static List<alapadatok> ImportAlapadatokResult { get { return importAlapadatokResult; } }
        public static List<cegadatok> ImportCegadatokResult { get { return importCegadatokResult; } }
        public static List<dokumentumok> ImportDokumentumokResult { get { return importDokumentumokResult; } }
        public static void ImportCeg(List<string> filepath)
        {
            List<alapadatok> importedAlapadatokItems = new List<alapadatok>();
            List<cegadatok> importedCegadatokItems = new List<cegadatok>();

            foreach (string file in filepath)
            {
               Application xlApp = new Application();

                Workbook xlWorkbook = xlApp.Workbooks.Open(@file, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
                {
                    _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[i];

                    int j = 1;

                    while (((xlWorksheet.Cells[j, 1]) as Range).Value != null)
                    {
                        alapadatok adat = new alapadatok();
                        adat.CegID = Int32.Parse(((xlWorksheet.Cells[j, 1] as Range).Value).ToString());
                        adat.Szamlazas = ((xlWorksheet.Cells[j, 2] as Range).Value).ToString();
                        adat.Felelos = ((xlWorksheet.Cells[j, 3] as Range).Value).ToString();
                        adat.Cegnev = ((xlWorksheet.Cells[j, 4] as Range).Value).ToString();
                        adat.Ceg_forma = ((xlWorksheet.Cells[j, 5] as Range).Value).ToString();
                        adat.Hivatkozas = ((xlWorksheet.Cells[j, 6] as Range).Value).ToString();
                        if (((xlWorksheet.Cells[j, 7] as Range).Value).ToString() == "True")
                        {
                            adat.Felfuggesztett = true;
                        }
                        else
                        {
                            adat.Felfuggesztett = false;
                        }
                        importedAlapadatokItems.Add(adat);

                        cegadatok ceg = new cegadatok();

                        ceg.CegID = adat.CegID;
                        ceg.Ceg_teljes_nev = ((xlWorksheet.Cells[j, 8] as Range).Value).ToString();
                        ceg.Email = ((xlWorksheet.Cells[j, 9] as Range).Value).ToString();
                        ceg.Telefon = ((xlWorksheet.Cells[j, 10] as Range).Value).ToString();
                        ceg.Telephely = ((xlWorksheet.Cells[j, 11] as Range).Value).ToString();
                        ceg.Tarifa = Int32.Parse(((xlWorksheet.Cells[j, 12] as Range).Value).ToString());
                        importedCegadatokItems.Add(ceg);

                        j++;
                    }
                }
            }
            importAlapadatokResult = importedAlapadatokItems;
            importCegadatokResult = importedCegadatokItems;
        }
        public static void ImportDokumentum(List<string> filepathces)
        {
            List<dokumentumok> importedDokumentumokItems = new List<dokumentumok>();

            foreach (string file in filepathces)
            {
                Application xlApp = new Application();

                Workbook xlWorkbook = xlApp.Workbooks.Open(@file, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                for (int i = 1; i <= xlWorkbook.Sheets.Count; i++)
                {
                    _Worksheet xlWorksheet = (_Worksheet)xlWorkbook.Sheets[i];


                    int j = 1;

                    while (((xlWorksheet.Cells[j, 1]) as Range).Value != null)
                    {
                        dokumentumok adat = new dokumentumok();
                        adat.CegID = Int32.Parse(((xlWorksheet.Cells[j, 1] as Range).Value).ToString());
                        adat.DokumentumID = Int32.Parse(((xlWorksheet.Cells[j, 2] as Range).Value).ToString());
                        adat.Dokumentum_tipus = ((xlWorksheet.Cells[j, 3] as Range).Value).ToString();
                        adat.Datum = DateTime.Parse(((xlWorksheet.Cells[j, 4] as Range).Value).ToString());
                        adat.Megjegyzes = ((xlWorksheet.Cells[j, 5] as Range).Value).ToString();

                        importedDokumentumokItems.Add(adat);

                        j++;
                    }
                }
            }
            importDokumentumokResult = importedDokumentumokItems;

        }
    }
}