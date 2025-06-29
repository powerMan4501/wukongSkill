using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class VectorToCollectionAdapter
{
	private VectorToCollectionAdapter()
	{
	}

	[SecurityCritical]
	internal int Count<T>()
	{
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		uint size = vector.Size;
		if (int.MaxValue < size)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		return (int)size;
	}

	[SecurityCritical]
	internal bool IsReadOnly<T>()
	{
		return false;
	}

	[SecurityCritical]
	internal void Add<T>(T item)
	{
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		vector.Append(item);
	}

	[SecurityCritical]
	internal void Clear<T>()
	{
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		vector.Clear();
	}

	[SecurityCritical]
	internal bool Contains<T>(T item)
	{
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		uint index;
		return vector.IndexOf(item, out index);
	}

	[SecurityCritical]
	internal void CopyTo<T>(T[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		if (array.Length <= arrayIndex && Count<T>() > 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IndexOutOfArrayBounds"));
		}
		if (array.Length - arrayIndex < Count<T>())
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InsufficientSpaceToCopyCollection"));
		}
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		int num = Count<T>();
		for (int i = 0; i < num; i++)
		{
			array[i + arrayIndex] = VectorToListAdapter.GetAt(vector, (uint)i);
		}
	}

	[SecurityCritical]
	internal bool Remove<T>(T item)
	{
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		if (!vector.IndexOf(item, out var index))
		{
			return false;
		}
		if (int.MaxValue < index)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		VectorToListAdapter.RemoveAtHelper(vector, index);
		return true;
	}
}
