using HospitalSoftware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HospitalSoftware
{
    public class Helper
    {
        public static void PopulateDoctors(DropDownList dpList, object data)
        {
            var doctors = data as List<Doctor>;
            dpList.DataSource = doctors; //unboxing
            dpList.DataTextField = "DoctorName";
            dpList.DataValueField = "DoctorId";
            dpList.DataBind();
        }
    }
}