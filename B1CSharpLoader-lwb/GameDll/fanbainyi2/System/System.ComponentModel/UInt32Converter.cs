using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class UInt32Converter : BaseNumberConverter
{
	internal override Type TargetType => typeof(uint);

	internal override object FromString(string value, int radix)
	{
		return Convert.ToUInt32(value, radix);
	}

	internal override object FromString(string value, NumberFormatInfo formatInfo)
	{
		return uint.Parse(value, NumberStyles.Integer, formatInfo);
	}

	internal override object FromString(string value, CultureInfo culture)
	{
		return uint.Parse(value, culture);
	}

	internal override string ToString(object value, NumberFormatInfo formatInfo)
	{
		return ((uint)value).ToString("G", formatInfo);
	}
}
