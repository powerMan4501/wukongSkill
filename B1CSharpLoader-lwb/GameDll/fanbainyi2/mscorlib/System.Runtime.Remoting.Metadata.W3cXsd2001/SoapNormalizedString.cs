using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapNormalizedString : ISoapXsd
{
	private string _value;

	public static string XsdType => "normalizedString";

	public string Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = Validate(value);
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapNormalizedString()
	{
	}

	public SoapNormalizedString(string value)
	{
		_value = Validate(value);
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapNormalizedString Parse(string value)
	{
		return new SoapNormalizedString(value);
	}

	private string Validate(string value)
	{
		if (value == null || value.Length == 0)
		{
			return value;
		}
		char[] anyOf = new char[3] { '\r', '\n', '\t' };
		int num = value.LastIndexOfAny(anyOf);
		if (num > -1)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid", "xsd:normalizedString", value));
		}
		return value;
	}
}
