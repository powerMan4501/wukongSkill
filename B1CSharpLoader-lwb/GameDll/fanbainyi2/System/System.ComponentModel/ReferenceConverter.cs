using System.Collections;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class ReferenceConverter : TypeConverter
{
	private class ReferenceComparer : IComparer
	{
		private ReferenceConverter converter;

		public ReferenceComparer(ReferenceConverter converter)
		{
			this.converter = converter;
		}

		public int Compare(object item1, object item2)
		{
			string strA = converter.ConvertToString(item1);
			string strB = converter.ConvertToString(item2);
			return string.Compare(strA, strB, ignoreCase: false, CultureInfo.InvariantCulture);
		}
	}

	private static readonly string none = SR.GetString("toStringNone");

	private Type type;

	public ReferenceConverter(Type type)
	{
		this.type = type;
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (sourceType == typeof(string) && context != null)
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
			if (!string.Equals(text, none) && context != null)
			{
				IReferenceService referenceService = (IReferenceService)context.GetService(typeof(IReferenceService));
				if (referenceService != null)
				{
					object reference = referenceService.GetReference(text);
					if (reference != null)
					{
						return reference;
					}
				}
				IContainer container = context.Container;
				if (container != null)
				{
					object obj = container.Components[text];
					if (obj != null)
					{
						return obj;
					}
				}
			}
			return null;
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
			if (value != null)
			{
				if (context != null)
				{
					IReferenceService referenceService = (IReferenceService)context.GetService(typeof(IReferenceService));
					if (referenceService != null)
					{
						string name = referenceService.GetName(value);
						if (name != null)
						{
							return name;
						}
					}
				}
				if (!Marshal.IsComObject(value) && value is IComponent)
				{
					IComponent component = (IComponent)value;
					ISite site = component.Site;
					if (site != null)
					{
						string name2 = site.Name;
						if (name2 != null)
						{
							return name2;
						}
					}
				}
				return string.Empty;
			}
			return none;
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		object[] array = null;
		if (context != null)
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(null);
			IReferenceService referenceService = (IReferenceService)context.GetService(typeof(IReferenceService));
			if (referenceService != null)
			{
				object[] references = referenceService.GetReferences(type);
				int num = references.Length;
				for (int i = 0; i < num; i++)
				{
					if (IsValueAllowed(context, references[i]))
					{
						arrayList.Add(references[i]);
					}
				}
			}
			else
			{
				IContainer container = context.Container;
				if (container != null)
				{
					ComponentCollection components = container.Components;
					foreach (IComponent item in components)
					{
						if (item != null && type.IsInstanceOfType(item) && IsValueAllowed(context, item))
						{
							arrayList.Add(item);
						}
					}
				}
			}
			array = arrayList.ToArray();
			Array.Sort(array, 0, array.Length, new ReferenceComparer(this));
		}
		return new StandardValuesCollection(array);
	}

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
	{
		return true;
	}

	public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
	{
		return true;
	}

	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
	{
		return true;
	}
}
