
namespace Onion.Domain.ExceptionAgg
{
    public class OnionException : System.Exception
    {
        public OnionException()
        {

        }
        public OnionException(string message , string Code) 
            :base(string.Format("Onion Custome Exception has one Message:{0} ,and One Code {1}",message,Code))
        {

        }
    }
}
