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
    public partial class ChildrenInfo : System.Web.UI.Page
    {
        string firstname, surname, dateofbr, age, gender, nameone, addressone, homephoneone, mobilephoneone, workphoneone,
            nametwo, addresstwo, homephonetwo, mobilephonetwo, workphonetwo;
        int ChildrenId,VictimId,ChildrenSelectId;
        protected void Page_Load(object sender, EventArgs e)
        {
           // Panel1.Visible = true;
            VictimId = Convert.ToInt32(Session["VictimId"]);
            ChildrenSelectId=Convert.ToInt32(Session["ChildrenSelectId"]);
            Response.Write(VictimId);
            Response.Write("The childrens id is" + ChildrenSelectId);
        }
        public void primarykey()
        {
            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            string strSql = "select * from Children";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);

            ChildrenId = dset.Tables[0].Rows.Count;

            ChildrenId = ChildrenId + 1;
            Response.Write("This is the number" + ChildrenId);
            con.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            primarykey();
            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            dateofbr = TxtDateofBirth.Text;
            age = TxtAge.Text;
            gender = DrpGender.SelectedItem.Text;
            nameone = TxtNameOne.Text;
            addressone = TxtAddressOne1.Text + TxtAddressOne2.Text + TxtAddressOne3.Text;
            homephoneone = TxtHomePhoneOne.Text;
            mobilephoneone = TxtMobilePhoneOne.Text;
            workphoneone = TxtWorkPhoneOne.Text;
            nametwo = TxtNameTwo.Text;
            addresstwo = TxtAddressTwo1.Text + TxtAddressTwo2.Text + TxtAddressTwo3.Text;
            homephonetwo = TxtHomePhoneTwo.Text;
            mobilephonetwo = TxtMobilePhoneTwo.Text;
            workphonetwo = TxtWorkPhoneTwo.Text;

            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();
            string sql = string.Format("Insert Into Children" + "(FirstName,Surname,DateofBirth,Age,Gender, NameOne,AddressOne,HomePhoneOne ,MobilePhoneOne, WorkPhoneOne , NameTwo , AddressTwo, HomePhoneTwo, MobilePhoneTwo, WorkPhoneTwo,ChildrenId,VictimId) Values" +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')", firstname, surname, dateofbr, age, gender, nameone, addressone, homephoneone, mobilephoneone, workphoneone, nametwo, addresstwo, homephonetwo, mobilephonetwo, workphonetwo, ChildrenId, VictimId);

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
            string strSql = string.Format("select * from Children where ChildrenId='{0}'", ChildrenSelectId);
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(strSql, con);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            int i = 0;
            Response.Write("The number of Rows is " + dset.Tables[0].Rows.Count);
            TxtFirstName.Text = dset.Tables[0].Rows[i]["FirstName"].ToString();
            TxtSurname.Text = dset.Tables[0].Rows[i]["Surname"].ToString();
            TxtDateofBirth.Text = dset.Tables[0].Rows[i]["DateofBirth"].ToString();
            TxtAge.Text = dset.Tables[0].Rows[i]["Age"].ToString();
            DrpGender.SelectedValue=dset.Tables[0].Rows[i]["Gender"].ToString();
            TxtNameOne.Text = dset.Tables[0].Rows[i]["NameOne"].ToString();
            TxtAddressOne1.Text = dset.Tables[0].Rows[i]["AddressOne"].ToString();
            TxtHomePhoneOne.Text = dset.Tables[0].Rows[i]["HomePhoneOne"].ToString();
            TxtMobilePhoneOne.Text = dset.Tables[0].Rows[i]["MobilePhoneOne"].ToString();
            TxtWorkPhoneOne.Text = dset.Tables[0].Rows[i]["WorkPhoneOne"].ToString();
            TxtNameTwo.Text = dset.Tables[0].Rows[i]["NameTwo"].ToString();
            TxtAddressTwo1.Text = dset.Tables[0].Rows[i]["AddressTwo"].ToString();
            TxtHomePhoneTwo.Text = dset.Tables[0].Rows[i]["HomePhoneTwo"].ToString();
            TxtMobilePhoneTwo.Text = dset.Tables[0].Rows[i]["MobilePhoneTwo"].ToString();
            TxtWorkPhoneTwo.Text = dset.Tables[0].Rows[i]["WorkPhoneTwo"].ToString();
            con.Close();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChildrenSelectId = Convert.ToInt32(GridView1.Rows[GridView1.SelectedRow.RowIndex].Cells[2].Text);
            Response.Write(ChildrenSelectId);
            Session["ChildrenSelectId"] = ChildrenSelectId;
            select();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            firstname = TxtFirstName.Text;
            surname = TxtSurname.Text;
            dateofbr = TxtDateofBirth.Text;
            age = TxtAge.Text;
            gender = DrpGender.SelectedValue;
            nameone = TxtNameOne.Text;
            addressone = TxtAddressOne1.Text + TxtAddressOne2.Text + TxtAddressOne3.Text;
            homephoneone = TxtHomePhoneOne.Text;
            mobilephoneone = TxtMobilePhoneOne.Text;
            workphoneone = TxtWorkPhoneOne.Text;
            nametwo = TxtNameTwo.Text;
            addresstwo = TxtAddressTwo1.Text + TxtAddressTwo2.Text + TxtAddressTwo3.Text;
            homephonetwo = TxtHomePhoneTwo.Text;
            mobilephonetwo = TxtMobilePhoneTwo.Text;
            workphonetwo = TxtWorkPhoneTwo.Text;

            string connectionString = @"Data Source=MOSESPC\SQLEXPRESS;Initial Catalog=VictimManagementDatabase;Integrated Security=True";
            SqlConnection sqlCn = new SqlConnection();
            sqlCn.ConnectionString = connectionString;
            sqlCn.Open();

            string sql = String.Format("Update Children Set FirstName='{0}',Surname='{1}',DateofBirth='{2}',Age='{3}',Gender='{4}',NameOne='{5}',AddressOne='{6}', HomePhoneOne='{7}',MobilePhoneOne='{8}',WorkPhoneOne='{9}', NameTwo='{10}',AddressTwo='{11}',HomePhoneTwo='{12}',MobilePhoneTwo='{13}',WorkPhoneTwo='{14}', VictimId='{16}' Where ChildrenId='{15}'",
                  firstname, surname, dateofbr,age, gender, nameone, addressone, homephoneone, mobilephoneone, workphoneone, nametwo, addresstwo, homephonetwo, mobilephonetwo, workphonetwo,  ChildrenSelectId, VictimId);

                Response.Write(sql);
                using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
                {
                    cmd.ExecuteNonQuery();
                }
             sqlCn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = "";
            TxtSurname.Text = "";
            TxtDateofBirth.Text = "";
            TxtAge.Text = "";
            TxtNameOne.Text = "";
            TxtAddressOne1.Text = "";
            TxtAddressOne2.Text = "";
            TxtAddressOne3.Text = "";
            TxtHomePhoneOne.Text = "";
            TxtMobilePhoneOne.Text = "";
            TxtWorkPhoneOne.Text = "";
            TxtNameTwo.Text = "";
            TxtAddressTwo1.Text = "";
            TxtAddressTwo2.Text = "";
            TxtAddressTwo3.Text = "";
            TxtHomePhoneTwo.Text = "";
            TxtMobilePhoneTwo.Text = "";
            TxtWorkPhoneTwo.Text = "";
        }
    }
}