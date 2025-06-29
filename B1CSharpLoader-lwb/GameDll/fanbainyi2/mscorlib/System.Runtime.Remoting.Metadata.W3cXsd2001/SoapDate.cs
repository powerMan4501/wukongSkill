using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapDate : ISoapXsd
{
	private DateTime _value = DateTime.MinValue.Date;

	private int _sign;

	private static string[] formats = new string[6] { "yyyy-MM-dd", "'+'yyyy-MM-dd", "'-'yyyy-MM-dd", "yyyy-MM-ddzzz", "'+'yyyy-MM-ddzzz", "'-'yyyy-MM-ddzzz" };

	public static string XsdType => "date";

	public DateTime Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value.Date;
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

	public SoapDate()
	{
	}

	public SoapDate(DateTime value)
	{
		_value = value;
	}

	public SoapDate(DateTime value, int sign)
	{
		_value = value;
		_sign = sign;
	}

	public override string ToString()
	{
		if (_sign < 0)
		{
			return _value.ToString("'-'yyyy-MM-dd", CultureInfo.InvariantCulture);
		}
		return _value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
	}

	public static SoapDate Parse(string value)
	{
		int sign = 0;
		if (value[0] == '-')
		{
			sign = -1;
		}
		return new SoapDate(DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None), sign);
	}
}
