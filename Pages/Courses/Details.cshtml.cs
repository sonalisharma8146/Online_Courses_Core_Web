﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Online_Courses_Core_Web.BusinessLayer;
using Online_Courses_Core_Web.Models;

namespace Online_Courses_Core_Web.Pages.Courses
{
    //Gets the details of the course
    public class DetailsModel : PageModel
    {
        private readonly Online_Courses_Core_Web.Models.Online_Courses_Core_DataBaseContext _context;

        public DetailsModel(Online_Courses_Core_Web.Models.Online_Courses_Core_DataBaseContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
