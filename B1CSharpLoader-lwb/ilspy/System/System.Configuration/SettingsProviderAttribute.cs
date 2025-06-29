namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class SettingsProviderAttribute : Attribute
{
	private readonly string _providerTypeName;

	public string ProviderTypeName => _providerTypeName;

	public SettingsProviderAttribute(string providerTypeName)
	{
		_providerTypeName = providerTypeName;
	}

	public SettingsProviderAttribute(Type providerType)
	{
		if (providerType != null)
		{
			_providerTypeName = providerType.AssemblyQualifiedName;
		}
	}
}
