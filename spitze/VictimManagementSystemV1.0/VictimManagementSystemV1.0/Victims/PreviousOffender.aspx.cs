using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace VictimManagementSystemV1._0.Victims
{
    public partial class PreviousOffender : System.Web.UI.Page
    {
        string firstname,surname,dateofbirth,gender,homeaddress,postcode,policerecordnumber;
        int VictimId,PreviousOffenderId,PreviousOffenderSelectId;
        protected void Page_Load(object sender, EventArgs e)
        {
            VictimId = Convert.ToInt32(Session["VictimId"]);
            Response.Write(VictimId);
            PreviousOffenderSelectId = Convert.ToInt32(Session["PreviousOffenderSelectId"]);
        }
        public void primarykey()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = "select * from PreviousOffender";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);

            PreviousOffenderId = dset.Tables[0].Rows.Count;

            PreviousOffenderId = PreviousOffenderId + 1;
            Response.Write("This is the number" + PreviousOffenderId);
            con.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            primarykey();
            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            dateofbirth = TxtDateofBirth.Text;
            gender = DrpGender.SelectedValue;
            homeaddress = TxtHomeAddress1.Text + TxtHomeAddress2.Text + TxtHomeAddress3.Text;
            postcode = TxtPostCode.Text;
            policerecordnumber = TxtPoliceRecordNumber.Text;
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            string sql = string.Format("Insert Into PreviousOffender" + "(FirstName,Surname,DateofBirth,Gender,HomeAddress, PostCode,PoliceRecordNumber, PreviousOffenderId, VictimId) Values" +
               "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", firstname, surname, dateofbirth, gender, homeaddress, postcode, policerecordnumber,PreviousOffenderId, VictimId);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
            sqlCn.Close();


            

        }
        public void select()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = string.Format("select * from PreviousOffender where PreviousOffenderId='{0}'", PreviousOffenderSelectId);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            int i = 0;
            TxtFirstName.Text=dset.Tables[0].Rows[i]["FirstName"].ToString();
            TxtSurname.Text = dset.Tables[0].Rows[i]["Surname"].ToString();
            TxtDateofBirth.Text = dset.Tables[0].Rows[i]["DateofBirth"].ToString();
            DrpGender.SelectedValue = dset.Tables[0].Rows[i]["Gender"].ToString();
            TxtHomeAddress1.Text = dset.Tables[0].Rows[i]["HomeAddress"].ToString();
            TxtPostCode.Text = dset.Tables[0].Rows[i]["PostCode"].ToString();
            TxtPoliceRecordNumber.Text = dset.Tables[0].Rows[i]["PoliceRecordNumber"].ToString();
            con.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviousOffenderSelectId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedRow.RowIndex].Cells[3].Text);
            Response.Write(PreviousOffenderSelectId);
            Session["PreviousOffenderSelectId"] = PreviousOffenderSelectId;
            select();      
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            dateofbirth = TxtDateofBirth.Text;
            gender = DrpGender.SelectedValue;
            homeaddress = TxtHomeAddress1.Text + TxtHomeAddress2.Text + TxtHomeAddress3.Text;
            postcode = TxtPostCode.Text;
            policerecordnumber = TxtPoliceRecordNumber.Text;
            Response.Write(PreviousOffenderSelectId);
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            string sql = String.Format("Update PreviousOffender Set FirstName='{0}',Surname='{1}',DateofBirth='{2}',Gender='{3}',HomeAddress='{4}',PostCode='{5}',PoliceRecordNumber='{6}',  VictimId='{8}' Where PreviousOffenderId='{7}'",
              firstname, surname, dateofbirth, gender, homeaddress, postcode, policerecordnumber, PreviousOffenderSelectId, VictimId);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
            sqlCn.Close();

        }
    }
}