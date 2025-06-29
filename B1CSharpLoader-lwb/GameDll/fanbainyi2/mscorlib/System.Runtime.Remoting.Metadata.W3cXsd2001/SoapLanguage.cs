using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapLanguage : ISoapXsd
{
	private string _value;

	public static string XsdType => "language";

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

	public SoapLanguage()
	{
	}

	public SoapLanguage(string value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return SoapType.Escape(_value);
	}

	public static SoapLanguage Parse(string value)
	{
		return new SoapLanguage(value);
	}
}
