using HospitalSoftware.Models;
using HospitalSoftware.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSoftware.Repo
{
    public class DoctorRepo
    {
        public List<Doctor> AllDoctors = new List<Doctor>
        {
            new Doctor{DoctorId=1,DoctorName="Shrusti",Fees=3000,Specialization="Pediatrician"},
            new Doctor{DoctorId=2,DoctorName="Lekha",Fees=2500,Specialization="Gynocologoist"},
            new Doctor{DoctorId=3,DoctorName="Pooja",Fees=2000,Specialization="General Medicine"}
        };  
    }
    public class PatientRepo : IPatientRepo
    {
        List<Patient> patientobj = new List<Patient>();

        public Patient FindPatient(int userid) => patientobj.Find((p) => p.PatientId == userid);

        public List<Patient> GetAllPatients(int userdocId) => patientobj.FindAll((p) => p.DoctorId == userdocId);

        public void RegisterNewPatient(Patient userInputPatient)
        {
            var id = 1;
            if (patientobj.Count != 0)
            {
                var lastId = patientobj[patientobj.Count - 1].PatientId;
                id = ++lastId;
            }
            userInputPatient.PatientId = id; //transfering the id from user to userobject
            patientobj.Add(userInputPatient); //transferring the id from userobject to patient through Patient object
        }

        public void UpdatePatient(Patient userInputPatient)
        {
            var selected = FindPatient(userInputPatient.PatientId);
            if (selected == null)
                throw new Exception(" Patient Details not found");
            selected.PatientName = userInputPatient.PatientName;
            selected.PatientMobile = userInputPatient.PatientMobile;
            selected.DateOfBirth = userInputPatient.DateOfBirth;
            selected.DoctorId = userInputPatient.DoctorId;
        }
    }
}