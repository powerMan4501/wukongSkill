using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapDay : ISoapXsd
{
	private DateTime _value = DateTime.MinValue;

	private static string[] formats = new string[2] { "---dd", "---ddzzz" };

	public static string XsdType => "gDay";

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

	public SoapDay()
	{
	}

	public SoapDay(DateTime value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return _value.ToString("---dd", CultureInfo.InvariantCulture);
	}

	public static SoapDay Parse(string value)
	{
		return new SoapDay(DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None));
	}
}
