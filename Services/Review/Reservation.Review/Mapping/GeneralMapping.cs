using AutoMapper;
using Reservation.Review.Dtos;
using Reservation.Review.Entities;

namespace Reservation.Review.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserReview, ResultUserViewDto>().ReverseMap();
            CreateMap<UserReview, GetByIdUserReviewDto>().ReverseMap();
            CreateMap<UserReview, CreateUserReviwDto>().ReverseMap();
            CreateMap<UserReview, UpdateUserReviewDto>().ReverseMap();
        }
    }
}
