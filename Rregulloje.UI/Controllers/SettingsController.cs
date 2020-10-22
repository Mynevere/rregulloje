using Microsoft.AspNetCore.Mvc;
using Rregulloje.Application.Interfaces;
using Rregulloje.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rregulloje.UI.Controllers
{
    public class SettingsController : BaseApiController
    {
        private readonly IEmailTemplateService _emailTemplateService; 

        public SettingsController(IEmailTemplateService emailTemplateService)
        {
            _emailTemplateService = emailTemplateService;
        }

        [HttpPost("sendUserMessageEmail")]
        public async Task<IActionResult> SendUserMessageEmail([FromBody]UserMessageEmailViewModel userMessageEmailView)
        {
            var emails = await _emailTemplateService.SendUserMessageEmail(userMessageEmailView);

            return Ok();
        }

        [HttpPost("sendIssueEmail")]
        public async Task<IActionResult> SendIssueEmail([FromBody]IssueViewModel issueViewModel)
        {
            var emails = await _emailTemplateService.SendIssueEmail(issueViewModel);

            return Ok();
        }
    }
}
