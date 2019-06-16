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
    public partial class q1 : Form
    {
        public q1()
        {
            InitializeComponent();
        }
        DataSet ds = new System.Data.DataSet();
        BindingSource s = new BindingSource();
        private void q1_Load(object sender, EventArgs e)
        {
            ado.da.SelectCommand.CommandText = "select * from voiture ";
            ado.da.Fill(ds, "voiture");
            s.DataSource = ds.Tables["voiture"];
            textBox1.DataBindings.Add("Text", s, "matricile");
            textBox2.DataBindings.Add("Text", s, "model");
            textBox3.DataBindings.Add("Text", s, "prixlocation");
            comboBox1.DataBindings.Add("Text", s, "idmarque");
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder br = new SqlCommandBuilder(ado.da);
            s.EndEdit();
            ado.da.Update(ds,"voiture");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.RemoveCurrent();
        }
    }
}
