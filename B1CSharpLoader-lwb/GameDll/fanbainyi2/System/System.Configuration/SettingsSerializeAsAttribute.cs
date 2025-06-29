namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class SettingsSerializeAsAttribute : Attribute
{
	private readonly SettingsSerializeAs _serializeAs;

	public SettingsSerializeAs SerializeAs => _serializeAs;

	public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs)
	{
		_serializeAs = serializeAs;
	}
}
