using System.Collections;
using System.Runtime.InteropServices;

namespace System.Security.Permissions;

[Serializable]
[ComVisible(true)]
public sealed class KeyContainerPermissionAccessEntryEnumerator : IEnumerator
{
	private KeyContainerPermissionAccessEntryCollection m_entries;

	private int m_current;

	public KeyContainerPermissionAccessEntry Current => m_entries[m_current];

	object IEnumerator.Current => m_entries[m_current];

	private KeyContainerPermissionAccessEntryEnumerator()
	{
	}

	internal KeyContainerPermissionAccessEntryEnumerator(KeyContainerPermissionAccessEntryCollection entries)
	{
		m_entries = entries;
		m_current = -1;
	}

	public bool MoveNext()
	{
		if (m_current == m_entries.Count - 1)
		{
			return false;
		}
		m_current++;
		return true;
	}

	public void Reset()
	{
		m_current = -1;
	}
}
