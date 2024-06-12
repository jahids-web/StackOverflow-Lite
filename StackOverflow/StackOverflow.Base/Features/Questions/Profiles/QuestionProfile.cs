using AutoMapper;
using StackOverflow.Base.Features.Questions.DTOs;
using StackOverflow.Base.Features.Questions.ViewModels;

namespace StackOverflow.Base.Features.Questions.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<InsertQuestionVM, InsertQuestionDTO>()
                   .ForMember(dest => dest.QuestionTitle, opt => opt.MapFrom(src => src.QuestionTitle))
                   .ForMember(dest => dest.QuestionBody, opt => opt.MapFrom(src => src.QuestionBody));
        }
    }
}
