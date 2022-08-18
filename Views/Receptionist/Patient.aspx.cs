using ClinicalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalManagement.Views.Receptionist
{
    public partial class Patient : System.Web.UI.Page
    {
        clinicEntities1 abc;
        protected void Page_Load(object sender, EventArgs e)
        {
            abc = new clinicEntities1();
            PatientGV.DataSource = abc.PatientTbls.ToList();
            PatientGV.DataBind();

            if (!IsPostBack)
            {
                var ghi = from gh in abc.ReceptionistTbls select new { gh.RecId, gh.RecName };
                AddCb.DataSource = ghi.ToList();
                AddCb.DataValueField = "RecId";
                AddCb.DataTextField = "RecName";
                AddCb.DataBind();
                AddCb.Items.Insert(0, new ListItem("--Select Receptionist--"));
            }
        }
        int key = 0;
        protected void PatientGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatNameTb.Value = PatientGV.SelectedRow.Cells[2].Text;
            PhoneTb.Value = PatientGV.SelectedRow.Cells[3].Text;
            GenderCb.SelectedItem.Value = PatientGV.SelectedRow.Cells[4].Text;
            DOBTb.Value = PatientGV.SelectedRow.Cells[5].Text;
            AddressTb.Value = PatientGV.SelectedRow.Cells[6].Text;
            AllergyTb.Value = PatientGV.SelectedRow.Cells[7].Text;
            AddCb.SelectedValue = PatientGV.SelectedRow.Cells[8].Text;


            if (PatNameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PatientTbl pat = new PatientTbl();

                pat.Addby = int.Parse(AddCb.SelectedValue);
                pat.PatName = PatNameTb.Value;
                pat.PatPhone = PhoneTb.Value;
                pat.PatGen = GenderCb.SelectedValue.ToString();
                pat.PatDob = Convert.ToDateTime(DOBTb.Value);
                pat.PatAdd = AddressTb.Value;
                pat.PatAllergies = AllergyTb.Value;
                abc.PatientTbls.Add(pat);
                abc.SaveChanges();
                PatientGV.DataSource = abc.PatientTbls.ToList();
                PatientGV.DataBind();
                ErrMsg.InnerText = "Patient Added";
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
                PatientTbl pat = new PatientTbl();
                var original = abc.PatientTbls.Find(int.Parse(PatientGV.SelectedRow.Cells[1].Text));
                pat.Addby = int.Parse(AddCb.SelectedValue);
                pat.PatName = PatNameTb.Value;
                pat.PatPhone = PhoneTb.Value;
                pat.PatGen = GenderCb.SelectedValue.ToString();
                pat.PatDob = Convert.ToDateTime(DOBTb.Value);
                pat.PatAdd = AddressTb.Value;
                pat.PatAllergies = AllergyTb.Value;
                pat.PatId = int.Parse(PatientGV.SelectedRow.Cells[1].Text);
                abc.Entry(original).CurrentValues.SetValues(pat);
                abc.SaveChanges();
                PatientGV.DataSource = abc.PatientTbls.ToList();
                PatientGV.DataBind();
                ErrMsg.InnerText = "Patient Updated";
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
                var original = abc.PatientTbls.Find(int.Parse(PatientGV.SelectedRow.Cells[1].Text));
                abc.PatientTbls.Remove(original);
                abc.SaveChanges();
                PatientGV.DataSource = abc.PatientTbls.ToList();
                PatientGV.DataBind();
                ErrMsg.InnerText = "Patient Deleted";
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }
    }
}
