namespace mhetrika.core.Entities
{
    public class Fibrosis : Exam
    {
        public int Age { get; set; }
        public double AST { get; set; }
        public double ALT { get; set; }
        public double IMC { get; set; }
        public double Platelets { get; set; }
        public double Albumin { get; set; }
        public bool Diabetic { get; set; }
    }
}
