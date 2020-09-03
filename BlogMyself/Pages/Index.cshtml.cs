using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMyself.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BlogMyself.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ContactsService _service;

        public IndexModel(ILogger<IndexModel> logger, ContactsService contactsService)
        {
            _service = contactsService;
            _logger = logger;
        }
        [BindProperty]
        public ContactDTO ContactDTO { get; set; }

        [BindProperty]
        public List<ContactDTO> Contacts { get; set; }

        public async Task OnGet()
        {
            Contacts = await _service.GetContactsAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _service.AddContactAsync(ContactDTO);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> OnPostWay2(string data)
        {
            await _service.RemoveAllContactsAsync();
            return RedirectToAction("Index");
        }
    }
}
