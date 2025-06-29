using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapAnyUri : ISoapXsd
{
	private string _value;

	public static string XsdType => "anyURI";

	public string Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapAnyUri()
	{
	}

	public SoapAnyUri(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return _value;
	}

	public static SoapAnyUri Parse(string value)
	{
		return new SoapAnyUri(value);
	}
}
