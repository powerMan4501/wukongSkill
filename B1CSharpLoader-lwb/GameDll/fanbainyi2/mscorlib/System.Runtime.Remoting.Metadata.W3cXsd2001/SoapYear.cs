using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapYear : ISoapXsd
{
	private DateTime _value = DateTime.MinValue;

	private int _sign;

	private static string[] formats = new string[6] { "yyyy", "'+'yyyy", "'-'yyyy", "yyyyzzz", "'+'yyyyzzz", "'-'yyyyzzz" };

	public static string XsdType => "gYear";

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

	public SoapYear()
	{
	}

	public SoapYear(DateTime value)
	{
		_value = value;
	}

	public SoapYear(DateTime value, int sign)
	{
		_value = value;
		_sign = sign;
	}

	public override string ToString()
	{
		if (_sign < 0)
		{
			return _value.ToString("'-'yyyy", CultureInfo.InvariantCulture);
		}
		return _value.ToString("yyyy", CultureInfo.InvariantCulture);
	}

	public static SoapYear Parse(string value)
	{
		int sign = 0;
		if (value[0] == '-')
		{
			sign = -1;
		}
		return new SoapYear(DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None), sign);
	}
}
