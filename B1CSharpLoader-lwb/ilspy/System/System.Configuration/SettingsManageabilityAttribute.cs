namespace System.Configuration;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public sealed class SettingsManageabilityAttribute : Attribute
{
	private readonly SettingsManageability _manageability;

	public SettingsManageability Manageability => _manageability;

	public SettingsManageabilityAttribute(SettingsManageability manageability)
	{
		_manageability = manageability;
	}
}
