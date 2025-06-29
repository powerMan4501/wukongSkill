using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class KeyContainerPermissionAccessEntryCollection : ICollection, IEnumerable
{
	private ArrayList m_list;

	private KeyContainerPermissionFlags m_globalFlags;

	public KeyContainerPermissionAccessEntry this[int index]
	{
		get
		{
			if (index < 0)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_EnumNotStarted"));
			}
			if (index >= Count)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
			}
			return (KeyContainerPermissionAccessEntry)m_list[index];
		}
	}

	public int Count => m_list.Count;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	private KeyContainerPermissionAccessEntryCollection()
	{
	}

	internal KeyContainerPermissionAccessEntryCollection(KeyContainerPermissionFlags globalFlags)
	{
		m_list = new ArrayList();
		m_globalFlags = globalFlags;
	}

	public int Add(KeyContainerPermissionAccessEntry accessEntry)
	{
		if (accessEntry == null)
		{
			throw new ArgumentNullException("accessEntry");
		}
		int num = m_list.IndexOf(accessEntry);
		if (num == -1)
		{
			if (accessEntry.Flags != m_globalFlags)
			{
				return m_list.Add(accessEntry);
			}
			return -1;
		}
		((KeyContainerPermissionAccessEntry)m_list[num]).Flags &= accessEntry.Flags;
		return num;
	}

	public void Clear()
	{
		m_list.Clear();
	}

	public int IndexOf(KeyContainerPermissionAccessEntry accessEntry)
	{
		return m_list.IndexOf(accessEntry);
	}

	public void Remove(KeyContainerPermissionAccessEntry accessEntry)
	{
		if (accessEntry == null)
		{
			throw new ArgumentNullException("accessEntry");
		}
		m_list.Remove(accessEntry);
	}

	public KeyContainerPermissionAccessEntryEnumerator GetEnumerator()
	{
		return new KeyContainerPermissionAccessEntryEnumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new KeyContainerPermissionAccessEntryEnumerator(this);
	}

	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (array.Rank != 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RankMultiDimNotSupported"));
		}
		if (index < 0 || index >= array.Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (index + Count > array.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(this[i], index);
			index++;
		}
	}

	public void CopyTo(KeyContainerPermissionAccessEntry[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}
}
