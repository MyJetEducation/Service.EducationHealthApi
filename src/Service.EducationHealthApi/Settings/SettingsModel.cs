using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationHealthApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationHealthApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationHealthApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationHealthApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationHealthApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}
