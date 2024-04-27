﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Book
    {
        [Key,Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string author {  get; set; }
        public string Publisher {  get; set; }
        public List<UserBook> Borrows { get; set; }
        
        public Book()
        {

        }
        

    }
}
