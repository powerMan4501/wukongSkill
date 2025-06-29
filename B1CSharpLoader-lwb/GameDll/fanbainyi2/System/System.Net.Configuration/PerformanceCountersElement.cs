using System.Configuration;

namespace System.Net.Configuration;

public sealed class PerformanceCountersElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty enabled = new ConfigurationProperty("enabled", typeof(bool), false, ConfigurationPropertyOptions.None);

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

	protected override ConfigurationPropertyCollection Properties => properties;

	public PerformanceCountersElement()
	{
		properties.Add(enabled);
	}
}
