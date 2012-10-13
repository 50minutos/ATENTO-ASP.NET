using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _007_XDataAdapter
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Width < 480 || Height < 320)
            {
                Width = 480;
                Height = 320;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Admin\Desktop\AtentoASPNET\006-Dados\001-ADO.NET\App_Data\Db.mdf;Integrated Security=True;User Instance=True";

            var cmd = "SELECT * FROM PESSOA";

            da = new SqlDataAdapter(cmd, cs);
            
            ds = new DataSet();

            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(da);

            da.Update(ds);

            MessageBox.Show("Feito...");

            button2.PerformClick();
        }
    }
}
