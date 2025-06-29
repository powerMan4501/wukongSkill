using System.Collections;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class DesigntimeLicenseContext : LicenseContext
{
	internal Hashtable savedLicenseKeys = new Hashtable();

	public override LicenseUsageMode UsageMode => LicenseUsageMode.Designtime;

	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
	{
		return null;
	}

	public override void SetSavedLicenseKey(Type type, string key)
	{
		savedLicenseKeys[type.AssemblyQualifiedName] = key;
	}
}
