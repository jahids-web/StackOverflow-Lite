using Microsoft.AspNetCore.Mvc;
using StackOverflow.Base.Features.Questions.Domain;
using StackOverflow.Base.Features.Questions.Entities;

namespace StackOverflow.Web.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository) 
        {
            _questionRepository = questionRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Question model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _questionRepository.Insert(model);
                    TempData["message"] = "Question Inserted Successfully";
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
