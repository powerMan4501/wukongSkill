using System.Security.Permissions;

namespace System.Diagnostics;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class UnescapedXmlDiagnosticData
{
	private string _xmlString;

	public string UnescapedXml
	{
		get
		{
			return _xmlString;
		}
		set
		{
			_xmlString = value;
		}
	}

	public UnescapedXmlDiagnosticData(string xmlPayload)
	{
		_xmlString = xmlPayload;
		if (_xmlString == null)
		{
			_xmlString = string.Empty;
		}
	}

	public override string ToString()
	{
		return _xmlString;
	}
}
