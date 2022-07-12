﻿using Onion.Application.Contract.Email;
using Onion.Domain.EmailAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application
{
    public class EmailApplication : IEmailApplication
    { 
        public async Task EmailSendAsync(EmailSend command)
        {
            await SendEmailAsync(command);
            Console.WriteLine();
        }
        private Task<string> SendEmailAsync(EmailSend command)
        {
            Email email = new Email(command.Subject, command.EmailAddress, command.Content);
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(10000);
                return "EMAIL SEND";
            });
        }
        public async Task EmailResivedAsync(EmailResived command)
        {
          
        }
    }
}