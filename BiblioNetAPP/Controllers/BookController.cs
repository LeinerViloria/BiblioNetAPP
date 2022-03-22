﻿using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController:Controller
    {
        private readonly IRepositorieBooks repositorieBooks;
        public BookController(IRepositorieBooks repositorieBooks)
        {
            this.repositorieBooks = repositorieBooks;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Books book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            book.AuthorId = 2;
            this.repositorieBooks.Create(book);
            return View();
        }
    }
}
