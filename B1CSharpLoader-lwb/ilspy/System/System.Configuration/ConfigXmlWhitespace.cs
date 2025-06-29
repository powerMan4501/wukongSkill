using System.Configuration.Internal;
using System.Xml;

namespace System.Configuration;

internal sealed class ConfigXmlWhitespace : XmlWhitespace, IConfigErrorInfo
{
	private int _line;

	private string _filename;

	int IConfigErrorInfo.LineNumber => _line;

	string IConfigErrorInfo.Filename => _filename;

	public ConfigXmlWhitespace(string filename, int line, string comment, XmlDocument doc)
		: base(comment, doc)
	{
		_line = line;
		_filename = filename;
	}

	public override XmlNode CloneNode(bool deep)
	{
		XmlNode xmlNode = base.CloneNode(deep);
		if (xmlNode is System.Configuration.ConfigXmlWhitespace configXmlWhitespace)
		{
			configXmlWhitespace._line = _line;
			configXmlWhitespace._filename = _filename;
		}
		return xmlNode;
	}
}
