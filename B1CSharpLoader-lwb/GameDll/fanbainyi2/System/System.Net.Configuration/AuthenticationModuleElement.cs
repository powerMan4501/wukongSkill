using System.Configuration;

namespace System.Net.Configuration;

public sealed class AuthenticationModuleElement : ConfigurationElement
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty type = new ConfigurationProperty("type", typeof(string), null, ConfigurationPropertyOptions.IsKey);

	protected override ConfigurationPropertyCollection Properties => properties;

	[ConfigurationProperty("type", IsRequired = true, IsKey = true)]
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

	internal string Key => Type;

	public AuthenticationModuleElement()
	{
		properties.Add(type);
	}

	public AuthenticationModuleElement(string typeName)
		: this()
	{
		if (typeName != (string)type.DefaultValue)
		{
			Type = typeName;
		}
	}
}
