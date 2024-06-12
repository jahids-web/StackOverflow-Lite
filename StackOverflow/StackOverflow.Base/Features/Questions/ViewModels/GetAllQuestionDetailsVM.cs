using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Features.Questions.ViewModels
{
    public class GetAllQuestionDetailsVM
    {
        public int Id { get; set; }
        public string? QuestionTitle { get; set; }
        public string? QuestionBody { get; set; }
    }
}
