namespace _0_Framework.BaseResultState
{
    public interface IResultDetails
    {
        public ResultDetails Success(string message);
        public ResultDetails Fail(string message);
    }
}
