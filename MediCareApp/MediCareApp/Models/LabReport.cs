using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCareApp.Models
{
    class LabReport
    {
        string Id;
        string Description;
        string PatientID;
        string PatientName;
        string DoctorID;
        string DoctorName;
        string CreatedDate;
        string CompletedDate;
        string Type;
        string Status;
        string LabAssistentID;
        string LabAssistentName;
        string ReportURL;

        public LabReport(string id, string description, string patientID, string patientName, string doctorID, string doctorName, string createdDate, string completedDate, string type, string status, string labAssistentID, string labAssistentName, string reportURL, string iD, string firstName, string lastName, string middleName, string tel, string email, string address, string dob, string nIC, string gender)
        {
            this.Id = id;
            this.Description = description;
            this.PatientID = patientID;
            this.PatientName = patientName;
            this.DoctorID = doctorID;
            this.DoctorName = doctorName;
            this.CreatedDate = createdDate;
            this.CompletedDate = completedDate;
            this.Type = type;
            this.Status = status;
            this.LabAssistentID = labAssistentID;
            this.LabAssistentName = labAssistentName;
            this.ReportURL = reportURL;
           
        }

        public string ID { get => Id; set => Id = value; }
        public string Descriptionm { get => Description; set => Description = value; }
        public string patientId { get =>PatientID; set => PatientID = value; }
        public string patientName { get => PatientName; set => patientName = value; }

        public string docId { get => DoctorID; set => DoctorID = value; }
        public string docName { get => DoctorName; set => DoctorName = value; }
        public string createdate { get => CreatedDate; set => CreatedDate = value; }
        public string completedate { get => CompletedDate; set => completedate = value; }
        public string types { get => Type; set => Type = value; }
        public string status { get => Status; set => Status = value; }
        public string labAssistent { get => LabAssistentID; set => LabAssistentID = value; }
        public string labAssistentname { get => LabAssistentName; set => LabAssistentName = value; }
        public string reportUrl { get => ReportURL; set => ReportURL = value; }
    }
}

