using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StackOverflow.Base.Features.Questions.Entities;
using StackOverflow.Base.Features.Questions.ViewModels;
using StackOverflow.Base.Services;
using StackOverflow.Web.Models;
using System.Diagnostics;

namespace StackOverflow.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IQuestionService _questionService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IQuestionService questionService)
        {
            _questionService = questionService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllQuestion()
        {
            return View();
        }

        public IActionResult AskQuestion()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AskQuestion(InsertQuestionVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _questionService.InsertFEAsync(model);
                    TempData["message"] = "Question Inserted Successfully";
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
