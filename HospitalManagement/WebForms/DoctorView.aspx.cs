using HospitalSoftware.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSoftware.WebForms
{
    public partial class DoctorView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            Helper.PopulateDoctors(dpDoctors,Application["Doctors"]);
        }

        protected void dpDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(dpDoctors.SelectedValue);
            var patientRepo = Application["Patients"] as PatientRepo;
            var pat = patientRepo.GetAllPatients(id);
            lstPatients.DataSource = pat;
            lstPatients.DataTextField = "PatientName";
            lstPatients.DataValueField = "PatientId";
            lstPatients.DataBind();
        }

        protected void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pId = int.Parse(lstPatients.SelectedValue);
            var patientRepo = Application["Patients"] as PatientRepo;
            var pat = patientRepo.FindPatient(pId);
            txtId.Text = pat.PatientId.ToString();
            txtName.Text = pat.PatientName;
            txtMobile.Text = pat.PatientMobile.ToString();
            txtAge.Text = pat.Age.ToString();
        }
    }
}