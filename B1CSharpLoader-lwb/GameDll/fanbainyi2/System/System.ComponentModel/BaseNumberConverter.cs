using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class BaseNumberConverter : TypeConverter
{
	internal virtual bool AllowHex => true;

	internal abstract Type TargetType { get; }

	internal abstract object FromString(string value, int radix);

	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	internal abstract object FromString(string value, CultureInfo culture);

	internal virtual Exception FromStringError(string failedText, Exception innerException)
	{
		return new Exception(SR.GetString("ConvertInvalidPrimitive", failedText, TargetType.Name), innerException);
	}

	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == typeof(string))
		{
			return true;
		}
		return base.CanConvertFrom(context, sourceType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			string text = ((string)value).Trim();
			try
			{
				if (AllowHex && text[0] == '#')
				{
					return FromString(text.Substring(1), 16);
				}
				if ((AllowHex && text.StartsWith("0x")) || text.StartsWith("0X") || text.StartsWith("&h") || text.StartsWith("&H"))
				{
					return FromString(text.Substring(2), 16);
				}
				if (culture == null)
				{
					culture = CultureInfo.CurrentCulture;
				}
				NumberFormatInfo formatInfo = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
				return FromString(text, formatInfo);
			}
			catch (Exception innerException)
			{
				throw FromStringError(text, innerException);
			}
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		if (destinationType == typeof(string) && value != null && TargetType.IsInstanceOfType(value))
		{
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			NumberFormatInfo numberFormatInfo = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
			return ToString(value, numberFormatInfo);
		}
		if (destinationType.IsPrimitive)
		{
			return Convert.ChangeType(value, destinationType, culture);
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type t)
	{
		if (base.CanConvertTo(context, t) || t.IsPrimitive)
		{
			return true;
		}
		return false;
	}
}
