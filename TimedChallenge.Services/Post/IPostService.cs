public interface IPostService
{
    Task<bool> RegisterPostAsync(PostRegister model);
}