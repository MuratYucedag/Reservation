using Reservation.Review.Dtos;

namespace Reservation.Review.Services
{
    public interface IUserReviewService
    {
        Task<List<ResultUserViewDto>> GetAllUserReviewAsync();
        Task CreateUserReviewAsync(CreateUserReviwDto createUserReviwDto);
        Task UpdateUserReviewAsync(UpdateUserReviewDto updateUserReviewDto);
        Task DeleteUserReviewAsync(int id);
        Task<GetByIdUserReviewDto> GetByIdUserReviewAsync(int id);
    }
}
