namespace System.Configuration;

public sealed class IriParsingElement : ConfigurationElement
{
	internal const bool EnabledDefaultValue = false;

	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty enabled = new ConfigurationProperty("enabled", typeof(bool), false, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("enabled", DefaultValue = false)]
	public bool Enabled
	{
		get
		{
			return (bool)base[enabled];
		}
		set
		{
			base[enabled] = value;
		}
	}

	public IriParsingElement()
	{
		properties.Add(enabled);
	}
}
