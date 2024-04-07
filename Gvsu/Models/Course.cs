
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gvsu.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string? Prefix { get; set; }
        #region
        [Range(0, 999)]
        #endregion
        public int? Number { get; set; }
        #region
        [Range(0, 100)]
        #endregion
        public int? Section { get; set; }
        #region
        [StringLength(50, MinimumLength = 3)]
        #endregion
        public string? Title { get; set; }
        #region
        [Range(0, 100)]
        #endregion
        public int? Capacity { get; set; }
        #region
        [Range(0, 100)]
        #endregion
        public int? Count { get; set; }
        #region
        [Range(0, 5)]
        #endregion
        public int Credits { get; set; }
        public int? DepartmentID { get; set; }

        [Display(Name = "Course Name")]
        public string CourseNumber
        {
            get
            {
                return Number + "-" + Section;
            }
        }
        public Department? Department { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public ICollection<CourseAssignment>? CourseAssignments { get; set; }
    }
}