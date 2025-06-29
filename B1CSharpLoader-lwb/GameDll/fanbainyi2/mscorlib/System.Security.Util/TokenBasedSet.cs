using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace System.Security.Util;

[Serializable]
internal class TokenBasedSet
{
	private int m_initSize = 24;

	private int m_increment = 8;

	private object[] m_objSet;

	[OptionalField(VersionAdded = 2)]
	private volatile object m_Obj;

	[OptionalField(VersionAdded = 2)]
	private volatile object[] m_Set;

	private int m_cElt;

	private volatile int m_maxIndex;

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
		OnDeserializedInternal();
	}

	private void OnDeserializedInternal()
	{
		if (m_objSet != null)
		{
			if (m_cElt == 1)
			{
				m_Obj = m_objSet[m_maxIndex];
			}
			else
			{
				m_Set = m_objSet;
			}
			m_objSet = null;
		}
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			if (m_cElt == 1)
			{
				m_objSet = new object[m_maxIndex + 1];
				m_objSet[m_maxIndex] = m_Obj;
			}
			else if (m_cElt > 0)
			{
				m_objSet = m_Set;
			}
		}
	}

	[OnSerialized]
	private void OnSerialized(StreamingContext ctx)
	{
		if ((ctx.State & ~(StreamingContextStates.Clone | StreamingContextStates.CrossAppDomain)) != 0)
		{
			m_objSet = null;
		}
	}

	internal bool MoveNext(ref TokenBasedSetEnumerator e)
	{
		switch (m_cElt)
		{
		case 0:
			return false;
		case 1:
			if (e.Index == -1)
			{
				e.Index = m_maxIndex;
				e.Current = m_Obj;
				return true;
			}
			e.Index = (short)(m_maxIndex + 1);
			e.Current = null;
			return false;
		}
		while (++e.Index <= m_maxIndex)
		{
			e.Current = Volatile.Read(ref m_Set[e.Index]);
			if (e.Current != null)
			{
				return true;
			}
		}
		e.Current = null;
		return false;
	}

	internal TokenBasedSet()
	{
		Reset();
	}

	internal TokenBasedSet(TokenBasedSet tbSet)
	{
		if (tbSet == null)
		{
			Reset();
			return;
		}
		if (tbSet.m_cElt > 1)
		{
			object[] set = tbSet.m_Set;
			int num = set.Length;
			object[] array = new object[num];
			Array.Copy(set, 0, array, 0, num);
			m_Set = array;
		}
		else
		{
			m_Obj = tbSet.m_Obj;
		}
		m_cElt = tbSet.m_cElt;
		m_maxIndex = tbSet.m_maxIndex;
	}

	internal void Reset()
	{
		m_Obj = null;
		m_Set = null;
		m_cElt = 0;
		m_maxIndex = -1;
	}

	internal void SetItem(int index, object item)
	{
		object[] array = null;
		if (item == null)
		{
			RemoveItem(index);
			return;
		}
		switch (m_cElt)
		{
		case 0:
			m_cElt = 1;
			m_maxIndex = (short)index;
			m_Obj = item;
			return;
		case 1:
		{
			if (index == m_maxIndex)
			{
				m_Obj = item;
				return;
			}
			object obj = m_Obj;
			int num = Math.Max(m_maxIndex, index);
			array = new object[num + 1];
			array[m_maxIndex] = obj;
			array[index] = item;
			m_maxIndex = (short)num;
			m_cElt = 2;
			m_Set = array;
			m_Obj = null;
			return;
		}
		}
		array = m_Set;
		if (index >= array.Length)
		{
			object[] array2 = new object[index + 1];
			Array.Copy(array, 0, array2, 0, m_maxIndex + 1);
			m_maxIndex = (short)index;
			array2[index] = item;
			m_Set = array2;
			m_cElt++;
			return;
		}
		if (array[index] == null)
		{
			m_cElt++;
		}
		array[index] = item;
		if (index > m_maxIndex)
		{
			m_maxIndex = (short)index;
		}
	}

	internal object GetItem(int index)
	{
		switch (m_cElt)
		{
		case 0:
			return null;
		case 1:
			if (index == m_maxIndex)
			{
				return m_Obj;
			}
			return null;
		default:
			if (index < m_Set.Length)
			{
				return Volatile.Read(ref m_Set[index]);
			}
			return null;
		}
	}

	internal object RemoveItem(int index)
	{
		object result = null;
		switch (m_cElt)
		{
		case 0:
			result = null;
			break;
		case 1:
			if (index != m_maxIndex)
			{
				result = null;
				break;
			}
			result = m_Obj;
			Reset();
			break;
		default:
			if (index < m_Set.Length && (result = Volatile.Read(ref m_Set[index])) != null)
			{
				Volatile.Write(ref m_Set[index], null);
				m_cElt--;
				if (index == m_maxIndex)
				{
					ResetMaxIndex(m_Set);
				}
				if (m_cElt == 1)
				{
					m_Obj = Volatile.Read(ref m_Set[m_maxIndex]);
					m_Set = null;
				}
			}
			break;
		}
		return result;
	}

	private void ResetMaxIndex(object[] aObj)
	{
		for (int num = aObj.Length - 1; num >= 0; num--)
		{
			if (aObj[num] != null)
			{
				m_maxIndex = (short)num;
				return;
			}
		}
		m_maxIndex = -1;
	}

	internal int GetStartingIndex()
	{
		if (m_cElt <= 1)
		{
			return m_maxIndex;
		}
		return 0;
	}

	internal int GetCount()
	{
		return m_cElt;
	}

	internal int GetMaxUsedIndex()
	{
		return m_maxIndex;
	}

	internal bool FastIsEmpty()
	{
		return m_cElt == 0;
	}

	internal TokenBasedSet SpecialUnion(TokenBasedSet other)
	{
		OnDeserializedInternal();
		TokenBasedSet tokenBasedSet = new TokenBasedSet();
		int num;
		if (other != null)
		{
			other.OnDeserializedInternal();
			num = ((GetMaxUsedIndex() > other.GetMaxUsedIndex()) ? GetMaxUsedIndex() : other.GetMaxUsedIndex());
		}
		else
		{
			num = GetMaxUsedIndex();
		}
		for (int i = 0; i <= num; i++)
		{
			object item = GetItem(i);
			IPermission permission = item as IPermission;
			ISecurityElementFactory securityElementFactory = item as ISecurityElementFactory;
			object obj = other?.GetItem(i);
			IPermission permission2 = obj as IPermission;
			ISecurityElementFactory securityElementFactory2 = obj as ISecurityElementFactory;
			if (item == null && obj == null)
			{
				continue;
			}
			if (item == null)
			{
				if (securityElementFactory2 != null)
				{
					permission2 = PermissionSet.CreatePerm(securityElementFactory2, ignoreTypeLoadFailures: false);
				}
				PermissionToken token = PermissionToken.GetToken(permission2);
				if (token == null)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
				}
				tokenBasedSet.SetItem(token.m_index, permission2);
			}
			else if (obj == null)
			{
				if (securityElementFactory != null)
				{
					permission = PermissionSet.CreatePerm(securityElementFactory, ignoreTypeLoadFailures: false);
				}
				PermissionToken token2 = PermissionToken.GetToken(permission);
				if (token2 == null)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_InsufficientState"));
				}
				tokenBasedSet.SetItem(token2.m_index, permission);
			}
		}
		return tokenBasedSet;
	}

	internal void SpecialSplit(ref TokenBasedSet unrestrictedPermSet, ref TokenBasedSet normalPermSet, bool ignoreTypeLoadFailures)
	{
		int maxUsedIndex = GetMaxUsedIndex();
		for (int i = GetStartingIndex(); i <= maxUsedIndex; i++)
		{
			object item = GetItem(i);
			if (item == null)
			{
				continue;
			}
			IPermission permission = item as IPermission;
			if (permission == null)
			{
				permission = PermissionSet.CreatePerm(item, ignoreTypeLoadFailures);
			}
			PermissionToken token = PermissionToken.GetToken(permission);
			if (permission == null || token == null)
			{
				continue;
			}
			if (permission is IUnrestrictedPermission)
			{
				if (unrestrictedPermSet == null)
				{
					unrestrictedPermSet = new TokenBasedSet();
				}
				unrestrictedPermSet.SetItem(token.m_index, permission);
			}
			else
			{
				if (normalPermSet == null)
				{
					normalPermSet = new TokenBasedSet();
				}
				normalPermSet.SetItem(token.m_index, permission);
			}
		}
	}
}
