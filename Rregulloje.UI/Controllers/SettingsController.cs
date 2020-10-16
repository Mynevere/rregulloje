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
        private readonly ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpPost("sendMessage")]
        public async Task<IActionResult> SendMessage(ContactUsViewModel contactUsViewModel) 
        {
            var sendMessage = await _settingsService.SendMessage(contactUsViewModel);
            return Ok(sendMessage);
        }
    }
}
