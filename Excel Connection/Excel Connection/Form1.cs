using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel_Connection.Excel;
using Microsoft.Office.Interop.Excel;

namespace Excel_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_Write_Click(object sender, EventArgs e)
        {
          /*  WriteExcel excel = new WriteExcel(@"C:\\Users\\thaka\\Desktop\\C# Projects\\Book1.xlsx", 1);
          
            MessageBox.Show(excel.ReadCell(0,0));*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteData();
        }

        public void WriteData()
        {
            WriteExcel excel = new WriteExcel(@"C:\\Users\\thaka\\Desktop\\C# Projects\\Book2.xlsx", 1);
            excel.WriteCell(5, 1, "1000 Degree Pizza");
            excel.Save();
            excel.SaveAs(@"C:\\Users\\thaka\\Desktop\\C# Projects\\Book1.xlsx");

            excel.Close();
        }
    }
}
