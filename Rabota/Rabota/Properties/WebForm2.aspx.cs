using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rabota.Properties

{

    public partial class WebForm2 : System.Web.UI.Page
    {
        string connect = "server = localhost; database = Azat1; user = root; password =ruslan96;";
        MySqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            table1();
        }
        private DataTable show_db(string sql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connect))
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dt.Load(dr);
                    }
                }
                con.Close();
                return dt;
            }
        }

        private void doit(string sql)
        {
            using (MySqlConnection con = new MySqlConnection(connect))
            {
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void table1()
        {
            string sql = @"SELECT * FROM AZAT1.models";
            GridView1.DataSource = null;
            GridView1.DataSource = show_db(sql);
            GridView1.DataBind();

        }
        protected void RowDataBound(object sender, GridViewRowEventArgs e)

        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[3].Text == "not active")
                {
                    e.Row.ForeColor = System.Drawing.Color.Gray;
                }
                if (e.Row.Cells[2].Text == "not active")
                {
                    e.Row.ForeColor = System.Drawing.Color.Gray;
                }

            }
        }
     
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM AZAT1.models";
            GridView1.DataSource = null;
            GridView1.DataSource = show_db(sql);
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            {
                string sql = "INSERT INTO azat1.models (brandid, name, active) VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '"+ TextBox4.Text + "')";
                doit(sql);
                table1();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE azat1.models SET brandid='" + TextBox1.Text + "', name='" + TextBox2.Text + "',active='" +TextBox4.Text+ "' where id=" + TextBox3.Text + ";";
            doit(sql);
            table1();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM azat1.models WHERE ID = " + TextBox3.Text + ";";
            doit(sql);
            table1();
            TextBox3.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM  azat1.brand, azat1.models where models.brandid=brand.id;";
            GridView1.DataSource = null;
            GridView1.DataSource = show_db(sql);
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}