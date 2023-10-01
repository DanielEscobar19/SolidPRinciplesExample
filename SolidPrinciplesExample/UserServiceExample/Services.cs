using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesExample.UserServiceExample
{
    public class UserService
    {
        private EmailService emailService;
        public UserService(EmailService aEmailService) { 
            this.emailService = emailService;
        }
        public void Register(string email)
        {
            if (emailService.ValidateEmail(email) == false)
            {
                throw new ValidationException("Email is not an email");
            }

            emailService.SendEmail("Hello I just registered my account!");
        }
    }

    public class EmailService {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending messahe: {message}");
        }
    }
}
