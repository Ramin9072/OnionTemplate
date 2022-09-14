using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Contract.Email
{
    public class EmailSendDTO
    {
        public string Subject { get; set; }
        public string EmailAddress { get; set; }
        public string Content { get; set; }
    }
}
