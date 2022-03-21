using System.ComponentModel.DataAnnotations;

namespace Service.EducationHealthApi.Models
{
	public class TaskGameRequest : TaskRequestBase
	{
		[Required]
		public bool Passed { get; set; }
	}
}