using AutoMapper;
using Demo1.Entity;
using Demo1.Model.ResponseModel;

namespace Demo1.AutoMapping
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            MapUser();
        }

        private void MapUser()
        {
            CreateMap<UserEntity, UserResponse>().
                ReverseMap();
        }
    }
}
