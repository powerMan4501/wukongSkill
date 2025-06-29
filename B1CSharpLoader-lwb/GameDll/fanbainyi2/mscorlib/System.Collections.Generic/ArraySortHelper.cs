using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;

namespace System.Collections.Generic;

[TypeDependency("System.Collections.Generic.GenericArraySortHelper`1")]
internal class ArraySortHelper<T> : IArraySortHelper<T>
{
	private static volatile IArraySortHelper<T> defaultArraySortHelper;

	public static IArraySortHelper<T> Default
	{
		get
		{
			IArraySortHelper<T> arraySortHelper = defaultArraySortHelper;
			if (arraySortHelper == null)
			{
				arraySortHelper = CreateArraySortHelper();
			}
			return arraySortHelper;
		}
	}

	[SecuritySafeCritical]
	private static IArraySortHelper<T> CreateArraySortHelper()
	{
		if (typeof(IComparable<T>).IsAssignableFrom(typeof(T)))
		{
			defaultArraySortHelper = (IArraySortHelper<T>)RuntimeTypeHandle.Allocate(typeof(GenericArraySortHelper<string>).TypeHandle.Instantiate(new Type[1] { typeof(T) }));
		}
		else
		{
			defaultArraySortHelper = new ArraySortHelper<T>();
		}
		return defaultArraySortHelper;
	}

	public void Sort(T[] keys, int index, int length, IComparer<T> comparer)
	{
		try
		{
			if (comparer == null)
			{
				comparer = Comparer<T>.Default;
			}
			if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				IntrospectiveSort(keys, index, length, comparer);
			}
			else
			{
				DepthLimitedQuickSort(keys, index, length + index - 1, comparer, 32);
			}
		}
		catch (IndexOutOfRangeException)
		{
			IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(comparer);
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_IComparerFailed"), innerException);
		}
	}

	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
	{
		try
		{
			if (comparer == null)
			{
				comparer = Comparer<T>.Default;
			}
			return InternalBinarySearch(array, index, length, value, comparer);
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_IComparerFailed"), innerException);
		}
	}

	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
	{
		int num = index;
		int num2 = index + length - 1;
		while (num <= num2)
		{
			int num3 = num + (num2 - num >> 1);
			int num4 = comparer.Compare(array[num3], value);
			if (num4 == 0)
			{
				return num3;
			}
			if (num4 < 0)
			{
				num = num3 + 1;
			}
			else
			{
				num2 = num3 - 1;
			}
		}
		return ~num;
	}

	private static void SwapIfGreater(T[] keys, IComparer<T> comparer, int a, int b)
	{
		if (a != b && comparer.Compare(keys[a], keys[b]) > 0)
		{
			T val = keys[a];
			keys[a] = keys[b];
			keys[b] = val;
		}
	}

	private static void Swap(T[] a, int i, int j)
	{
		if (i != j)
		{
			T val = a[i];
			a[i] = a[j];
			a[j] = val;
		}
	}

	internal static void DepthLimitedQuickSort(T[] keys, int left, int right, IComparer<T> comparer, int depthLimit)
	{
		do
		{
			if (depthLimit == 0)
			{
				Heapsort(keys, left, right, comparer);
				break;
			}
			int num = left;
			int num2 = right;
			int num3 = num + (num2 - num >> 1);
			SwapIfGreater(keys, comparer, num, num3);
			SwapIfGreater(keys, comparer, num, num2);
			SwapIfGreater(keys, comparer, num3, num2);
			T val = keys[num3];
			while (true)
			{
				if (comparer.Compare(keys[num], val) < 0)
				{
					num++;
					continue;
				}
				while (comparer.Compare(val, keys[num2]) < 0)
				{
					num2--;
				}
				if (num > num2)
				{
					break;
				}
				if (num < num2)
				{
					T val2 = keys[num];
					keys[num] = keys[num2];
					keys[num2] = val2;
				}
				num++;
				num2--;
				if (num > num2)
				{
					break;
				}
			}
			depthLimit--;
			if (num2 - left <= right - num)
			{
				if (left < num2)
				{
					DepthLimitedQuickSort(keys, left, num2, comparer, depthLimit);
				}
				left = num;
			}
			else
			{
				if (num < right)
				{
					DepthLimitedQuickSort(keys, num, right, comparer, depthLimit);
				}
				right = num2;
			}
		}
		while (left < right);
	}

	internal static void IntrospectiveSort(T[] keys, int left, int length, IComparer<T> comparer)
	{
		if (length >= 2)
		{
			IntroSort(keys, left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2(keys.Length), comparer);
		}
	}

	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, IComparer<T> comparer)
	{
		while (hi > lo)
		{
			int num = hi - lo + 1;
			if (num <= 16)
			{
				switch (num)
				{
				case 1:
					break;
				case 2:
					SwapIfGreater(keys, comparer, lo, hi);
					break;
				case 3:
					SwapIfGreater(keys, comparer, lo, hi - 1);
					SwapIfGreater(keys, comparer, lo, hi);
					SwapIfGreater(keys, comparer, hi - 1, hi);
					break;
				default:
					InsertionSort(keys, lo, hi, comparer);
					break;
				}
				break;
			}
			if (depthLimit == 0)
			{
				Heapsort(keys, lo, hi, comparer);
				break;
			}
			depthLimit--;
			int num2 = PickPivotAndPartition(keys, lo, hi, comparer);
			IntroSort(keys, num2 + 1, hi, depthLimit, comparer);
			hi = num2 - 1;
		}
	}

	private static int PickPivotAndPartition(T[] keys, int lo, int hi, IComparer<T> comparer)
	{
		int num = lo + (hi - lo) / 2;
		SwapIfGreater(keys, comparer, lo, num);
		SwapIfGreater(keys, comparer, lo, hi);
		SwapIfGreater(keys, comparer, num, hi);
		T val = keys[num];
		Swap(keys, num, hi - 1);
		int num2 = lo;
		int num3 = hi - 1;
		while (num2 < num3)
		{
			while (comparer.Compare(keys[++num2], val) < 0)
			{
			}
			while (comparer.Compare(val, keys[--num3]) < 0)
			{
			}
			if (num2 >= num3)
			{
				break;
			}
			Swap(keys, num2, num3);
		}
		Swap(keys, num2, hi - 1);
		return num2;
	}

	private static void Heapsort(T[] keys, int lo, int hi, IComparer<T> comparer)
	{
		int num = hi - lo + 1;
		for (int num2 = num / 2; num2 >= 1; num2--)
		{
			DownHeap(keys, num2, num, lo, comparer);
		}
		for (int num3 = num; num3 > 1; num3--)
		{
			Swap(keys, lo, lo + num3 - 1);
			DownHeap(keys, 1, num3 - 1, lo, comparer);
		}
	}

	private static void DownHeap(T[] keys, int i, int n, int lo, IComparer<T> comparer)
	{
		T val = keys[lo + i - 1];
		while (i <= n / 2)
		{
			int num = 2 * i;
			if (num < n && comparer.Compare(keys[lo + num - 1], keys[lo + num]) < 0)
			{
				num++;
			}
			if (comparer.Compare(val, keys[lo + num - 1]) >= 0)
			{
				break;
			}
			keys[lo + i - 1] = keys[lo + num - 1];
			i = num;
		}
		keys[lo + i - 1] = val;
	}

	private static void InsertionSort(T[] keys, int lo, int hi, IComparer<T> comparer)
	{
		for (int i = lo; i < hi; i++)
		{
			int num = i;
			T val = keys[i + 1];
			while (num >= lo && comparer.Compare(val, keys[num]) < 0)
			{
				keys[num + 1] = keys[num];
				num--;
			}
			keys[num + 1] = val;
		}
	}
}
[TypeDependency("System.Collections.Generic.GenericArraySortHelper`2")]
internal class ArraySortHelper<TKey, TValue> : IArraySortHelper<TKey, TValue>
{
	private static volatile IArraySortHelper<TKey, TValue> defaultArraySortHelper;

	public static IArraySortHelper<TKey, TValue> Default
	{
		get
		{
			IArraySortHelper<TKey, TValue> arraySortHelper = defaultArraySortHelper;
			if (arraySortHelper == null)
			{
				arraySortHelper = CreateArraySortHelper();
			}
			return arraySortHelper;
		}
	}

	[SecuritySafeCritical]
	private static IArraySortHelper<TKey, TValue> CreateArraySortHelper()
	{
		if (typeof(IComparable<TKey>).IsAssignableFrom(typeof(TKey)))
		{
			defaultArraySortHelper = (IArraySortHelper<TKey, TValue>)RuntimeTypeHandle.Allocate(typeof(GenericArraySortHelper<string, string>).TypeHandle.Instantiate(new Type[2]
			{
				typeof(TKey),
				typeof(TValue)
			}));
		}
		else
		{
			defaultArraySortHelper = new ArraySortHelper<TKey, TValue>();
		}
		return defaultArraySortHelper;
	}

	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer)
	{
		try
		{
			if (comparer == null || comparer == Comparer<TKey>.Default)
			{
				comparer = Comparer<TKey>.Default;
			}
			if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				IntrospectiveSort(keys, values, index, length, comparer);
			}
			else
			{
				DepthLimitedQuickSort(keys, values, index, length + index - 1, comparer, 32);
			}
		}
		catch (IndexOutOfRangeException)
		{
			IntrospectiveSortUtilities.ThrowOrIgnoreBadComparer(comparer);
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_IComparerFailed"), innerException);
		}
	}

	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b)
	{
		if (a != b && comparer.Compare(keys[a], keys[b]) > 0)
		{
			TKey val = keys[a];
			keys[a] = keys[b];
			keys[b] = val;
			if (values != null)
			{
				TValue val2 = values[a];
				values[a] = values[b];
				values[b] = val2;
			}
		}
	}

	private static void Swap(TKey[] keys, TValue[] values, int i, int j)
	{
		if (i != j)
		{
			TKey val = keys[i];
			keys[i] = keys[j];
			keys[j] = val;
			if (values != null)
			{
				TValue val2 = values[i];
				values[i] = values[j];
				values[j] = val2;
			}
		}
	}

	internal static void DepthLimitedQuickSort(TKey[] keys, TValue[] values, int left, int right, IComparer<TKey> comparer, int depthLimit)
	{
		do
		{
			if (depthLimit == 0)
			{
				Heapsort(keys, values, left, right, comparer);
				break;
			}
			int num = left;
			int num2 = right;
			int num3 = num + (num2 - num >> 1);
			SwapIfGreaterWithItems(keys, values, comparer, num, num3);
			SwapIfGreaterWithItems(keys, values, comparer, num, num2);
			SwapIfGreaterWithItems(keys, values, comparer, num3, num2);
			TKey val = keys[num3];
			while (true)
			{
				if (comparer.Compare(keys[num], val) < 0)
				{
					num++;
					continue;
				}
				while (comparer.Compare(val, keys[num2]) < 0)
				{
					num2--;
				}
				if (num > num2)
				{
					break;
				}
				if (num < num2)
				{
					TKey val2 = keys[num];
					keys[num] = keys[num2];
					keys[num2] = val2;
					if (values != null)
					{
						TValue val3 = values[num];
						values[num] = values[num2];
						values[num2] = val3;
					}
				}
				num++;
				num2--;
				if (num > num2)
				{
					break;
				}
			}
			depthLimit--;
			if (num2 - left <= right - num)
			{
				if (left < num2)
				{
					DepthLimitedQuickSort(keys, values, left, num2, comparer, depthLimit);
				}
				left = num;
			}
			else
			{
				if (num < right)
				{
					DepthLimitedQuickSort(keys, values, num, right, comparer, depthLimit);
				}
				right = num2;
			}
		}
		while (left < right);
	}

	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer)
	{
		if (length >= 2)
		{
			IntroSort(keys, values, left, length + left - 1, 2 * IntrospectiveSortUtilities.FloorLog2(keys.Length), comparer);
		}
	}

	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
	{
		while (hi > lo)
		{
			int num = hi - lo + 1;
			if (num <= 16)
			{
				switch (num)
				{
				case 1:
					break;
				case 2:
					SwapIfGreaterWithItems(keys, values, comparer, lo, hi);
					break;
				case 3:
					SwapIfGreaterWithItems(keys, values, comparer, lo, hi - 1);
					SwapIfGreaterWithItems(keys, values, comparer, lo, hi);
					SwapIfGreaterWithItems(keys, values, comparer, hi - 1, hi);
					break;
				default:
					InsertionSort(keys, values, lo, hi, comparer);
					break;
				}
				break;
			}
			if (depthLimit == 0)
			{
				Heapsort(keys, values, lo, hi, comparer);
				break;
			}
			depthLimit--;
			int num2 = PickPivotAndPartition(keys, values, lo, hi, comparer);
			IntroSort(keys, values, num2 + 1, hi, depthLimit, comparer);
			hi = num2 - 1;
		}
	}

	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
	{
		int num = lo + (hi - lo) / 2;
		SwapIfGreaterWithItems(keys, values, comparer, lo, num);
		SwapIfGreaterWithItems(keys, values, comparer, lo, hi);
		SwapIfGreaterWithItems(keys, values, comparer, num, hi);
		TKey val = keys[num];
		Swap(keys, values, num, hi - 1);
		int num2 = lo;
		int num3 = hi - 1;
		while (num2 < num3)
		{
			while (comparer.Compare(keys[++num2], val) < 0)
			{
			}
			while (comparer.Compare(val, keys[--num3]) < 0)
			{
			}
			if (num2 >= num3)
			{
				break;
			}
			Swap(keys, values, num2, num3);
		}
		Swap(keys, values, num2, hi - 1);
		return num2;
	}

	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
	{
		int num = hi - lo + 1;
		for (int num2 = num / 2; num2 >= 1; num2--)
		{
			DownHeap(keys, values, num2, num, lo, comparer);
		}
		for (int num3 = num; num3 > 1; num3--)
		{
			Swap(keys, values, lo, lo + num3 - 1);
			DownHeap(keys, values, 1, num3 - 1, lo, comparer);
		}
	}

	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer)
	{
		TKey val = keys[lo + i - 1];
		TValue val2 = ((values != null) ? values[lo + i - 1] : default(TValue));
		while (i <= n / 2)
		{
			int num = 2 * i;
			if (num < n && comparer.Compare(keys[lo + num - 1], keys[lo + num]) < 0)
			{
				num++;
			}
			if (comparer.Compare(val, keys[lo + num - 1]) >= 0)
			{
				break;
			}
			keys[lo + i - 1] = keys[lo + num - 1];
			if (values != null)
			{
				values[lo + i - 1] = values[lo + num - 1];
			}
			i = num;
		}
		keys[lo + i - 1] = val;
		if (values != null)
		{
			values[lo + i - 1] = val2;
		}
	}

	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer)
	{
		for (int i = lo; i < hi; i++)
		{
			int num = i;
			TKey val = keys[i + 1];
			TValue val2 = ((values != null) ? values[i + 1] : default(TValue));
			while (num >= lo && comparer.Compare(val, keys[num]) < 0)
			{
				keys[num + 1] = keys[num];
				if (values != null)
				{
					values[num + 1] = values[num];
				}
				num--;
			}
			keys[num + 1] = val;
			if (values != null)
			{
				values[num + 1] = val2;
			}
		}
	}
}
