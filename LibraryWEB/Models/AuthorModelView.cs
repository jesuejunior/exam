﻿using Business.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWEB.Models
{
    public class AuthorModelView
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public AuthorModelView fromModel(Author model)
        {
            this.AuthorId = model.AuthorId;
            this.FirstName = model.FirstName;
            this.LastName = model.LastName;
            this.Books = model.Books;
            return this;
        }
    }
}