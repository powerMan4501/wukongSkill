using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapName : ISoapXsd
{
	private string _value;

	public static string XsdType => "Name";

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

	public SoapName()
	{
	}

	public SoapName(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapName Parse(string value)
	{
		return new SoapName(value);
	}
}
