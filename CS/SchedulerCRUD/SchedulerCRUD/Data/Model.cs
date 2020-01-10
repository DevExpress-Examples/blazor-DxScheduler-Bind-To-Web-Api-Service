using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulerCRUD.Data
{
    public class MedicalAppointments
    {
        public int Id { get; set; }
        public int? MedicId { get; set; }
        public string MedicIds { get; set; }
        public int Status { get; set; } //return nullable after fix
        public string Subject { get; set; }
        public string Description { get; set; }
        public int Label { get; set; } //return nullable after fix
        public DateTime StartTime { get; set; } //return nullable after fix
        public DateTime EndTime { get; set; } //return nullable after fix
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public string ContactInfo { get; set; }
    }
}
