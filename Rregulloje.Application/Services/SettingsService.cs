using AutoMapper;
using Rregulloje.Application.Interfaces;
using Rregulloje.Application.ViewModels;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Application.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly ISettingsRepository _settingsRepository;
        private readonly IMapper _mapper;

        public SettingsService(ISettingsRepository settingsRepository, IMapper mapper)
        {
            _settingsRepository = settingsRepository;
            _mapper = mapper;
        }

        public async Task<ContactUsViewModel> SendMessage(ContactUsViewModel contactUsViewModel)
        {
            ContactUs sendMessage = new ContactUs()
            {
                Name = contactUsViewModel.Name,
                Email = contactUsViewModel.Email,
                Subject = contactUsViewModel.Subject,
                Message = contactUsViewModel.Message
            };

            var message = await _settingsRepository.SendMessage(sendMessage);
            return _mapper.Map<ContactUsViewModel>(message);
        }
    }
}
