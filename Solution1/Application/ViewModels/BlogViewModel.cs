﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateUptaed { get; set; }
        public string LogoImagePath { get; set; }
        public Category Category { get; set; }
    }
}
