using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationHealthApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationHealthApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationHealthApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationHealthApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationHealthApi.EnableApiTrace")]
		public bool EnableApiTrace { get; set; }

		[YamlProperty("EducationHealthApi.MyNoSqlReaderHostPort")]
		public string MyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationHealthApi.AuthMyNoSqlReaderHostPort")]
		public string AuthMyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationHealthApi.SessionEncryptionKeyId")]
		public string SessionEncryptionKeyId { get; set; }

		[YamlProperty("EducationHealthApi.MyNoSqlWriterUrl")]
		public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationHealthApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }
	}
}