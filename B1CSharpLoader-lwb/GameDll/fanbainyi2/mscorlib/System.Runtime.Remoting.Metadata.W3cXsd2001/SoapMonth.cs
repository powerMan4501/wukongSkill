using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata.W3cXsd2001;

[Serializable]
[ComVisible(true)]
public sealed class SoapMonth : ISoapXsd
{
	private DateTime _value = DateTime.MinValue;

	private static string[] formats = new string[2] { "--MM--", "--MM--zzz" };

	public static string XsdType => "gMonth";

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

	public SoapMonth()
	{
	}

	public SoapMonth(DateTime value)
	{
		_value = value;
	}

	public override string ToString()
	{
		return _value.ToString("--MM--", CultureInfo.InvariantCulture);
	}

	public static SoapMonth Parse(string value)
	{
		return new SoapMonth(DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture, DateTimeStyles.None));
	}
}
