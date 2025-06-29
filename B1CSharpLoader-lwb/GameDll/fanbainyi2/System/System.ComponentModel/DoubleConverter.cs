using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class DoubleConverter : BaseNumberConverter
{
	internal override bool AllowHex => false;

	internal override Type TargetType => typeof(double);

	internal override object FromString(string value, int radix)
	{
		return Convert.ToDouble(value, CultureInfo.CurrentCulture);
	}

	internal override object FromString(string value, NumberFormatInfo formatInfo)
	{
		return double.Parse(value, NumberStyles.Float, formatInfo);
	}

	internal override object FromString(string value, CultureInfo culture)
	{
		return double.Parse(value, culture);
	}

	internal override string ToString(object value, NumberFormatInfo formatInfo)
	{
		return ((double)value).ToString("R", formatInfo);
	}
}
