namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Property)]
public class AttributeProviderAttribute : Attribute
{
	private string _typeName;

	private string _propertyName;

	public string TypeName => _typeName;

	public string PropertyName => _propertyName;

	public AttributeProviderAttribute(string typeName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		_typeName = typeName;
	}

	public AttributeProviderAttribute(string typeName, string propertyName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		_typeName = typeName;
		_propertyName = propertyName;
	}

	public AttributeProviderAttribute(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		_typeName = type.AssemblyQualifiedName;
	}
}
