using ClinicalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalManagement.Views.Admin
{
    public partial class Receptionist : System.Web.UI.Page
    {
        clinicEntities1 abc;
        protected void Page_Load(object sender, EventArgs e)
        {
            abc = new clinicEntities1();
            ReceptionistGV.DataSource = abc.ReceptionistTbls.ToList();
            ReceptionistGV.DataBind();
        }
        int key = 0;
        protected void ReceptionistGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecNameTb.Value = ReceptionistGV.SelectedRow.Cells[2].Text;
            RecEmailTb.Value = ReceptionistGV.SelectedRow.Cells[3].Text;
            AddressTb.Value = ReceptionistGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = ReceptionistGV.SelectedRow.Cells[5].Text;
            PasswordTb.Value = ReceptionistGV.SelectedRow.Cells[6].Text;

            if (RecNameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceptionistGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void AddBtn_Click1(object sender, EventArgs e)
        {
            try
            {

                ReceptionistTbl rec = new ReceptionistTbl();
                rec.RecName = RecNameTb.Value;
                rec.RecEmail = RecEmailTb.Value;
                rec.RecAdd = AddressTb.Value;
                rec.RecPhone = PhoneTb.Value;
                rec.RecPassword = PasswordTb.Value;
                abc.ReceptionistTbls.Add(rec);
                abc.SaveChanges();
                ReceptionistGV.DataSource = abc.ReceptionistTbls.ToList();
                ReceptionistGV.DataBind();
                ErrMsg.InnerText = "Receptionist Added";
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
                ReceptionistTbl rec = new ReceptionistTbl();
                var original = abc.ReceptionistTbls.Find(int.Parse(ReceptionistGV.SelectedRow.Cells[1].Text));
                rec.RecName = RecNameTb.Value;
                rec.RecEmail = RecEmailTb.Value;
                rec.RecAdd = AddressTb.Value;
                rec.RecPhone = PhoneTb.Value;
                rec.RecPassword = PasswordTb.Value;
                rec.RecId = int.Parse(ReceptionistGV.SelectedRow.Cells[1].Text);
                abc.Entry(original).CurrentValues.SetValues(rec);
                abc.SaveChanges();
                ReceptionistGV.DataSource = abc.ReceptionistTbls.ToList();
                ReceptionistGV.DataBind();
                ErrMsg.InnerText = "Receptionist Updated";
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
                ReceptionistTbl Rec = new ReceptionistTbl();
                var original = abc.ReceptionistTbls.Find(int.Parse(ReceptionistGV.SelectedRow.Cells[1].Text));
                abc.ReceptionistTbls.Remove(original);
                abc.SaveChanges();
                ReceptionistGV.DataSource = abc.ReceptionistTbls.ToList();
                ReceptionistGV.DataBind();
                ErrMsg.InnerText = "Receptionist Deleted";
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}