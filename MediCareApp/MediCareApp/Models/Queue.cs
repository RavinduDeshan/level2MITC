using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class Queue
    {
        String queueid;
        int size;
        int currentNumber;
        String sheduleId;
        int maxSize;
        String date;

        public Queue(String id, int size, int currentNumber, String sheduleId, int maxSize, String date)
        {
            this.queueid = id;
            this.size = size;
            this.currentNumber = currentNumber;
            this.sheduleId = sheduleId;
            this.maxSize = maxSize;
            this.date = date;
        }

        public string QID { get => queueid; set => queueid = value; }
        public int Size { get => size; set => size = value; }
        public int CurrentNumber { get => currentNumber; set => currentNumber = value; }
        public String SheduleId { get => sheduleId; set => sheduleId = value; }
        public int MaxSize { get => maxSize; set => maxSize = value; }
        public string Date { get => date; set => date = value; }

    }
}
