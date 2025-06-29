using System.Configuration.Internal;
using System.IO;
using System.Security.Permissions;
using System.Xml;

namespace System.Configuration;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo
{
	private XmlTextReader _reader;

	private int _lineOffset;

	private string _filename;

	int IConfigErrorInfo.LineNumber
	{
		get
		{
			if (_reader == null)
			{
				return 0;
			}
			if (_lineOffset > 0)
			{
				return _reader.LineNumber + _lineOffset - 1;
			}
			return _reader.LineNumber;
		}
	}

	public int LineNumber => ((IConfigErrorInfo)this).LineNumber;

	public string Filename => ConfigurationException.SafeFilename(_filename);

	string IConfigErrorInfo.Filename => _filename;

	public override void Load(string filename)
	{
		_filename = filename;
		try
		{
			_reader = new XmlTextReader(filename);
			_reader.XmlResolver = null;
			base.Load(_reader);
		}
		finally
		{
			if (_reader != null)
			{
				_reader.Close();
				_reader = null;
			}
		}
	}

	public void LoadSingleElement(string filename, XmlTextReader sourceReader)
	{
		_filename = filename;
		_lineOffset = sourceReader.LineNumber;
		string s = sourceReader.ReadOuterXml();
		try
		{
			_reader = new XmlTextReader(new StringReader(s), sourceReader.NameTable);
			base.Load(_reader);
		}
		finally
		{
			if (_reader != null)
			{
				_reader.Close();
				_reader = null;
			}
		}
	}

	public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceUri)
	{
		return new System.Configuration.ConfigXmlAttribute(_filename, LineNumber, prefix, localName, namespaceUri, this);
	}

	public override XmlElement CreateElement(string prefix, string localName, string namespaceUri)
	{
		return new System.Configuration.ConfigXmlElement(_filename, LineNumber, prefix, localName, namespaceUri, this);
	}

	public override XmlText CreateTextNode(string text)
	{
		return new System.Configuration.ConfigXmlText(_filename, LineNumber, text, this);
	}

	public override XmlCDataSection CreateCDataSection(string data)
	{
		return new System.Configuration.ConfigXmlCDataSection(_filename, LineNumber, data, this);
	}

	public override XmlComment CreateComment(string data)
	{
		return new System.Configuration.ConfigXmlComment(_filename, LineNumber, data, this);
	}

	public override XmlSignificantWhitespace CreateSignificantWhitespace(string data)
	{
		return new System.Configuration.ConfigXmlSignificantWhitespace(_filename, LineNumber, data, this);
	}

	public override XmlWhitespace CreateWhitespace(string data)
	{
		return new System.Configuration.ConfigXmlWhitespace(_filename, LineNumber, data, this);
	}
}
