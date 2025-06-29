using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapNcName : ISoapXsd
{
	private string _value;

	public static string XsdType => "NCName";

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

	public SoapNcName()
	{
	}

	public SoapNcName(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapNcName Parse(string value)
	{
		return new SoapNcName(value);
	}
}
