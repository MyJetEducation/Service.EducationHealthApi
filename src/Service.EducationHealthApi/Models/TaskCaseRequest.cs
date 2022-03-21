using System.ComponentModel.DataAnnotations;

namespace Service.EducationHealthApi.Models
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}