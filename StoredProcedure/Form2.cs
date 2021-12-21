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

namespace StoredProcedure
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABD7H3A;Initial Catalog=kantinAmikom;Integrated Security=True");

        //Automated transactions
        private string notrans
        {
            get
            {
                con.Open();
                string nomor = "TR-001";
                SqlCommand cmd = new SqlCommand("select max(right(idTransaksi,4)) from transaksi", con);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd[0].ToString() != "")
                    nomor = "TR-" + (int.Parse(rd[0].ToString()) + 1).ToString("0000");
                rd.Close();
                return nomor;
            }


        }

        private void isicombo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT namaMenu from menu";
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds1, "menu");
            cbomenu.DataSource = ds1.Tables["menu"];
            cbomenu.DisplayMember = "namaMenu";   
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            storeProcedure gila = new storeProcedure();
            gila.ShowDialog();
        }

            private void resetdata()
        {
            con.Close();
            txtno.Text = notrans;
            txtidcust.Text = "";
            cbomenu.Text = "";
            txtharga.Text = "";
            txtidmenu.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();

            txtharga.ReadOnly = true;
            txtidmenu.ReadOnly = true;

            txtno.Text = notrans;
            isicombo();
            txttgl.Text = DateTime.Now.ToString("dd/MM/yyyy");
           
        }

        private void cbomenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM menu WHERE namaMenu = '" + cbomenu.Text + "'", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtidmenu.Text = rd[0].ToString();
                txtharga.Text = rd[2].ToString();
                rd.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtharga.Text == "")
            {
                MessageBox.Show("harga harus diisi");
                goto berhenti;
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSER INTO transaksi values('" + txtno.Text + "','" + txttgl.Text + "','" + txtidcust.Text + "','" + txtharga.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = "INSERT INTO detailTransaksi values('" + txtno.Text + "', '" + txtidmenu.Text + "')";
            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            resetdata();
            txtidcust.Focus();

        berhenti:
            ;
        }
    }
}
