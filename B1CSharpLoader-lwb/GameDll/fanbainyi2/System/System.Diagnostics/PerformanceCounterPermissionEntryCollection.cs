using System.Collections;
using System.Security.Permissions;

namespace System.Diagnostics;

[Serializable]
public class PerformanceCounterPermissionEntryCollection : CollectionBase
{
	private PerformanceCounterPermission owner;

	public PerformanceCounterPermissionEntry this[int index]
	{
		get
		{
			return (PerformanceCounterPermissionEntry)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	internal PerformanceCounterPermissionEntryCollection(PerformanceCounterPermission owner, ResourcePermissionBaseEntry[] entries)
	{
		this.owner = owner;
		for (int i = 0; i < entries.Length; i++)
		{
			base.InnerList.Add(new PerformanceCounterPermissionEntry(entries[i]));
		}
	}

	public int Add(PerformanceCounterPermissionEntry value)
	{
		return base.List.Add(value);
	}

	public void AddRange(PerformanceCounterPermissionEntry[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		for (int i = 0; i < value.Length; i++)
		{
			Add(value[i]);
		}
	}

	public void AddRange(PerformanceCounterPermissionEntryCollection value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		int count = value.Count;
		for (int i = 0; i < count; i++)
		{
			Add(value[i]);
		}
	}

	public bool Contains(PerformanceCounterPermissionEntry value)
	{
		return base.List.Contains(value);
	}

	public void CopyTo(PerformanceCounterPermissionEntry[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	public int IndexOf(PerformanceCounterPermissionEntry value)
	{
		return base.List.IndexOf(value);
	}

	public void Insert(int index, PerformanceCounterPermissionEntry value)
	{
		base.List.Insert(index, value);
	}

	public void Remove(PerformanceCounterPermissionEntry value)
	{
		base.List.Remove(value);
	}

	protected override void OnClear()
	{
		owner.Clear();
	}

	protected override void OnInsert(int index, object value)
	{
		owner.AddPermissionAccess((PerformanceCounterPermissionEntry)value);
	}

	protected override void OnRemove(int index, object value)
	{
		owner.RemovePermissionAccess((PerformanceCounterPermissionEntry)value);
	}

	protected override void OnSet(int index, object oldValue, object newValue)
	{
		owner.RemovePermissionAccess((PerformanceCounterPermissionEntry)oldValue);
		owner.AddPermissionAccess((PerformanceCounterPermissionEntry)newValue);
	}
}
