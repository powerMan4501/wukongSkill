using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal class OrderPreservingPipeliningMergeHelper<TOutput, TKey> : IMergeHelper<TOutput>
{
	private class ProducerComparer : IComparer<Producer<TKey>>
	{
		private IComparer<TKey> _keyComparer;

		internal ProducerComparer(IComparer<TKey> keyComparer)
		{
			_keyComparer = keyComparer;
		}

		public int Compare(Producer<TKey> x, Producer<TKey> y)
		{
			return _keyComparer.Compare(y.MaxKey, x.MaxKey);
		}
	}

	private class OrderedPipeliningMergeEnumerator : MergeEnumerator<TOutput>
	{
		private OrderPreservingPipeliningMergeHelper<TOutput, TKey> m_mergeHelper;

		private readonly FixedMaxHeap<Producer<TKey>> m_producerHeap;

		private readonly TOutput[] m_producerNextElement;

		private readonly Queue<Pair<TKey, TOutput>>[] m_privateBuffer;

		private bool m_initialized;

		public override TOutput Current
		{
			get
			{
				int producerIndex = m_producerHeap.MaxValue.ProducerIndex;
				return m_producerNextElement[producerIndex];
			}
		}

		internal OrderedPipeliningMergeEnumerator(OrderPreservingPipeliningMergeHelper<TOutput, TKey> mergeHelper, IComparer<Producer<TKey>> producerComparer)
			: base(mergeHelper.m_taskGroupState)
		{
			int partitionCount = mergeHelper.m_partitions.PartitionCount;
			m_mergeHelper = mergeHelper;
			m_producerHeap = new FixedMaxHeap<Producer<TKey>>(partitionCount, producerComparer);
			m_privateBuffer = new Queue<Pair<TKey, TOutput>>[partitionCount];
			m_producerNextElement = new TOutput[partitionCount];
		}

		public override bool MoveNext()
		{
			if (!m_initialized)
			{
				m_initialized = true;
				for (int i = 0; i < m_mergeHelper.m_partitions.PartitionCount; i++)
				{
					Pair<TKey, TOutput> element = default(Pair<TKey, TOutput>);
					if (TryWaitForElement(i, ref element))
					{
						m_producerHeap.Insert(new Producer<TKey>(element.First, i));
						m_producerNextElement[i] = element.Second;
					}
					else
					{
						ThrowIfInTearDown();
					}
				}
			}
			else
			{
				if (m_producerHeap.Count == 0)
				{
					return false;
				}
				int producerIndex = m_producerHeap.MaxValue.ProducerIndex;
				Pair<TKey, TOutput> element2 = default(Pair<TKey, TOutput>);
				if (TryGetPrivateElement(producerIndex, ref element2) || TryWaitForElement(producerIndex, ref element2))
				{
					m_producerHeap.ReplaceMax(new Producer<TKey>(element2.First, producerIndex));
					m_producerNextElement[producerIndex] = element2.Second;
				}
				else
				{
					ThrowIfInTearDown();
					m_producerHeap.RemoveMax();
				}
			}
			return m_producerHeap.Count > 0;
		}

		private void ThrowIfInTearDown()
		{
			if (!m_mergeHelper.m_taskGroupState.CancellationState.MergedCancellationToken.IsCancellationRequested)
			{
				return;
			}
			try
			{
				object[] bufferLocks = m_mergeHelper.m_bufferLocks;
				for (int i = 0; i < bufferLocks.Length; i++)
				{
					lock (bufferLocks[i])
					{
						Monitor.Pulse(bufferLocks[i]);
					}
				}
				m_taskGroupState.QueryEnd(userInitiatedDispose: false);
			}
			finally
			{
				m_producerHeap.Clear();
			}
		}

		private bool TryWaitForElement(int producer, ref Pair<TKey, TOutput> element)
		{
			Queue<Pair<TKey, TOutput>> queue = m_mergeHelper.m_buffers[producer];
			object obj = m_mergeHelper.m_bufferLocks[producer];
			lock (obj)
			{
				if (queue.Count == 0)
				{
					if (m_mergeHelper.m_producerDone[producer])
					{
						element = default(Pair<TKey, TOutput>);
						return false;
					}
					m_mergeHelper.m_consumerWaiting[producer] = true;
					Monitor.Wait(obj);
					if (queue.Count == 0)
					{
						element = default(Pair<TKey, TOutput>);
						return false;
					}
				}
				if (m_mergeHelper.m_producerWaiting[producer])
				{
					Monitor.Pulse(obj);
					m_mergeHelper.m_producerWaiting[producer] = false;
				}
				if (queue.Count < 1024)
				{
					element = queue.Dequeue();
					return true;
				}
				m_privateBuffer[producer] = m_mergeHelper.m_buffers[producer];
				m_mergeHelper.m_buffers[producer] = new Queue<Pair<TKey, TOutput>>(128);
			}
			bool flag = TryGetPrivateElement(producer, ref element);
			return true;
		}

		private bool TryGetPrivateElement(int producer, ref Pair<TKey, TOutput> element)
		{
			Queue<Pair<TKey, TOutput>> queue = m_privateBuffer[producer];
			if (queue != null)
			{
				if (queue.Count > 0)
				{
					element = queue.Dequeue();
					return true;
				}
				m_privateBuffer[producer] = null;
			}
			return false;
		}

		public override void Dispose()
		{
			int num = m_mergeHelper.m_buffers.Length;
			for (int i = 0; i < num; i++)
			{
				object obj = m_mergeHelper.m_bufferLocks[i];
				lock (obj)
				{
					if (m_mergeHelper.m_producerWaiting[i])
					{
						Monitor.Pulse(obj);
					}
				}
			}
			base.Dispose();
		}
	}

	private readonly QueryTaskGroupState m_taskGroupState;

	private readonly PartitionedStream<TOutput, TKey> m_partitions;

	private readonly TaskScheduler m_taskScheduler;

	private readonly bool m_autoBuffered;

	private readonly Queue<Pair<TKey, TOutput>>[] m_buffers;

	private readonly bool[] m_producerDone;

	private readonly bool[] m_producerWaiting;

	private readonly bool[] m_consumerWaiting;

	private readonly object[] m_bufferLocks;

	private IComparer<Producer<TKey>> m_producerComparer;

	internal const int INITIAL_BUFFER_SIZE = 128;

	internal const int STEAL_BUFFER_SIZE = 1024;

	internal const int MAX_BUFFER_SIZE = 8192;

	internal OrderPreservingPipeliningMergeHelper(PartitionedStream<TOutput, TKey> partitions, TaskScheduler taskScheduler, CancellationState cancellationState, bool autoBuffered, int queryId, IComparer<TKey> keyComparer)
	{
		m_taskGroupState = new QueryTaskGroupState(cancellationState, queryId);
		m_partitions = partitions;
		m_taskScheduler = taskScheduler;
		m_autoBuffered = autoBuffered;
		int partitionCount = m_partitions.PartitionCount;
		m_buffers = new Queue<Pair<TKey, TOutput>>[partitionCount];
		m_producerDone = new bool[partitionCount];
		m_consumerWaiting = new bool[partitionCount];
		m_producerWaiting = new bool[partitionCount];
		m_bufferLocks = new object[partitionCount];
		if (keyComparer == Util.GetDefaultComparer<int>())
		{
			m_producerComparer = (IComparer<Producer<TKey>>)new ProducerComparerInt();
		}
		else
		{
			m_producerComparer = new ProducerComparer(keyComparer);
		}
	}

	void IMergeHelper<TOutput>.Execute()
	{
		OrderPreservingPipeliningSpoolingTask<TOutput, TKey>.Spool(m_taskGroupState, m_partitions, m_consumerWaiting, m_producerWaiting, m_producerDone, m_buffers, m_bufferLocks, m_taskScheduler, m_autoBuffered);
	}

	IEnumerator<TOutput> IMergeHelper<TOutput>.GetEnumerator()
	{
		return new OrderedPipeliningMergeEnumerator(this, m_producerComparer);
	}

	public TOutput[] GetResultsAsArray()
	{
		throw new InvalidOperationException();
	}
}
