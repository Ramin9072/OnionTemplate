namespace _0_Framework.BaseResultState
{

    public class ResultDetails : IResultDetails
    {
        public string Message { get; set; }
        public bool Result { get; set; }

        public ResultDetails Success(string message)
        {
            Result = true;
            Message = message;
            return this;
        }
        public ResultDetails Fail(string message)
        {
            Result = false;
            Message = message;
            return this;
        }
    }

}
