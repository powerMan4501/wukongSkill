using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class BooleanConverter : TypeConverter
{
	private static volatile StandardValuesCollection values;

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
			string value2 = ((string)value).Trim();
			try
			{
				return bool.Parse(value2);
			}
			catch (FormatException innerException)
			{
				throw new FormatException(SR.GetString("ConvertInvalidPrimitive", (string)value, "Boolean"), innerException);
			}
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		if (values == null)
		{
			values = new StandardValuesCollection(new object[2] { true, false });
		}
		return values;
	}

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return true;
	}

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return true;
	}
}
