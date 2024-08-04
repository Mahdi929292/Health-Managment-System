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

namespace ProjectCSCI370
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=mahdi_pc;Initial Catalog=HealthDb;Integrated Security=True;Encrypt=False");
        private void FillName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT MName FROM PatientTb1", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName",typeof(string));
            dt.Load(rdr);
            Mname.ValueMember = "Mname";
            Mname.DataSource= dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
        private void show()
        {
            con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDVG.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Mname.Text == "" || Mamount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string payperiod = Pdate.Value.Month.ToString() + Pdate.Value.Year.ToString();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PPatient='" +
                Mname.SelectedValue.ToString() + "'and PMonth='" + payperiod + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid for this Month!");
                }
                else
                {
                    string query = "insert into PaymentTbl ([PMonth],[PPatient] ,[PAmount]) values ('" + payperiod + "','" +
                        Mname.SelectedValue.ToString()+ "', " + Mamount.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful!");
                }
                con.Close();
                show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mname.Text = "";
            Mamount.Text = "";

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            show();
        }
        int key = 1;
        private void PaymentDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            }
        }
    }

