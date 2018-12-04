namespace mhetrika.core.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Cardio CardioExam { get; set; }
        public int CardioExamId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public int QuizId { get; set; }
    }
}
