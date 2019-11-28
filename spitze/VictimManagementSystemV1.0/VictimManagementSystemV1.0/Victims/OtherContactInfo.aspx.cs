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
    public partial class OtherContactInfo : System.Web.UI.Page
    {
        string familygp,phone,councelforchild,councelphone,lawyer,lawyerphone,neighbours,neighboursaddress,
            neighbourshomephone,neighboursmobilephone,neighboursworkphone,relationshipone,relationshipnameone,
            relationshipaddressone,relationshiphomephoneone,relationshipmobilephoneone,relationshipworkphoneone,
            relationshiptwo,relationshipnametwo,relationshipaddresstwo,relationshiphomephonetwo,relationshipmobilephonetwo,
            relationshipworkphonetwo;
        int victimId, contactId,contactSelectId;

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["VictimId"]);
            victimId = Convert.ToInt32(Session["VictimId"]);
            contactSelectId = Convert.ToInt32(Session["ContactSelectId"]);
            Response.Write("The Following Contact is selected" + contactSelectId);
        }

       

        protected void Edit_Click(object sender, EventArgs e)
        {
            familygp = TxtFamilGP.Text;
            phone = TxtPhone.Text;
            councelforchild = TxtCounselForChild.Text;
            councelphone = TxtCounselPhone.Text;
            lawyer = TxtLawyer.Text;
            lawyerphone = TxtLawyerPhone.Text;
            neighbours = TxtNeighbours.Text;
            neighboursaddress = TxtNeighboursAddressOne.Text + TxtNeighboursAddressTwo.Text + TxtNeighboursAddressThree.Text;
            neighbourshomephone = TxtNeighboursHomePhone.Text;
            neighboursmobilephone = TxtNeighboursMobilePhone.Text;
            neighboursworkphone = TxtNeighboursWorkPhone.Text;
            relationshipone = TxtRelationshipOne.Text;
            relationshipnameone = TxtRelationshipNameOne.Text;
            relationshipaddressone = TxtRelationshipAddressOne1.Text + TxtRelationshipAddressOne2.Text + TxtRelationshipAddressOne3.Text;
            relationshiphomephoneone = TxtRelationshipHomePhoneOne.Text;
            relationshipmobilephoneone = TxtRelationshipMobilePhoneOne.Text;
            relationshipworkphoneone = TxtRelationshipWorkPhoneOne.Text;
            relationshiptwo = TxtRelationshipTwo.Text;
            relationshipnametwo = TxtRelationshipNameTwo.Text;
            relationshipaddresstwo = TxtRelationshipAddressTwo1.Text + TxtRelationshipAddressTwo2.Text + TxtRelationshipAddressTwo3.Text;
            relationshiphomephonetwo = TxtRelationshipHomePhoneTwo.Text;
            relationshipmobilephonetwo = TxtRelationshipMobilePhoneTwo.Text;
            relationshipworkphonetwo = TxtRelationshipWorkPhoneTwo.Text;

            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();

            string sql = String.Format("Update ContactInfo Set FamilyGP='{0}',Phone='{1}',CounselForChild='{2}',CounselPhone='{3}',Lawyer='{4}',LawyerPhone='{5}',Neighbours='{6}', NeighboursAddress='{7}',NeighboursHomePhone='{8}',NeighboursMobilePhone='{9}', NeighboursWorkPhone='{10}',RelationshipOne='{11}', RelationshipNameOne='{12}',RelationshipAddressOne='{13}',RelationshipHomePhoneOne='{14}',RelationshipMobilePhoneOne='{15}',RelationshipWorkPhoneOne='{16}',RelationshipTwo='{17}',RelationshipNameTwo='{18}',RelationshipAddressTwo='{19}',RelationshipHomePhoneTwo='{20}',RelationshipMobilePhoneTwo='{21}',RelationshipWorkPhoneTwo='{22}', VictimId='{24}' Where ContactId='{23}'",
                  familygp, phone, councelforchild, councelphone, lawyer, lawyerphone, neighbours, neighboursaddress, neighbourshomephone, neighboursmobilephone, neighboursworkphone, relationshipone, relationshipnameone, relationshipaddressone, relationshiphomephoneone,relationshipmobilephoneone,relationshipworkphoneone,relationshiptwo,relationshipnametwo,relationshipaddresstwo,relationshiphomephonetwo,relationshipmobilephonetwo,relationshipworkphonetwo, contactSelectId, victimId);

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
            string strSql = "select * from ContactInfo";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);

            contactId = dset.Tables[0].Rows.Count;

            contactId = contactId + 1;
            Response.Write("This is the number" + contactId);
            con.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            primarykey();
            familygp = TxtFamilGP.Text;
            phone = TxtPhone.Text;
            councelforchild = TxtCounselForChild.Text;
            councelphone = TxtCounselPhone.Text;
            lawyer = TxtLawyer.Text;
            lawyerphone = TxtLawyerPhone.Text;
            neighbours = TxtNeighbours.Text;
            neighboursaddress = TxtNeighboursAddressOne.Text + TxtNeighboursAddressTwo.Text + TxtNeighboursAddressThree.Text;
            neighbourshomephone = TxtNeighboursHomePhone.Text;
            neighboursmobilephone = TxtNeighboursMobilePhone.Text;
            neighboursworkphone = TxtNeighboursWorkPhone.Text;
            relationshipone = TxtRelationshipOne.Text;
            relationshipnameone = TxtRelationshipNameOne.Text;
            relationshipaddressone = TxtRelationshipAddressOne1.Text + TxtRelationshipAddressOne2.Text + TxtRelationshipAddressOne3.Text;
            relationshiphomephoneone = TxtRelationshipHomePhoneOne.Text;
            relationshipmobilephoneone = TxtRelationshipMobilePhoneOne.Text;
            relationshipworkphoneone = TxtRelationshipWorkPhoneOne.Text;
            relationshiptwo = TxtRelationshipTwo.Text;
            relationshipnametwo = TxtRelationshipNameTwo.Text;
            relationshipaddresstwo = TxtRelationshipAddressTwo1.Text + TxtRelationshipAddressTwo2.Text + TxtRelationshipAddressTwo3.Text;
            relationshiphomephonetwo = TxtRelationshipHomePhoneTwo.Text;
            relationshipmobilephonetwo = TxtRelationshipMobilePhoneTwo.Text;
            relationshipworkphonetwo = TxtRelationshipWorkPhoneTwo.Text;

            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            string sql = string.Format("Insert Into ContactInfo" + "(FamilyGP,Phone,CounselForChild,CounselPhone,Lawyer, LawyerPhone,Neighbours, NeighboursAddress , NeighboursHomePhone, NeighboursMobilePhone , NeighboursWorkPhone , RelationshipOne, RelationshipNameOne, RelationshipAddressOne, RelationshipHomePhoneOne,RelationshipMobilePhoneOne,RelationshipWorkPhoneOne,RelationshipTwo,RelationshipNameTwo,RelationshipAddressTwo,RelationshipHomePhoneTwo,RelationshipMobilePhoneTwo,RelationshipWorkPhoneTwo,ContactId,VictimId) Values" +
               "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}')", familygp, phone, councelforchild, councelphone, lawyer, lawyerphone, neighbours, neighboursaddress, neighbourshomephone, neighboursmobilephone, neighboursworkphone, relationshipone, relationshipnameone, relationshipaddressone, relationshiphomephoneone,relationshipmobilephoneone,relationshipworkphoneone,relationshiptwo,relationshipnametwo,relationshipaddresstwo,relationshiphomephonetwo,relationshipmobilephonetwo,relationshipworkphonetwo, contactId, victimId);

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
            string strSql = string.Format("select * from ContactInfo where ContactId='{0}'", contactSelectId);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            int i = 0;
            Response.Write("The number of Rows is " + dset.Tables[0].Rows.Count);
            TxtFamilGP.Text = dset.Tables[0].Rows[i]["FamilyGP"].ToString();
            TxtPhone.Text = dset.Tables[0].Rows[i]["Phone"].ToString();
            TxtCounselForChild.Text = dset.Tables[0].Rows[i]["CounselForChild"].ToString();
            TxtCounselPhone.Text = dset.Tables[0].Rows[i]["CounselPhone"].ToString();
            TxtLawyer.Text = dset.Tables[0].Rows[i]["Lawyer"].ToString();
            TxtLawyerPhone.Text = dset.Tables[0].Rows[i]["LawyerPhone"].ToString();
            TxtNeighbours.Text = dset.Tables[0].Rows[i]["Neighbours"].ToString();
            TxtNeighboursAddressOne.Text = dset.Tables[0].Rows[i]["NeighboursAddress"].ToString();
            TxtNeighboursHomePhone.Text = dset.Tables[0].Rows[i]["NeighboursHomePhone"].ToString();
            TxtNeighboursMobilePhone.Text = dset.Tables[0].Rows[i]["NeighboursMobilePhone"].ToString();
            TxtNeighboursWorkPhone.Text = dset.Tables[0].Rows[i]["NeighboursWorkPhone"].ToString();
            TxtRelationshipOne.Text = dset.Tables[0].Rows[i]["RelationshipOne"].ToString();
            TxtRelationshipNameOne.Text = dset.Tables[0].Rows[i]["RelationshipNameOne"].ToString();
            TxtRelationshipAddressOne1.Text = dset.Tables[0].Rows[i]["RelationshipAddressOne"].ToString();
            TxtRelationshipHomePhoneOne.Text = dset.Tables[0].Rows[i]["RelationshipHomePhoneOne"].ToString();
            TxtRelationshipMobilePhoneOne.Text = dset.Tables[0].Rows[i]["RelationshipMobilePhoneOne"].ToString();
            TxtRelationshipWorkPhoneOne.Text = dset.Tables[0].Rows[i]["RelationshipWorkPhoneOne"].ToString();
            TxtRelationshipTwo.Text = dset.Tables[0].Rows[i]["RelationshipTwo"].ToString();
            TxtRelationshipNameTwo.Text = dset.Tables[0].Rows[i]["RelationshipNameTwo"].ToString();
            TxtRelationshipAddressTwo1.Text = dset.Tables[0].Rows[i]["RelationshipAddressTwo"].ToString();
            TxtRelationshipHomePhoneTwo.Text = dset.Tables[0].Rows[i]["RelationshipHomePhoneTwo"].ToString();
            TxtRelationshipMobilePhoneTwo.Text = dset.Tables[0].Rows[i]["RelationshipMobilePhoneTwo"].ToString();
            TxtRelationshipWorkPhoneTwo.Text = dset.Tables[0].Rows[i]["RelationshipWorkPhoneTwo"].ToString();


            con.Close();

            
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactSelectId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedRow.RowIndex].Cells[1].Text);
            Response.Write(contactSelectId);
            Session["ContactSelectId"] = contactSelectId;
            select();
        }
    }
}