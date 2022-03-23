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
    public partial class FormBasis1 : Form
    {
        public FormBasis1()
        {
            InitializeComponent();
        }

        SqlConnection connect;
        SqlCommand run;
        SqlDataReader read;
        string source = @"Data Source=TRINHMANHDIV;Initial Catalog=ManageTeacher;Integrated Security=True";
        string cmd = @"";
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //ktra trùng mã
            cmd = @"SELECT Code FROM Basis";
            run = new SqlCommand(cmd, connect);
            connect.Open();
            read = run.ExecuteReader();
            int j = 0;
            while (read.Read())
            {
                if (textBoxCode.Text == read[0].ToString())
                {
                    j = 1;
                }   
                
            }   
            connect.Close();
            //thêm
            if(j == 1)
            {
                DialogResult result = MessageBox.Show("Bạn vừa nhập trùng mã cơ sở ?", "Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                cmd = @"INSERT INTO Basis
                                       (Code, Name, Contact, Address, Note)
                         VALUES        (@Code,@Name,@Contact,@Address,@Note)";
                //connect = new SqlConnection(source); không cần khởi tạo do trước đó đã chạy tại formload
                run = new SqlCommand(cmd, connect);
                run.Parameters.Add("@Code", SqlDbType.NVarChar);
                run.Parameters.Add("@Name", SqlDbType.NVarChar);
                run.Parameters.Add("@Contact", SqlDbType.NVarChar);
                run.Parameters.Add("@Address", SqlDbType.NVarChar);
                run.Parameters.Add("@Note", SqlDbType.NVarChar);
                //dua du lieu vao trong cac Parameters
                run.Parameters["@Code"].Value = textBoxCode.Text;
                run.Parameters["@Name"].Value = textBoxName.Text;
                run.Parameters["@Contact"].Value = textBoxContact.Text;
                run.Parameters["@Address"].Value = textBoxAddress.Text;
                run.Parameters["@Note"].Value = textBoxNote.Text;
                connect.Open();
                run.ExecuteNonQuery();
                connect.Close();
                display();
            }
        }
        void display()
        {
            cmd = @"SELECT * FROM Basis";
            run = new SqlCommand(cmd, connect);
            connect.Open();
            read = run.ExecuteReader();
            int i = 0;
            dataGridView.Rows.Clear();
            while (read.Read())
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = read[0].ToString();
                dataGridView.Rows[i].Cells[1].Value = read[1].ToString();
                dataGridView.Rows[i].Cells[2].Value = read[2].ToString();
                dataGridView.Rows[i].Cells[3].Value = read[3].ToString();
                dataGridView.Rows[i].Cells[4].Value = read[4].ToString();
                i++;
            }
            connect.Close();
        }
        private void FormBasis1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(source);
            display();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Bạn có muốn xóa nhân viên mã {dataGridView.CurrentRow.Cells[0].Value.ToString()}", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                cmd = @"DELETE FROM Basis
                        WHERE        (Code = @Original_Code)";
                run = new SqlCommand(cmd, connect);
                run.Parameters.Add("@Code", SqlDbType.NVarChar);
                run.Parameters.Add("@Name", SqlDbType.NVarChar);
                run.Parameters.Add("@Contact", SqlDbType.NVarChar);
                run.Parameters.Add("@Address", SqlDbType.NVarChar);
                run.Parameters.Add("@Note", SqlDbType.NVarChar);
                run.Parameters.Add("@Original_Code", SqlDbType.NVarChar);
                //dua du lieu vao trong cac Parameters
                run.Parameters["@Code"].Value = textBoxCode.Text;
                run.Parameters["@Name"].Value = textBoxName.Text;
                run.Parameters["@Contact"].Value = textBoxContact.Text;
                run.Parameters["@Address"].Value = textBoxAddress.Text;
                run.Parameters["@Note"].Value = textBoxNote.Text;
                run.Parameters["@Original_Code"].Value = dataGridView.CurrentRow.Cells[0].Value.ToString();
                connect.Open();
                run.ExecuteNonQuery();
                connect.Close();
                display();
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCode.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxContact.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            textBoxNote.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            cmd = @"UPDATE       Basis
                    SET                Code = @Code, Name = @Name, Contact = @Contact, Address = @Address, Note = @Note
                    WHERE        (Code = @Original_Code)";
            //connect = new SqlConnection(source); không cần khởi tạo do trước đó đã chạy tại formload
            run = new SqlCommand(cmd, connect);
            run.Parameters.Add("@Code", SqlDbType.NVarChar);
            run.Parameters.Add("@Name", SqlDbType.NVarChar);
            run.Parameters.Add("@Contact", SqlDbType.NVarChar);
            run.Parameters.Add("@Address", SqlDbType.NVarChar);
            run.Parameters.Add("@Note", SqlDbType.NVarChar);
            run.Parameters.Add("@Original_Code", SqlDbType.NVarChar);
            //dua du lieu vao trong cac Parameters
            run.Parameters["@Code"].Value = textBoxCode.Text;
            run.Parameters["@Name"].Value = textBoxName.Text;
            run.Parameters["@Contact"].Value = textBoxContact.Text;
            run.Parameters["@Address"].Value = textBoxAddress.Text;
            run.Parameters["@Note"].Value = textBoxNote.Text;
            run.Parameters["@Original_Code"].Value = dataGridView.CurrentRow.Cells[0].Value.ToString();
            connect.Open();
            run.ExecuteNonQuery();
            connect.Close();
            display();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
