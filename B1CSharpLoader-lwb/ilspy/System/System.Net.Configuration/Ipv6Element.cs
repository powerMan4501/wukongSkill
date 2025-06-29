using System.Configuration;

namespace System.Net.Configuration;

public sealed class Ipv6Element : ConfigurationElement
{
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

	public Ipv6Element()
	{
		properties.Add(enabled);
	}
}
