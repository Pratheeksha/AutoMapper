using AutoMapper;

namespace AutoMapper1
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.ID)).ReverseMap();
        }
    }
}
