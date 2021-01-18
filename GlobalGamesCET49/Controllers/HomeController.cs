using GlobalGamesCET49.Data;
using GlobalGamesCET49.Data.Enteties;
using GlobalGamesCET49.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET49.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
       
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Registrations()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // O atributo ValidateAntiForgeryToken ajuda a evitar ataques de falsificação de solicitação entre sites  e requer uma instrução Html.AntiForgeryToken () 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrations([Bind("Id,FirstName,LastName, Adress, City, PhoneNumber, Email,Message")] Contact contacts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contacts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // POST: Registrations form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Services([Bind("Id,FirstName,LastName, Adress, City, IdCard, BirthDate")] Contact registrations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
