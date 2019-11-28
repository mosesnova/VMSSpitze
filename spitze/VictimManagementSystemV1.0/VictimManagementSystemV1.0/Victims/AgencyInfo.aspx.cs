using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace VictimManagementSystemV1._0.Victims
{
    public partial class AgencyInfo : System.Web.UI.Page
    {
        string referraldate,referralagency,referralcontactperson,referraltelephone,referralfax,referralemail,
            otherdate,otheragency,othercontactperson,othertelephone,otherfax,otheremail;
        int agencyId,victimId,agencyselectId;
        protected void Page_Load(object sender, EventArgs e)
        {
            victimId = Convert.ToInt32(Session["VictimId"]);
            Response.Write(victimId);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        public void primarykey()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = "select * from Agency";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);

            agencyId = dset.Tables[0].Rows.Count;

            agencyId = agencyId + 1;
            Response.Write("This is the number" + agencyId);
            con.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            primarykey();
            referraldate = TxtReferralDate.Text;
            referralagency = TxtReferralAgency.Text;
            referralcontactperson = TxtReferralContactPerson.Text;
            referraltelephone = TxtReferralTelephone.Text;
            referralfax = TxtReferralFax.Text;
            referralemail = TxtReferralEmail.Text;
           
            otherdate = TxtOtherDate.Text;
            otheragency = TxtOtherAgency.Text;
            othercontactperson = TxtOtherContactPerson.Text;
            othertelephone= TxtOtherTelephone.Text;
            otherfax = TxtOtherFax.Text;
            otheremail = TxtOtherEmail.Text;

            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            string sql = string.Format("Insert Into Agency" + "(ReferralDate,ReferralAgency,ReferralContactPerson,ReferralTelephone, ReferralFax, ReferralEmail, OtherDate, OtherAgency ,OtherContactPerson, OtherTelephone , OtherFax , OtherEmail, AgencyId,VictimId) Values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", referraldate, referralagency, referralcontactperson, referraltelephone, referralfax, referralemail, otherdate, otheragency, othercontactperson,othertelephone ,otherfax , otheremail, agencyId, victimId);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
            sqlCn.Close();



        }
        public void select()
        {
        
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            agencyselectId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedRow.RowIndex].Cells[1].Text);
            Response.Write(agencyselectId);
            Session["AgencySelectId"] = agencyselectId;
            select();
        }
    }
}