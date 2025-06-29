using System.Net.Configuration;

namespace System.Configuration.Internal;

internal sealed class ConfigurationManagerHelper : IConfigurationManagerHelper
{
	private ConfigurationManagerHelper()
	{
	}

	void IConfigurationManagerHelper.EnsureNetConfigLoaded()
	{
		SettingsSection.EnsureConfigLoaded();
	}
}
