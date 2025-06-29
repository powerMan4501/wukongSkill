using System.Collections;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class ListToBindableVectorViewAdapter : IBindableVectorView, IBindableIterable
{
	private readonly IList list;

	public uint Size => (uint)list.Count;

	internal ListToBindableVectorViewAdapter(IList list)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		this.list = list;
	}

	private static void EnsureIndexInt32(uint index, int listCapacity)
	{
		if (int.MaxValue <= index || index >= (uint)listCapacity)
		{
			Exception ex = new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_IndexLargerThanMaxValue"));
			ex.SetErrorCode(-2147483637);
			throw ex;
		}
	}

	public IBindableIterator First()
	{
		IEnumerator enumerator = list.GetEnumerator();
		return new EnumeratorToIteratorAdapter<object>(new EnumerableToBindableIterableAdapter.NonGenericToGenericEnumerator(enumerator));
	}

	public object GetAt(uint index)
	{
		EnsureIndexInt32(index, list.Count);
		try
		{
			return list[(int)index];
		}
		catch (ArgumentOutOfRangeException innerException)
		{
			throw WindowsRuntimeMarshal.GetExceptionForHR(-2147483637, innerException, "ArgumentOutOfRange_IndexOutOfRange");
		}
	}

	public bool IndexOf(object value, out uint index)
	{
		int num = list.IndexOf(value);
		if (-1 == num)
		{
			index = 0u;
			return false;
		}
		index = (uint)num;
		return true;
	}
}
