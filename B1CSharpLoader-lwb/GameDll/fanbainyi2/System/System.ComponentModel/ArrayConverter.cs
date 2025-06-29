using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ArrayConverter : CollectionConverter
{
	private class ArrayPropertyDescriptor : SimplePropertyDescriptor
	{
		private int index;

		public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
			: base(arrayType, "[" + index + "]", elementType, null)
		{
			this.index = index;
		}

		public override object GetValue(object instance)
		{
			if (instance is Array)
			{
				Array array = (Array)instance;
				if (array.GetLength(0) > index)
				{
					return array.GetValue(index);
				}
			}
			return null;
		}

		public override void SetValue(object instance, object value)
		{
			if (instance is Array)
			{
				Array array = (Array)instance;
				if (array.GetLength(0) > index)
				{
					array.SetValue(value, index);
				}
				OnValueChanged(instance, EventArgs.Empty);
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		if (destinationType == typeof(string) && value is Array)
		{
			return SR.GetString("ArrayConverterText", value.GetType().Name);
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
	{
		PropertyDescriptor[] array = null;
		if (value.GetType().IsArray)
		{
			Array array2 = (Array)value;
			int length = array2.GetLength(0);
			array = new PropertyDescriptor[length];
			Type type = value.GetType();
			Type elementType = type.GetElementType();
			for (int i = 0; i < length; i++)
			{
				array[i] = new ArrayPropertyDescriptor(type, elementType, i);
			}
		}
		return new PropertyDescriptorCollection(array);
	}

	public override bool GetPropertiesSupported(ITypeDescriptorContext context)
	{
		return true;
	}
}
