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
using System.Web;

namespace ProjectCSCI370
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=mahdi_pc;Initial Catalog=HealthDb;Integrated Security=True;Encrypt=False");

        private void button2_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Please Fill All Fields!");
            }
            else
            {
                con.Open();
                string qeury = "insert into PatientTb1 values('" + NameTb.Text + "','"
                    + PhoneTb.Text + "','" + Gendercb.SelectedItem.ToString() + "'," +
                      AgeTb.Text + "," + AmountTb.Text + ",'" + Timecb.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(qeury, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Successfully Added");
                con.Close();
                AmountTb.Text = "";
                AgeTb.Text = "";
                NameTb.Text = "";
                PhoneTb.Text = "";
                Gendercb.Text = "";
                Timecb.Text = "";
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            Gendercb.Text = "";
            Timecb.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Timecb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
