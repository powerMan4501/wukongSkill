using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapToken : ISoapXsd
{
	private string _value;

	public static string XsdType => "token";

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

	public SoapToken()
	{
	}

	public SoapToken(string value)
	{
		_value = Validate(value);
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapToken Parse(string value)
	{
		return new SoapToken(value);
	}

	private string Validate(string value)
	{
		if (value == null || value.Length == 0)
		{
			return value;
		}
		char[] anyOf = new char[2] { '\r', '\t' };
		int num = value.LastIndexOfAny(anyOf);
		if (num > -1)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid", "xsd:token", value));
		}
		if (value.Length > 0 && (char.IsWhiteSpace(value[0]) || char.IsWhiteSpace(value[value.Length - 1])))
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid", "xsd:token", value));
		}
		num = value.IndexOf("  ");
		if (num > -1)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid", "xsd:token", value));
		}
		return value;
	}
}
