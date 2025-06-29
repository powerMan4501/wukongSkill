using System.Configuration.Internal;
using System.Xml;

namespace System.Configuration;

internal sealed class ConfigXmlText : XmlText, IConfigErrorInfo
{
	private int _line;

	private string _filename;

	int IConfigErrorInfo.LineNumber => _line;

	string IConfigErrorInfo.Filename => _filename;

	public ConfigXmlText(string filename, int line, string strData, XmlDocument doc)
		: base(strData, doc)
	{
		_line = line;
		_filename = filename;
	}

	public override XmlNode CloneNode(bool deep)
	{
		XmlNode xmlNode = base.CloneNode(deep);
		if (xmlNode is System.Configuration.ConfigXmlText configXmlText)
		{
			configXmlText._line = _line;
			configXmlText._filename = _filename;
		}
		return xmlNode;
	}
}
