                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediCareApp.Models;


namespace MediCareApp.Services
{
    interface PatientServices
    {
        bool AddPatient(Patient P);

       int getAllPatientCount(Patient P);

        Patient getAsinglePatient(string id);

        bool getpatientList();

        bool updatePatient();

    }
}
