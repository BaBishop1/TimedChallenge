using TimedChallenge.Data.Entities;
using Microsoft.EntityFrameworkCore;

public class ReplyService : IReplyService
{
    private readonly ApplicationDbContext _context;

    public ReplyService(ApplicationDbContext context) => _context = context;

    public async Task<bool> RegisterReplyAsync(ReplyRegister model)
    {
        var entity = new Reply 
        {
            ReplyText = model.ReplyText,
            AuthorID = model.AuthorID,
            DateCreated = model.DateCreated
        };

        _context.Reply.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1; 

    }

    private async Task<Reply> GetReplyAuthorIDAsync (Guid authorID)
    {
        return await _context.Reply.FirstOrDefaultAsync(reply => reply.AuthorID == authorID);
    }

}