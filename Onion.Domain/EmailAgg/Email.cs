using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.EmailAgg
{
    public class Email
    {
        public Email(string subject, 
            string emailAddress, 
            string content)
        {
            Subject = subject;
            EmailAddress = emailAddress;
            Content = content;
        }

        public string Subject { get; private set; }
        public string EmailAddress { get; private set; }
        public string Content { get; set; }

    }
}
