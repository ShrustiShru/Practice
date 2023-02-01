using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSoftware.Models.Interface
{
    interface IPatientRepo
    {
        void RegisterNewPatient(Patient userInputPatient);
        void UpdatePatient(Patient userInputPatient);
        List<Patient> GetAllPatients(int userdocId);
        Patient FindPatient(int userid);
    }
}
