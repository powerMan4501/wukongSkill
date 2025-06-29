using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ByteConverter : BaseNumberConverter
{
	internal override Type TargetType => typeof(byte);

	internal override object FromString(string value, int radix)
	{
		return Convert.ToByte(value, radix);
	}

	internal override object FromString(string value, NumberFormatInfo formatInfo)
	{
		return byte.Parse(value, NumberStyles.Integer, formatInfo);
	}

	internal override object FromString(string value, CultureInfo culture)
	{
		return byte.Parse(value, culture);
	}

	internal override string ToString(object value, NumberFormatInfo formatInfo)
	{
		return ((byte)value).ToString("G", formatInfo);
	}
}
