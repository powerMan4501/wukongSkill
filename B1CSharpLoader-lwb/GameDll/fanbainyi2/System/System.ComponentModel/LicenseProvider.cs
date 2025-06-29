using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public abstract class LicenseProvider
{
	public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions);
}
