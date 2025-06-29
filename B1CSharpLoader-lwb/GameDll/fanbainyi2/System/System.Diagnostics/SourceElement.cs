using System.Collections;
using System.Configuration;
using System.Xml;

namespace System.Diagnostics;

internal class SourceElement : ConfigurationElement
{
	private static readonly ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propName;

	private static readonly ConfigurationProperty _propSwitchName;

	private static readonly ConfigurationProperty _propSwitchValue;

	private static readonly ConfigurationProperty _propSwitchType;

	private static readonly ConfigurationProperty _propListeners;

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

	[ConfigurationProperty("listeners")]
	public ListenerElementsCollection Listeners => (ListenerElementsCollection)base[_propListeners];

	[ConfigurationProperty("name", IsRequired = true, DefaultValue = "")]
	public string Name => (string)base[_propName];

	protected override ConfigurationPropertyCollection Properties => _properties;

	[ConfigurationProperty("switchName")]
	public string SwitchName => (string)base[_propSwitchName];

	[ConfigurationProperty("switchValue")]
	public string SwitchValue => (string)base[_propSwitchValue];

	[ConfigurationProperty("switchType")]
	public string SwitchType => (string)base[_propSwitchType];

	static SourceElement()
	{
		_propName = new ConfigurationProperty("name", typeof(string), "", ConfigurationPropertyOptions.IsRequired);
		_propSwitchName = new ConfigurationProperty("switchName", typeof(string), null, ConfigurationPropertyOptions.None);
		_propSwitchValue = new ConfigurationProperty("switchValue", typeof(string), null, ConfigurationPropertyOptions.None);
		_propSwitchType = new ConfigurationProperty("switchType", typeof(string), null, ConfigurationPropertyOptions.None);
		_propListeners = new ConfigurationProperty("listeners", typeof(ListenerElementsCollection), new ListenerElementsCollection(), ConfigurationPropertyOptions.None);
		_properties = new ConfigurationPropertyCollection();
		_properties.Add(_propName);
		_properties.Add(_propSwitchName);
		_properties.Add(_propSwitchValue);
		_properties.Add(_propSwitchType);
		_properties.Add(_propListeners);
	}

	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
	{
		base.DeserializeElement(reader, serializeCollectionKey);
		if (!string.IsNullOrEmpty(SwitchName) && !string.IsNullOrEmpty(SwitchValue))
		{
			throw new ConfigurationErrorsException(SR.GetString("Only_specify_one", Name));
		}
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
		if (sourceElement is SourceElement { _attributes: not null } sourceElement2)
		{
			_attributes = sourceElement2._attributes;
		}
	}

	internal void ResetProperties()
	{
		if (_attributes != null)
		{
			_attributes.Clear();
			_properties.Clear();
			_properties.Add(_propName);
			_properties.Add(_propSwitchName);
			_properties.Add(_propSwitchValue);
			_properties.Add(_propSwitchType);
			_properties.Add(_propListeners);
		}
	}
}
