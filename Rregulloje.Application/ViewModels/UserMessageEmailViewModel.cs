using System;
using System.Collections.Generic;
using System.Text;

namespace Rregulloje.Application.ViewModels
{
    public class UserMessageEmailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; set; } 
        public string Subject { get; set; }
        public string Message { get; set; } 
    }
}
