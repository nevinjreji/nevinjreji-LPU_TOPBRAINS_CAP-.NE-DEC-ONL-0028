using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Models
{
	public class Course
	{
		[Key]
		public int CourseId { get; set; }

		[Required]
		public string CourseName { get; set; }

		public string Duration { get; set; }

		public decimal Fees { get; set; }

		[ForeignKey("Department")]
		public int DepartmentId { get; set; }

		public Department Department { get; set; }
	}
}