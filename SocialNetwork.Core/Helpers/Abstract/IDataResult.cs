namespace SocialNetwork.Core.Helpers.Abstract
{
    public interface IDataResult<TResult> : IResult
    {
        TResult Data { get; }
    }
}