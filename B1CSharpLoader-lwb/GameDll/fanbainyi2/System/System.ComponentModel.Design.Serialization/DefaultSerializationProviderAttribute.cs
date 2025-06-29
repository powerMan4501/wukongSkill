namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class DefaultSerializationProviderAttribute : Attribute
{
	private string _providerTypeName;

	public string ProviderTypeName => _providerTypeName;

	public DefaultSerializationProviderAttribute(Type providerType)
	{
		if (providerType == null)
		{
			throw new ArgumentNullException("providerType");
		}
		_providerTypeName = providerType.AssemblyQualifiedName;
	}

	public DefaultSerializationProviderAttribute(string providerTypeName)
	{
		if (providerTypeName == null)
		{
			throw new ArgumentNullException("providerTypeName");
		}
		_providerTypeName = providerTypeName;
	}
}
