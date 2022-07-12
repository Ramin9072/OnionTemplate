namespace Onion.Application.Contract.Email
{
    public interface IEmailApplication
    {
        Task  EmailSendAsync(EmailSend command);
        Task EmailResivedAsync(EmailResived command);

    }
}
