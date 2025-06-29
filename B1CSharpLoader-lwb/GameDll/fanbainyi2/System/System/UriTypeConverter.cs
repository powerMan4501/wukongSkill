using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System;

public class UriTypeConverter : TypeConverter
{
	private UriKind m_UriKind;

	public UriTypeConverter()
		: this(UriKind.RelativeOrAbsolute)
	{
	}

	internal UriTypeConverter(UriKind uriKind)
	{
		m_UriKind = uriKind;
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == null)
		{
			throw new ArgumentNullException("sourceType");
		}
		if (sourceType == typeof(string))
		{
			return true;
		}
		if (typeof(Uri).IsAssignableFrom(sourceType))
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
		if (destinationType == typeof(string))
		{
			return true;
		}
		if (destinationType == typeof(Uri))
		{
			return true;
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string uriString)
		{
			return new Uri(uriString, m_UriKind);
		}
		Uri uri = value as Uri;
		if (uri != null)
		{
			return new Uri(uri.OriginalString, (m_UriKind != UriKind.RelativeOrAbsolute) ? m_UriKind : (uri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative));
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		Uri uri = value as Uri;
		if (uri != null && destinationType == typeof(InstanceDescriptor))
		{
			ConstructorInfo constructor = typeof(Uri).GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[2]
			{
				typeof(string),
				typeof(UriKind)
			}, null);
			return new InstanceDescriptor(constructor, new object[2]
			{
				uri.OriginalString,
				(m_UriKind != UriKind.RelativeOrAbsolute) ? m_UriKind : (uri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative)
			});
		}
		if (uri != null && destinationType == typeof(string))
		{
			return uri.OriginalString;
		}
		if (uri != null && destinationType == typeof(Uri))
		{
			return new Uri(uri.OriginalString, (m_UriKind != UriKind.RelativeOrAbsolute) ? m_UriKind : (uri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative));
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override bool IsValid(ITypeDescriptorContext context, object value)
	{
		if (value is string uriString)
		{
			Uri result;
			return Uri.TryCreate(uriString, m_UriKind, out result);
		}
		return value is Uri;
	}
}
