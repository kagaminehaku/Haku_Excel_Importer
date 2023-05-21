using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;


namespace Haku_Excel_Importer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string filePath;
        private List<string> dataColumn1;
        private List<string> dataColumn2;
        private List<string> dataColumn3;
        private void selectfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Excel File";
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                MessageBox.Show("File selected: " + filePath);
            }
        }

        private void adddata_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please select an Excel file first.");
                return;
            }

            // Read the Excel file
            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                //ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // Assuming you want to read the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];

                // Get the data from the columns
                int rowCount = worksheet.Dimension.Rows;
                dataColumn1 = new List<string>();
                dataColumn2 = new List<string>();
                dataColumn3 = new List<string>();
                for (int row = 2; row <= rowCount; row++) // Assuming data starts from the second row
                {
                    string value1 = worksheet.Cells[row, 1].Value?.ToString(); // Assuming the name is in column 1
                    string value2 = worksheet.Cells[row, 2].Value?.ToString(); // Assuming the bday is in column 2
                    string value3 = worksheet.Cells[row, 3].Value?.ToString(); // Assuming the gender is in column 3
                    dataColumn1.Add(value1);
                    dataColumn2.Add(value2);
                    dataColumn3.Add(value3);
                }
                // Insert the data into the database
                try
                {
                    SqlConnection connection = new SqlConnection("Data Source=HATSUNEMIKUPOCK;Initial Catalog=sinhvien;Integrated Security=True");
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [profile] (name, bday, gender) VALUES (@Value1, @Value2, @Value3)", connection);
                    for (int i = 0; i < dataColumn1.Count; i++)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Value1", dataColumn1[i]);
                        command.Parameters.AddWithValue("@Value2", dataColumn2[i]);
                        command.Parameters.AddWithValue("@Value3", dataColumn3[i]);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    }
}
