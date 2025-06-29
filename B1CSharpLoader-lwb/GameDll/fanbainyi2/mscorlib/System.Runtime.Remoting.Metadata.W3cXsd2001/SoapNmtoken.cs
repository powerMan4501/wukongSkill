using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapNmtoken : ISoapXsd
{
	private string _value;

	public static string XsdType => "NMTOKEN";

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

	public SoapNmtoken()
	{
	}

	public SoapNmtoken(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapNmtoken Parse(string value)
	{
		return new SoapNmtoken(value);
	}
}
