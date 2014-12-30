using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using DomainModel;

namespace AcupunturaExcel
{
    public class ExcelHandler
    {
        public static List<Sintoma> readSintomasFromExcel(string path)
        {

            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet excelWorkSheet = excelWorkBook.Worksheets.get_Item("Lista de Sintomas");

            List<Sintoma> _listaSintomas = new List<Sintoma>();
            Sintoma s = null;
            string nome = "";
            int count = 1;

            do
            {
                nome = excelWorkSheet.Cells[count, 1].Value;
                count++;
                s = new Sintoma(nome);
                _listaSintomas.Add(s);

            } while (excelWorkSheet.Cells[count, 1].Value != null);

            excelWorkBook.Close();
            excelApplication.Quit();
            return _listaSintomas;

        }

        public static List<Diagnostico> readDiagnosticosFromExcel(string path)
        {

            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;
            Excel.Workbook excelWorkBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet excelWorkSheet = excelWorkBook.Worksheets.get_Item("Diagnósticos e Tratamentos");

            List<Diagnostico> _listaDiagnosticos = new List<Diagnostico>();
            Diagnostico d = null;
            int count = 2;

            do
            {
                string orgao = excelWorkSheet.Cells[count, 1].Value;
                string nome = excelWorkSheet.Cells[count, 2].Value;
                string descricao = excelWorkSheet.Cells[count, 3].Value;
                string tratamento = excelWorkSheet.Cells[count, 4].Value;

                List<Sintoma> _listaSintomas = new List<Sintoma>();
                int countSintomas = 5;

                do
                {
                    Sintoma sintoma = new Sintoma(excelWorkSheet.Cells[count, countSintomas].Value);
                    _listaSintomas.Add(sintoma);
                    countSintomas++;
                } while (excelWorkSheet.Cells[count, countSintomas].Value != null);

                count++;
                d = new Diagnostico(orgao, nome, descricao, tratamento, _listaSintomas);
                _listaDiagnosticos.Add(d);

            } while (excelWorkSheet.Cells[count, 1].Value != null);

            excelWorkBook.Close();
            excelApplication.Quit();
            return _listaDiagnosticos;
        }
    }
}
