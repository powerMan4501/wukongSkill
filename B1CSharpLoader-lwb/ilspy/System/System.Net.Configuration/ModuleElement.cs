using System.Configuration;

namespace System.Net.Configuration;

public sealed class ModuleElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty type = new ConfigurationProperty("type", typeof(string), null, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("type")]
	public string Type
	{
		get
		{
			return (string)base[type];
		}
		set
		{
			base[type] = value;
		}
	}

	public ModuleElement()
	{
		properties.Add(type);
	}
}
