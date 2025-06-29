using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
public sealed class EventLogPermission : ResourcePermissionBase
{
	private EventLogPermissionEntryCollection innerCollection;

	public EventLogPermissionEntryCollection PermissionEntries
	{
		get
		{
			if (innerCollection == null)
			{
				innerCollection = new EventLogPermissionEntryCollection(this, GetPermissionEntries());
			}
			return innerCollection;
		}
	}

	public EventLogPermission()
	{
		SetNames();
	}

	public EventLogPermission(PermissionState state)
		: base(state)
	{
		SetNames();
	}

	public EventLogPermission(EventLogPermissionAccess permissionAccess, string machineName)
	{
		SetNames();
		AddPermissionAccess(new EventLogPermissionEntry(permissionAccess, machineName));
	}

	public EventLogPermission(EventLogPermissionEntry[] permissionAccessEntries)
	{
		if (permissionAccessEntries == null)
		{
			throw new ArgumentNullException("permissionAccessEntries");
		}
		SetNames();
		for (int i = 0; i < permissionAccessEntries.Length; i++)
		{
			AddPermissionAccess(permissionAccessEntries[i]);
		}
	}

	internal void AddPermissionAccess(EventLogPermissionEntry entry)
	{
		AddPermissionAccess(entry.GetBaseEntry());
	}

	internal new void Clear()
	{
		base.Clear();
	}

	internal void RemovePermissionAccess(EventLogPermissionEntry entry)
	{
		RemovePermissionAccess(entry.GetBaseEntry());
	}

	private void SetNames()
	{
		base.PermissionAccessType = typeof(EventLogPermissionAccess);
		base.TagNames = new string[1] { "Machine" };
	}
}
