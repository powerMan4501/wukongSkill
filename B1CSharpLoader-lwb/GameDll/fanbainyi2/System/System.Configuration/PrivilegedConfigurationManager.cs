using System.Security.Permissions;

namespace System.Configuration;

[ConfigurationPermission(SecurityAction.Assert, Unrestricted = true)]
internal static class PrivilegedConfigurationManager
{
	internal static ConnectionStringSettingsCollection ConnectionStrings => ConfigurationManager.ConnectionStrings;

	internal static object GetSection(string sectionName)
	{
		return ConfigurationManager.GetSection(sectionName);
	}
}
