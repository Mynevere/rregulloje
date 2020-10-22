using Rregulloje.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Application.Interfaces
{
    public interface IEmailTemplateService
    {
        public Task<bool> SendUserMessageEmail(UserMessageEmailViewModel contactUsViewModel);
    }
}
