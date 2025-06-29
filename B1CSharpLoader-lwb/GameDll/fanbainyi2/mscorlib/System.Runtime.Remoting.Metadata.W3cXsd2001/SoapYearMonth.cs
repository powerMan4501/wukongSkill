using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapYearMonth : ISoapXsd
{
	private DateTime _value = DateTime.MinValue;

	private int _sign;

	private static string[] formats = new string[6] { "yyyy-MM", "'+'yyyy-MM", "'-'yyyy-MM", "yyyy-MMzzz", "'+'yyyy-MMzzz", "'-'yyyy-MMzzz" };

	public static string XsdType => "gYearMonth";

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

	public int Sign
	{
		get
		{
			return _sign;
		}
		set
		{
			_sign = value;
		}
	}

	public string GetXsdType()
	{
		return XsdType;
	}

	public SoapYearMonth()
	{
	}

	public SoapYearMonth(DateTime value)
	{
		_value = value;
	}

	public SoapYearMonth(DateTime value, int sign)
	{
		_value = value;
		_sign = sign;
	}

	public override string ToString()
	{
		if (_sign < 0)
		{
			return _value.ToString("'-'yyyy-MM", CultureInfo.InvariantCulture);
		}
		return _value.ToString("yyyy-MM", CultureInfo.InvariantCulture);
	}

	public static SoapYearMonth Parse(string value)
	{
		int sign = 0;
		if (value[0] == '-')
		{
			sign = -1;
		}
		return new SoapYearMonth(DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None), sign);
	}
}
