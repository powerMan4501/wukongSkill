using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class TypeListConverter : TypeConverter
{
	private Type[] types;

	private StandardValuesCollection values;

	protected TypeListConverter(Type[] types)
	{
		this.types = types;
	}

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
			Type[] array = types;
			foreach (Type type in array)
			{
				if (value.Equals(type.FullName))
				{
					return type;
				}
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
		if (destinationType == typeof(string))
		{
			if (value == null)
			{
				return SR.GetString("toStringNone");
			}
			return ((Type)value).FullName;
		}
		if (destinationType == typeof(InstanceDescriptor) && value is Type)
		{
			MethodInfo method = typeof(Type).GetMethod("GetType", new Type[1] { typeof(string) });
			if (method != null)
			{
				return new InstanceDescriptor(method, new object[1] { ((Type)value).AssemblyQualifiedName });
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		if (values == null)
		{
			object[] destinationArray;
			if (types != null)
			{
				destinationArray = new object[types.Length];
				Array.Copy(types, destinationArray, types.Length);
			}
			else
			{
				destinationArray = null;
			}
			values = new StandardValuesCollection(destinationArray);
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
