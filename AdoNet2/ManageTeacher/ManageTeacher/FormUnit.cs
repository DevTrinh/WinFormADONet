using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ManageTeacher
{
    public partial class FormUnit : Form
    {
        public FormUnit()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        SqlCommand run;
        SqlDataReader read;
        string source = @"Data Source=TRINHMANHDIV;Initial Catalog=ManageTeacher;Integrated Security=True";
        string cmd = @"";
        private void FormUnit_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(source);
            cmd = @"SELECT        Code
            FROM            Basis";
            run = new SqlCommand(cmd,connect);
            connect.Open();
            read = run.ExecuteReader();
            while (read.Read())
            {
                comboBoxBasis.Items.Add(read[0].ToString()); 
            }
            connect.Close();
        }

      
    
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxCode.Text = textBoxName.Text + " - " + comboBoxBasis.Text;
        }
    }
}
