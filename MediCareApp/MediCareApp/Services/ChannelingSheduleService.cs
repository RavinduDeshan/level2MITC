using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediCareApp.Models;

namespace MediCareApp.Services
{
    interface ChannelingSheduleService
    {
        bool addChannelingSchedule(ChannelingSchedule CS);

        bool updateChannelingSchedule(ChannelingSchedule CS);

        bool deleteChannelingSchedule(ChannelingSchedule CS);
    }
}
