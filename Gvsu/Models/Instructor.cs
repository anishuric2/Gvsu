﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gvsu.Models
{
    public class Instructor: Person
    {

        #region
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        #endregion
        public DateTime HireDate { get; set; }

        [Display(Name = "Instructor")]
        public string InstructorName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
        public OfficeAssignment? OfficeAssignment { get; set; }
    }
}