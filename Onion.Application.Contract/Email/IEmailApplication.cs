namespace Onion.Application.Contract.Email
{
    public interface IEmailApplication
    {
        Task  EmailSendAsync(EmailSendDTO command);
        Task EmailResivedAsync(EmailResivedDTO command);

    }
}
