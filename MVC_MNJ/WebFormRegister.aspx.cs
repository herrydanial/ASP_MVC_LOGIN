using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MVC_MNJ
{
    public partial class WebFormRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Add_Click(object sender, EventArgs e)
        {
            SQL_command("INSERT INTO Table_Register (Name, Age, Address, Phone) "
                + "VALUES(" + "'" + TextBox_Name.Text + "' , '" + TextBox_Age.Text + "' , '" + TextBox_Address.Text + "' , '" + TextBox_Phone.Text + "')");
        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            SQL_command("UPDATE Table_Register SET Name = '" + TextBox_Name.Text + "', Age = '" + TextBox_Age.Text + "', Address = '" + TextBox_Address.Text + "', Phone = '" + TextBox_Phone.Text + "' WHERE Name = '" + TextBox_Name.Text + "'");
        }

        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            SQL_command("DELETE FROM Table_Register WHERE Name = '" + TextBox_Name.Text + "'");
        }

        private void SQL_command(string Command)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=CWJH63-01\SQLEXPRESS;Initial Catalog=LoginDBMNJ;Integrated Security=True";
            SqlCommand command = new SqlCommand(Command, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}