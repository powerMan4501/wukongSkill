using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal class OrderPreservingPipeliningSpoolingTask<TOutput, TKey> : SpoolingTaskBase
{
	private readonly QueryTaskGroupState m_taskGroupState;

	private readonly TaskScheduler m_taskScheduler;

	private readonly QueryOperatorEnumerator<TOutput, TKey> m_partition;

	private readonly bool[] m_consumerWaiting;

	private readonly bool[] m_producerWaiting;

	private readonly bool[] m_producerDone;

	private readonly int m_partitionIndex;

	private readonly Queue<Pair<TKey, TOutput>>[] m_buffers;

	private readonly object m_bufferLock;

	private readonly bool m_autoBuffered;

	private const int PRODUCER_BUFFER_AUTO_SIZE = 16;

	internal OrderPreservingPipeliningSpoolingTask(QueryOperatorEnumerator<TOutput, TKey> partition, QueryTaskGroupState taskGroupState, bool[] consumerWaiting, bool[] producerWaiting, bool[] producerDone, int partitionIndex, Queue<Pair<TKey, TOutput>>[] buffers, object bufferLock, TaskScheduler taskScheduler, bool autoBuffered)
		: base(partitionIndex, taskGroupState)
	{
		m_partition = partition;
		m_taskGroupState = taskGroupState;
		m_producerDone = producerDone;
		m_consumerWaiting = consumerWaiting;
		m_producerWaiting = producerWaiting;
		m_partitionIndex = partitionIndex;
		m_buffers = buffers;
		m_bufferLock = bufferLock;
		m_taskScheduler = taskScheduler;
		m_autoBuffered = autoBuffered;
	}

	protected override void SpoolingWork()
	{
		TOutput currentElement = default(TOutput);
		TKey currentKey = default(TKey);
		int num = ((!m_autoBuffered) ? 1 : 16);
		Pair<TKey, TOutput>[] array = new Pair<TKey, TOutput>[num];
		QueryOperatorEnumerator<TOutput, TKey> partition = m_partition;
		CancellationToken mergedCancellationToken = m_taskGroupState.CancellationState.MergedCancellationToken;
		int i;
		do
		{
			for (i = 0; i < num; i++)
			{
				if (!partition.MoveNext(ref currentElement, ref currentKey))
				{
					break;
				}
				array[i] = new Pair<TKey, TOutput>(currentKey, currentElement);
			}
			if (i == 0)
			{
				break;
			}
			lock (m_bufferLock)
			{
				if (mergedCancellationToken.IsCancellationRequested)
				{
					break;
				}
				for (int j = 0; j < i; j++)
				{
					m_buffers[m_partitionIndex].Enqueue(array[j]);
				}
				if (m_consumerWaiting[m_partitionIndex])
				{
					Monitor.Pulse(m_bufferLock);
					m_consumerWaiting[m_partitionIndex] = false;
				}
				if (m_buffers[m_partitionIndex].Count >= 8192)
				{
					m_producerWaiting[m_partitionIndex] = true;
					Monitor.Wait(m_bufferLock);
				}
			}
		}
		while (i == num);
	}

	public static void Spool(QueryTaskGroupState groupState, PartitionedStream<TOutput, TKey> partitions, bool[] consumerWaiting, bool[] producerWaiting, bool[] producerDone, Queue<Pair<TKey, TOutput>>[] buffers, object[] bufferLocks, TaskScheduler taskScheduler, bool autoBuffered)
	{
		int degreeOfParallelism = partitions.PartitionCount;
		for (int i = 0; i < degreeOfParallelism; i++)
		{
			buffers[i] = new Queue<Pair<TKey, TOutput>>(128);
			bufferLocks[i] = new object();
		}
		Task task = new Task(delegate
		{
			for (int j = 0; j < degreeOfParallelism; j++)
			{
				QueryTask queryTask = new OrderPreservingPipeliningSpoolingTask<TOutput, TKey>(partitions[j], groupState, consumerWaiting, producerWaiting, producerDone, j, buffers, bufferLocks[j], taskScheduler, autoBuffered);
				queryTask.RunAsynchronously(taskScheduler);
			}
		});
		groupState.QueryBegin(task);
		task.Start(taskScheduler);
	}

	protected override void SpoolingFinally()
	{
		lock (m_bufferLock)
		{
			m_producerDone[m_partitionIndex] = true;
			if (m_consumerWaiting[m_partitionIndex])
			{
				Monitor.Pulse(m_bufferLock);
				m_consumerWaiting[m_partitionIndex] = false;
			}
		}
		base.SpoolingFinally();
		m_partition.Dispose();
	}
}
