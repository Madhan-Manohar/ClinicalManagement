using ClinicalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ClinicalManagement.Views.Admin
{
    public partial class Doctors : System.Web.UI.Page
    {
        clinicEntities1 abc;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            abc = new clinicEntities1();
            DoctorsGV.DataSource = abc.DoctorTbls.ToList();
            DoctorsGV.DataBind();
        }
       

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorTbl Doc = new DoctorTbl();
                Doc.DocName = DocNameTb.Value;
                Doc.DocPhone = DocPhoneTb.Value;
                Doc.DocExp = Convert.ToInt32(DocExpTb.Value);
                Doc.DocSpec = SpecialisationTb.Value;
                Doc.DocGen = GenderCb.SelectedValue.ToString();
                Doc.DocAdd = AddressTb.Value;
                Doc.DocDob = Convert.ToDateTime(DOBTb.Value);
                Doc.DocPass = PasswordTb.Value;
                Doc.DocEmail = EmailTb.Value;

                abc.DoctorTbls.Add(Doc);
                abc.SaveChanges();
                DoctorsGV.DataSource = abc.DoctorTbls.ToList();
                DoctorsGV.DataBind();
                ErrMsg.InnerText = "Doctor Added";
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }


        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DocNameTb.Value == " ")
                {
                    ErrMsg.InnerText = "Select a Doctor!!!";
                }
                else
                {
                    var original = abc.DoctorTbls.Find(int.Parse(DoctorsGV.SelectedRow.Cells[1].Text));
                    abc.DoctorTbls.Remove(original);
                    abc.SaveChanges();
                    DoctorsGV.DataSource = abc.DoctorTbls.ToList();
                    DoctorsGV.DataBind();
                    ErrMsg.InnerText = "Doctor Deleted";
                }
               
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
           
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorTbl Doc = new DoctorTbl();
                var original = abc.DoctorTbls.Find(int.Parse(DoctorsGV.SelectedRow.Cells[1].Text));
                Doc.DocName = DocNameTb.Value;
                Doc.DocPhone = DocPhoneTb.Value;
                Doc.DocExp = Convert.ToInt32(DocExpTb.Value);
                Doc.DocSpec = SpecialisationTb.Value;
                Doc.DocGen = GenderCb.SelectedValue.ToString();
                Doc.DocAdd = AddressTb.Value;
                Doc.DocDob = Convert.ToDateTime(DOBTb.Value);
                Doc.DocPass = PasswordTb.Value;
                Doc.DocEmail = EmailTb.Value;
                Doc.DocId = int.Parse(DoctorsGV.SelectedRow.Cells[1].Text);

                abc.Entry(original).CurrentValues.SetValues(Doc);
                abc.SaveChanges();
                DoctorsGV.DataSource = abc.DoctorTbls.ToList();
                DoctorsGV.DataBind();
                ErrMsg.InnerText = "Doctor Updated";

            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
            
        }
        int key = 0;

        protected void DoctorsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocNameTb.Value = DoctorsGV.SelectedRow.Cells[2].Text;
            DocPhoneTb.Value = DoctorsGV.SelectedRow.Cells[3].Text;
            DocExpTb.Value = DoctorsGV.SelectedRow.Cells[4].Text;
            SpecialisationTb.Value = DoctorsGV.SelectedRow.Cells[5].Text;
            GenderCb.SelectedItem.Value = DoctorsGV.SelectedRow.Cells[6].Text;
            AddressTb.Value = DoctorsGV.SelectedRow.Cells[7].Text;
            DOBTb.Value = DoctorsGV.SelectedRow.Cells[8].Text;
            PasswordTb.Value = DoctorsGV.SelectedRow.Cells[9].Text;
            EmailTb.Value = DoctorsGV.SelectedRow.Cells[10].Text;
            if (DocNameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DoctorsGV.SelectedRow.Cells[1].Text);
            }
        }
    }
}