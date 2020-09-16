using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediCareApp.Models;

namespace MediCareApp.Services
{
    interface LabReportService
    {
        bool AddLabReport(LabReport LR);

        bool DeleteLabReport(LabReport LR);

        bool UpdateLabReport(LabReport LR);
    }
}
