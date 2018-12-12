using System.Collections.Generic;

namespace mhetrika.core.Entities
{
    public class Doctor : User
    {
        public string Crm { get; set; }
        public string Uf { get; set; }
        public string Phone { get; set; }
        public string Specialty { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
