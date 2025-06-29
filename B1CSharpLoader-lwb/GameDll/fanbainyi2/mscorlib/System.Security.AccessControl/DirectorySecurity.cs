using System.IO;
using System.Security.Permissions;

namespace System.Security.AccessControl;

public sealed class DirectorySecurity : FileSystemSecurity
{
	[SecuritySafeCritical]
	public DirectorySecurity()
		: base(isContainer: true)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	public DirectorySecurity(string name, AccessControlSections includeSections)
		: base(isContainer: true, name, includeSections, isDirectory: true)
	{
		string fullPathInternal = Path.GetFullPathInternal(name);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.NoAccess, AccessControlActions.View, fullPathInternal, checkForDuplicates: false, needFullPath: false);
	}
}
