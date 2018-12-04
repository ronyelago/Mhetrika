namespace mhetrika.core.Entities
{
    public class Cardio : Exam
    {
        public int Pas { get; set; }
        public int Ldl_c { get; set; }
        public int Hdl_c { get; set; }
        public int Ct { get; set; }
        public bool Status { get; set; }
        public bool Smokes { get; set; }
        public bool Statin { get; set; }
    }
}
