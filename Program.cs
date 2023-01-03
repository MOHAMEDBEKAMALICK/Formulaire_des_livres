using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }








        static string chaine = @"Data Source=localhost;Initial Catalog=BDGED_copy;Integrated Security=True";

        MySqlConnection MySQLConnection = new MySqlConnection();
        MySqlDataAdapter MySQLAdapter = new MySqlDataAdapter();
        String MySQLChaineConnection = "server=localhost; user id=root;password='MySQL' ;database=db_book";

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into table book_table(ID_book, Name_book) values('" + txtId_book.Text + "','" + txtName_book.Text + "', '" + txtAuthor_book.Text + "','" + txtPublication_date_book.Text + "', '" + txtPrice_book.Text + "');
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update table book_table set Name_book='" + txtName_book.Text + "' where ID_book='" + txtId_book.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from table book_table where ID_book='" + txtId_dossier.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from table book_table";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }
    }
}
