using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal abstract class SortHelper<TInputOutput>
{
	internal abstract TInputOutput[] Sort();
}
internal class SortHelper<TInputOutput, TKey> : SortHelper<TInputOutput>, IDisposable
{
	private QueryOperatorEnumerator<TInputOutput, TKey> m_source;

	private int m_partitionCount;

	private int m_partitionIndex;

	private QueryTaskGroupState m_groupState;

	private int[][] m_sharedIndices;

	private GrowingArray<TKey>[] m_sharedKeys;

	private TInputOutput[][] m_sharedValues;

	private Barrier[,] m_sharedBarriers;

	private OrdinalIndexState m_indexState;

	private IComparer<TKey> m_keyComparer;

	private SortHelper(QueryOperatorEnumerator<TInputOutput, TKey> source, int partitionCount, int partitionIndex, QueryTaskGroupState groupState, int[][] sharedIndices, OrdinalIndexState indexState, IComparer<TKey> keyComparer, GrowingArray<TKey>[] sharedkeys, TInputOutput[][] sharedValues, Barrier[,] sharedBarriers)
	{
		m_source = source;
		m_partitionCount = partitionCount;
		m_partitionIndex = partitionIndex;
		m_groupState = groupState;
		m_sharedIndices = sharedIndices;
		m_indexState = indexState;
		m_keyComparer = keyComparer;
		m_sharedKeys = sharedkeys;
		m_sharedValues = sharedValues;
		m_sharedBarriers = sharedBarriers;
	}

	internal static SortHelper<TInputOutput, TKey>[] GenerateSortHelpers(PartitionedStream<TInputOutput, TKey> partitions, QueryTaskGroupState groupState)
	{
		int partitionCount = partitions.PartitionCount;
		SortHelper<TInputOutput, TKey>[] array = new SortHelper<TInputOutput, TKey>[partitionCount];
		int num = 1;
		int num2 = 0;
		while (num < partitionCount)
		{
			num2++;
			num <<= 1;
		}
		int[][] sharedIndices = new int[partitionCount][];
		GrowingArray<TKey>[] sharedkeys = new GrowingArray<TKey>[partitionCount];
		TInputOutput[][] sharedValues = new TInputOutput[partitionCount][];
		Barrier[,] array2 = new Barrier[num2, partitionCount];
		if (partitionCount > 1)
		{
			int num3 = 1;
			for (int i = 0; i < array2.GetLength(0); i++)
			{
				for (int j = 0; j < array2.GetLength(1); j++)
				{
					if (j % num3 == 0)
					{
						array2[i, j] = new Barrier(2);
					}
				}
				num3 *= 2;
			}
		}
		for (int k = 0; k < partitionCount; k++)
		{
			array[k] = new SortHelper<TInputOutput, TKey>(partitions[k], partitionCount, k, groupState, sharedIndices, partitions.OrdinalIndexState, partitions.KeyComparer, sharedkeys, sharedValues, array2);
		}
		return array;
	}

	public void Dispose()
	{
		if (m_partitionIndex != 0)
		{
			return;
		}
		for (int i = 0; i < m_sharedBarriers.GetLength(0); i++)
		{
			for (int j = 0; j < m_sharedBarriers.GetLength(1); j++)
			{
				m_sharedBarriers[i, j]?.Dispose();
			}
		}
	}

	internal override TInputOutput[] Sort()
	{
		GrowingArray<TKey> keys = null;
		List<TInputOutput> values = null;
		BuildKeysFromSource(ref keys, ref values);
		QuickSortIndicesInPlace(keys, values, m_indexState);
		if (m_partitionCount > 1)
		{
			MergeSortCooperatively();
		}
		return m_sharedValues[m_partitionIndex];
	}

	private void BuildKeysFromSource(ref GrowingArray<TKey> keys, ref List<TInputOutput> values)
	{
		values = new List<TInputOutput>();
		CancellationToken mergedCancellationToken = m_groupState.CancellationState.MergedCancellationToken;
		try
		{
			TInputOutput currentElement = default(TInputOutput);
			TKey currentKey = default(TKey);
			bool flag = m_source.MoveNext(ref currentElement, ref currentKey);
			if (keys == null)
			{
				keys = new GrowingArray<TKey>();
			}
			if (!flag)
			{
				return;
			}
			int num = 0;
			do
			{
				if ((num++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(mergedCancellationToken);
				}
				keys.Add(currentKey);
				values.Add(currentElement);
			}
			while (m_source.MoveNext(ref currentElement, ref currentKey));
		}
		finally
		{
			m_source.Dispose();
		}
	}

	private void QuickSortIndicesInPlace(GrowingArray<TKey> keys, List<TInputOutput> values, OrdinalIndexState ordinalIndexState)
	{
		int[] array = new int[values.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i;
		}
		if (array.Length > 1 && ordinalIndexState.IsWorseThan(OrdinalIndexState.Increasing))
		{
			QuickSort(0, array.Length - 1, keys.InternalArray, array, m_groupState.CancellationState.MergedCancellationToken);
		}
		if (m_partitionCount == 1)
		{
			TInputOutput[] array2 = new TInputOutput[values.Count];
			for (int j = 0; j < array.Length; j++)
			{
				array2[j] = values[array[j]];
			}
			m_sharedValues[m_partitionIndex] = array2;
		}
		else
		{
			m_sharedIndices[m_partitionIndex] = array;
			m_sharedKeys[m_partitionIndex] = keys;
			m_sharedValues[m_partitionIndex] = new TInputOutput[values.Count];
			values.CopyTo(m_sharedValues[m_partitionIndex]);
		}
	}

	private void MergeSortCooperatively()
	{
		CancellationToken mergedCancellationToken = m_groupState.CancellationState.MergedCancellationToken;
		int length = m_sharedBarriers.GetLength(0);
		for (int i = 0; i < length; i++)
		{
			bool flag = i == length - 1;
			int num = ComputePartnerIndex(i);
			if (num >= m_partitionCount)
			{
				continue;
			}
			int[] array = m_sharedIndices[m_partitionIndex];
			GrowingArray<TKey> growingArray = m_sharedKeys[m_partitionIndex];
			TKey[] internalArray = growingArray.InternalArray;
			TInputOutput[] array2 = m_sharedValues[m_partitionIndex];
			m_sharedBarriers[i, Math.Min(m_partitionIndex, num)].SignalAndWait(mergedCancellationToken);
			if (m_partitionIndex < num)
			{
				int[] array3 = m_sharedIndices[num];
				TKey[] internalArray2 = m_sharedKeys[num].InternalArray;
				TInputOutput[] array4 = m_sharedValues[num];
				m_sharedIndices[num] = array;
				m_sharedKeys[num] = growingArray;
				m_sharedValues[num] = array2;
				int num2 = array2.Length;
				int num3 = array4.Length;
				int num4 = num2 + num3;
				int[] array5 = null;
				TInputOutput[] array6 = new TInputOutput[num4];
				if (!flag)
				{
					array5 = new int[num4];
				}
				m_sharedIndices[m_partitionIndex] = array5;
				m_sharedKeys[m_partitionIndex] = growingArray;
				m_sharedValues[m_partitionIndex] = array6;
				m_sharedBarriers[i, m_partitionIndex].SignalAndWait(mergedCancellationToken);
				int num5 = (num4 + 1) / 2;
				int j = 0;
				int num6 = 0;
				int num7 = 0;
				for (; j < num5; j++)
				{
					if ((j & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(mergedCancellationToken);
					}
					if (num6 < num2 && (num7 >= num3 || m_keyComparer.Compare(internalArray[array[num6]], internalArray2[array3[num7]]) <= 0))
					{
						if (flag)
						{
							array6[j] = array2[array[num6]];
						}
						else
						{
							array5[j] = array[num6];
						}
						num6++;
					}
					else
					{
						if (flag)
						{
							array6[j] = array4[array3[num7]];
						}
						else
						{
							array5[j] = num2 + array3[num7];
						}
						num7++;
					}
				}
				if (!flag && num2 > 0)
				{
					Array.Copy(array2, 0, array6, 0, num2);
				}
				m_sharedBarriers[i, m_partitionIndex].SignalAndWait(mergedCancellationToken);
				continue;
			}
			m_sharedBarriers[i, num].SignalAndWait(mergedCancellationToken);
			int[] array7 = m_sharedIndices[m_partitionIndex];
			TKey[] internalArray3 = m_sharedKeys[m_partitionIndex].InternalArray;
			TInputOutput[] array8 = m_sharedValues[m_partitionIndex];
			int[] array9 = m_sharedIndices[num];
			GrowingArray<TKey> growingArray2 = m_sharedKeys[num];
			TInputOutput[] array10 = m_sharedValues[num];
			int num8 = array8.Length;
			int num9 = array2.Length;
			int num10 = num8 + num9;
			int num11 = (num10 + 1) / 2;
			int num12 = num10 - 1;
			int num13 = num8 - 1;
			int num14 = num9 - 1;
			while (num12 >= num11)
			{
				if ((num12 & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(mergedCancellationToken);
				}
				if (num13 >= 0 && (num14 < 0 || m_keyComparer.Compare(internalArray3[array7[num13]], internalArray[array[num14]]) > 0))
				{
					if (flag)
					{
						array10[num12] = array8[array7[num13]];
					}
					else
					{
						array9[num12] = array7[num13];
					}
					num13--;
				}
				else
				{
					if (flag)
					{
						array10[num12] = array2[array[num14]];
					}
					else
					{
						array9[num12] = num8 + array[num14];
					}
					num14--;
				}
				num12--;
			}
			if (!flag && array2.Length != 0)
			{
				growingArray2.CopyFrom(internalArray, array2.Length);
				Array.Copy(array2, 0, array10, num8, array2.Length);
			}
			m_sharedBarriers[i, num].SignalAndWait(mergedCancellationToken);
			break;
		}
	}

	private int ComputePartnerIndex(int phase)
	{
		int num = 1 << phase;
		return m_partitionIndex + ((m_partitionIndex % (num * 2) == 0) ? num : (-num));
	}

	private void QuickSort(int left, int right, TKey[] keys, int[] indices, CancellationToken cancelToken)
	{
		if (right - left > 63)
		{
			CancellationState.ThrowIfCanceled(cancelToken);
		}
		do
		{
			int num = left;
			int num2 = right;
			int num3 = indices[num + (num2 - num >> 1)];
			TKey y = keys[num3];
			while (true)
			{
				if (m_keyComparer.Compare(keys[indices[num]], y) < 0)
				{
					num++;
					continue;
				}
				while (m_keyComparer.Compare(keys[indices[num2]], y) > 0)
				{
					num2--;
				}
				if (num > num2)
				{
					break;
				}
				if (num < num2)
				{
					int num4 = indices[num];
					indices[num] = indices[num2];
					indices[num2] = num4;
				}
				num++;
				num2--;
				if (num > num2)
				{
					break;
				}
			}
			if (num2 - left <= right - num)
			{
				if (left < num2)
				{
					QuickSort(left, num2, keys, indices, cancelToken);
				}
				left = num;
			}
			else
			{
				if (num < right)
				{
					QuickSort(num, right, keys, indices, cancelToken);
				}
				right = num2;
			}
		}
		while (left < right);
	}
}
