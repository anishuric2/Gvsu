﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gvsu.Models
{
    public class Student: Person
    {
        #region
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        #endregion
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Student")]
        public string StudentName
        {
            get
            {
                return FullName;
            }
        }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}