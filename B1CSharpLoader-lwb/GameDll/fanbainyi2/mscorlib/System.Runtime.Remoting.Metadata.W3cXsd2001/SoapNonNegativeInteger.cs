using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapNonNegativeInteger : ISoapXsd
{
	private decimal _value;

	public static string XsdType => "nonNegativeInteger";

	public decimal Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = decimal.Truncate(value);
			if (_value < 0m)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "xsd:nonNegativeInteger", value));
			}
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapNonNegativeInteger()
	{
	}

	public SoapNonNegativeInteger(decimal value)
	{
		_value = decimal.Truncate(value);
		if (_value < 0m)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "xsd:nonNegativeInteger", value));
		}
	}

	public override string ToString()
	{
		return _value.ToString(CultureInfo.InvariantCulture);
	}

	public static SoapNonNegativeInteger Parse(string value)
	{
		return new SoapNonNegativeInteger(decimal.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture));
	}
}
