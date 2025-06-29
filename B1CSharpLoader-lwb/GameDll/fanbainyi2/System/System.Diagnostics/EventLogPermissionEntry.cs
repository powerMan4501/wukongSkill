using System.ComponentModel;
using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
public class EventLogPermissionEntry
{
	private string machineName;

	private EventLogPermissionAccess permissionAccess;

	public string MachineName => machineName;

	public EventLogPermissionAccess PermissionAccess => permissionAccess;

	public EventLogPermissionEntry(EventLogPermissionAccess permissionAccess, string machineName)
	{
		if (!SyntaxCheck.CheckMachineName(machineName))
		{
			throw new ArgumentException(SR.GetString("InvalidParameter", "MachineName", machineName));
		}
		this.permissionAccess = permissionAccess;
		this.machineName = machineName;
	}

	internal EventLogPermissionEntry(ResourcePermissionBaseEntry baseEntry)
	{
		permissionAccess = (EventLogPermissionAccess)baseEntry.PermissionAccess;
		machineName = baseEntry.PermissionAccessPath[0];
	}

	internal ResourcePermissionBaseEntry GetBaseEntry()
	{
		return new ResourcePermissionBaseEntry((int)PermissionAccess, new string[1] { MachineName });
	}
}
