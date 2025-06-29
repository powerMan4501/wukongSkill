namespace System.Configuration;

public sealed class ClientSettingsSection : ConfigurationSection
{
	private static ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propSettings;

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("", IsDefaultCollection = true)]
	public SettingElementCollection Settings => (SettingElementCollection)base[_propSettings];

	static ClientSettingsSection()
	{
		_propSettings = new ConfigurationProperty(null, typeof(SettingElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propSettings);
	}
}
