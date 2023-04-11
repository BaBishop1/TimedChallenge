public class PostService : IPostService
{
    private readonly ApplicationDbContext _context;
    public PostService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> RegisterUserAsync(PostRegister model)
    {

    }
}