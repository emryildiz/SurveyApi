using AutoMapper;
using SurveyApi.Common.Dtos;
using SurveyApi.Common.Entities;

namespace SurveyApi
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            this.CreateMap<SurveyDto, Survey>();
            this.CreateMap<UserDto, User>();
            this.CreateMap<User, UserDto>();
            this.CreateMap<UserCreateDto, User>();
            this.CreateMap<SurveyCreateDto, Survey>();
        }
    }
}
