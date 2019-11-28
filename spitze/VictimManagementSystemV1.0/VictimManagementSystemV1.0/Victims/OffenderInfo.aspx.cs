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
    public partial class OffenderInfo : System.Web.UI.Page
    {
        string firstname,surname,dateofbt,gender,homeaddress,postcode,policerecordnumber,
            healthconcernsdrp,healthconcernstxt,accesstovehicle,placefrequentvisit,peopleassociate,

            familymembers,firarmwep,antiresp,policrisk,niaalerts;
        int OffenderkeyId,VictimkeyId,OffendSelectId;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["VictimId"]);
            VictimkeyId = Convert.ToInt32(Session["VictimId"]);
            OffendSelectId = Convert.ToInt32(Session["OffendSelectId"]);
            primarykey();
           
               
            
        
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void select()
        {
           
               
                string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
                string strSql = string.Format("select * from Offender where OffenderId='{0}'", OffendSelectId);
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter dadapter = new SqlDataAdapter();
                dadapter.SelectCommand = new SqlCommand(strSql, con);
                DataSet dset = new DataSet();
                dadapter.Fill(dset);
                int i = 0;
                Response.Write("This is the first number record" + dset.Tables[0].Rows.Count);
                TxtFirstName.Text = dset.Tables[0].Rows[i]["FirstName"].ToString();
                TxtSurname.Text = dset.Tables[0].Rows[i]["Surname"].ToString();
                TxtDateofBirth.Text = dset.Tables[0].Rows[i]["DateofBirth"].ToString();
                DrpGender.SelectedItem.Text = dset.Tables[0].Rows[i]["Gender"].ToString();
                TxtHomeAddress1.Text = dset.Tables[0].Rows[i]["HomeAddress"].ToString();
                TxtPostCode.Text = dset.Tables[0].Rows[i]["PostCode"].ToString();
                TxtPoliceRecordNumber.Text = dset.Tables[0].Rows[i]["PoliceRecordNumber"].ToString();
                DrpHealth.SelectedItem.Text = dset.Tables[0].Rows[i]["HealthConcerns"].ToString();
                TxtHealthConcerns.Text = dset.Tables[0].Rows[i]["HealthConcernsDetail"].ToString();
                TxtAccessVehicle.Text = dset.Tables[0].Rows[i]["AccessVehicle"].ToString();
                TxtPlacesFrequentVisit.Text = dset.Tables[0].Rows[i]["PlFrVisit"].ToString();
                TxtPpleAssociate.Text = dset.Tables[0].Rows[i]["PpleAssociate"].ToString();
                TxtFamilyMembers.Text = dset.Tables[0].Rows[i]["FamilyMembers"].ToString();
                TxtFirearm.Text = dset.Tables[0].Rows[i]["FireArm"].ToString();
                TxtAnticipatedResponse.Text = dset.Tables[0].Rows[i]["AntiRespAuthority"].ToString();
                TxtPoliceRisk.Text = dset.Tables[0].Rows[i]["PoliceRiskAssessment"].ToString();
                TxtNIA.Text = dset.Tables[0].Rows[i]["NIAAlerts"].ToString();
                con.Close();
            
        }
       
        protected void Edit_Click(object sender, EventArgs e)
        {
              
                firstname = TxtFirstName.Text;
                surname = TxtSurname.Text;
                dateofbt = TxtDateofBirth.Text;
                gender = DrpGender.SelectedItem.Text;
                homeaddress = TxtHomeAddress1.Text + TxtHomeAddress2.Text + TxtHomeAddress3.Text;
                postcode = TxtPostCode.Text;
                policerecordnumber = TxtPoliceRecordNumber.Text;
                healthconcernsdrp = DrpHealth.SelectedItem.Text;
                healthconcernstxt = TxtHealthConcerns.Text;
                accesstovehicle = TxtAccessVehicle.Text;
                placefrequentvisit = TxtPlacesFrequentVisit.Text;
                peopleassociate = TxtPpleAssociate.Text;
                familymembers = TxtFamilyMembers.Text;
                firarmwep = TxtFirearm.Text;
                antiresp = TxtAnticipatedResponse.Text;
                policrisk = TxtPoliceRisk.Text;
                niaalerts = TxtNIA.Text;
                Response.Write("This is value of offende select id" + OffendSelectId);
                string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
                SqlConnection sqlCn = new SqlConnection();
                sqlCn.ConnectionString = connectionString;
                sqlCn.Open();
                string sql = String.Format("Update Offender Set FirstName='{0}',Surname='{1}',DateofBirth='{2}',Gender='{3}',HomeAddress='{4}',PostCode='{5}',PoliceRecordNumber='{6}', HealthConcerns='{7}',HealthConcernsDetail='{8}',AccessVehicle='{9}',PlFrVisit='{10}',PpleAssociate='{11}',FamilyMembers='{12}',FireArm='{13}',AntiRespAuthority='{14}',PoliceRiskAssessment='{15}',NIAAlerts='{16}', VictimId='{18}' Where OffenderId='{17}'",
                  firstname, surname, dateofbt, gender, homeaddress, postcode, policerecordnumber, healthconcernsdrp, healthconcernstxt, accesstovehicle, placefrequentvisit, peopleassociate, familymembers, firarmwep, antiresp, policrisk, niaalerts, OffendSelectId, VictimkeyId);

                Response.Write(sql);
                using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
                {
                    cmd.ExecuteNonQuery();
                }
                sqlCn.Close();
                


        }
        public void primarykey()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = "select * from Offender";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
           
            OffenderkeyId = dset.Tables[0].Rows.Count;

            OffenderkeyId=OffenderkeyId+1;
            Response.Write("This is the number" + OffenderkeyId);
            con.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            
            
            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            dateofbt = TxtDateofBirth.Text;
            gender = DrpGender.SelectedItem.Text;
            homeaddress = TxtHomeAddress1.Text + TxtHomeAddress2.Text + TxtHomeAddress3.Text;
            postcode = TxtPostCode.Text;
            policerecordnumber = TxtPoliceRecordNumber.Text;
            healthconcernsdrp = DrpHealth.SelectedItem.Text;
            healthconcernstxt = TxtHealthConcerns.Text;
            accesstovehicle = TxtAccessVehicle.Text;
            placefrequentvisit = TxtPlacesFrequentVisit.Text;
            peopleassociate=TxtPpleAssociate.Text;
            familymembers = TxtFamilyMembers.Text;
            firarmwep = TxtFirearm.Text;
            antiresp = TxtAnticipatedResponse.Text;
            policrisk = TxtPoliceRisk.Text;
            niaalerts = TxtNIA.Text;

            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            string sql = string.Format("Insert Into Offender" + "(FirstName,Surname,DateofBirth,Gender,HomeAddress,PostCode,PoliceRecordNumber ,HealthConcerns, HealthConcernsDetail ,AccessVehicle ,PlFrVisit,PpleAssociate,FamilyMembers,FireArm,AntiRespAuthority,PoliceRiskAssessment,NIAAlerts,OffenderId,VictimId) Values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}')", firstname, surname, dateofbt, gender, homeaddress, postcode, policerecordnumber, healthconcernsdrp, healthconcernstxt, accesstovehicle, placefrequentvisit,peopleassociate, familymembers, firarmwep, antiresp, policrisk, niaalerts, OffenderkeyId,VictimkeyId);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
            sqlCn.Close();




            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Grid Clicked");
            OffendSelectId= Convert.ToInt32(GridView1.Rows[GridView1.SelectedRow.RowIndex].Cells[3].Text);
            Session["OffendSelectId"] = OffendSelectId;
            Response.Write(Session["OffendSelectId"]);
            select();
        }

        protected void Saveo_Click(object sender, EventArgs e)
        {

        }

        
    }
}