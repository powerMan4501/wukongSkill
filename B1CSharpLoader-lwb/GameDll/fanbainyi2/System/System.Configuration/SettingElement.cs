using System.Xml;

namespace System.Configuration;

public sealed class SettingElement : ConfigurationElement
{
	private static ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propName;

	private static readonly ConfigurationProperty _propSerializeAs;

	private static readonly ConfigurationProperty _propValue;

	private static XmlDocument doc;

	internal string Key => Name;

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("name", IsRequired = true, IsKey = true, DefaultValue = "")]
	public string Name
	{
		get
		{
			return (string)base[_propName];
		}
		set
		{
			base[_propName] = value;
		}
	}

	[ConfigurationProperty("serializeAs", IsRequired = true, DefaultValue = SettingsSerializeAs.String)]
	public SettingsSerializeAs SerializeAs
	{
		get
		{
			return (SettingsSerializeAs)base[_propSerializeAs];
		}
		set
		{
			base[_propSerializeAs] = value;
		}
	}

	[ConfigurationProperty("value", IsRequired = true, DefaultValue = null)]
	public SettingValueElement Value
	{
		get
		{
			return (SettingValueElement)base[_propValue];
		}
		set
		{
			base[_propValue] = value;
		}
	}

	static SettingElement()
	{
		_propName = new ConfigurationProperty("name", typeof(string), "", ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
		_propSerializeAs = new ConfigurationProperty("serializeAs", typeof(SettingsSerializeAs), SettingsSerializeAs.String, ConfigurationPropertyOptions.IsRequired);
		_propValue = new ConfigurationProperty("value", typeof(SettingValueElement), null, ConfigurationPropertyOptions.IsRequired);
		doc = new XmlDocument();
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propName);
		_properties.Add(_propSerializeAs);
		_properties.Add(_propValue);
	}

	public SettingElement()
	{
	}

	public SettingElement(string name, SettingsSerializeAs serializeAs)
		: this()
	{
		Name = name;
		SerializeAs = serializeAs;
	}

	public override bool Equals(object settings)
	{
		if (settings is SettingElement settingElement && base.Equals(settings))
		{
			return object.Equals(settingElement.Value, Value);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode() ^ Value.GetHashCode();
	}
}
