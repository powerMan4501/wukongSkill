using System.Configuration;

namespace System.Security.Authentication.ExtendedProtection.Configuration;

public sealed class ServiceNameElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty name = new ConfigurationProperty("name", typeof(string), null, ConfigurationPropertyOptions.IsRequired);

	[ConfigurationProperty("name")]
	public string Name
	{
		get
		{
			return (string)base[name];
		}
		set
		{
			base[name] = value;
		}
	}

	protected override ConfigurationPropertyCollection Properties => properties;

	internal string Key => Name;

	public ServiceNameElement()
	{
		properties.Add(name);
	}
}
