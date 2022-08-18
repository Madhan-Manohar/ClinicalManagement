using ClinicalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalManagement.Views.Doctors
{
    public partial class Prescription : System.Web.UI.Page
    {
        clinicEntities1 abc;
        protected void Page_Load(object sender, EventArgs e)
        {
            abc = new clinicEntities1();
            PrescriptionGV.DataSource = abc.PrescriptionTbls.ToList();
            PrescriptionGV.DataBind();

            if (!IsPostBack)
            {
                var original = from or in abc.PatientTbls select new { or.PatId, or.PatName };
                PatientCb.DataSource = original.ToList();
                PatientCb.DataValueField = "PatId";
                PatientCb.DataTextField = "PatName";
                PatientCb.DataBind();
                PatientCb.Items.Insert(0, new ListItem("--Select Patient--"));

                var def = from de in abc.LabTestTbls select new { de.TestId, de.TestName };
                TestCb.DataSource = def.ToList();
                TestCb.DataValueField = "TestId";
                TestCb.DataTextField = "TestName";
                TestCb.DataBind();
                TestCb.Items.Insert(0, new ListItem("--Select Test--"));

                var ghi = from gh in abc.DoctorTbls select new { gh.DocId, gh.DocName };
                AddCb.DataSource = ghi.ToList();
                AddCb.DataValueField = "DocId";
                AddCb.DataTextField = "DocName";
                AddCb.DataBind();
                AddCb.Items.Insert(0, new ListItem("--Select Doctor--"));
            }
        }
        int key = 0;
        protected void PrescriptionGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCb.SelectedValue = PrescriptionGV.SelectedRow.Cells[2].Text;
            PatientCb.SelectedItem.Value = PrescriptionGV.SelectedRow.Cells[3].Text;
            MedicineTb.Value = PrescriptionGV.SelectedRow.Cells[4].Text;
            TestCb.SelectedItem.Value = PrescriptionGV.SelectedRow.Cells[5].Text;
            CostTb.Value = PrescriptionGV.SelectedRow.Cells[6].Text;

            if (PatientCb.SelectedItem.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {

                PrescriptionTbl pre = new PrescriptionTbl();

                pre.Doctor = int.Parse(AddCb.SelectedValue);
                pre.Patient = int.Parse(PatientCb.SelectedValue);
                pre.Medicines = MedicineTb.Value;
                pre.LabTest = int.Parse(TestCb.SelectedValue);
                pre.Cost = int.Parse(CostTb.Value);
                abc.PrescriptionTbls.Add(pre);
                abc.SaveChanges();
                PrescriptionGV.DataSource = abc.PrescriptionTbls.ToList();
                PrescriptionGV.DataBind();
                ErrMsg.InnerText = "Prescription Added";
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}