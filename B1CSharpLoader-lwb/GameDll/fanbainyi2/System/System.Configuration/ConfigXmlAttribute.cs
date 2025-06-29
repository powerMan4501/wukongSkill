using System.Configuration.Internal;
using System.Xml;

namespace System.Configuration;

internal sealed class ConfigXmlAttribute : XmlAttribute, IConfigErrorInfo
{
	private int _line;

	private string _filename;

	int IConfigErrorInfo.LineNumber => _line;

	string IConfigErrorInfo.Filename => _filename;

	public ConfigXmlAttribute(string filename, int line, string prefix, string localName, string namespaceUri, XmlDocument doc)
		: base(prefix, localName, namespaceUri, doc)
	{
		_line = line;
		_filename = filename;
	}

	public override XmlNode CloneNode(bool deep)
	{
		XmlNode xmlNode = base.CloneNode(deep);
		if (xmlNode is System.Configuration.ConfigXmlAttribute configXmlAttribute)
		{
			configXmlAttribute._line = _line;
			configXmlAttribute._filename = _filename;
		}
		return xmlNode;
	}
}
