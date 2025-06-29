using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapMonthDay : ISoapXsd
{
	private DateTime _value = DateTime.MinValue;

	private static string[] formats = new string[2] { "--MM-dd", "--MM-ddzzz" };

	public static string XsdType => "gMonthDay";

	public DateTime Value
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

	public SoapMonthDay()
	{
	}

	public SoapMonthDay(DateTime value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return _value.ToString("'--'MM'-'dd", CultureInfo.InvariantCulture);
	}

	public static SoapMonthDay Parse(string value)
	{
		return new SoapMonthDay(DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None));
	}
}
