namespace mhetrika.core.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public Cardio CardioExam { get; set; }
        public int CardioExamId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int QuizId { get; set; }
    }
}
