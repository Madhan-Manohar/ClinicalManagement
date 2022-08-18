using ClinicalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalManagement.Views.Admin
{
    public partial class Laboratorian : System.Web.UI.Page
    {
        clinicEntities1 abc;
        protected void Page_Load(object sender, EventArgs e)
        {
            abc = new clinicEntities1();
            LaboratorianGV.DataSource = abc.LaboratorianTbls.ToList();
            LaboratorianGV.DataBind();
        }
        int key = 0;
        protected void LaboratorianGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LaboratorianGV.SelectedRow.Cells[2].Text;
            EmailTb.Value = LaboratorianGV.SelectedRow.Cells[3].Text;
            PasswordTb.Value = LaboratorianGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = LaboratorianGV.SelectedRow.Cells[5].Text;
            AddressTb.Value = LaboratorianGV.SelectedRow.Cells[6].Text;
            GenderCb.SelectedItem.Value = LaboratorianGV.SelectedRow.Cells[7].Text;


            if (LabNameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LaboratorianGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {


                LaboratorianTbl lab = new LaboratorianTbl();
                lab.LabName = LabNameTb.Value;
                lab.LabEmail = EmailTb.Value;
                lab.LabPass = PasswordTb.Value;
                lab.LabPhone = PhoneTb.Value;
                lab.LabAddress = AddressTb.Value;
                lab.LabGen = GenderCb.SelectedValue.ToString();
                abc.LaboratorianTbls.Add(lab);
                abc.SaveChanges();
                LaboratorianGV.DataSource = abc.LaboratorianTbls.ToList();
                LaboratorianGV.DataBind();
                ErrMsg.InnerText = "Laboratorian Added";
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

                LaboratorianTbl lab = new LaboratorianTbl();
                var original = abc.LaboratorianTbls.Find(int.Parse(LaboratorianGV.SelectedRow.Cells[1].Text));
                lab.LabName = LabNameTb.Value;
                lab.LabEmail = EmailTb.Value;
                lab.LabPass = PasswordTb.Value;
                lab.LabPhone = PhoneTb.Value;
                lab.LabAddress = AddressTb.Value;
                lab.LabGen = GenderCb.SelectedValue.ToString();
                lab.LabId = int.Parse(LaboratorianGV.SelectedRow.Cells[1].Text);
                abc.Entry(original).CurrentValues.SetValues(lab);
                abc.SaveChanges();
                LaboratorianGV.DataSource = abc.LaboratorianTbls.ToList();
                LaboratorianGV.DataBind();
                ErrMsg.InnerText = "Laboratorian Updated";
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
                LaboratorianTbl lab = new LaboratorianTbl();
                var original = abc.LaboratorianTbls.Find(int.Parse(LaboratorianGV.SelectedRow.Cells[1].Text));
                abc.LaboratorianTbls.Remove(original);
                abc.SaveChanges();
                LaboratorianGV.DataSource = abc.DoctorTbls.ToList();
                LaboratorianGV.DataBind();
                ErrMsg.InnerText = "Laboratorian Deleted";
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}