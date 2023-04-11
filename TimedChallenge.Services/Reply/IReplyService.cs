public interface IReplyService
{
    Task<bool> RegisterReplyAsync(ReplyRegister model);
}