using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class TimeSpanConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == typeof(string))
		{
			return true;
		}
		return base.CanConvertFrom(context, sourceType);
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (destinationType == typeof(InstanceDescriptor))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string)
		{
			string input = ((string)value).Trim();
			try
			{
				return TimeSpan.Parse(input, culture);
			}
			catch (FormatException innerException)
			{
				throw new FormatException(SR.GetString("ConvertInvalidPrimitive", (string)value, "TimeSpan"), innerException);
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
		if (destinationType == typeof(InstanceDescriptor) && value is TimeSpan)
		{
			MethodInfo method = typeof(TimeSpan).GetMethod("Parse", new Type[1] { typeof(string) });
			if (method != null)
			{
				return new InstanceDescriptor(method, new object[1] { value.ToString() });
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
