using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Concurrent;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public abstract class Partitioner<TSource>
{
	[__DynamicallyInvokable]
	public virtual bool SupportsDynamicPartitions
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public abstract IList<IEnumerator<TSource>> GetPartitions(int partitionCount);

	[__DynamicallyInvokable]
	public virtual IEnumerable<TSource> GetDynamicPartitions()
	{
		throw new NotSupportedException(Environment.GetResourceString("Partitioner_DynamicPartitionsNotSupported"));
	}

	[__DynamicallyInvokable]
	protected Partitioner()
	{
	}
}
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public static class Partitioner
{
	private abstract class DynamicPartitionEnumerator_Abstract<TSource, TSourceReader> : IEnumerator<KeyValuePair<long, TSource>>, IDisposable, IEnumerator
	{
		protected readonly TSourceReader m_sharedReader;

		protected static int s_defaultMaxChunkSize = GetDefaultChunkSize<TSource>();

		protected SharedInt m_currentChunkSize;

		protected SharedInt m_localOffset;

		private const int CHUNK_DOUBLING_RATE = 3;

		private int m_doublingCountdown;

		protected readonly int m_maxChunkSize;

		protected readonly SharedLong m_sharedIndex;

		protected abstract bool HasNoElementsLeft { get; set; }

		public abstract KeyValuePair<long, TSource> Current { get; }

		object IEnumerator.Current => Current;

		protected DynamicPartitionEnumerator_Abstract(TSourceReader sharedReader, SharedLong sharedIndex)
			: this(sharedReader, sharedIndex, useSingleChunking: false)
		{
		}

		protected DynamicPartitionEnumerator_Abstract(TSourceReader sharedReader, SharedLong sharedIndex, bool useSingleChunking)
		{
			m_sharedReader = sharedReader;
			m_sharedIndex = sharedIndex;
			m_maxChunkSize = (useSingleChunking ? 1 : s_defaultMaxChunkSize);
		}

		protected abstract bool GrabNextChunk(int requestedChunkSize);

		public abstract void Dispose();

		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			if (m_localOffset == null)
			{
				m_localOffset = new SharedInt(-1);
				m_currentChunkSize = new SharedInt(0);
				m_doublingCountdown = 3;
			}
			if (m_localOffset.Value < m_currentChunkSize.Value - 1)
			{
				m_localOffset.Value++;
				return true;
			}
			int requestedChunkSize;
			if (m_currentChunkSize.Value == 0)
			{
				requestedChunkSize = 1;
			}
			else if (m_doublingCountdown > 0)
			{
				requestedChunkSize = m_currentChunkSize.Value;
			}
			else
			{
				requestedChunkSize = Math.Min(m_currentChunkSize.Value * 2, m_maxChunkSize);
				m_doublingCountdown = 3;
			}
			m_doublingCountdown--;
			if (GrabNextChunk(requestedChunkSize))
			{
				m_localOffset.Value = 0;
				return true;
			}
			return false;
		}
	}

	private class DynamicPartitionerForIEnumerable<TSource> : OrderablePartitioner<TSource>
	{
		private class InternalPartitionEnumerable : IEnumerable<KeyValuePair<long, TSource>>, IEnumerable, IDisposable
		{
			private readonly IEnumerator<TSource> m_sharedReader;

			private SharedLong m_sharedIndex;

			private volatile KeyValuePair<long, TSource>[] m_FillBuffer;

			private volatile int m_FillBufferSize;

			private volatile int m_FillBufferCurrentPosition;

			private volatile int m_activeCopiers;

			private SharedBool m_hasNoElementsLeft;

			private SharedBool m_sourceDepleted;

			private object m_sharedLock;

			private bool m_disposed;

			private SharedInt m_activePartitionCount;

			private readonly bool m_useSingleChunking;

			internal InternalPartitionEnumerable(IEnumerator<TSource> sharedReader, bool useSingleChunking, bool isStaticPartitioning)
			{
				m_sharedReader = sharedReader;
				m_sharedIndex = new SharedLong(-1L);
				m_hasNoElementsLeft = new SharedBool(value: false);
				m_sourceDepleted = new SharedBool(value: false);
				m_sharedLock = new object();
				m_useSingleChunking = useSingleChunking;
				if (!m_useSingleChunking)
				{
					m_FillBuffer = new KeyValuePair<long, TSource>[((PlatformHelper.ProcessorCount <= 4) ? 1 : 4) * GetDefaultChunkSize<TSource>()];
				}
				if (isStaticPartitioning)
				{
					m_activePartitionCount = new SharedInt(0);
				}
				else
				{
					m_activePartitionCount = null;
				}
			}

			public IEnumerator<KeyValuePair<long, TSource>> GetEnumerator()
			{
				if (m_disposed)
				{
					throw new ObjectDisposedException(Environment.GetResourceString("PartitionerStatic_CanNotCallGetEnumeratorAfterSourceHasBeenDisposed"));
				}
				return new InternalPartitionEnumerator(m_sharedReader, m_sharedIndex, m_hasNoElementsLeft, m_sharedLock, m_activePartitionCount, this, m_useSingleChunking);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			private void TryCopyFromFillBuffer(KeyValuePair<long, TSource>[] destArray, int requestedChunkSize, ref int actualNumElementsGrabbed)
			{
				actualNumElementsGrabbed = 0;
				KeyValuePair<long, TSource>[] fillBuffer = m_FillBuffer;
				if (fillBuffer != null && m_FillBufferCurrentPosition < m_FillBufferSize)
				{
					Interlocked.Increment(ref m_activeCopiers);
					int num = Interlocked.Add(ref m_FillBufferCurrentPosition, requestedChunkSize);
					int num2 = num - requestedChunkSize;
					if (num2 < m_FillBufferSize)
					{
						actualNumElementsGrabbed = ((num < m_FillBufferSize) ? num : (m_FillBufferSize - num2));
						Array.Copy(fillBuffer, num2, destArray, 0, actualNumElementsGrabbed);
					}
					Interlocked.Decrement(ref m_activeCopiers);
				}
			}

			internal bool GrabChunk(KeyValuePair<long, TSource>[] destArray, int requestedChunkSize, ref int actualNumElementsGrabbed)
			{
				actualNumElementsGrabbed = 0;
				if (m_hasNoElementsLeft.Value)
				{
					return false;
				}
				if (m_useSingleChunking)
				{
					return GrabChunk_Single(destArray, requestedChunkSize, ref actualNumElementsGrabbed);
				}
				return GrabChunk_Buffered(destArray, requestedChunkSize, ref actualNumElementsGrabbed);
			}

			internal bool GrabChunk_Single(KeyValuePair<long, TSource>[] destArray, int requestedChunkSize, ref int actualNumElementsGrabbed)
			{
				lock (m_sharedLock)
				{
					if (m_hasNoElementsLeft.Value)
					{
						return false;
					}
					try
					{
						if (m_sharedReader.MoveNext())
						{
							m_sharedIndex.Value = checked(m_sharedIndex.Value + 1);
							destArray[0] = new KeyValuePair<long, TSource>(m_sharedIndex.Value, m_sharedReader.Current);
							actualNumElementsGrabbed = 1;
							return true;
						}
						m_sourceDepleted.Value = true;
						m_hasNoElementsLeft.Value = true;
						return false;
					}
					catch
					{
						m_sourceDepleted.Value = true;
						m_hasNoElementsLeft.Value = true;
						throw;
					}
				}
			}

			internal bool GrabChunk_Buffered(KeyValuePair<long, TSource>[] destArray, int requestedChunkSize, ref int actualNumElementsGrabbed)
			{
				TryCopyFromFillBuffer(destArray, requestedChunkSize, ref actualNumElementsGrabbed);
				if (actualNumElementsGrabbed == requestedChunkSize)
				{
					return true;
				}
				if (m_sourceDepleted.Value)
				{
					m_hasNoElementsLeft.Value = true;
					m_FillBuffer = null;
					return actualNumElementsGrabbed > 0;
				}
				lock (m_sharedLock)
				{
					if (m_sourceDepleted.Value)
					{
						return actualNumElementsGrabbed > 0;
					}
					try
					{
						if (m_activeCopiers > 0)
						{
							SpinWait spinWait = default(SpinWait);
							while (m_activeCopiers > 0)
							{
								spinWait.SpinOnce();
							}
						}
						while (actualNumElementsGrabbed < requestedChunkSize)
						{
							if (m_sharedReader.MoveNext())
							{
								m_sharedIndex.Value = checked(m_sharedIndex.Value + 1);
								destArray[actualNumElementsGrabbed] = new KeyValuePair<long, TSource>(m_sharedIndex.Value, m_sharedReader.Current);
								actualNumElementsGrabbed++;
								continue;
							}
							m_sourceDepleted.Value = true;
							break;
						}
						KeyValuePair<long, TSource>[] fillBuffer = m_FillBuffer;
						if (!m_sourceDepleted.Value && fillBuffer != null && m_FillBufferCurrentPosition >= fillBuffer.Length)
						{
							for (int i = 0; i < fillBuffer.Length; i++)
							{
								if (m_sharedReader.MoveNext())
								{
									m_sharedIndex.Value = checked(m_sharedIndex.Value + 1);
									fillBuffer[i] = new KeyValuePair<long, TSource>(m_sharedIndex.Value, m_sharedReader.Current);
									continue;
								}
								m_sourceDepleted.Value = true;
								m_FillBufferSize = i;
								break;
							}
							m_FillBufferCurrentPosition = 0;
						}
					}
					catch
					{
						m_sourceDepleted.Value = true;
						m_hasNoElementsLeft.Value = true;
						throw;
					}
				}
				return actualNumElementsGrabbed > 0;
			}

			public void Dispose()
			{
				if (!m_disposed)
				{
					m_disposed = true;
					m_sharedReader.Dispose();
				}
			}
		}

		private class InternalPartitionEnumerator : DynamicPartitionEnumerator_Abstract<TSource, IEnumerator<TSource>>
		{
			private KeyValuePair<long, TSource>[] m_localList;

			private readonly SharedBool m_hasNoElementsLeft;

			private readonly object m_sharedLock;

			private readonly SharedInt m_activePartitionCount;

			private InternalPartitionEnumerable m_enumerable;

			protected override bool HasNoElementsLeft
			{
				get
				{
					return m_hasNoElementsLeft.Value;
				}
				set
				{
					m_hasNoElementsLeft.Value = true;
				}
			}

			public override KeyValuePair<long, TSource> Current
			{
				get
				{
					if (m_currentChunkSize == null)
					{
						throw new InvalidOperationException(Environment.GetResourceString("PartitionerStatic_CurrentCalledBeforeMoveNext"));
					}
					return m_localList[m_localOffset.Value];
				}
			}

			internal InternalPartitionEnumerator(IEnumerator<TSource> sharedReader, SharedLong sharedIndex, SharedBool hasNoElementsLeft, object sharedLock, SharedInt activePartitionCount, InternalPartitionEnumerable enumerable, bool useSingleChunking)
				: base(sharedReader, sharedIndex, useSingleChunking)
			{
				m_hasNoElementsLeft = hasNoElementsLeft;
				m_sharedLock = sharedLock;
				m_enumerable = enumerable;
				m_activePartitionCount = activePartitionCount;
				if (m_activePartitionCount != null)
				{
					Interlocked.Increment(ref m_activePartitionCount.Value);
				}
			}

			protected override bool GrabNextChunk(int requestedChunkSize)
			{
				if (HasNoElementsLeft)
				{
					return false;
				}
				if (m_localList == null)
				{
					m_localList = new KeyValuePair<long, TSource>[m_maxChunkSize];
				}
				return m_enumerable.GrabChunk(m_localList, requestedChunkSize, ref m_currentChunkSize.Value);
			}

			public override void Dispose()
			{
				if (m_activePartitionCount != null && Interlocked.Decrement(ref m_activePartitionCount.Value) == 0)
				{
					m_enumerable.Dispose();
				}
			}
		}

		private IEnumerable<TSource> m_source;

		private readonly bool m_useSingleChunking;

		public override bool SupportsDynamicPartitions => true;

		internal DynamicPartitionerForIEnumerable(IEnumerable<TSource> source, EnumerablePartitionerOptions partitionerOptions)
			: base(keysOrderedInEachPartition: true, keysOrderedAcrossPartitions: false, keysNormalized: true)
		{
			m_source = source;
			m_useSingleChunking = (partitionerOptions & EnumerablePartitionerOptions.NoBuffering) != 0;
		}

		public override IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount)
		{
			if (partitionCount <= 0)
			{
				throw new ArgumentOutOfRangeException("partitionCount");
			}
			IEnumerator<KeyValuePair<long, TSource>>[] array = new IEnumerator<KeyValuePair<long, TSource>>[partitionCount];
			IEnumerable<KeyValuePair<long, TSource>> enumerable = new InternalPartitionEnumerable(m_source.GetEnumerator(), m_useSingleChunking, isStaticPartitioning: true);
			for (int i = 0; i < partitionCount; i++)
			{
				array[i] = enumerable.GetEnumerator();
			}
			return array;
		}

		public override IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
		{
			return new InternalPartitionEnumerable(m_source.GetEnumerator(), m_useSingleChunking, isStaticPartitioning: false);
		}
	}

	private abstract class DynamicPartitionerForIndexRange_Abstract<TSource, TCollection> : OrderablePartitioner<TSource>
	{
		private TCollection m_data;

		public override bool SupportsDynamicPartitions => true;

		protected DynamicPartitionerForIndexRange_Abstract(TCollection data)
			: base(keysOrderedInEachPartition: true, keysOrderedAcrossPartitions: false, keysNormalized: true)
		{
			m_data = data;
		}

		protected abstract IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions_Factory(TCollection data);

		public override IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount)
		{
			if (partitionCount <= 0)
			{
				throw new ArgumentOutOfRangeException("partitionCount");
			}
			IEnumerator<KeyValuePair<long, TSource>>[] array = new IEnumerator<KeyValuePair<long, TSource>>[partitionCount];
			IEnumerable<KeyValuePair<long, TSource>> orderableDynamicPartitions_Factory = GetOrderableDynamicPartitions_Factory(m_data);
			for (int i = 0; i < partitionCount; i++)
			{
				array[i] = orderableDynamicPartitions_Factory.GetEnumerator();
			}
			return array;
		}

		public override IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
		{
			return GetOrderableDynamicPartitions_Factory(m_data);
		}
	}

	private abstract class DynamicPartitionEnumeratorForIndexRange_Abstract<TSource, TSourceReader> : DynamicPartitionEnumerator_Abstract<TSource, TSourceReader>
	{
		protected int m_startIndex;

		protected abstract int SourceCount { get; }

		protected override bool HasNoElementsLeft
		{
			get
			{
				return Volatile.Read(ref m_sharedIndex.Value) >= SourceCount - 1;
			}
			set
			{
			}
		}

		protected DynamicPartitionEnumeratorForIndexRange_Abstract(TSourceReader sharedReader, SharedLong sharedIndex)
			: base(sharedReader, sharedIndex)
		{
		}

		protected override bool GrabNextChunk(int requestedChunkSize)
		{
			while (!HasNoElementsLeft)
			{
				long num = Volatile.Read(ref m_sharedIndex.Value);
				if (HasNoElementsLeft)
				{
					return false;
				}
				long num2 = Math.Min(SourceCount - 1, num + requestedChunkSize);
				if (Interlocked.CompareExchange(ref m_sharedIndex.Value, num2, num) == num)
				{
					m_currentChunkSize.Value = (int)(num2 - num);
					m_localOffset.Value = -1;
					m_startIndex = (int)(num + 1);
					return true;
				}
			}
			return false;
		}

		public override void Dispose()
		{
		}
	}

	private class DynamicPartitionerForIList<TSource> : DynamicPartitionerForIndexRange_Abstract<TSource, IList<TSource>>
	{
		private class InternalPartitionEnumerable : IEnumerable<KeyValuePair<long, TSource>>, IEnumerable
		{
			private readonly IList<TSource> m_sharedReader;

			private SharedLong m_sharedIndex;

			internal InternalPartitionEnumerable(IList<TSource> sharedReader)
			{
				m_sharedReader = sharedReader;
				m_sharedIndex = new SharedLong(-1L);
			}

			public IEnumerator<KeyValuePair<long, TSource>> GetEnumerator()
			{
				return new InternalPartitionEnumerator(m_sharedReader, m_sharedIndex);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}
		}

		private class InternalPartitionEnumerator : DynamicPartitionEnumeratorForIndexRange_Abstract<TSource, IList<TSource>>
		{
			protected override int SourceCount => m_sharedReader.Count;

			public override KeyValuePair<long, TSource> Current
			{
				get
				{
					if (m_currentChunkSize == null)
					{
						throw new InvalidOperationException(Environment.GetResourceString("PartitionerStatic_CurrentCalledBeforeMoveNext"));
					}
					return new KeyValuePair<long, TSource>(m_startIndex + m_localOffset.Value, m_sharedReader[m_startIndex + m_localOffset.Value]);
				}
			}

			internal InternalPartitionEnumerator(IList<TSource> sharedReader, SharedLong sharedIndex)
				: base(sharedReader, sharedIndex)
			{
			}
		}

		internal DynamicPartitionerForIList(IList<TSource> source)
			: base(source)
		{
		}

		protected override IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions_Factory(IList<TSource> m_data)
		{
			return new InternalPartitionEnumerable(m_data);
		}
	}

	private class DynamicPartitionerForArray<TSource> : DynamicPartitionerForIndexRange_Abstract<TSource, TSource[]>
	{
		private class InternalPartitionEnumerable : IEnumerable<KeyValuePair<long, TSource>>, IEnumerable
		{
			private readonly TSource[] m_sharedReader;

			private SharedLong m_sharedIndex;

			internal InternalPartitionEnumerable(TSource[] sharedReader)
			{
				m_sharedReader = sharedReader;
				m_sharedIndex = new SharedLong(-1L);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return GetEnumerator();
			}

			public IEnumerator<KeyValuePair<long, TSource>> GetEnumerator()
			{
				return new InternalPartitionEnumerator(m_sharedReader, m_sharedIndex);
			}
		}

		private class InternalPartitionEnumerator : DynamicPartitionEnumeratorForIndexRange_Abstract<TSource, TSource[]>
		{
			protected override int SourceCount => m_sharedReader.Length;

			public override KeyValuePair<long, TSource> Current
			{
				get
				{
					if (m_currentChunkSize == null)
					{
						throw new InvalidOperationException(Environment.GetResourceString("PartitionerStatic_CurrentCalledBeforeMoveNext"));
					}
					return new KeyValuePair<long, TSource>(m_startIndex + m_localOffset.Value, m_sharedReader[m_startIndex + m_localOffset.Value]);
				}
			}

			internal InternalPartitionEnumerator(TSource[] sharedReader, SharedLong sharedIndex)
				: base(sharedReader, sharedIndex)
			{
			}
		}

		internal DynamicPartitionerForArray(TSource[] source)
			: base(source)
		{
		}

		protected override IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions_Factory(TSource[] m_data)
		{
			return new InternalPartitionEnumerable(m_data);
		}
	}

	private abstract class StaticIndexRangePartitioner<TSource, TCollection> : OrderablePartitioner<TSource>
	{
		protected abstract int SourceCount { get; }

		protected StaticIndexRangePartitioner()
			: base(keysOrderedInEachPartition: true, keysOrderedAcrossPartitions: true, keysNormalized: true)
		{
		}

		protected abstract IEnumerator<KeyValuePair<long, TSource>> CreatePartition(int startIndex, int endIndex);

		public override IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount)
		{
			if (partitionCount <= 0)
			{
				throw new ArgumentOutOfRangeException("partitionCount");
			}
			int result;
			int num = Math.DivRem(SourceCount, partitionCount, out result);
			IEnumerator<KeyValuePair<long, TSource>>[] array = new IEnumerator<KeyValuePair<long, TSource>>[partitionCount];
			int num2 = -1;
			for (int i = 0; i < partitionCount; i++)
			{
				int num3 = num2 + 1;
				num2 = ((i >= result) ? (num3 + num - 1) : (num3 + num));
				array[i] = CreatePartition(num3, num2);
			}
			return array;
		}
	}

	private abstract class StaticIndexRangePartition<TSource> : IEnumerator<KeyValuePair<long, TSource>>, IDisposable, IEnumerator
	{
		protected readonly int m_startIndex;

		protected readonly int m_endIndex;

		protected volatile int m_offset;

		public abstract KeyValuePair<long, TSource> Current { get; }

		object IEnumerator.Current => Current;

		protected StaticIndexRangePartition(int startIndex, int endIndex)
		{
			m_startIndex = startIndex;
			m_endIndex = endIndex;
			m_offset = startIndex - 1;
		}

		public void Dispose()
		{
		}

		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			if (m_offset < m_endIndex)
			{
				m_offset++;
				return true;
			}
			m_offset = m_endIndex + 1;
			return false;
		}
	}

	private class StaticIndexRangePartitionerForIList<TSource> : StaticIndexRangePartitioner<TSource, IList<TSource>>
	{
		private IList<TSource> m_list;

		protected override int SourceCount => m_list.Count;

		internal StaticIndexRangePartitionerForIList(IList<TSource> list)
		{
			m_list = list;
		}

		protected override IEnumerator<KeyValuePair<long, TSource>> CreatePartition(int startIndex, int endIndex)
		{
			return new StaticIndexRangePartitionForIList<TSource>(m_list, startIndex, endIndex);
		}
	}

	private class StaticIndexRangePartitionForIList<TSource> : StaticIndexRangePartition<TSource>
	{
		private volatile IList<TSource> m_list;

		public override KeyValuePair<long, TSource> Current
		{
			get
			{
				if (m_offset < m_startIndex)
				{
					throw new InvalidOperationException(Environment.GetResourceString("PartitionerStatic_CurrentCalledBeforeMoveNext"));
				}
				return new KeyValuePair<long, TSource>(m_offset, m_list[m_offset]);
			}
		}

		internal StaticIndexRangePartitionForIList(IList<TSource> list, int startIndex, int endIndex)
			: base(startIndex, endIndex)
		{
			m_list = list;
		}
	}

	private class StaticIndexRangePartitionerForArray<TSource> : StaticIndexRangePartitioner<TSource, TSource[]>
	{
		private TSource[] m_array;

		protected override int SourceCount => m_array.Length;

		internal StaticIndexRangePartitionerForArray(TSource[] array)
		{
			m_array = array;
		}

		protected override IEnumerator<KeyValuePair<long, TSource>> CreatePartition(int startIndex, int endIndex)
		{
			return new StaticIndexRangePartitionForArray<TSource>(m_array, startIndex, endIndex);
		}
	}

	private class StaticIndexRangePartitionForArray<TSource> : StaticIndexRangePartition<TSource>
	{
		private volatile TSource[] m_array;

		public override KeyValuePair<long, TSource> Current
		{
			get
			{
				if (m_offset < m_startIndex)
				{
					throw new InvalidOperationException(Environment.GetResourceString("PartitionerStatic_CurrentCalledBeforeMoveNext"));
				}
				return new KeyValuePair<long, TSource>(m_offset, m_array[m_offset]);
			}
		}

		internal StaticIndexRangePartitionForArray(TSource[] array, int startIndex, int endIndex)
			: base(startIndex, endIndex)
		{
			m_array = array;
		}
	}

	private class SharedInt
	{
		internal volatile int Value;

		internal SharedInt(int value)
		{
			Value = value;
		}
	}

	private class SharedBool
	{
		internal volatile bool Value;

		internal SharedBool(bool value)
		{
			Value = value;
		}
	}

	private class SharedLong
	{
		internal long Value;

		internal SharedLong(long value)
		{
			Value = value;
		}
	}

	private const int DEFAULT_BYTES_PER_CHUNK = 512;

	[__DynamicallyInvokable]
	public static OrderablePartitioner<TSource> Create<TSource>(IList<TSource> list, bool loadBalance)
	{
		if (list == null)
		{
			throw new ArgumentNullException("list");
		}
		if (loadBalance)
		{
			return new DynamicPartitionerForIList<TSource>(list);
		}
		return new StaticIndexRangePartitionerForIList<TSource>(list);
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<TSource> Create<TSource>(TSource[] array, bool loadBalance)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (loadBalance)
		{
			return new DynamicPartitionerForArray<TSource>(array);
		}
		return new StaticIndexRangePartitionerForArray<TSource>(array);
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<TSource> Create<TSource>(IEnumerable<TSource> source)
	{
		return Create(source, EnumerablePartitionerOptions.None);
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<TSource> Create<TSource>(IEnumerable<TSource> source, EnumerablePartitionerOptions partitionerOptions)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if ((partitionerOptions & ~EnumerablePartitionerOptions.NoBuffering) != EnumerablePartitionerOptions.None)
		{
			throw new ArgumentOutOfRangeException("partitionerOptions");
		}
		return new DynamicPartitionerForIEnumerable<TSource>(source, partitionerOptions);
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<Tuple<long, long>> Create(long fromInclusive, long toExclusive)
	{
		int num = 3;
		if (toExclusive <= fromInclusive)
		{
			throw new ArgumentOutOfRangeException("toExclusive");
		}
		long num2 = (toExclusive - fromInclusive) / (PlatformHelper.ProcessorCount * num);
		if (num2 == 0L)
		{
			num2 = 1L;
		}
		return Create(CreateRanges(fromInclusive, toExclusive, num2), EnumerablePartitionerOptions.NoBuffering);
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<Tuple<long, long>> Create(long fromInclusive, long toExclusive, long rangeSize)
	{
		if (toExclusive <= fromInclusive)
		{
			throw new ArgumentOutOfRangeException("toExclusive");
		}
		if (rangeSize <= 0)
		{
			throw new ArgumentOutOfRangeException("rangeSize");
		}
		return Create(CreateRanges(fromInclusive, toExclusive, rangeSize), EnumerablePartitionerOptions.NoBuffering);
	}

	private static IEnumerable<Tuple<long, long>> CreateRanges(long fromInclusive, long toExclusive, long rangeSize)
	{
		bool shouldQuit = false;
		for (long i = fromInclusive; i < toExclusive; i += rangeSize)
		{
			if (shouldQuit)
			{
				break;
			}
			long item = i;
			long num;
			try
			{
				num = checked(i + rangeSize);
			}
			catch (OverflowException)
			{
				num = toExclusive;
				shouldQuit = true;
			}
			if (num > toExclusive)
			{
				num = toExclusive;
			}
			yield return new Tuple<long, long>(item, num);
		}
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<Tuple<int, int>> Create(int fromInclusive, int toExclusive)
	{
		int num = 3;
		if (toExclusive <= fromInclusive)
		{
			throw new ArgumentOutOfRangeException("toExclusive");
		}
		int num2 = (toExclusive - fromInclusive) / (PlatformHelper.ProcessorCount * num);
		if (num2 == 0)
		{
			num2 = 1;
		}
		return Create(CreateRanges(fromInclusive, toExclusive, num2), EnumerablePartitionerOptions.NoBuffering);
	}

	[__DynamicallyInvokable]
	public static OrderablePartitioner<Tuple<int, int>> Create(int fromInclusive, int toExclusive, int rangeSize)
	{
		if (toExclusive <= fromInclusive)
		{
			throw new ArgumentOutOfRangeException("toExclusive");
		}
		if (rangeSize <= 0)
		{
			throw new ArgumentOutOfRangeException("rangeSize");
		}
		return Create(CreateRanges(fromInclusive, toExclusive, rangeSize), EnumerablePartitionerOptions.NoBuffering);
	}

	private static IEnumerable<Tuple<int, int>> CreateRanges(int fromInclusive, int toExclusive, int rangeSize)
	{
		bool shouldQuit = false;
		for (int i = fromInclusive; i < toExclusive; i += rangeSize)
		{
			if (shouldQuit)
			{
				break;
			}
			int item = i;
			int num;
			try
			{
				num = checked(i + rangeSize);
			}
			catch (OverflowException)
			{
				num = toExclusive;
				shouldQuit = true;
			}
			if (num > toExclusive)
			{
				num = toExclusive;
			}
			yield return new Tuple<int, int>(item, num);
		}
	}

	private static int GetDefaultChunkSize<TSource>()
	{
		if (typeof(TSource).IsValueType)
		{
			if (typeof(TSource).StructLayoutAttribute.Value == LayoutKind.Explicit)
			{
				return Math.Max(1, 512 / Marshal.SizeOf(typeof(TSource)));
			}
			return 128;
		}
		return 512 / IntPtr.Size;
	}
}
