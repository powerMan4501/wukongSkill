using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapInteger : ISoapXsd
{
	private decimal _value;

	public static string XsdType => "integer";

	public decimal Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = decimal.Truncate(value);
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapInteger()
	{
	}

	public SoapInteger(decimal value)
	{
		_value = decimal.Truncate(value);
	}

	public override string ToString()
	{
		return _value.ToString(CultureInfo.InvariantCulture);
	}

	public static SoapInteger Parse(string value)
	{
		return new SoapInteger(decimal.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture));
	}
}
