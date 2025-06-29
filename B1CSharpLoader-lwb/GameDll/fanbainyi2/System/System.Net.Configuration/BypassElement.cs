using System.Configuration;

namespace System.Net.Configuration;

public sealed class BypassElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty address = new ConfigurationProperty("address", typeof(string), null, ConfigurationPropertyOptions.IsKey);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("address", IsRequired = true, IsKey = true)]
	public string Address
	{
		get
		{
			return (string)base[address];
		}
		set
		{
			base[address] = value;
		}
	}

	internal string Key => Address;

	public BypassElement()
	{
		properties.Add(address);
	}

	public BypassElement(string address)
		: this()
	{
		Address = address;
	}
}
