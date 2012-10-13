using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _008_DataSetXml
{
    public partial class Form1 : Form
    {
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXml("Agenda.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.WriteXml("Agenda.xml");
            MessageBox.Show("Pronto...");
        }
    }
}
