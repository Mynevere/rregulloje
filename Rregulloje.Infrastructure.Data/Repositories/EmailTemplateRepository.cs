using Microsoft.EntityFrameworkCore;
using Rregulloje.Domain.Context;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Helpers;
using Rregulloje.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Repositories
{
    public class EmailTemplateRepository : IEmailTemplateRepository
    {
        private readonly ApplicationDbContext _ctx;
        private readonly ISendEmailRepository _sendEmailRepository;


        public EmailTemplateRepository(ApplicationDbContext ctx, ISendEmailRepository sendEmailRepository) 
        {
            _ctx = ctx;
            _sendEmailRepository = sendEmailRepository;
        }

        public async Task<EmailTemplates> GetEmailTemplate(string name)
        {
            var emailTemplate = await _ctx.EmailTemplates.Where(x => x.Name == name).FirstOrDefaultAsync();

            return emailTemplate;
        }

        public async Task<string> GetSettingsByKey(string key)
        {
            var value = await _ctx.Settings
            .Where(x => x.Key == key)
            .Select(x => x.Value)
            .FirstOrDefaultAsync();
            return value;
        }

       
        public async Task<bool> SendUserMessageEmail(UserMessageEmail userMessageEmail)
        {
            var emailTemplate = await GetEmailTemplate(name: DataConstants.EmailTemplates.SendUserMessageEmail);

            string clientBaseUrl = await GetSettingsByKey(DataConstants.Settings.ClientBaseUrl);

            if (emailTemplate != null)
            {

                emailTemplate.Body = emailTemplate.Body.Replace("{{EMAIL}}", userMessageEmail.FromEmail)
                    .Replace("{{NAME}}", userMessageEmail.Name)
                    .Replace("{{SUBJECT}}", userMessageEmail.Subject)
                    .Replace("{{MESSAGE}}", userMessageEmail.Message);

                var result = _sendEmailRepository.SendEmail(emailTemplate, userMessageEmail.ToEmail);

                return result;
            }

            return false;
        }

        public async Task<bool> SendIssueEmail(Issue issue)
        {
            issue.Service = _ctx.Services.Where(x => x.Id == issue.ServiceId).FirstOrDefault();

            var emailTemplate = await GetEmailTemplate(name: DataConstants.EmailTemplates.SendIssueEmail);

            string clientBaseUrl = await GetSettingsByKey(DataConstants.Settings.ClientBaseUrl);

            if (emailTemplate != null)
            {

                emailTemplate.Body = emailTemplate.Body.Replace("{{EMAIL}}", issue.Email)
                    .Replace("{{NAME}}", issue.Name)
                    .Replace("{{LASTNAME}}", issue.LastName)
                    .Replace("{{CITY}}", issue.City)
                    .Replace("{{LIVINGOBJECT}}", issue.LivingObject)
                    .Replace("{{LIVINGENTRYNUMBER}}", issue.LivingEntryNumber)
                    .Replace("{{APARTMENTNUMBER}}", issue.ApartmentNumber)
                    .Replace("{{PHONENUMBER}}", issue.PhoneNumber)
                    .Replace("{{ISSUESUBJECT}}", issue.Service.Name)
                    .Replace("{{MESSAGE}}", issue.Message);

                var result = _sendEmailRepository.SendEmail(emailTemplate, issue.ToEmail);

                return result;
            }

            return false;
        }
    }
}
