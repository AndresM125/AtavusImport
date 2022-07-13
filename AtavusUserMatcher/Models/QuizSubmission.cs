using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class QuizSubmission
    {
        public QuizSubmission()
        {
            Answers = new HashSet<Answer>();
        }

        public long Id { get; set; }
        public long? QuizId { get; set; }
        public long? EnrollmentId { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public decimal? CalculatedGrade { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Enrollment? Enrollment { get; set; }
        public virtual Quiz? Quiz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
