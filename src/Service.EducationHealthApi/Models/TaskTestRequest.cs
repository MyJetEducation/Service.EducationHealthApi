using System.ComponentModel.DataAnnotations;

namespace Service.EducationHealthApi.Models
{
	public class TaskTestRequest : TaskRequestBase
	{
		[Required]
		public TaskAnswer[] Answers { get; set; }
	}
}