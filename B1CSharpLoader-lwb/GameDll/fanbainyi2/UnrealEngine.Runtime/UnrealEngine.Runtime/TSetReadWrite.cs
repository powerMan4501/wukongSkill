using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TSetReadWrite<T> : TSetBase<T>, ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	public bool IsReadOnly => false;

	public TSetReadWrite(UObject owner, FFieldAddress setProperty, IntPtr address, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
		: base(owner, setProperty, address, fromNative, toNative)
	{
	}

	public bool Add(T item)
	{
		if (!Contains(item))
		{
			AddInternal(item);
			return true;
		}
		return false;
	}

	public void Clear()
	{
		ClearInternal();
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		int maxIndex = SetHelper.GetMaxIndex();
		int num = arrayIndex;
		for (int i = 0; i < maxIndex; i++)
		{
			if (SetHelper.IsValidIndex(i))
			{
				array[num++] = Get(i);
			}
		}
	}

	public void ExceptWith(IEnumerable<T> other)
	{
		if (base.Count == 0)
		{
			return;
		}
		if (other is TSetBase<T> tSetBase)
		{
			{
				foreach (T item in tSetBase)
				{
					Remove(item);
				}
				return;
			}
		}
		foreach (T item2 in other)
		{
			Remove(item2);
		}
	}

	public void IntersectWith(IEnumerable<T> other)
	{
		if (other is TSetBase<T> tSetBase)
		{
			if (tSetBase.Count == 0)
			{
				Clear();
				return;
			}
			for (int num = SetHelper.GetMaxIndex() - 1; num >= 0; num--)
			{
				if (SetHelper.IsValidIndex(num))
				{
					T item = Get(num);
					if (!tSetBase.Contains(item))
					{
						RemoveAtInternal(num);
					}
				}
			}
			return;
		}
		HashSet<T> hashSet = new HashSet<T>(other);
		if (hashSet.Count == 0)
		{
			Clear();
			return;
		}
		for (int num2 = SetHelper.GetMaxIndex() - 1; num2 >= 0; num2--)
		{
			if (SetHelper.IsValidIndex(num2))
			{
				T item2 = Get(num2);
				if (!hashSet.Contains(item2))
				{
					RemoveAtInternal(num2);
				}
			}
		}
	}

	public bool IsProperSubsetOf(IEnumerable<T> other)
	{
		if (other is TSetBase<T> tSetBase)
		{
			if (base.Count == 0)
			{
				return tSetBase.Count > 0;
			}
			if (base.Count >= tSetBase.Count)
			{
				return false;
			}
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					if (!tSetBase.Contains(current))
					{
						return false;
					}
				}
			}
			return true;
		}
		HashSet<T> hashSet = new HashSet<T>(other);
		if (base.Count == 0)
		{
			return hashSet.Count > 0;
		}
		if (base.Count >= hashSet.Count)
		{
			return false;
		}
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current2 = enumerator.Current;
				if (!hashSet.Contains(current2))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool IsProperSupersetOf(IEnumerable<T> other)
	{
		if (base.Count == 0)
		{
			return false;
		}
		if (other is TSetBase<T> tSetBase)
		{
			foreach (T item in tSetBase)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		foreach (T item2 in other)
		{
			if (!Contains(item2))
			{
				return false;
			}
		}
		return true;
	}

	public bool IsSubsetOf(IEnumerable<T> other)
	{
		if (base.Count == 0)
		{
			return true;
		}
		if (other is TSetBase<T> tSetBase)
		{
			if (base.Count > tSetBase.Count)
			{
				return false;
			}
			using (Enumerator enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T current = enumerator.Current;
					if (!tSetBase.Contains(current))
					{
						return false;
					}
				}
			}
			return true;
		}
		HashSet<T> hashSet = new HashSet<T>(other);
		if (base.Count > hashSet.Count)
		{
			return false;
		}
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current2 = enumerator.Current;
				if (!hashSet.Contains(current2))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool IsSupersetOf(IEnumerable<T> other)
	{
		if (other is TSetBase<T> tSetBase)
		{
			if (tSetBase.Count == 0)
			{
				return true;
			}
			if (tSetBase.Count > base.Count)
			{
				return false;
			}
			foreach (T item in tSetBase)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
		}
		else
		{
			foreach (T item2 in other)
			{
				if (!Contains(item2))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool Overlaps(IEnumerable<T> other)
	{
		if (base.Count == 0)
		{
			return false;
		}
		if (other is TSetBase<T> tSetBase)
		{
			foreach (T item in tSetBase)
			{
				if (Contains(item))
				{
					return true;
				}
			}
		}
		else
		{
			foreach (T item2 in other)
			{
				if (Contains(item2))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool Remove(T item)
	{
		int num = IndexOf(item);
		if (num >= 0)
		{
			RemoveAtInternal(num);
			return true;
		}
		return false;
	}

	public bool SetEquals(IEnumerable<T> other)
	{
		if (other is TSetBase<T> tSetBase)
		{
			if (base.Count != tSetBase.Count)
			{
				return false;
			}
			foreach (T item in tSetBase)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		foreach (T item2 in other)
		{
			if (!Contains(item2))
			{
				return false;
			}
		}
		return true;
	}

	public void SymmetricExceptWith(IEnumerable<T> other)
	{
		if (base.Count == 0)
		{
			UnionWith(other);
			return;
		}
		if (other is TSetBase<T> tSetBase)
		{
			{
				foreach (T item in tSetBase)
				{
					if (!Remove(item))
					{
						Add(item);
					}
				}
				return;
			}
		}
		foreach (T item2 in new HashSet<T>(other))
		{
			if (!Remove(item2))
			{
				Add(item2);
			}
		}
	}

	public void UnionWith(IEnumerable<T> other)
	{
		if (other is TSetBase<T> tSetBase)
		{
			{
				foreach (T item in tSetBase)
				{
					if (!Contains(item))
					{
						Add(item);
					}
				}
				return;
			}
		}
		foreach (T item2 in other)
		{
			if (!Contains(item2))
			{
				Add(item2);
			}
		}
	}

	void ICollection<T>.Add(T item)
	{
		AddInternal(item);
	}
}
