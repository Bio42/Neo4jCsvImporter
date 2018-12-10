using Neo4J_DataImporter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvImportNeo4j
{
    public partial class Form1 : Form
    {
        public static string user = "neo4j";
        public static string password = "password";
        public static string uri = @"bolt://localhost:7687";

        public static char FieldTerminator = ';';

        //private static readonly string CsvPath = @"C:\Users\Björn Fernkorn\Documents\Neo4j\K58_MFCS.csv";
        private static string CsvPath = @"E:\Programme\Neo4j\AppData\neo4jDatabases\database-bfe9406e-7a8b-4732-b1da-2e43001dcc1c\installation-3.4.9\import";
        private string UserSelectedPath;
        //private static readonly string CsvPathUNI = @"C:\Users\Björn\Documents\Projekt Graph DB\DATA\K58_MFCS.csv";

        public Form1()
        {
            InitializeComponent();
            CSV_Path_lbl.Text = CsvPath;
            RefreshFiles();
            tb_pw.Text = password;
            tb_Username.Text = user;
            tb_uri.Text = uri;
            lbl_status.Text = "";
        }

        private void RefreshFiles()
        {
            var files=Directory.GetFiles(CSV_Path_lbl.Text);
            foreach (var file in files)
            {
                var fi = new FileInfo(file);

                listView.Items.Add(fi.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Import button
            password = tb_pw.Text;
            user = tb_Username.Text;
            uri = tb_uri.Text;
            CsvPath = CSV_Path_lbl.Text;
            try
            {
                Auto();
                lbl_status.ForeColor = Color.Green;
                lbl_status.Text = "GREAT SUCCES";
            }
            catch (Exception ex)
            {
                log_tb.Text = ex.Message;
                lbl_status.ForeColor = Color.Red;
                lbl_status.Text = "ERROR see Log for details.";
            }
            
        }
        private static void Auto()
        {
            var Files = Directory.GetFiles(CsvPath);

            foreach (var file in Files)
            {
                List<string> Titles = ReadTitlesFromCsv(file);

                FileInfo f = new FileInfo(file);
                string cypherQuery = WriteCypherQuery(Titles, f.Name);
                ExcecuteQuery(cypherQuery);
            }
        }

        private static void ExcecuteQuery(string cypherQuery)
        {
            using (Neo4JConnector connector = new Neo4JConnector(uri, user, password))
            {
                connector.Ececute(cypherQuery);
            }
        }

        private static string WriteCypherQuery(List<string> titles, string fileName)
        {
            string query = "LOAD CSV with headers from \"file:///" + fileName + "\" as row FIELDTERMINATOR '" + FieldTerminator + "' Merge(batch: Batch { BatchId: row.BatchId}) ";
            query += "Merge(sample: Sample {SampleId: row.SampleID, BatchId: row.BatchId, SampleID: row.SampleID,";

            foreach (var item in titles)
            {
                if (item == "SampleId" || item == "BatchId")
                {
                    continue;
                }
                //query += "`" + item + "`:toFloat(row.`" + item + "`),";
                query += "`" + item + "`:row.`" + item + "`,";
            }
            query = query.TrimEnd(',');
            query += "}) ";
            query += "Merge(batch) -[rel1: CONTAINS]->(sample) Merge(sample) -[rel2: FROM]->(batch)";
            return query;
        }

        private static List<string> ReadTitlesFromCsv(string filePath)
        {
            var titles = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                foreach (string title in reader.ReadLine().Split(';'))
                {
                    titles.Add(title);
                }
            }
            return titles;
        }

        private void fbd_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.ShowDialog();
            if (fbd.SelectedPath != null)
            {
                UserSelectedPath = fbd.SelectedPath;
                CSV_Path_lbl.Text = UserSelectedPath;
                RefreshFiles();
            }
        }        
    }
}
