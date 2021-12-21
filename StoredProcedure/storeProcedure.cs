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
    public partial class storeProcedure : Form
    {
        public storeProcedure()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ABD7H3A;Initial Catalog=kantinAmikom;Integrated Security=True");

        private void showdata()
        {
            SqlCommand asu = new SqlCommand();
            asu.Connection = con;
            asu.CommandType = CommandType.Text;
            asu.CommandText = "select * from menu";
            DataSet kirik = new DataSet();
            SqlDataAdapter segawon = new SqlDataAdapter(asu);
            segawon.Fill(kirik, "menu");
            dataku.DataSource = kirik;
            dataku.DataMember = "menu";
            dataku.ReadOnly = true;
        }

        private void resetdata()
        {
            txtid.Text = "";
            txtmenu.Text = "";
            txtharga.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showdata();
            resetdata();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel1.Text = Environment.MachineName.ToString();
        }

        private void masukin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand butuk = new SqlCommand();
            butuk.Connection = con;
            butuk.CommandText = "ADDMENU";
            butuk.CommandType = CommandType.StoredProcedure;

            //Creating sql parameter with same variable name in SQL
            //Stored procedure guess create
            SqlParameter idMenu = new SqlParameter("@id",SqlDbType.VarChar);
            SqlParameter namaMenu = new SqlParameter("@nama",SqlDbType.VarChar);
            SqlParameter harga = new SqlParameter("@harga",SqlDbType.VarChar);

            //Fill in the sql parameter variable earlier
            //with the value that we have input from the box
            idMenu.Value = txtid.Text;
            namaMenu.Value = txtmenu.Text;
            harga.Value = txtharga.Text;

            //Then add the paramater that we made
            //earlier into the existing command
            butuk.Parameters.Add(idMenu);
            butuk.Parameters.Add(namaMenu);
            butuk.Parameters.Add(harga);

            //run storedProcedure
            butuk.ExecuteNonQuery();

            con.Close();
            showdata();
            resetdata();
        }

        private void busek_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand kirik = new SqlCommand();
            kirik.Connection = con;
            kirik.CommandText = "DELMENU";
            kirik.CommandType = CommandType.StoredProcedure;

            SqlParameter idMenu = new SqlParameter("@id",SqlDbType.VarChar);

            idMenu.Value = txtid.Text;
            kirik.Parameters.Add(idMenu);
            kirik.ExecuteNonQuery();
            con.Close();
            showdata();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 asu = new Form2();
            asu.ShowDialog();
            this.Close();
        }
    }
}
