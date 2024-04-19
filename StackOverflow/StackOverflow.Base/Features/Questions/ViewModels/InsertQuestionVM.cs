using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Features.Questions.ViewModels
{
    public class InsertQuestionVM
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string? QuestionTitle { get; set; }

        [Required]
        public string? QuestionBody { get; set; }
    }
}
