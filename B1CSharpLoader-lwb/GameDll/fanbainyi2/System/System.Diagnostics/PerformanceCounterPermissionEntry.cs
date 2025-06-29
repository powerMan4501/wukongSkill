using System.ComponentModel;
using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
public class PerformanceCounterPermissionEntry
{
	private string categoryName;

	private string machineName;

	private PerformanceCounterPermissionAccess permissionAccess;

	public string CategoryName => categoryName;

	public string MachineName => machineName;

	public PerformanceCounterPermissionAccess PermissionAccess => permissionAccess;

	public PerformanceCounterPermissionEntry(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName)
	{
		if (categoryName == null)
		{
			throw new ArgumentNullException("categoryName");
		}
		if ((permissionAccess & ~PerformanceCounterPermissionAccess.Administer) != PerformanceCounterPermissionAccess.None)
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "permissionAccess", permissionAccess));
		}
		if (machineName == null)
		{
			throw new ArgumentNullException("machineName");
		}
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "MachineName", machineName));
		}
		this.permissionAccess = permissionAccess;
		this.machineName = machineName;
		this.categoryName = categoryName;
	}

	internal PerformanceCounterPermissionEntry(ResourcePermissionBaseEntry baseEntry)
	{
		permissionAccess = (PerformanceCounterPermissionAccess)baseEntry.PermissionAccess;
		machineName = baseEntry.PermissionAccessPath[0];
		categoryName = baseEntry.PermissionAccessPath[1];
	}

	internal ResourcePermissionBaseEntry GetBaseEntry()
	{
		return new ResourcePermissionBaseEntry((int)PermissionAccess, new string[2] { MachineName, CategoryName });
	}
}
