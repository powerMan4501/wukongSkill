using System.IO;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.AccessControl;

public sealed class FileSecurity : FileSystemSecurity
{
	[SecuritySafeCritical]
	public FileSecurity()
		: base(isContainer: false)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	public FileSecurity(string fileName, AccessControlSections includeSections)
		: base(isContainer: false, fileName, includeSections, isDirectory: false)
	{
		string fullPathInternal = Path.GetFullPathInternal(fileName);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.NoAccess, AccessControlActions.View, fullPathInternal, checkForDuplicates: false, needFullPath: false);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	internal FileSecurity(SafeFileHandle handle, string fullPath, AccessControlSections includeSections)
		: base(isContainer: false, handle, includeSections, isDirectory: false)
	{
		if (fullPath != null)
		{
			FileIOPermission.QuickDemand(FileIOPermissionAccess.NoAccess, AccessControlActions.View, fullPath);
		}
		else
		{
			FileIOPermission.QuickDemand(PermissionState.Unrestricted);
		}
	}
}
