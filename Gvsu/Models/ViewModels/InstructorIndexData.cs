﻿
using Gvsu.Models;

namespace Gvsu.Models.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor>? Instructors { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
        public IEnumerable<Enrollment>? Enrollments { get; set; }
    }
}
