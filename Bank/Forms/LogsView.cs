using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank.Forms
{
    public partial class LogsView : Form
    {
        public string CardGUID { get; set; }
        public LogsView(string cardGUID)
        {
            InitializeComponent();
            this.CardGUID = cardGUID;
        }

        private void LogsView_Load(object sender, EventArgs e)
        {
            //Upon load get the logs from the DB and display them in GridView Control
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=../../Main.accdb;
            Persist Security Info=False;"))
            {
                connection.Open();
                //Get all the logs for this card and orders them by descending order
                OleDbCommand commandLogs = new OleDbCommand("Select Type,[Date],Amount from Logs where cardGUID=@1 ORDER BY [date] desc",connection);
                commandLogs.Parameters.AddWithValue("@1", this.CardGUID);               
                OleDbDataAdapter da = new OleDbDataAdapter(commandLogs);
                DataTable logs = new DataTable();
                da.Fill(logs);
                //Points that the source of data for the dataGridView is the datatable Logs
                dataGridView1.DataSource = logs;
            }
            
        }
    }
}
