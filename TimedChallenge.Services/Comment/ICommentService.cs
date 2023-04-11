public interface ICommentService
{
    Task<bool> RegisterCommentAsync(CommentRegister model);
}