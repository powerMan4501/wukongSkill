using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Collections.Concurrent;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public abstract class OrderablePartitioner<TSource> : Partitioner<TSource>
{
	private class EnumerableDropIndices : IEnumerable<TSource>, IEnumerable, IDisposable
	{
		private readonly IEnumerable<KeyValuePair<long, TSource>> m_source;

		public EnumerableDropIndices(IEnumerable<KeyValuePair<long, TSource>> source)
		{
			m_source = source;
		}

		public IEnumerator<TSource> GetEnumerator()
		{
			return new EnumeratorDropIndices(m_source.GetEnumerator());
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Dispose()
		{
			if (m_source is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	private class EnumeratorDropIndices : IEnumerator<TSource>, IDisposable, IEnumerator
	{
		private readonly IEnumerator<KeyValuePair<long, TSource>> m_source;

		public TSource Current => m_source.Current.Value;

		object IEnumerator.Current => Current;

		public EnumeratorDropIndices(IEnumerator<KeyValuePair<long, TSource>> source)
		{
			m_source = source;
		}

		public bool MoveNext()
		{
			return m_source.MoveNext();
		}

		public void Dispose()
		{
			m_source.Dispose();
		}

		public void Reset()
		{
			m_source.Reset();
		}
	}

	[__DynamicallyInvokable]
	public bool KeysOrderedInEachPartition
	{
		[__DynamicallyInvokable]
		get;
		private set; }

	[__DynamicallyInvokable]
	public bool KeysOrderedAcrossPartitions
	{
		[__DynamicallyInvokable]
		get;
		private set; }

	[__DynamicallyInvokable]
	public bool KeysNormalized
	{
		[__DynamicallyInvokable]
		get;
		private set; }

	[__DynamicallyInvokable]
	protected OrderablePartitioner(bool keysOrderedInEachPartition, bool keysOrderedAcrossPartitions, bool keysNormalized)
	{
		KeysOrderedInEachPartition = keysOrderedInEachPartition;
		KeysOrderedAcrossPartitions = keysOrderedAcrossPartitions;
		KeysNormalized = keysNormalized;
	}

	[__DynamicallyInvokable]
	public abstract IList<IEnumerator<KeyValuePair<long, TSource>>> GetOrderablePartitions(int partitionCount);

	[__DynamicallyInvokable]
	public virtual IEnumerable<KeyValuePair<long, TSource>> GetOrderableDynamicPartitions()
	{
		throw new NotSupportedException(Environment.GetResourceString("Partitioner_DynamicPartitionsNotSupported"));
	}

	[__DynamicallyInvokable]
	public override IList<IEnumerator<TSource>> GetPartitions(int partitionCount)
	{
		IList<IEnumerator<KeyValuePair<long, TSource>>> orderablePartitions = GetOrderablePartitions(partitionCount);
		if (orderablePartitions.Count != partitionCount)
		{
			throw new InvalidOperationException("OrderablePartitioner_GetPartitions_WrongNumberOfPartitions");
		}
		IEnumerator<TSource>[] array = new IEnumerator<TSource>[partitionCount];
		for (int i = 0; i < partitionCount; i++)
		{
			array[i] = new EnumeratorDropIndices(orderablePartitions[i]);
		}
		return array;
	}

	[__DynamicallyInvokable]
	public override IEnumerable<TSource> GetDynamicPartitions()
	{
		IEnumerable<KeyValuePair<long, TSource>> orderableDynamicPartitions = GetOrderableDynamicPartitions();
		return new EnumerableDropIndices(orderableDynamicPartitions);
	}
}
