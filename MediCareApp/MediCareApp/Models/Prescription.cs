using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class Prescription
    {
        string id;
        string docId;
        string docName;
        string patientID;
        string patientName;
        string illness;
        string treatment;
        string note;
        string date;

        public Prescription(string id, string docId, string docName, string patientID, string patientName, string illness, string treatment, string date)
        {
            this.id = id;
            this.docId = docId;
            this.docName = docName;
            this.patientID = patientID;
            this.patientName = patientName;
            this.illness = illness;
            this.treatment = treatment;
            this.date = date;
        }

        public string ID { get => id; set => id = value; }
        public string DocId { get => docId; set => docId = value; }
        public string DocName { get => docName; set => docName = value; }
        public string PatientID { get => patientID; set => patientID = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string Illness { get => illness; set => illness = value; }
        public string Treatment { get => treatment; set => treatment = value; }
       
        public string Date { get => date; set => date = value; }
      

    }




}
