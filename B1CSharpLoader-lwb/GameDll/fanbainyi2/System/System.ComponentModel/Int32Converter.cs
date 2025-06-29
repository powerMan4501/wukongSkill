using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class Int32Converter : BaseNumberConverter
{
	internal override Type TargetType => typeof(int);

	internal override object FromString(string value, int radix)
	{
		return Convert.ToInt32(value, radix);
	}

	internal override object FromString(string value, NumberFormatInfo formatInfo)
	{
		return int.Parse(value, NumberStyles.Integer, formatInfo);
	}

	internal override object FromString(string value, CultureInfo culture)
	{
		return int.Parse(value, culture);
	}

	internal override string ToString(object value, NumberFormatInfo formatInfo)
	{
		return ((int)value).ToString("G", formatInfo);
	}
}
