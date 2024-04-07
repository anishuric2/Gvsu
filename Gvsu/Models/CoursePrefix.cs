using System.ComponentModel.DataAnnotations;

namespace Gvsu.Models
{
    public class CoursePrefix
    {
        public int CoursePrefixID { get; set; }
        #region
        [StringLength(5, MinimumLength = 3)]
        #endregion
        public string? Prefix { get; set; }
    }
}
