using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication30
{
    public partial class q4_b : Form
    {
        
        public q4_b()
        {
            InitializeComponent();
        }

        private void q4_b_Load(object sender, EventArgs e)
        {
            ado.cmd.CommandText = "select * from locations";
            ado.cnx.Open();
            SqlDataReader dr = ado.cmd.ExecuteReader();
            DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            ado.cnx.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int idl = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
               ado.da.SelectCommand.CommandText = string.Format("select v.* from locations l inner join voiture v on l.matricile = v.matricile"); 
                    DataTable dt = new System.Data.DataTable();
                ado.da.Fill(dt);
                dataGridView2.DataSource = dt;
                  
                
            }
        }
    }
}
