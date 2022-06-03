using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulerCRUD.Data
{
    public class MedicalAppointments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int? medicId { get; set; }
        public string medicIds { get; set; }
        public int status { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public int label { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public string location { get; set; }
        public bool allDay { get; set; }
        public int eventType { get; set; }
        public string recurrenceInfo { get; set; }
        public string reminderInfo { get; set; }
        public string contactInfo { get; set; }
    }
}
