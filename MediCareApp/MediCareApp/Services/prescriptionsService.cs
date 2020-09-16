using MediCareApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Services
{
    interface prescriptionsService
    {
        DataTable getPrescriptionByPAtient(String Pid);

        bool AddPrescription(Prescription p);
    }
}
