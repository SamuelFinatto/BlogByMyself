using BlogMyself.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlogMyself.Services
{
     
    public class ContactsService
    {
        private readonly BlogmyselfDBContext _context;

        public ContactsService(BlogmyselfDBContext blogmyselfDBContext)
        {
            _context = blogmyselfDBContext;
        }

        public async Task<bool> AddContactAsync(ContactDTO contact, CancellationToken ct = default)
        {
            _context.Contact.Add(new Models.Contact { Name = contact.Name, Phone = contact.Phone });
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<List<ContactDTO>> GetContactsAsync(CancellationToken ct = default)
        {
            return await (from con in _context.Contact
                          select new ContactDTO
                          {
                              Name = con.Name,
                              Phone = con.Phone
                          }).ToListAsync(ct);
        }
    }
}
