using GameVault.Context;
using GameVault.Models;
using GameVault.Repositories.Interfaces;

namespace GameVault.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _context;
        public ReviewRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddReview(Review review)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _context.Reviews;
        }

        public Review GetReviewById(int reviewId)
        {
            return _context.Reviews.FirstOrDefault(r => r.ReviewId == reviewId);
        }
    }
}
