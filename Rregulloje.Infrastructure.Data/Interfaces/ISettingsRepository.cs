using Rregulloje.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Interfaces
{
    public interface ISettingsRepository
    {
        Task<ContactUs> SendMessage(ContactUs contactUs);
    }
}
