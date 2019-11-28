using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace VictimManagementSystemV1._0.Victims
{
       
    public partial class VictimInfo : System.Web.UI.Page
    {
        private SqlConnection con = null;
        string firstname, surname, date, homeaddress, homephone, workphone, mobilephone, ethinicity, iwi, gender,
           occupation, placeofwork, postcode, immigrationstatus, fstvictim;
        int policerecordnumber, victimId;
        int primarykeyId;
        int sessionVictimId;
        protected void Page_Load(object sender, EventArgs e)
        {
            sessionVictimId = Convert.ToInt32(Session["VictimId"]);
            
            Response.Write(sessionVictimId);
            if (!this.IsPostBack)
            {
                if (sessionVictimId != 0)
                {
                    

                }
                else
                {
                    clearForm();
                }
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TxtHomePhone_TextChanged(object sender, EventArgs e)
        {

        }
        public void select()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = string.Format("select * from Victim where VictimId='{0}'", sessionVictimId);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            //for (int i = 0; i < dset.Tables[0].Rows.Count; i++)
            int i = 0;
            Response.Write("This is the first number record" + dset.Tables[0].Rows.Count);
            TxtFirstName.Text = dset.Tables[0].Rows[i]["FirstName"].ToString();
            TxtSurname.Text = dset.Tables[0].Rows[i]["Surname"].ToString();
            TxtDateofBirth.Text = dset.Tables[0].Rows[i]["DateofBirth"].ToString();
            TxtHomeAddress1.Text = dset.Tables[0].Rows[i]["HomeAddress"].ToString();
            TxtPostCode.Text = dset.Tables[0].Rows[i]["PostCode"].ToString();
            TxtHomePhone.Text = dset.Tables[0].Rows[i]["HomePhone"].ToString();
            TxtMobilePhone.Text = dset.Tables[0].Rows[i]["MobilePhone"].ToString();
            TxtOccupation.Text = dset.Tables[0].Rows[i]["Occupation"].ToString();
            TxtPlaceofWork.Text = dset.Tables[0].Rows[i]["PlaceofWork"].ToString();
            TxtWrkPhone.Text = dset.Tables[0].Rows[i]["WorkPhone"].ToString();
            victimId = Convert.ToInt32(dset.Tables[0].Rows[i]["VictimId"].ToString());
            policerecordnumber = Convert.ToInt32(dset.Tables[0].Rows[i]["PoliceRecordNumber"].ToString());
            TxtPoliceRecord.Text = policerecordnumber.ToString();
            VictimIdLbl.Text = victimId.ToString();
            drpImmigrationstatus.SelectedValue = dset.Tables[0].Rows[i]["ImmigrationStatus"].ToString();
            DrpGender.SelectedValue = dset.Tables[0].Rows[i]["Gender"].ToString();
            DrpEthinicity.SelectedValue = dset.Tables[0].Rows[i]["Ethinicity"].ToString();
            DrpIwi.SelectedItem.Text = dset.Tables[0].Rows[i]["Iwi"].ToString();
            ChkFST.Checked = Convert.ToBoolean(dset.Tables[0].Rows[i]["FSTVictim"].ToString());



            //Response.Write(victimId);
            //Response.Write(policerecordnumber);
            con.Close();
        }
        public void clearForm()
        {
            TxtFirstName.Text = "";
            TxtSurname.Text = "";
            TxtDateofBirth.Text = "";
            TxtHomeAddress1.Text = "";
            TxtHomeAddress2.Text = "";
            TxtHomeAddress3.Text = "";
            TxtHomePhone.Text = "";
            TxtMobilePhone.Text = "";
            TxtOccupation.Text = "";
            TxtPlaceofWork.Text = "";
            TxtPoliceRecord.Text = "";
            TxtPostCode.Text = "";
            TxtWrkPhone.Text = "";
        }
        public void primarykey()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = "select * from Victim";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            //for (int i = 0; i < dset.Tables[0].Rows.Count; i++)
            //int i = 0;
            
            primarykeyId = dset.Tables[0].Rows.Count;
           
            primarykeyId++;
            Response.Write("This is the number" + primarykeyId);
            con.Close();
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            primarykey();
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();

            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            date = TxtDateofBirth.Text;
            homeaddress = TxtHomeAddress1.Text + TxtHomeAddress2.Text + TxtHomeAddress3.Text;
            workphone = TxtWrkPhone.Text;
            homephone = TxtHomePhone.Text;
            mobilephone = TxtMobilePhone.Text;
            occupation = TxtOccupation.Text;
            placeofwork = TxtPlaceofWork.Text;
            postcode = TxtPostCode.Text;
            immigrationstatus = drpImmigrationstatus.SelectedItem.Text.ToString();
            ethinicity = DrpEthinicity.SelectedItem.Text.ToString();
            iwi = DrpIwi.SelectedItem.Text.ToString();
            fstvictim = ChkFST.Checked.ToString();
            gender = DrpGender.SelectedItem.Text.ToString();
            policerecordnumber=Convert.ToInt32(TxtPoliceRecord.Text);
            Response.Write(firstname + surname + date + homeaddress + workphone +gender+
                mobilephone + occupation + placeofwork + postcode + immigrationstatus + ethinicity + iwi + fstvictim);
            Response.Write("This is the primary key Id" + primarykeyId);
            string sql = string.Format("Insert Into Victim" + "(FirstName,Surname,DateofBirth,HomeAddress,HomePhone,WorkPhone,MobilePhone, Occupation,PlaceofWork,PostCode,ImmigrationStatus,PoliceRecordNumber,FSTVictim,Ethinicity,Iwi,VictimId,Gender) Values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')", firstname, surname,date, homeaddress,homephone, workphone,mobilephone,occupation,placeofwork,postcode,immigrationstatus,policerecordnumber,fstvictim,ethinicity,iwi,primarykeyId,gender );

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
             cmd.ExecuteNonQuery();
            }
        sqlCn.Close();
        clearForm(); 
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            string firstname, surname, date, homeaddress, homephone, workphone, mobilephone, ethinicity, iwi, gender,
            occupation, placeofwork, postcode, immigrationstatus, fstvictim;
            int policerecordnumber, victimId;
            
            
            
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();

            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            date = TxtDateofBirth.Text;
            homeaddress = TxtHomeAddress1.Text + TxtHomeAddress2.Text + TxtHomeAddress3.Text;
            workphone = TxtWrkPhone.Text;
            homephone = TxtHomePhone.Text;
            mobilephone = TxtMobilePhone.Text;
            occupation = TxtOccupation.Text;
            placeofwork = TxtPlaceofWork.Text;
            postcode = TxtPostCode.Text;
            immigrationstatus = drpImmigrationstatus.SelectedItem.Text.ToString();
            ethinicity = DrpEthinicity.SelectedItem.Text.ToString();
            iwi = DrpIwi.SelectedItem.Text.ToString();
            fstvictim = ChkFST.Checked.ToString();
            gender = DrpGender.SelectedItem.Text.ToString();
            policerecordnumber = Convert.ToInt32(TxtPoliceRecord.Text);
            victimId = Convert.ToInt32(VictimIdLbl.Text);
            Response.Write("Edit Vicitmid"+victimId);
            Response.Write(firstname + surname + date + homeaddress + workphone + gender +
                mobilephone + occupation + placeofwork + postcode + immigrationstatus + ethinicity + iwi + fstvictim);
            string sql = String.Format("Update Victim Set FirstName='{0}',Surname='{1}',DateofBirth='{2}',HomeAddress='{3}',HomePhone='{4}',WorkPhone='{5}',MobilePhone='{6}', Occupation='{7}',PlaceofWork='{8}',PostCode='{9}',ImmigrationStatus='{10}',PoliceRecordNumber='{11}',FSTVictim='{12}',Ethinicity='{13}',Iwi='{14}',Gender='{16}' Where VictimId='{15}'" ,
                firstname, surname, date, homeaddress, homephone, workphone, mobilephone, occupation, placeofwork, postcode, immigrationstatus, policerecordnumber, fstvictim, ethinicity, iwi,sessionVictimId,gender);

            Response.Write(sql);
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
            sqlCn.Close();
            clearForm();  
           
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Grid Clicked");
            sessionVictimId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedRow.RowIndex].Cells[2].Text);
            Response.Write(sessionVictimId);
            Session["VictimId"] = sessionVictimId;
            select();
        }

        protected void LinkButton21_Click(object sender, EventArgs e)
        {
           
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("OffenderInfo.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ChildrenInfo.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("OtherContactInfo.aspx");
        }

        protected void LinkButton4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PreviousOffender.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgencyInfo.aspx");
        }
    }
}