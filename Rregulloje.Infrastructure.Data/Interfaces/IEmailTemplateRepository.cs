using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Interfaces
{
    public interface IEmailTemplateRepository
    {
        public Task<EmailTemplates> GetEmailTemplate(string name);
        public Task<bool> SendUserMessageEmail(UserMessageEmail userMessageEmail);
        public Task<bool> SendIssueEmail(Issue issue);  
    }
}
