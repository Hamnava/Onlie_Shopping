using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
   public class QuestionAnswerViewModel
    {
        public string usernameQ { get; set; }
        public string DescriptionQ { get; set; }
        public DateTime CreateQDate { get; set; }
        public int Questionid { get; set; }
        public AnswerViewModel showAnswer { get; set; }
    }
    public class AnswerViewModel
    {
        public string usernameA { get; set; }
        public string DescriptionA { get; set; }
        public DateTime? CreateADate { get; set; }
        public int? AnswerId { get; set; }
    }
}
