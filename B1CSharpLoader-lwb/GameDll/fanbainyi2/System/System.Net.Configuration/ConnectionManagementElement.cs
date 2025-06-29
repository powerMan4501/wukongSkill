using System.Configuration;

namespace System.Net.Configuration;

public sealed class ConnectionManagementElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty address = new ConfigurationProperty("address", typeof(string), null, ConfigurationPropertyOptions.IsKey);

	private readonly ConfigurationProperty maxconnection = new ConfigurationProperty("maxconnection", typeof(int), 1, ConfigurationPropertyOptions.None);

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

	[ConfigurationProperty("maxconnection", IsRequired = true, DefaultValue = 1)]
	public int MaxConnection
	{
		get
		{
			return (int)base[maxconnection];
		}
		set
		{
			base[maxconnection] = value;
		}
	}

	internal string Key => Address;

	public ConnectionManagementElement()
	{
		properties.Add(address);
		properties.Add(maxconnection);
	}

	public ConnectionManagementElement(string address, int maxConnection)
		: this()
	{
		Address = address;
		MaxConnection = maxConnection;
	}
}
