using System.Collections;
using System.Configuration;
using System.Xml;

namespace System.Diagnostics;

internal class SwitchElement : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propName;

	private static readonly ConfigurationProperty _propValue;

	private Hashtable _attributes;

	public Hashtable Attributes
	{
		get
		{
			if (_attributes == null)
			{
				_attributes = new Hashtable(StringComparer.OrdinalIgnoreCase);
			}
			return _attributes;
		}
	}

	[ConfigurationProperty("name", DefaultValue = "", IsRequired = true, IsKey = true)]
	public string Name => (string)base[_propName];

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("value", IsRequired = true)]
	public string Value => (string)base[_propValue];

	static SwitchElement()
	{
		_propName = new ConfigurationProperty("name", typeof(string), "", ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
		_propValue = new ConfigurationProperty("value", typeof(string), null, ConfigurationPropertyOptions.IsRequired);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propName);
		_properties.Add(_propValue);
	}

	protected override bool OnDeserializeUnrecognizedAttribute(string name, string value)
	{
		Attributes.Add(name, value);
		return true;
	}

	protected override void PreSerialize(XmlWriter writer)
	{
		if (_attributes == null)
		{
			return;
		}
		IDictionaryEnumerator enumerator = _attributes.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string text = (string)enumerator.Value;
			string localName = (string)enumerator.Key;
			if (text != null)
			{
				writer?.WriteAttributeString(localName, text);
			}
		}
	}

	protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey)
	{
		return base.SerializeElement(writer, serializeCollectionKey) || (_attributes != null && _attributes.Count > 0);
	}

	protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
	{
		base.Unmerge(sourceElement, parentElement, saveMode);
		if (sourceElement is SwitchElement { _attributes: not null } switchElement)
		{
			_attributes = switchElement._attributes;
		}
	}

	internal void ResetProperties()
	{
		if (_attributes != null)
		{
			_attributes.Clear();
			_properties.Clear();
			_properties.Add(_propName);
			_properties.Add(_propValue);
		}
	}
}
