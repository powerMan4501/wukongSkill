using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.ComponentModel;

[ComVisible(true)]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class PropertyDescriptor : MemberDescriptor
{
	private TypeConverter converter;

	private Hashtable valueChangedHandlers;

	private object[] editors;

	private Type[] editorTypes;

	private int editorCount;

	public abstract Type ComponentType { get; }

	public virtual TypeConverter Converter
	{
		get
		{
			AttributeCollection attributeCollection = Attributes;
			if (converter == null)
			{
				TypeConverterAttribute typeConverterAttribute = (TypeConverterAttribute)attributeCollection[typeof(TypeConverterAttribute)];
				if (typeConverterAttribute.ConverterTypeName != null && typeConverterAttribute.ConverterTypeName.Length > 0)
				{
					Type typeFromName = GetTypeFromName(typeConverterAttribute.ConverterTypeName);
					if (typeFromName != null && typeof(TypeConverter).IsAssignableFrom(typeFromName))
					{
						converter = (TypeConverter)CreateInstance(typeFromName);
					}
				}
				if (converter == null)
				{
					converter = TypeDescriptor.GetConverter(PropertyType);
				}
			}
			return converter;
		}
	}

	public virtual bool IsLocalizable => LocalizableAttribute.Yes.Equals(Attributes[typeof(LocalizableAttribute)]);

	public abstract bool IsReadOnly { get; }

	public DesignerSerializationVisibility SerializationVisibility
	{
		get
		{
			DesignerSerializationVisibilityAttribute designerSerializationVisibilityAttribute = (DesignerSerializationVisibilityAttribute)Attributes[typeof(DesignerSerializationVisibilityAttribute)];
			return designerSerializationVisibilityAttribute.Visibility;
		}
	}

	public abstract Type PropertyType { get; }

	public virtual bool SupportsChangeEvents => false;

	protected PropertyDescriptor(string name, Attribute[] attrs)
		: base(name, attrs)
	{
	}

	protected PropertyDescriptor(MemberDescriptor descr)
		: base(descr)
	{
	}

	protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
		: base(descr, attrs)
	{
	}

	public virtual void AddValueChanged(object component, EventHandler handler)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (valueChangedHandlers == null)
		{
			valueChangedHandlers = new Hashtable();
		}
		EventHandler a = (EventHandler)valueChangedHandlers[component];
		valueChangedHandlers[component] = Delegate.Combine(a, handler);
	}

	public abstract bool CanResetValue(object component);

	public override bool Equals(object obj)
	{
		try
		{
			if (obj == this)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (obj is PropertyDescriptor propertyDescriptor && propertyDescriptor.NameHashCode == NameHashCode && propertyDescriptor.PropertyType == PropertyType && propertyDescriptor.Name.Equals(Name))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	protected object CreateInstance(Type type)
	{
		Type[] array = new Type[1] { typeof(Type) };
		ConstructorInfo constructor = type.GetConstructor(array);
		if (constructor != null)
		{
			return TypeDescriptor.CreateInstance(null, type, array, new object[1] { PropertyType });
		}
		return TypeDescriptor.CreateInstance(null, type, null, null);
	}

	protected override void FillAttributes(IList attributeList)
	{
		converter = null;
		editors = null;
		editorTypes = null;
		editorCount = 0;
		base.FillAttributes(attributeList);
	}

	public PropertyDescriptorCollection GetChildProperties()
	{
		return GetChildProperties(null, null);
	}

	public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
	{
		return GetChildProperties(null, filter);
	}

	public PropertyDescriptorCollection GetChildProperties(object instance)
	{
		return GetChildProperties(instance, null);
	}

	public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
	{
		if (instance == null)
		{
			return TypeDescriptor.GetProperties(PropertyType, filter);
		}
		return TypeDescriptor.GetProperties(instance, filter);
	}

	public virtual object GetEditor(Type editorBaseType)
	{
		object obj = null;
		AttributeCollection attributeCollection = Attributes;
		if (editorTypes != null)
		{
			for (int i = 0; i < editorCount; i++)
			{
				if (editorTypes[i] == editorBaseType)
				{
					return editors[i];
				}
			}
		}
		if (obj == null)
		{
			for (int j = 0; j < attributeCollection.Count; j++)
			{
				if (!(attributeCollection[j] is EditorAttribute editorAttribute))
				{
					continue;
				}
				Type typeFromName = GetTypeFromName(editorAttribute.EditorBaseTypeName);
				if (editorBaseType == typeFromName)
				{
					Type typeFromName2 = GetTypeFromName(editorAttribute.EditorTypeName);
					if (typeFromName2 != null)
					{
						obj = CreateInstance(typeFromName2);
						break;
					}
				}
			}
			if (obj == null)
			{
				obj = TypeDescriptor.GetEditor(PropertyType, editorBaseType);
			}
			if (editorTypes == null)
			{
				editorTypes = new Type[5];
				editors = new object[5];
			}
			if (editorCount >= editorTypes.Length)
			{
				Type[] destinationArray = new Type[editorTypes.Length * 2];
				object[] destinationArray2 = new object[editors.Length * 2];
				Array.Copy(editorTypes, destinationArray, editorTypes.Length);
				Array.Copy(editors, destinationArray2, editors.Length);
				editorTypes = destinationArray;
				editors = destinationArray2;
			}
			editorTypes[editorCount] = editorBaseType;
			editors[editorCount++] = obj;
		}
		return obj;
	}

	public override int GetHashCode()
	{
		return NameHashCode ^ PropertyType.GetHashCode();
	}

	protected override object GetInvocationTarget(Type type, object instance)
	{
		object obj = base.GetInvocationTarget(type, instance);
		if (obj is ICustomTypeDescriptor customTypeDescriptor)
		{
			obj = customTypeDescriptor.GetPropertyOwner(this);
		}
		return obj;
	}

	protected Type GetTypeFromName(string typeName)
	{
		if (typeName == null || typeName.Length == 0)
		{
			return null;
		}
		Type type = Type.GetType(typeName);
		Type type2 = null;
		if (ComponentType != null && (type == null || ComponentType.Assembly.FullName.Equals(type.Assembly.FullName)))
		{
			int num = typeName.IndexOf(',');
			if (num != -1)
			{
				typeName = typeName.Substring(0, num);
			}
			type2 = ComponentType.Assembly.GetType(typeName);
		}
		return type2 ?? type;
	}

	public abstract object GetValue(object component);

	protected virtual void OnValueChanged(object component, EventArgs e)
	{
		if (component != null && valueChangedHandlers != null)
		{
			((EventHandler)valueChangedHandlers[component])?.Invoke(component, e);
		}
	}

	public virtual void RemoveValueChanged(object component, EventHandler handler)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (valueChangedHandlers != null)
		{
			EventHandler source = (EventHandler)valueChangedHandlers[component];
			source = (EventHandler)Delegate.Remove(source, handler);
			if (source != null)
			{
				valueChangedHandlers[component] = source;
			}
			else
			{
				valueChangedHandlers.Remove(component);
			}
		}
	}

	protected internal EventHandler GetValueChangedHandler(object component)
	{
		if (component != null && valueChangedHandlers != null)
		{
			return (EventHandler)valueChangedHandlers[component];
		}
		return null;
	}

	public abstract void ResetValue(object component);

	public abstract void SetValue(object component, object value);

	public abstract bool ShouldSerializeValue(object component);
}
