using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace VictimManagementSystemV1._0.Victims
{
    public partial class Agency_Info : System.Web.UI.Page
    {
        private SqlConnection sqlCn = null;
        string date, agency, contactperson, telephone, fax, email;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = "select * from ReferralAgency";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            Response.Write(dset.Tables[0].Rows[0][0]);
            TxtDate.Text = dset.Tables[0].Rows[0][0].ToString();
            DrpAgency.Items.Add(dset.Tables[0].Rows[0][1].ToString());
            TxtContactPerson.Text = dset.Tables[0].Rows[0][2].ToString();
            TxtTelephone.Text = dset.Tables[0].Rows[0][3].ToString();
            TxtFax.Text = dset.Tables[0].Rows[0][4].ToString();
            TxtEmail.Text = dset.Tables[0].Rows[0][5].ToString();



            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            
            
            
            date=TxtDate.Text;
            agency = DrpAgency.SelectedItem.Text.ToString();
            contactperson = TxtContactPerson.Text;
            telephone = TxtTelephone.Text;
            fax = TxtFax.Text;
            email = TxtEmail.Text;
            Response.Write(date +agency + contactperson +telephone +fax+email);
           // Response.Write(agency);

           
            string sql = string.Format("Insert Into ReferralAgency" + "(Date,Agency,ContactPerson,Telephone,Fax,Email) Values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}')", date, agency, contactperson, telephone, fax, email);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
            
            
            //Insert(date, agency, contactperson, telephone, fax, email);
            sqlCn.Close();   
        }
        
        protected void Insert(string date, string agency, string contactperson, string telephone, string fax, string email)
        {
            string sql = string.Format("Insert Into ReferralAgency" + "(Date,Agency,ContactPerson,Telephone,Fax,Email) Values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}')", date, agency, contactperson, telephone, fax, email);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();



            date = TxtDate.Text;
            agency = DrpAgency.SelectedItem.Text.ToString();
            contactperson = TxtContactPerson.Text;
            telephone = TxtTelephone.Text;
            fax = TxtFax.Text;
            email = TxtEmail.Text;
            Response.Write(date + agency + contactperson + telephone + fax + email);
            // Response.Write(agency);


            string sql = string.Format("Update ReferralAgency Set Date='{0}',Agency='{1}',ContactPerson='{2}',Telephone='{3}',Fax='{4}',Email='{5}'",
                 date, agency, contactperson, telephone, fax, email);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }


            //Insert(date, agency, contactperson, telephone, fax, email);
            sqlCn.Close();   

        }
    }
}