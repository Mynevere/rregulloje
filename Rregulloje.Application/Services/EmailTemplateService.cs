using AutoMapper;
using Rregulloje.Application.Interfaces;
using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Interfaces;
using Rregulloje.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Application.Services
{
    public class EmailTemplateService : IEmailTemplateService
    {
        private readonly IEmailTemplateRepository _emailTemplateRepository;
        private readonly ISettingsRepository _settingsRepository;

        private readonly IMapper _mapper;

        public EmailTemplateService(IEmailTemplateRepository emailTemplateRepository, ISettingsRepository settingsRepository, 
            IMapper mapper)
        {
            _emailTemplateRepository = emailTemplateRepository;
            _settingsRepository = settingsRepository;
            _mapper = mapper;
        } 

        public async Task<bool> SendUserMessageEmail(UserMessageEmailViewModel userMessageEmailView)
        {
            var userEmailMessage = _mapper.Map<UserMessageEmail>(userMessageEmailView);
            return await _emailTemplateRepository.SendUserMessageEmail(userEmailMessage);

        }

        public async Task<bool> SendIssueEmail(IssueViewModel issueViewModel)
        {
            var issueEmail = _mapper.Map<Issue>(issueViewModel);
            return await _emailTemplateRepository.SendIssueEmail(issueEmail); 

        }
    }
}
