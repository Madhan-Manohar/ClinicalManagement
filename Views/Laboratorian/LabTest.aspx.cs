using ClinicalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicalManagement.Views.Laboratorian
{
    public partial class LabTest : System.Web.UI.Page
    {
        clinicEntities1 abc;
        protected void Page_Load(object sender, EventArgs e)
        {
            abc = new clinicEntities1();
            LabTestGV.DataSource = abc.LabTestTbls.ToList();
            LabTestGV.DataBind();

            if (!IsPostBack)
            {
                var ghi = from gh in abc.LaboratorianTbls  select new { gh.LabId, gh.LabName };
                AddCb.DataSource = ghi.ToList();
                AddCb.DataValueField = "LabId";
                AddCb.DataTextField = "LabName";
                AddCb.DataBind();
                AddCb.Items.Insert(0, new ListItem("--Select Laboratorian--"));
            }
        }
        int key = 0;
        protected void LabTestGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LabTestGV.SelectedRow.Cells[2].Text;
            TestCostTb.Value = LabTestGV.SelectedRow.Cells[3].Text;
            AddCb.SelectedValue = LabTestGV.SelectedRow.Cells[4].Text;

            if (LabNameTb.Value == " ")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LabTestGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LabTestTbl lab = new LabTestTbl();
                lab.AddBy = int.Parse(AddCb.SelectedValue);
                lab.TestName = LabNameTb.Value;
                lab.TestCost = int.Parse(TestCostTb.Value);
                abc.LabTestTbls.Add(lab);
                abc.SaveChanges();
                LabTestGV.DataSource = abc.LabTestTbls.ToList();
                LabTestGV.DataBind();
                ErrMsg.InnerText = "Test Added";
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
                LabTestTbl lab = new LabTestTbl();
                var original = abc.LabTestTbls.Find(int.Parse(LabTestGV.SelectedRow.Cells[1].Text));
                lab.TestName = LabNameTb.Value;
                lab.TestCost = int.Parse(TestCostTb.Value);
                lab.AddBy = int.Parse(AddCb.SelectedValue);
                lab.TestId = int.Parse(LabTestGV.SelectedRow.Cells[1].Text);
                abc.Entry(original).CurrentValues.SetValues(lab);
                abc.SaveChanges();
                LabTestGV.DataSource = abc.LabTestTbls.ToList();
                LabTestGV.DataBind();
                ErrMsg.InnerText = "Test Updated";
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
                var original = abc.LabTestTbls.Find(int.Parse(LabTestGV.SelectedRow.Cells[1].Text));
                abc.LabTestTbls.Remove(original);
                abc.SaveChanges();
                LabTestGV.DataSource = abc.LabTestTbls.ToList();
                LabTestGV.DataBind();
                ErrMsg.InnerText = "Test Deleted";
            }
            catch(Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}