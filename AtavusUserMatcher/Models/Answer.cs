using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Answer
    {
        public long Id { get; set; }
        public long? QuestionChoiceId { get; set; }
        public long? QuizSubmissionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual QuestionChoice? QuestionChoice { get; set; }
        public virtual QuizSubmission? QuizSubmission { get; set; }
    }
}
