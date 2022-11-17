using SocialNetwork.Core.Helpers.Abstract;

namespace SocialNetwork.Core.Helpers.Concrete
{
    public class DataResult<TResult> : Result, IDataResult<TResult>
    {
        public DataResult(TResult data, bool success) : base(success)
        {
            Data = data;
        }
        public DataResult(TResult data, bool success, string message) : base(success)
        {
            Data = data;
        }
        public TResult Data { get; }
    }
}