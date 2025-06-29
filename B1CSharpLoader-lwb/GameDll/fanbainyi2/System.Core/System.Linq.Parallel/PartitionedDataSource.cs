using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class PartitionedDataSource<T> : PartitionedStream<T, int>
{
	internal sealed class ArrayIndexRangeEnumerator : QueryOperatorEnumerator<T, int>
	{
		private class Mutables
		{
			internal int m_currentSection;

			internal int m_currentChunkSize;

			internal int m_currentPositionInChunk;

			internal int m_currentChunkOffset;

			internal Mutables()
			{
				m_currentSection = -1;
			}
		}

		private readonly T[] m_data;

		private readonly int m_elementCount;

		private readonly int m_partitionCount;

		private readonly int m_partitionIndex;

		private readonly int m_maxChunkSize;

		private readonly int m_sectionCount;

		private Mutables m_mutables;

		internal ArrayIndexRangeEnumerator(T[] data, int partitionCount, int partitionIndex, int maxChunkSize)
		{
			m_data = data;
			m_elementCount = data.Length;
			m_partitionCount = partitionCount;
			m_partitionIndex = partitionIndex;
			m_maxChunkSize = maxChunkSize;
			int num = maxChunkSize * partitionCount;
			m_sectionCount = m_elementCount / num + ((m_elementCount % num != 0) ? 1 : 0);
		}

		internal override bool MoveNext(ref T currentElement, ref int currentKey)
		{
			Mutables mutables = m_mutables;
			if (mutables == null)
			{
				mutables = (m_mutables = new Mutables());
			}
			if (++mutables.m_currentPositionInChunk < mutables.m_currentChunkSize || MoveNextSlowPath())
			{
				currentKey = mutables.m_currentChunkOffset + mutables.m_currentPositionInChunk;
				currentElement = m_data[currentKey];
				return true;
			}
			return false;
		}

		private bool MoveNextSlowPath()
		{
			Mutables mutables = m_mutables;
			int num = ++mutables.m_currentSection;
			int num2 = m_sectionCount - num;
			if (num2 <= 0)
			{
				return false;
			}
			int num3 = num * m_partitionCount * m_maxChunkSize;
			mutables.m_currentPositionInChunk = 0;
			if (num2 > 1)
			{
				mutables.m_currentChunkSize = m_maxChunkSize;
				mutables.m_currentChunkOffset = num3 + m_partitionIndex * m_maxChunkSize;
			}
			else
			{
				int num4 = m_elementCount - num3;
				int num5 = num4 / m_partitionCount;
				int num6 = num4 % m_partitionCount;
				mutables.m_currentChunkSize = num5;
				if (m_partitionIndex < num6)
				{
					mutables.m_currentChunkSize++;
				}
				if (mutables.m_currentChunkSize == 0)
				{
					return false;
				}
				mutables.m_currentChunkOffset = num3 + m_partitionIndex * num5 + ((m_partitionIndex < num6) ? m_partitionIndex : num6);
			}
			return true;
		}
	}

	internal sealed class ArrayContiguousIndexRangeEnumerator : QueryOperatorEnumerator<T, int>
	{
		private readonly T[] m_data;

		private readonly int m_startIndex;

		private readonly int m_maximumIndex;

		private Shared<int> m_currentIndex;

		internal ArrayContiguousIndexRangeEnumerator(T[] data, int partitionCount, int partitionIndex)
		{
			m_data = data;
			int num = data.Length / partitionCount;
			int num2 = data.Length % partitionCount;
			int num3 = partitionIndex * num + ((partitionIndex < num2) ? partitionIndex : num2);
			m_startIndex = num3 - 1;
			m_maximumIndex = num3 + num + ((partitionIndex < num2) ? 1 : 0);
		}

		internal override bool MoveNext(ref T currentElement, ref int currentKey)
		{
			if (m_currentIndex == null)
			{
				m_currentIndex = new Shared<int>(m_startIndex);
			}
			int num = ++m_currentIndex.Value;
			if (num < m_maximumIndex)
			{
				currentKey = num;
				currentElement = m_data[num];
				return true;
			}
			return false;
		}
	}

	internal sealed class ListIndexRangeEnumerator : QueryOperatorEnumerator<T, int>
	{
		private class Mutables
		{
			internal int m_currentSection;

			internal int m_currentChunkSize;

			internal int m_currentPositionInChunk;

			internal int m_currentChunkOffset;

			internal Mutables()
			{
				m_currentSection = -1;
			}
		}

		private readonly IList<T> m_data;

		private readonly int m_elementCount;

		private readonly int m_partitionCount;

		private readonly int m_partitionIndex;

		private readonly int m_maxChunkSize;

		private readonly int m_sectionCount;

		private Mutables m_mutables;

		internal ListIndexRangeEnumerator(IList<T> data, int partitionCount, int partitionIndex, int maxChunkSize)
		{
			m_data = data;
			m_elementCount = data.Count;
			m_partitionCount = partitionCount;
			m_partitionIndex = partitionIndex;
			m_maxChunkSize = maxChunkSize;
			int num = maxChunkSize * partitionCount;
			m_sectionCount = m_elementCount / num + ((m_elementCount % num != 0) ? 1 : 0);
		}

		internal override bool MoveNext(ref T currentElement, ref int currentKey)
		{
			Mutables mutables = m_mutables;
			if (mutables == null)
			{
				mutables = (m_mutables = new Mutables());
			}
			if (++mutables.m_currentPositionInChunk < mutables.m_currentChunkSize || MoveNextSlowPath())
			{
				currentKey = mutables.m_currentChunkOffset + mutables.m_currentPositionInChunk;
				currentElement = m_data[currentKey];
				return true;
			}
			return false;
		}

		private bool MoveNextSlowPath()
		{
			Mutables mutables = m_mutables;
			int num = ++mutables.m_currentSection;
			int num2 = m_sectionCount - num;
			if (num2 <= 0)
			{
				return false;
			}
			int num3 = num * m_partitionCount * m_maxChunkSize;
			mutables.m_currentPositionInChunk = 0;
			if (num2 > 1)
			{
				mutables.m_currentChunkSize = m_maxChunkSize;
				mutables.m_currentChunkOffset = num3 + m_partitionIndex * m_maxChunkSize;
			}
			else
			{
				int num4 = m_elementCount - num3;
				int num5 = num4 / m_partitionCount;
				int num6 = num4 % m_partitionCount;
				mutables.m_currentChunkSize = num5;
				if (m_partitionIndex < num6)
				{
					mutables.m_currentChunkSize++;
				}
				if (mutables.m_currentChunkSize == 0)
				{
					return false;
				}
				mutables.m_currentChunkOffset = num3 + m_partitionIndex * num5 + ((m_partitionIndex < num6) ? m_partitionIndex : num6);
			}
			return true;
		}
	}

	internal sealed class ListContiguousIndexRangeEnumerator : QueryOperatorEnumerator<T, int>
	{
		private readonly IList<T> m_data;

		private readonly int m_startIndex;

		private readonly int m_maximumIndex;

		private Shared<int> m_currentIndex;

		internal ListContiguousIndexRangeEnumerator(IList<T> data, int partitionCount, int partitionIndex)
		{
			m_data = data;
			int num = data.Count / partitionCount;
			int num2 = data.Count % partitionCount;
			int num3 = partitionIndex * num + ((partitionIndex < num2) ? partitionIndex : num2);
			m_startIndex = num3 - 1;
			m_maximumIndex = num3 + num + ((partitionIndex < num2) ? 1 : 0);
		}

		internal override bool MoveNext(ref T currentElement, ref int currentKey)
		{
			if (m_currentIndex == null)
			{
				m_currentIndex = new Shared<int>(m_startIndex);
			}
			int num = ++m_currentIndex.Value;
			if (num < m_maximumIndex)
			{
				currentKey = num;
				currentElement = m_data[num];
				return true;
			}
			return false;
		}
	}

	private class ContiguousChunkLazyEnumerator : QueryOperatorEnumerator<T, int>
	{
		private class Mutables
		{
			internal readonly T[] m_chunkBuffer;

			internal int m_nextChunkMaxSize;

			internal int m_currentChunkSize;

			internal int m_currentChunkIndex;

			internal int m_chunkBaseIndex;

			internal int m_chunkCounter;

			internal Mutables()
			{
				m_nextChunkMaxSize = 1;
				m_chunkBuffer = new T[Scheduling.GetDefaultChunkSize<T>()];
				m_currentChunkSize = 0;
				m_currentChunkIndex = -1;
				m_chunkBaseIndex = 0;
				m_chunkCounter = 0;
			}
		}

		private const int chunksPerChunkSize = 7;

		private readonly IEnumerator<T> m_source;

		private readonly object m_sourceSyncLock;

		private readonly Shared<int> m_currentIndex;

		private readonly Shared<int> m_activeEnumeratorsCount;

		private readonly Shared<bool> m_exceptionTracker;

		private Mutables m_mutables;

		internal ContiguousChunkLazyEnumerator(IEnumerator<T> source, Shared<bool> exceptionTracker, object sourceSyncLock, Shared<int> currentIndex, Shared<int> degreeOfParallelism)
		{
			m_source = source;
			m_sourceSyncLock = sourceSyncLock;
			m_currentIndex = currentIndex;
			m_activeEnumeratorsCount = degreeOfParallelism;
			m_exceptionTracker = exceptionTracker;
		}

		internal override bool MoveNext(ref T currentElement, ref int currentKey)
		{
			Mutables mutables = m_mutables;
			if (mutables == null)
			{
				mutables = (m_mutables = new Mutables());
			}
			T[] chunkBuffer;
			int num;
			while (true)
			{
				chunkBuffer = mutables.m_chunkBuffer;
				num = ++mutables.m_currentChunkIndex;
				if (num < mutables.m_currentChunkSize)
				{
					break;
				}
				lock (m_sourceSyncLock)
				{
					int i = 0;
					if (m_exceptionTracker.Value)
					{
						return false;
					}
					try
					{
						for (; i < mutables.m_nextChunkMaxSize; i++)
						{
							if (!m_source.MoveNext())
							{
								break;
							}
							chunkBuffer[i] = m_source.Current;
						}
					}
					catch
					{
						m_exceptionTracker.Value = true;
						throw;
					}
					mutables.m_currentChunkSize = i;
					if (i == 0)
					{
						return false;
					}
					mutables.m_chunkBaseIndex = m_currentIndex.Value;
					checked
					{
						m_currentIndex.Value += i;
					}
				}
				if (mutables.m_nextChunkMaxSize < chunkBuffer.Length && (mutables.m_chunkCounter++ & 7) == 7)
				{
					mutables.m_nextChunkMaxSize *= 2;
					if (mutables.m_nextChunkMaxSize > chunkBuffer.Length)
					{
						mutables.m_nextChunkMaxSize = chunkBuffer.Length;
					}
				}
				mutables.m_currentChunkIndex = -1;
			}
			currentElement = chunkBuffer[num];
			currentKey = mutables.m_chunkBaseIndex + num;
			return true;
		}

		protected override void Dispose(bool disposing)
		{
			if (Interlocked.Decrement(ref m_activeEnumeratorsCount.Value) == 0)
			{
				m_source.Dispose();
			}
		}
	}

	internal PartitionedDataSource(IEnumerable<T> source, int partitionCount, bool useStriping)
		: base(partitionCount, (IComparer<int>)Util.GetDefaultComparer<int>(), (!(source is IList<T>)) ? OrdinalIndexState.Correct : OrdinalIndexState.Indexible)
	{
		InitializePartitions(source, partitionCount, useStriping);
	}

	private void InitializePartitions(IEnumerable<T> source, int partitionCount, bool useStriping)
	{
		if (source is ParallelEnumerableWrapper<T> parallelEnumerableWrapper)
		{
			source = parallelEnumerableWrapper.WrappedEnumerable;
		}
		if (source is IList<T> list)
		{
			QueryOperatorEnumerator<T, int>[] array = new QueryOperatorEnumerator<T, int>[partitionCount];
			int count = list.Count;
			T[] array2 = source as T[];
			int num = -1;
			if (useStriping)
			{
				num = Scheduling.GetDefaultChunkSize<T>();
				if (num < 1)
				{
					num = 1;
				}
			}
			for (int i = 0; i < partitionCount; i++)
			{
				if (array2 != null)
				{
					if (useStriping)
					{
						array[i] = new ArrayIndexRangeEnumerator(array2, partitionCount, i, num);
					}
					else
					{
						array[i] = new ArrayContiguousIndexRangeEnumerator(array2, partitionCount, i);
					}
				}
				else if (useStriping)
				{
					array[i] = new ListIndexRangeEnumerator(list, partitionCount, i, num);
				}
				else
				{
					array[i] = new ListContiguousIndexRangeEnumerator(list, partitionCount, i);
				}
			}
			m_partitions = array;
		}
		else
		{
			m_partitions = MakePartitions(source.GetEnumerator(), partitionCount);
		}
	}

	private static QueryOperatorEnumerator<T, int>[] MakePartitions(IEnumerator<T> source, int partitionCount)
	{
		QueryOperatorEnumerator<T, int>[] array = new QueryOperatorEnumerator<T, int>[partitionCount];
		object sourceSyncLock = new object();
		Shared<int> currentIndex = new Shared<int>(0);
		Shared<int> degreeOfParallelism = new Shared<int>(partitionCount);
		Shared<bool> exceptionTracker = new Shared<bool>(value: false);
		for (int i = 0; i < partitionCount; i++)
		{
			array[i] = new ContiguousChunkLazyEnumerator(source, exceptionTracker, sourceSyncLock, currentIndex, degreeOfParallelism);
		}
		return array;
	}
}
