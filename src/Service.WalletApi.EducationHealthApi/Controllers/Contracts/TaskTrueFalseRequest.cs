using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationHealthApi.Controllers.Contracts
{
	public class TaskTrueFalseRequest : TaskRequestBase
	{
		[Required]
		public TaskTrueFalse[] Answers { get; set; }
	}
}