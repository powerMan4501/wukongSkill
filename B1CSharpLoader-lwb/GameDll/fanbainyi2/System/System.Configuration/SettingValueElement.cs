using System.Xml;

namespace System.Configuration;

public sealed class SettingValueElement : ConfigurationElement
{
	private static volatile ConfigurationPropertyCollection _properties;

	private static XmlDocument doc = new XmlDocument();

	private XmlNode _valueXml;

	private bool isModified;

	protected override ConfigurationPropertyCollection Properties
	{
		get
		{
			if (_properties == null)
			{
				_properties = new ConfigurationPropertyCollection();
			}
			return _properties;
		}
	}

	public XmlNode ValueXml
	{
		get
		{
			return _valueXml;
		}
		set
		{
			_valueXml = value;
			isModified = true;
		}
	}

	protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
	{
		ValueXml = doc.ReadNode(reader);
	}

	public override bool Equals(object settingValue)
	{
		if (settingValue is SettingValueElement settingValueElement)
		{
			return object.Equals(settingValueElement.ValueXml, ValueXml);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ValueXml.GetHashCode();
	}

	protected override bool IsModified()
	{
		return isModified;
	}

	protected override void ResetModified()
	{
		isModified = false;
	}

	protected override bool SerializeToXmlElement(XmlWriter writer, string elementName)
	{
		if (ValueXml != null)
		{
			if (writer != null)
			{
				ValueXml.WriteTo(writer);
			}
			return true;
		}
		return false;
	}

	protected override void Reset(ConfigurationElement parentElement)
	{
		base.Reset(parentElement);
		ValueXml = ((SettingValueElement)parentElement).ValueXml;
	}

	protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
	{
		base.Unmerge(sourceElement, parentElement, saveMode);
		ValueXml = ((SettingValueElement)sourceElement).ValueXml;
	}
}
