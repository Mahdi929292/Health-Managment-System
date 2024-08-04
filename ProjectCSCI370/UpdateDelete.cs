using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCSCI370
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=mahdi_pc;Initial Catalog=HealthDb;Integrated Security=True;Encrypt=False");
        private void show()
        {
            con.Open();
            string query = "select * from PatientTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDVG.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Mname.Text == "" || Pnumber.Text == "" || Age.Text == ""
                || Pamount.Text == "" || Gender.Text == "" || Time.Text == "")
            {
                MessageBox.Show("Please Choose the Patient to change");
            }
            else
            {
                con.Open();
                string query = "update PatientTb1 set MName='" + Mname.Text + "',MPhone='"
                    + Pnumber.Text + "',MGen='" + Gender.Text + "',MAge=" + Age.Text + ",MAmount=" + Pamount.Text +
                    ",MTime='" + Time.Text + "'where MId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful!");
                con.Close();
                show();
            }
            Mname.Text = "";
            Age.Text = "";
            Pnumber.Text = "";
            Gender.Text = "";
            Time.Text = "";
            Pamount.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            show();
        }
        int key = 0;

        private void Mname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mname.Text = "";
            Age.Text = "";
            Pnumber.Text = "";
            Gender.Text = "";
            Time.Text = "";
            Pamount.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please Choose the Patient to delete");
            }
            else
            {
                con.Open();
                string query = "delete from PatientTb1 where MId=" + key + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful!");
                con.Close();
                show();
            }
            Mname.Text = "";
            Age.Text = "";
            Pnumber.Text = "";
            Gender.Text = "";
            Time.Text = "";
            Pamount.Text = "";
        }

        private void MemberSDVG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < MemberSDVG.Rows.Count)
            {
                DataGridViewRow row = MemberSDVG.Rows[e.RowIndex];
                key = Convert.ToInt32(row.Cells[0].Value?.ToString());
                Mname.Text = row.Cells[1].Value?.ToString();
                Pnumber.Text = row.Cells[2].Value?.ToString();
                Gender.Text = row.Cells[3].Value?.ToString();
                Age.Text = row.Cells[4].Value?.ToString();
                Pamount.Text = row.Cells[5].Value?.ToString();
                Time.Text = row.Cells[6].Value?.ToString();
            }
        }

    }
}
