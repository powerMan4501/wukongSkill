using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

[DebuggerDisplay("Size = {Size}")]
internal sealed class IReadOnlyListToIVectorViewAdapter
{
	private IReadOnlyListToIVectorViewAdapter()
	{
	}

	[SecurityCritical]
	internal T GetAt<T>(uint index)
	{
		IReadOnlyList<T> readOnlyList = JitHelpers.UnsafeCast<IReadOnlyList<T>>(this);
		EnsureIndexInt32(index, readOnlyList.Count);
		try
		{
			return readOnlyList[(int)index];
		}
		catch (ArgumentOutOfRangeException ex)
		{
			ex.SetErrorCode(-2147483637);
			throw;
		}
	}

	[SecurityCritical]
	internal uint Size<T>()
	{
		IReadOnlyList<T> readOnlyList = JitHelpers.UnsafeCast<IReadOnlyList<T>>(this);
		return (uint)readOnlyList.Count;
	}

	[SecurityCritical]
	internal bool IndexOf<T>(T value, out uint index)
	{
		IReadOnlyList<T> readOnlyList = JitHelpers.UnsafeCast<IReadOnlyList<T>>(this);
		int num = -1;
		int count = readOnlyList.Count;
		for (int i = 0; i < count; i++)
		{
			if (EqualityComparer<T>.Default.Equals(value, readOnlyList[i]))
			{
				num = i;
				break;
			}
		}
		if (-1 == num)
		{
			index = 0u;
			return false;
		}
		index = (uint)num;
		return true;
	}

	[SecurityCritical]
	internal uint GetMany<T>(uint startIndex, T[] items)
	{
		IReadOnlyList<T> readOnlyList = JitHelpers.UnsafeCast<IReadOnlyList<T>>(this);
		if (startIndex == readOnlyList.Count)
		{
			return 0u;
		}
		EnsureIndexInt32(startIndex, readOnlyList.Count);
		if (items == null)
		{
			return 0u;
		}
		uint num = Math.Min((uint)items.Length, (uint)readOnlyList.Count - startIndex);
		for (uint num2 = 0u; num2 < num; num2++)
		{
			items[num2] = readOnlyList[(int)(num2 + startIndex)];
		}
		if (typeof(T) == typeof(string))
		{
			string[] array = items as string[];
			for (uint num3 = num; num3 < items.Length; num3++)
			{
				array[num3] = string.Empty;
			}
		}
		return num;
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
}
