using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewApp.Models
{
    public class QuestionAnswers
    {
        public Questions Question { get; set; }
        public List<Answers> Answers { get; set; }
    }
}
