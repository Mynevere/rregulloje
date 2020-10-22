using Rregulloje.Domain.Context;
using Rregulloje.Domain.Models;
using Rregulloje.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rregulloje.Infrastructure.Data.Repositories
{
    public class SettingsRepository : BaseRepository, ISettingsRepository
    {
        private readonly ApplicationDbContext _context;

        public SettingsRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        //public async Task<ContactUs> SendMessage(ContactUs contactUs)
        //{
        //    _context.ContactUs.Add(contactUs);
        //    await _context.SaveChangesAsync();

        //    return contactUs;
        //}
    }
}
