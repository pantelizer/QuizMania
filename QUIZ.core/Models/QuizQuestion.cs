using System;
using System.Collections.Generic;
using System.Text;

namespace QUIZ.core.Models
{
    public class QuizQuestion
    {
        public string Question { get; }
        public string Answer1 { get; }
        public string Answer2 { get; }
        public string CorrectAnswer { get; }

        // contsructor (αυτο που βάζουμε μέσα τα δεδομένα για τις ερωτήσεις όποτε προσθέτουμε αντικείμενο στη κλάση)
        public QuizQuestion(string question, string answer1, string answer2, string correctanswer)
        {
            Question = question;
            Answer1 = answer1;
            Answer2 = answer2;
            CorrectAnswer = correctanswer;

        }

    }
}
