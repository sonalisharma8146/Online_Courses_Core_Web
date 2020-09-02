﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core_Web.BusinessLayer
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

    }
}
