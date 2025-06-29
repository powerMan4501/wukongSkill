using System.Collections;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class NullableConverter : TypeConverter
{
	private Type nullableType;

	private Type simpleType;

	private TypeConverter simpleTypeConverter;

	public Type NullableType => nullableType;

	public Type UnderlyingType => simpleType;

	public TypeConverter UnderlyingTypeConverter => simpleTypeConverter;

	public NullableConverter(Type type)
	{
		nullableType = type;
		simpleType = Nullable.GetUnderlyingType(type);
		if (simpleType == null)
		{
			throw new ArgumentException(SR.GetString("NullableConverterBadCtorArg"), "type");
		}
		simpleTypeConverter = TypeDescriptor.GetConverter(simpleType);
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == simpleType)
		{
			return true;
		}
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.CanConvertFrom(context, sourceType);
		}
		return base.CanConvertFrom(context, sourceType);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value == null || value.GetType() == simpleType)
		{
			return value;
		}
		if (value is string && string.IsNullOrEmpty(value as string))
		{
			return null;
		}
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.ConvertFrom(context, culture, value);
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		if (destinationType == simpleType)
		{
			return true;
		}
		if (destinationType == typeof(InstanceDescriptor))
		{
			return true;
		}
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.CanConvertTo(context, destinationType);
		}
		return base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		if (destinationType == simpleType && nullableType.IsInstanceOfType(value))
		{
			return value;
		}
		if (destinationType == typeof(InstanceDescriptor))
		{
			ConstructorInfo constructor = nullableType.GetConstructor(new Type[1] { simpleType });
			return new InstanceDescriptor(constructor, new object[1] { value }, isComplete: true);
		}
		if (value == null)
		{
			if (destinationType == typeof(string))
			{
				return string.Empty;
			}
		}
		else if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.ConvertTo(context, culture, value, destinationType);
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
	{
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.CreateInstance(context, propertyValues);
		}
		return base.CreateInstance(context, propertyValues);
	}

	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
	{
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.GetCreateInstanceSupported(context);
		}
		return base.GetCreateInstanceSupported(context);
	}

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.GetProperties(context, value, attributes);
		}
		return base.GetProperties(context, value, attributes);
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.GetPropertiesSupported(context);
		}
		return base.GetPropertiesSupported(context);
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		if (simpleTypeConverter != null)
		{
			StandardValuesCollection standardValues = simpleTypeConverter.GetStandardValues(context);
			if (GetStandardValuesSupported(context) && standardValues != null)
			{
				object[] array = new object[standardValues.Count + 1];
				int num = 0;
				array[num++] = null;
				foreach (object item in standardValues)
				{
					array[num++] = item;
				}
				return new StandardValuesCollection(array);
			}
		}
		return base.GetStandardValues(context);
	}

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.GetStandardValuesExclusive(context);
		}
		return base.GetStandardValuesExclusive(context);
	}

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		if (simpleTypeConverter != null)
		{
			return simpleTypeConverter.GetStandardValuesSupported(context);
		}
		return base.GetStandardValuesSupported(context);
	}

	public override bool IsValid(ITypeDescriptorContext context, object value)
	{
		if (simpleTypeConverter != null)
		{
			if (value == null)
			{
				return true;
			}
			return simpleTypeConverter.IsValid(context, value);
		}
		return base.IsValid(context, value);
	}
}
