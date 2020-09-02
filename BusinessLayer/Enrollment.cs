﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Courses_Core_Web.BusinessLayer
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int InstructorId { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }

        public Instructor Instructor { get; set; }

    }
}
