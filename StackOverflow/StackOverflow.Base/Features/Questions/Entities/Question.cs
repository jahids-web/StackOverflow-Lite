using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow.Base.Features.Questions.Entities
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? QuestionId { get; set; }

        [Required]
        public string? QuestionTitle { get; set; }

        [Required]
        public string? QuestionBody { get; set; }

    }
}
