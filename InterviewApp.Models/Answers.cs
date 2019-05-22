using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewApp.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public int QuestionId { get; set; }
    }
}
