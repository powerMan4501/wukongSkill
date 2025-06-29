using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class VectorToListAdapter
{
	private VectorToListAdapter()
	{
	}

	[SecurityCritical]
	internal T Indexer_Get<T>(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		return GetAt(vector, (uint)index);
	}

	[SecurityCritical]
	internal void Indexer_Set<T>(int index, T value)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		SetAt(vector, (uint)index, value);
	}

	[SecurityCritical]
	internal int IndexOf<T>(T item)
	{
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		if (!vector.IndexOf(item, out var index))
		{
			return -1;
		}
		if (int.MaxValue < index)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		return (int)index;
	}

	[SecurityCritical]
	internal void Insert<T>(int index, T item)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		InsertAtHelper(vector, (uint)index, item);
	}

	[SecurityCritical]
	internal void RemoveAt<T>(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IVector<T> vector = JitHelpers.UnsafeCast<IVector<T>>(this);
		RemoveAtHelper(vector, (uint)index);
	}

	internal static T GetAt<T>(IVector<T> _this, uint index)
	{
		try
		{
			return _this.GetAt(index);
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			throw;
		}
	}

	private static void SetAt<T>(IVector<T> _this, uint index, T value)
	{
		try
		{
			_this.SetAt(index, value);
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			throw;
		}
	}

	private static void InsertAtHelper<T>(IVector<T> _this, uint index, T item)
	{
		try
		{
			_this.InsertAt(index, item);
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			throw;
		}
	}

	internal static void RemoveAtHelper<T>(IVector<T> _this, uint index)
	{
		try
		{
			_this.RemoveAt(index);
		}
		catch (Exception ex)
		{
			if (-2147483637 == ex._HResult)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			throw;
		}
	}
}
