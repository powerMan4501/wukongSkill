using System.IO;
using System.Security;
using System.Security.Permissions;

namespace System.ComponentModel;

[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
internal static class IntSecurity
{
	public static readonly CodeAccessPermission UnmanagedCode = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);

	public static readonly CodeAccessPermission FullReflection = new ReflectionPermission(PermissionState.Unrestricted);

	public static string UnsafeGetFullPath(string fileName)
	{
		FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.None);
		fileIOPermission.AllFiles = FileIOPermissionAccess.PathDiscovery;
		fileIOPermission.Assert();
		try
		{
			return Path.GetFullPath(fileName);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}
}
