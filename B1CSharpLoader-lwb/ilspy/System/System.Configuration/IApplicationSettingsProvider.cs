using System.Security.Permissions;

namespace System.Configuration;

public interface IApplicationSettingsProvider
{
	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	void Reset(SettingsContext context);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
}
