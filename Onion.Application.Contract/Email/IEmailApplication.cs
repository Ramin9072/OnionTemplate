namespace Onion.Application.Contract.Email
{
    public interface IEmailApplication
    {
        Task  EmailSendAsync(EmailSendDTO command, out string message);
        Task EmailResivedAsync(EmailResivedDTO command);

    }
}
