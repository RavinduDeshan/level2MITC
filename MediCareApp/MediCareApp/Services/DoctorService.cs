using MediCareApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Services
{
    interface DoctorService
    {
        bool addDoctor(Doctor D);
        bool deleteDoctor(string docID);

       


    }
}
