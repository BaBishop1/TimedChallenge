

using Microsoft.EntityFrameworkCore;
using TimedChallenge.Data.Entities;

public class CommentService : ICommentService
{
    private readonly ApplicationDbContext _context;
    public CommentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> RegisterCommentAsync(CommentRegister model)
    {
        if (await GetCommentTextAsync(model.CommentText) != null)
        return false;

        var entity = new Comment
        {
            CommentText = model.CommentText
        };

        _context.Comments.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    private async Task<Comment> GetCommentTextAsync(string CommentText)
    {
        return await _context.Comments.FirstOrDefaultAsync(Comment => Comment.CommentText == CommentText);
    }
}