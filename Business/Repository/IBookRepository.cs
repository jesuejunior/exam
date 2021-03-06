﻿using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business.Repository
{
    public interface IBookRepository
    {
        Book Create(string Isbn, string Title, int Year, ICollection<Author> Authors);
        Book Update(int Id, string Isbn, string Title, int Year);
        Book Get(int? Id);
        Book Delete(int? id);
        List<Book> GetAll();
        bool Exist(int? id);
    }
}