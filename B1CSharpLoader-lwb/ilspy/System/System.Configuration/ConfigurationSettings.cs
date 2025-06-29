using System.Collections.Specialized;

namespace System.Configuration;

public sealed class ConfigurationSettings
{
	[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings")]
	public static NameValueCollection AppSettings => ConfigurationManager.AppSettings;

	private ConfigurationSettings()
	{
	}

	[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
	public static object GetConfig(string sectionName)
	{
		return ConfigurationManager.GetSection(sectionName);
	}
}
