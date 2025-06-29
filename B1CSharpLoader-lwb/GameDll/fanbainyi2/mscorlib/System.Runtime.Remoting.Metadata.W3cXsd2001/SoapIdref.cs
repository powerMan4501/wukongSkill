using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapIdref : ISoapXsd
{
	private string _value;

	public static string XsdType => "IDREF";

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

	public SoapIdref()
	{
	}

	public SoapIdref(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapIdref Parse(string value)
	{
		return new SoapIdref(value);
	}
}
