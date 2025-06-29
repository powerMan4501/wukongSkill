namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class TypeDescriptionProviderAttribute : Attribute
{
	private string _typeName;

	public string TypeName => _typeName;

	public TypeDescriptionProviderAttribute(string typeName)
	{
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		_typeName = typeName;
	}

	public TypeDescriptionProviderAttribute(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		_typeName = type.AssemblyQualifiedName;
	}
}
