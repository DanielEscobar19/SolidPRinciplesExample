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
        private EmailService EmailService;
        private DbService DbService;
        public UserService(EmailService emailService, DbService dbService) { 
            this.EmailService = emailService;
            this.DbService = dbService;
        }
        public void Register(string email)
        {
            if (EmailService.ValidateEmail(email) == false)
            {
                throw new ValidationException("Email is not an email");
            }

            this.DbService.RegisterUserEmail(email);

            EmailService.SendEmail("Hello I just registered my account!");
        }
    }

    public class EmailService {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@") && email.EndsWith(".com");
        }

        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending message: {message}");
        }
    }

    public class DbService
    {
        public void RegisterUserEmail(string email)
        {
            Console.WriteLine($"User: {email} has been registered successfully");

        }
    }
}
