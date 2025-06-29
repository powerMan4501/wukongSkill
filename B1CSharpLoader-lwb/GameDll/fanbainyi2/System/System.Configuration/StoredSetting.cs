using System.Xml;

namespace System.Configuration;

internal struct StoredSetting
{
	internal SettingsSerializeAs SerializeAs;

	internal XmlNode Value;

	internal StoredSetting(SettingsSerializeAs serializeAs, XmlNode value)
	{
		SerializeAs = serializeAs;
		Value = value;
	}
}
