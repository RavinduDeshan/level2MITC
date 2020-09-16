using MediCareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Services
{
    interface specialistService
    {
        bool validateUser(string Username, string password);

        string getIdByNIC(string nic);
    }
}
