using System;
using System.Collections.Generic;

namespace DataSourceWebApi.Models
{
    public partial class MedicalAppointments
    {
        public int Id { get; set; }
        public int? MedicId { get; set; }
        public string MedicIds { get; set; }
        public int? Status { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int? Label { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int? EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public string ContactInfo { get; set; }
    }
}
