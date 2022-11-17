namespace SocialNetwork.Core.Helpers.Abstract
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
}
}