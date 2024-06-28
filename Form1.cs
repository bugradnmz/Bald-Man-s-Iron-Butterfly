using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Access.Dao;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace bald_mans_iron_butterfly
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\iron_butterfly_db.accdb");
        OleDbCommand command;
        OleDbDataReader reader;

        int id;
        int islemMiktar;
        int toplamMiktar;
        string envanterYon;
        string stokKodu;
        string malzemeAdi;
        string notLokasyon;
        string tarihSaat;
        string kullanici;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            this.envanter_hareketTableAdapter.Fill(this.iron_butterfly_dbDataSet.envanter_hareket);
            this.demir_stokTableAdapter.Fill(this.iron_butterfly_dbDataSet.demir_stok);
        }

        //Uh-huh, this my shit. All the girls, stomp your feet like this.
        private void stokIsle_btn_Click(object sender, EventArgs e)
        {    
            try
            {
                id = demirCap_comboBox.SelectedIndex + 1;
                notLokasyon = not_txtBox.Text.ToString();
                islemMiktar = Convert.ToInt32(miktar_txtBox.Text);
                tarihSaat = DateTime.Now.ToString();
                kullanici = Environment.UserName.ToString();

                connection.Open();
                command = new OleDbCommand
                    ("SELECT stok_kodu, malzeme_adi, miktar " +
                    "FROM demir_stok " +
                    "WHERE id=" + id + "",
                    connection);
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    stokKodu = reader.GetString(0);
                    malzemeAdi = reader.GetString(1);
                    toplamMiktar = reader.GetInt32(2);
                }                

                if (giris_radioBtn.Checked)
                {
                    try
                    {
                        envanterYon = "GİRİŞ";                        
                        toplamMiktar += islemMiktar;

                        //STOK
                        ExecuteQuery
                            ("UPDATE demir_stok " +
                            "SET miktar = " + toplamMiktar + " " +
                            "WHERE id=" + id + "");

                        //ENVANTER HAREKET
                        ExecuteQuery
                            ("INSERT INTO envanter_hareket " +
                            "(stok_kodu, malzeme_adi, miktar, yon, not_lokasyon, tarih, kullanıcı) " +
                            "VALUES ('" + stokKodu + "','" + malzemeAdi + "'," + islemMiktar + ",'" + envanterYon + "','" +
                            notLokasyon + "','" + tarihSaat + "','" + kullanici +"')");

                        MessageBox.Show("Giriş başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetStuff();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (cikis_radioBtn.Checked)
                {
                    try
                    {
                        envanterYon = "ÇIKIŞ";
                        toplamMiktar -= islemMiktar;

                        //STOK
                        ExecuteQuery
                            ("UPDATE demir_stok " +
                             "SET miktar = " + toplamMiktar + " " +
                             "WHERE id=" + id + "");

                        //ENVANTER HAREKET
                        ExecuteQuery
                            ("INSERT INTO envanter_hareket " +
                            "(stok_kodu, malzeme_adi, miktar, yon, not_lokasyon, tarih, kullanıcı) " +
                            "VALUES ('" + stokKodu + "','" + malzemeAdi + "'," + islemMiktar + ",'" + envanterYon + "','" +
                            notLokasyon + "','" + tarihSaat + "','" + kullanici + "')");

                        MessageBox.Show("Çıkış başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetStuff();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Yön belirtiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.envanter_hareketTableAdapter.Fill(this.iron_butterfly_dbDataSet.envanter_hareket);
                this.demir_stokTableAdapter.Fill(this.iron_butterfly_dbDataSet.demir_stok);
                connection.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }            
        }

        private void github_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bugradnmz");
        }

        private void linkedin_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/bugradnmz/");
        }

        private void girisCikis_btn_Click(object sender, EventArgs e)
        {
            girisCikis_groupBox.Visible = true;
            hareket_groupBox.Visible = false;
            this.demir_stokTableAdapter.Fill(this.iron_butterfly_dbDataSet.demir_stok);
        }

        private void envanterHareket_btn_Click(object sender, EventArgs e)
        {
            girisCikis_groupBox.Visible = false;
            hareket_groupBox.Visible = true;
            this.envanter_hareketTableAdapter.Fill(this.iron_butterfly_dbDataSet.envanter_hareket);
        }

        private void stokYazdir_btn_Click(object sender, EventArgs e)
        {
            PrintDataTable(stok_dataGridView);
        }

        private void hareketYazdir_btn_Click(object sender, EventArgs e)
        {
            PrintDataTable(hareket_dataGridView);
        }

        void ResetStuff()
        {
            demirCap_comboBox.SelectedIndex = -1;
            miktar_txtBox.Clear();
            not_txtBox.Clear();
            giris_radioBtn.Checked = false;
            cikis_radioBtn.Checked = false;
        }

        void ExecuteQuery(string cmd)
        {
            command = new OleDbCommand(cmd, connection);
            command.ExecuteNonQuery();
        }

        //DATATABLE'I EXCEL'E YAZDIRIR VE BİÇİMLENDİRİR. //Interop.Excel için, Solution Explorer üzerinden New Reference (Başvuru) olarak Excel'i ekledim.
        void PrintDataTable(DataGridView dataGrid)
        {
            {
                Microsoft.Office.Interop.Excel.Application excel;
                Microsoft.Office.Interop.Excel.Workbook excelworkBook;
                Microsoft.Office.Interop.Excel.Worksheet excelSheet;
                Microsoft.Office.Interop.Excel.Range excelCellrange;

                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // Make Excel invisible and disable alerts.
                excel.Visible = true;
                excel.DisplayAlerts = false;

                // Create a new Workbook.
                excelworkBook = excel.Workbooks.Add(Type.Missing);

                // Create a Worksheet.
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                excelSheet.Name = "RAPOR";

                //Convert Grid to DataTable
                //Creating DataTable.
                System.Data.DataTable dataTable = new System.Data.DataTable();

                //Adding the Columns.
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows.
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    dataTable.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                //Export DataTable to Excel
                int rowcount = 0;
                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount++;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {
                        excelSheet.Cells[1, i] = dataTable.Columns[i - 1].ColumnName;

                        excelSheet.Cells[rowcount + 1, i] = datarow[i - 1].ToString();
                    }
                }

                // Format the columns
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount + 1, dataTable.Columns.Count]];
                excelCellrange.EntireColumn.AutoFit();
                excelCellrange.EntireColumn.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                excelCellrange.EntireColumn.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;
            }
        }        
    }
}
