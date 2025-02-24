using GameVault.Models;

namespace GameVault.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAllReviews();
        Review GetReviewById(int reviewId);
        void AddReview(Review review);
    }
}
