using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Domain.Models
{
    public class UserMessageEmail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; } = "myneverehyseni@gmail.com";
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
