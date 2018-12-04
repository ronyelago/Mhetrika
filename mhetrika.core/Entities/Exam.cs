using System;

namespace mhetrika.core.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }
        public virtual Laboratory Laboratory { get; set; }
        public int LaboratoryId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}