using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class BindableVectorToListAdapter
{
	private BindableVectorToListAdapter()
	{
	}

	[SecurityCritical]
	internal object Indexer_Get(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		return GetAt(bindableVector, (uint)index);
	}

	[SecurityCritical]
	internal void Indexer_Set(int index, object value)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		SetAt(bindableVector, (uint)index, value);
	}

	[SecurityCritical]
	internal int Add(object value)
	{
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		bindableVector.Append(value);
		uint size = bindableVector.Size;
		if (int.MaxValue < size)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
		}
		return (int)(size - 1);
	}

	[SecurityCritical]
	internal bool Contains(object item)
	{
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		uint index;
		return bindableVector.IndexOf(item, out index);
	}

	[SecurityCritical]
	internal void Clear()
	{
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		bindableVector.Clear();
	}

	[SecurityCritical]
	internal bool IsFixedSize()
	{
		return false;
	}

	[SecurityCritical]
	internal bool IsReadOnly()
	{
		return false;
	}

	[SecurityCritical]
	internal int IndexOf(object item)
	{
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		if (!bindableVector.IndexOf(item, out var index))
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
	internal void Insert(int index, object item)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		InsertAtHelper(bindableVector, (uint)index, item);
	}

	[SecurityCritical]
	internal void Remove(object item)
	{
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		if (bindableVector.IndexOf(item, out var index))
		{
			if (int.MaxValue < index)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CollectionBackingListTooLarge"));
			}
			RemoveAtHelper(bindableVector, index);
		}
	}

	[SecurityCritical]
	internal void RemoveAt(int index)
	{
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		IBindableVector bindableVector = JitHelpers.UnsafeCast<IBindableVector>(this);
		RemoveAtHelper(bindableVector, (uint)index);
	}

	private static object GetAt(IBindableVector _this, uint index)
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

	private static void SetAt(IBindableVector _this, uint index, object value)
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

	private static void InsertAtHelper(IBindableVector _this, uint index, object item)
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

	private static void RemoveAtHelper(IBindableVector _this, uint index)
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
