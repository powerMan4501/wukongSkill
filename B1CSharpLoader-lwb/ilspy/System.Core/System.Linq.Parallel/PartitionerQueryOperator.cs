using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class PartitionerQueryOperator<TElement> : QueryOperator<TElement>
{
	private class PartitionerQueryOperatorResults : QueryResults<TElement>
	{
		private Partitioner<TElement> m_partitioner;

		private QuerySettings m_settings;

		internal PartitionerQueryOperatorResults(Partitioner<TElement> partitioner, QuerySettings settings)
		{
			m_partitioner = partitioner;
			m_settings = settings;
		}

		internal override void GivePartitionedStream(IPartitionedStreamRecipient<TElement> recipient)
		{
			int value = m_settings.DegreeOfParallelism.Value;
			OrderablePartitioner<TElement> orderablePartitioner = m_partitioner as OrderablePartitioner<TElement>;
			OrdinalIndexState indexState = ((orderablePartitioner != null) ? PartitionerQueryOperator<TElement>.GetOrdinalIndexState((Partitioner<TElement>)orderablePartitioner) : OrdinalIndexState.Shuffled);
			PartitionedStream<TElement, int> partitionedStream = new PartitionedStream<TElement, int>(value, Util.GetDefaultComparer<int>(), indexState);
			if (orderablePartitioner != null)
			{
				IList<IEnumerator<KeyValuePair<long, TElement>>> orderablePartitions = orderablePartitioner.GetOrderablePartitions(value);
				if (orderablePartitions == null)
				{
					throw new InvalidOperationException(SR.GetString("PartitionerQueryOperator_NullPartitionList"));
				}
				if (orderablePartitions.Count != value)
				{
					throw new InvalidOperationException(SR.GetString("PartitionerQueryOperator_WrongNumberOfPartitions"));
				}
				for (int i = 0; i < value; i++)
				{
					IEnumerator<KeyValuePair<long, TElement>> enumerator = orderablePartitions[i];
					if (enumerator == null)
					{
						throw new InvalidOperationException(SR.GetString("PartitionerQueryOperator_NullPartition"));
					}
					partitionedStream[i] = new OrderablePartitionerEnumerator(enumerator);
				}
			}
			else
			{
				IList<IEnumerator<TElement>> partitions = m_partitioner.GetPartitions(value);
				if (partitions == null)
				{
					throw new InvalidOperationException(SR.GetString("PartitionerQueryOperator_NullPartitionList"));
				}
				if (partitions.Count != value)
				{
					throw new InvalidOperationException(SR.GetString("PartitionerQueryOperator_WrongNumberOfPartitions"));
				}
				for (int j = 0; j < value; j++)
				{
					IEnumerator<TElement> enumerator2 = partitions[j];
					if (enumerator2 == null)
					{
						throw new InvalidOperationException(SR.GetString("PartitionerQueryOperator_NullPartition"));
					}
					partitionedStream[j] = new PartitionerEnumerator(enumerator2);
				}
			}
			recipient.Receive(partitionedStream);
		}
	}

	private class OrderablePartitionerEnumerator : QueryOperatorEnumerator<TElement, int>
	{
		private IEnumerator<KeyValuePair<long, TElement>> m_sourceEnumerator;

		internal OrderablePartitionerEnumerator(IEnumerator<KeyValuePair<long, TElement>> sourceEnumerator)
		{
			m_sourceEnumerator = sourceEnumerator;
		}

		internal override bool MoveNext(ref TElement currentElement, ref int currentKey)
		{
			if (!m_sourceEnumerator.MoveNext())
			{
				return false;
			}
			KeyValuePair<long, TElement> current = m_sourceEnumerator.Current;
			currentElement = current.Value;
			currentKey = checked((int)current.Key);
			return true;
		}

		protected override void Dispose(bool disposing)
		{
			m_sourceEnumerator.Dispose();
		}
	}

	private class PartitionerEnumerator : QueryOperatorEnumerator<TElement, int>
	{
		private IEnumerator<TElement> m_sourceEnumerator;

		internal PartitionerEnumerator(IEnumerator<TElement> sourceEnumerator)
		{
			m_sourceEnumerator = sourceEnumerator;
		}

		internal override bool MoveNext(ref TElement currentElement, ref int currentKey)
		{
			if (!m_sourceEnumerator.MoveNext())
			{
				return false;
			}
			currentElement = m_sourceEnumerator.Current;
			currentKey = 0;
			return true;
		}

		protected override void Dispose(bool disposing)
		{
			m_sourceEnumerator.Dispose();
		}
	}

	private Partitioner<TElement> m_partitioner;

	internal bool Orderable => m_partitioner is OrderablePartitioner<TElement>;

	internal override OrdinalIndexState OrdinalIndexState => GetOrdinalIndexState(m_partitioner);

	internal override bool LimitsParallelism => false;

	internal PartitionerQueryOperator(Partitioner<TElement> partitioner)
		: base(isOrdered: false, QuerySettings.Empty)
	{
		m_partitioner = partitioner;
	}

	internal override QueryResults<TElement> Open(QuerySettings settings, bool preferStriping)
	{
		return new PartitionerQueryOperatorResults(m_partitioner, settings);
	}

	internal override IEnumerable<TElement> AsSequentialQuery(CancellationToken token)
	{
		using IEnumerator<TElement> enumerator = m_partitioner.GetPartitions(1)[0];
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}

	internal static OrdinalIndexState GetOrdinalIndexState(Partitioner<TElement> partitioner)
	{
		if (!(partitioner is OrderablePartitioner<TElement> orderablePartitioner))
		{
			return OrdinalIndexState.Shuffled;
		}
		if (orderablePartitioner.KeysOrderedInEachPartition)
		{
			if (orderablePartitioner.KeysNormalized)
			{
				return OrdinalIndexState.Correct;
			}
			return OrdinalIndexState.Increasing;
		}
		return OrdinalIndexState.Shuffled;
	}
}
