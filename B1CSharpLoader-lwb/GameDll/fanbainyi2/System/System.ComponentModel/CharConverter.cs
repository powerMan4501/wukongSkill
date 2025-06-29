using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class CharConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == typeof(string))
		{
			return true;
		}
		return base.CanConvertFrom(context, sourceType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string) && value is char && (char)value == '\0')
		{
			return "";
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			string text = (string)value;
			if (text.Length > 1)
			{
				text = text.Trim();
			}
			if (text != null && text.Length > 0)
			{
				if (text.Length != 1)
				{
					throw new FormatException(SR.GetString("ConvertInvalidPrimitive", text, "Char"));
				}
				return text[0];
			}
			return '\0';
		}
		return base.ConvertFrom(context, culture, value);
	}
}
