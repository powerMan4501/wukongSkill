using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
public sealed class PerformanceCounterPermission : ResourcePermissionBase
{
	private PerformanceCounterPermissionEntryCollection innerCollection;

	public PerformanceCounterPermissionEntryCollection PermissionEntries
	{
		get
		{
			if (innerCollection == null)
			{
				innerCollection = new PerformanceCounterPermissionEntryCollection(this, GetPermissionEntries());
			}
			return innerCollection;
		}
	}

	public PerformanceCounterPermission()
	{
		SetNames();
	}

	public PerformanceCounterPermission(PermissionState state)
		: base(state)
	{
		SetNames();
	}

	public PerformanceCounterPermission(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName)
	{
		SetNames();
		AddPermissionAccess(new PerformanceCounterPermissionEntry(permissionAccess, machineName, categoryName));
	}

	public PerformanceCounterPermission(PerformanceCounterPermissionEntry[] permissionAccessEntries)
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

	internal void AddPermissionAccess(PerformanceCounterPermissionEntry entry)
	{
		AddPermissionAccess(entry.GetBaseEntry());
	}

	internal new void Clear()
	{
		base.Clear();
	}

	internal void RemovePermissionAccess(PerformanceCounterPermissionEntry entry)
	{
		RemovePermissionAccess(entry.GetBaseEntry());
	}

	private void SetNames()
	{
		base.PermissionAccessType = typeof(PerformanceCounterPermissionAccess);
		base.TagNames = new string[2] { "Machine", "Category" };
	}
}
