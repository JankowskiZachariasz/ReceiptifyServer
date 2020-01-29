using AutoMapper;
using ReceiptifyServer.Entities;
using ReceiptifyServer.Models.Users;

namespace ReceiptifyServer.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}