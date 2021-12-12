using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Store Project;User Id=postgres;Password=postgres");

        public Form1()
        {
            InitializeComponent();
            initialize();

            
        }




        public void initialize()
        {

            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from employees";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }

            comm.CommandText = "select * from customers";

            dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }

            comm.CommandText = "select * from products";
            dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;
            }

            comm.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int index = row.Index;

            string idtodel = dataGridView1.Rows[index].Cells[0].Value.ToString();




            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from employees where employeeid=" + idtodel;
            NpgsqlDataReader dr = comm.ExecuteReader();

            conn.Close();

            initialize();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            int index = row.Index;

            string idtodel = dataGridView2.Rows[index].Cells[0].Value.ToString();




            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from customers where customerid=" + idtodel;
            NpgsqlDataReader dr = comm.ExecuteReader();
            conn.Close();
            initialize();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.CurrentRow;
            int index = row.Index;

            string idtodel = dataGridView3.Rows[index].Cells[0].Value.ToString();



            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from products where productid=" + idtodel;
            NpgsqlDataReader dr = comm.ExecuteReader();
            conn.Close();
            initialize();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from employees order by employeeid";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if(dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from employees order by fname";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from employees order by lname";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from employees order by title";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from customers order by customerid";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from customers order by fname";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from customers order by lname";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from products order by productid";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;
            }
            conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from products order by name";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;
            }
            conn.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from products order by aisle";
            NpgsqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView3.DataSource = dt;
            }
            conn.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.Parameters.AddWithValue("a", Convert.ToInt32(textBox1.Text));
            comm.Parameters.AddWithValue("b", textBox2.Text);
            comm.Parameters.AddWithValue("c", textBox3.Text);
            comm.Parameters.AddWithValue("d", Convert.ToDouble(textBox4.Text));
            comm.Parameters.AddWithValue("e", textBox5.Text);

            comm.CommandText = "insert into employees (employeeid, fname, lname, wage, title) values (@a, @b, @c, @d, @e)"  ;
            NpgsqlDataReader dr = comm.ExecuteReader();
            conn.Close();
            initialize();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.Parameters.AddWithValue("a", Convert.ToInt32(textBox6.Text));
            comm.Parameters.AddWithValue("b", textBox7.Text);
            comm.Parameters.AddWithValue("c", textBox8.Text);
            comm.Parameters.AddWithValue("d", textBox9.Text);
            

            comm.CommandText = "insert into customers (customerid, fname, lname, address) values (@a, @b, @c, @d)";
            NpgsqlDataReader dr = comm.ExecuteReader();
            conn.Close();
            initialize();

            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try { conn.Open(); }
            catch { }
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.Parameters.AddWithValue("a", Convert.ToInt32(textBox10.Text));
            comm.Parameters.AddWithValue("b", textBox11.Text);
            comm.Parameters.AddWithValue("c", Convert.ToDouble(textBox12.Text));
            comm.Parameters.AddWithValue("d", Convert.ToInt32(textBox13.Text));
            comm.Parameters.AddWithValue("e", Convert.ToInt32(textBox14.Text));

            comm.CommandText = "insert into products (productid, name, price, ammount, aisle) values (@a, @b, @c, @d, @e)";
            NpgsqlDataReader dr = comm.ExecuteReader();
            conn.Close();
            initialize();

            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
        }
    }
}
