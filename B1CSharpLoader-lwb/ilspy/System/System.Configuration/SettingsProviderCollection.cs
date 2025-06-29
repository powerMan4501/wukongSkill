using System.Configuration.Provider;

namespace System.Configuration;

public class SettingsProviderCollection : ProviderCollection
{
	public new SettingsProvider this[string name] => (SettingsProvider)base[name];

	public override void Add(ProviderBase provider)
	{
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!(provider is SettingsProvider))
		{
			throw new ArgumentException(SR.GetString("Config_provider_must_implement_type", typeof(SettingsProvider).ToString()), "provider");
		}
		base.Add(provider);
	}
}
