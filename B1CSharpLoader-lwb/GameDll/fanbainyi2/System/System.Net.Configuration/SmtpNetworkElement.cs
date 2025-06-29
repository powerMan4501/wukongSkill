using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration;

public sealed class SmtpNetworkElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty defaultCredentials = new ConfigurationProperty("defaultCredentials", typeof(bool), false, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty host = new ConfigurationProperty("host", typeof(string), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty clientDomain = new ConfigurationProperty("clientDomain", typeof(string), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty password = new ConfigurationProperty("password", typeof(string), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty port = new ConfigurationProperty("port", typeof(int), 25, null, new IntegerValidator(1, 65535), ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty userName = new ConfigurationProperty("userName", typeof(string), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty targetName = new ConfigurationProperty("targetName", typeof(string), null, ConfigurationPropertyOptions.None);

	private readonly ConfigurationProperty enableSsl = new ConfigurationProperty("enableSsl", typeof(bool), false, ConfigurationPropertyOptions.None);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("defaultCredentials", DefaultValue = false)]
	public bool DefaultCredentials
	{
		get
		{
			return (bool)base[defaultCredentials];
		}
		set
		{
			base[defaultCredentials] = value;
		}
	}

	[ConfigurationProperty("host")]
	public string Host
	{
		get
		{
			return (string)base[host];
		}
		set
		{
			base[host] = value;
		}
	}

	[ConfigurationProperty("targetName")]
	public string TargetName
	{
		get
		{
			return (string)base[targetName];
		}
		set
		{
			base[targetName] = value;
		}
	}

	[ConfigurationProperty("clientDomain")]
	public string ClientDomain
	{
		get
		{
			return (string)base[clientDomain];
		}
		set
		{
			base[clientDomain] = value;
		}
	}

	[ConfigurationProperty("password")]
	public string Password
	{
		get
		{
			return (string)base[password];
		}
		set
		{
			base[password] = value;
		}
	}

	[ConfigurationProperty("port", DefaultValue = 25)]
	public int Port
	{
		get
		{
			return (int)base[port];
		}
		set
		{
			base[port] = value;
		}
	}

	[ConfigurationProperty("userName")]
	public string UserName
	{
		get
		{
			return (string)base[userName];
		}
		set
		{
			base[userName] = value;
		}
	}

	[ConfigurationProperty("enableSsl", DefaultValue = false)]
	public bool EnableSsl
	{
		get
		{
			return (bool)base[enableSsl];
		}
		set
		{
			base[enableSsl] = value;
		}
	}

	public SmtpNetworkElement()
	{
		properties.Add(defaultCredentials);
		properties.Add(host);
		properties.Add(clientDomain);
		properties.Add(password);
		properties.Add(port);
		properties.Add(userName);
		properties.Add(targetName);
		properties.Add(enableSsl);
	}

	protected override void PostDeserialize()
	{
		if (base.EvaluationContext.IsMachineLevel)
		{
			return;
		}
		PropertyInformation propertyInformation = base.ElementInformation.Properties["port"];
		if (propertyInformation.ValueOrigin != PropertyValueOrigin.SetHere || (int)propertyInformation.Value == (int)propertyInformation.DefaultValue)
		{
			return;
		}
		try
		{
			new SmtpPermission(SmtpAccess.ConnectToUnrestrictedPort).Demand();
		}
		catch (Exception inner)
		{
			throw new ConfigurationErrorsException(SR.GetString("net_config_property_permission", propertyInformation.Name), inner);
		}
	}
}
