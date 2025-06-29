using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapPositiveInteger : ISoapXsd
{
	private decimal _value;

	public static string XsdType => "positiveInteger";

	public decimal Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = decimal.Truncate(value);
			if (_value < 1m)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "xsd:positiveInteger", value));
			}
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapPositiveInteger()
	{
	}

	public SoapPositiveInteger(decimal value)
	{
		_value = decimal.Truncate(value);
		if (_value < 1m)
		{
			throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_SOAPInteropxsdInvalid"), "xsd:positiveInteger", value));
		}
	}

	public override string ToString()
	{
		return _value.ToString(CultureInfo.InvariantCulture);
	}

	public static SoapPositiveInteger Parse(string value)
	{
		return new SoapPositiveInteger(decimal.Parse(value, NumberStyles.Integer, CultureInfo.InvariantCulture));
	}
}
