using mhetrika.core.Entities;
using System;

namespace Mhetrika.Web.ViewModels
{
    public class FibrosisViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int LaboratoryId { get; set; }
        public virtual Laboratory Laboratory { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int Age { get; set; }
        public double AST { get; set; }
        public double ALT { get; set; }
        public double IMC { get; set; }
        public double Platelets { get; set; }
        public double Albumin { get; set; }
        public bool Diabetic { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
