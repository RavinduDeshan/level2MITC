                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediCareApp.Models;


namespace MediCareApp.Services
{
    interface PatientServices
    {
        bool AddPatient(Patient P);

       int getAllPatientCount();

        Patient getAsinglePatient(string id);

        DataTable getpatientList();

        bool updatePatient();

    }
}
