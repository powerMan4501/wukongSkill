using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

namespace System.Collections.Concurrent;

[ComVisible(false)]
[DebuggerTypeProxy(typeof(SystemThreadingCollections_BlockingCollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}, Type = {m_collection}")]
[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class BlockingCollection<T> : IEnumerable<T>, IEnumerable, ICollection, IDisposable, IReadOnlyCollection<T>
{
	private IProducerConsumerCollection<T> m_collection;

	private int m_boundedCapacity;

	private const int NON_BOUNDED = -1;

	private SemaphoreSlim m_freeNodes;

	private SemaphoreSlim m_occupiedNodes;

	private bool m_isDisposed;

	private CancellationTokenSource m_ConsumersCancellationTokenSource;

	private CancellationTokenSource m_ProducersCancellationTokenSource;

	private volatile int m_currentAdders;

	private const int COMPLETE_ADDING_ON_MASK = int.MinValue;

	[global::__DynamicallyInvokable]
	public int BoundedCapacity
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_boundedCapacity;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsAddingCompleted
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_currentAdders == int.MinValue;
		}
	}

	[global::__DynamicallyInvokable]
	public bool IsCompleted
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			if (IsAddingCompleted)
			{
				return m_occupiedNodes.CurrentCount == 0;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return m_occupiedNodes.CurrentCount;
		}
	}

	[global::__DynamicallyInvokable]
	bool ICollection.IsSynchronized
	{
		[global::__DynamicallyInvokable]
		get
		{
			CheckDisposed();
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	object ICollection.SyncRoot
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException(SR.GetString("ConcurrentCollection_SyncRoot_NotSupported"));
		}
	}

	private static bool IsSTAThread => Thread.CurrentThread.GetApartmentState() == ApartmentState.STA;

	[global::__DynamicallyInvokable]
	public BlockingCollection()
		: this((IProducerConsumerCollection<T>)new ConcurrentQueue<T>())
	{
	}

	[global::__DynamicallyInvokable]
	public BlockingCollection(int boundedCapacity)
		: this((IProducerConsumerCollection<T>)new ConcurrentQueue<T>(), boundedCapacity)
	{
	}

	[global::__DynamicallyInvokable]
	public BlockingCollection(IProducerConsumerCollection<T> collection, int boundedCapacity)
	{
		if (boundedCapacity < 1)
		{
			throw new ArgumentOutOfRangeException("boundedCapacity", boundedCapacity, SR.GetString("BlockingCollection_ctor_BoundedCapacityRange"));
		}
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		int count = collection.Count;
		if (count > boundedCapacity)
		{
			throw new ArgumentException(SR.GetString("BlockingCollection_ctor_CountMoreThanCapacity"));
		}
		Initialize(collection, boundedCapacity, count);
	}

	[global::__DynamicallyInvokable]
	public BlockingCollection(IProducerConsumerCollection<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		Initialize(collection, -1, collection.Count);
	}

	private void Initialize(IProducerConsumerCollection<T> collection, int boundedCapacity, int collectionCount)
	{
		m_collection = collection;
		m_boundedCapacity = boundedCapacity;
		m_isDisposed = false;
		m_ConsumersCancellationTokenSource = new CancellationTokenSource();
		m_ProducersCancellationTokenSource = new CancellationTokenSource();
		if (boundedCapacity == -1)
		{
			m_freeNodes = null;
		}
		else
		{
			m_freeNodes = new SemaphoreSlim(boundedCapacity - collectionCount);
		}
		m_occupiedNodes = new SemaphoreSlim(collectionCount);
	}

	[global::__DynamicallyInvokable]
	public void Add(T item)
	{
		TryAddWithNoTimeValidation(item, -1, default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public void Add(T item, CancellationToken cancellationToken)
	{
		TryAddWithNoTimeValidation(item, -1, cancellationToken);
	}

	[global::__DynamicallyInvokable]
	public bool TryAdd(T item)
	{
		return TryAddWithNoTimeValidation(item, 0, default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public bool TryAdd(T item, TimeSpan timeout)
	{
		ValidateTimeout(timeout);
		return TryAddWithNoTimeValidation(item, (int)timeout.TotalMilliseconds, default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public bool TryAdd(T item, int millisecondsTimeout)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryAddWithNoTimeValidation(item, millisecondsTimeout, default(CancellationToken));
	}

	[global::__DynamicallyInvokable]
	public bool TryAdd(T item, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryAddWithNoTimeValidation(item, millisecondsTimeout, cancellationToken);
	}

	private bool TryAddWithNoTimeValidation(T item, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		CheckDisposed();
		if (cancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), cancellationToken);
		}
		if (IsAddingCompleted)
		{
			throw new InvalidOperationException(SR.GetString("BlockingCollection_Completed"));
		}
		bool flag = true;
		if (m_freeNodes != null)
		{
			CancellationTokenSource cancellationTokenSource = null;
			try
			{
				flag = m_freeNodes.Wait(0);
				if (!flag && millisecondsTimeout != 0)
				{
					cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, m_ProducersCancellationTokenSource.Token);
					flag = m_freeNodes.Wait(millisecondsTimeout, cancellationTokenSource.Token);
				}
			}
			catch (OperationCanceledException)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), cancellationToken);
				}
				throw new InvalidOperationException(SR.GetString("BlockingCollection_Add_ConcurrentCompleteAdd"));
			}
			finally
			{
				cancellationTokenSource?.Dispose();
			}
		}
		if (flag)
		{
			SpinWait spinWait = default(SpinWait);
			while (true)
			{
				int currentAdders = m_currentAdders;
				if ((currentAdders & int.MinValue) != 0)
				{
					spinWait.Reset();
					while (m_currentAdders != int.MinValue)
					{
						spinWait.SpinOnce();
					}
					throw new InvalidOperationException(SR.GetString("BlockingCollection_Completed"));
				}
				if (Interlocked.CompareExchange(ref m_currentAdders, currentAdders + 1, currentAdders) == currentAdders)
				{
					break;
				}
				spinWait.SpinOnce();
			}
			try
			{
				bool flag2 = false;
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					flag2 = m_collection.TryAdd(item);
				}
				catch
				{
					if (m_freeNodes != null)
					{
						m_freeNodes.Release();
					}
					throw;
				}
				if (!flag2)
				{
					throw new InvalidOperationException(SR.GetString("BlockingCollection_Add_Failed"));
				}
				m_occupiedNodes.Release();
			}
			finally
			{
				Interlocked.Decrement(ref m_currentAdders);
			}
		}
		return flag;
	}

	[global::__DynamicallyInvokable]
	public T Take()
	{
		if (!TryTake(out var item, -1, CancellationToken.None))
		{
			throw new InvalidOperationException(SR.GetString("BlockingCollection_CantTakeWhenDone"));
		}
		return item;
	}

	[global::__DynamicallyInvokable]
	public T Take(CancellationToken cancellationToken)
	{
		if (!TryTake(out var item, -1, cancellationToken))
		{
			throw new InvalidOperationException(SR.GetString("BlockingCollection_CantTakeWhenDone"));
		}
		return item;
	}

	[global::__DynamicallyInvokable]
	public bool TryTake(out T item)
	{
		return TryTake(out item, 0, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public bool TryTake(out T item, TimeSpan timeout)
	{
		ValidateTimeout(timeout);
		return TryTakeWithNoTimeValidation(out item, (int)timeout.TotalMilliseconds, CancellationToken.None, null);
	}

	[global::__DynamicallyInvokable]
	public bool TryTake(out T item, int millisecondsTimeout)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryTakeWithNoTimeValidation(out item, millisecondsTimeout, CancellationToken.None, null);
	}

	[global::__DynamicallyInvokable]
	public bool TryTake(out T item, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryTakeWithNoTimeValidation(out item, millisecondsTimeout, cancellationToken, null);
	}

	private bool TryTakeWithNoTimeValidation(out T item, int millisecondsTimeout, CancellationToken cancellationToken, CancellationTokenSource combinedTokenSource)
	{
		CheckDisposed();
		item = default(T);
		if (cancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), cancellationToken);
		}
		if (IsCompleted)
		{
			return false;
		}
		bool flag = false;
		CancellationTokenSource cancellationTokenSource = combinedTokenSource;
		try
		{
			flag = m_occupiedNodes.Wait(0);
			if (!flag && millisecondsTimeout != 0)
			{
				if (combinedTokenSource == null)
				{
					cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, m_ConsumersCancellationTokenSource.Token);
				}
				flag = m_occupiedNodes.Wait(millisecondsTimeout, cancellationTokenSource.Token);
			}
		}
		catch (OperationCanceledException)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), cancellationToken);
			}
			return false;
		}
		finally
		{
			if (cancellationTokenSource != null && combinedTokenSource == null)
			{
				cancellationTokenSource.Dispose();
			}
		}
		if (flag)
		{
			bool flag2 = false;
			bool flag3 = true;
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				flag2 = m_collection.TryTake(out item);
				flag3 = false;
				if (!flag2)
				{
					throw new InvalidOperationException(SR.GetString("BlockingCollection_Take_CollectionModified"));
				}
			}
			finally
			{
				if (flag2)
				{
					if (m_freeNodes != null)
					{
						m_freeNodes.Release();
					}
				}
				else if (flag3)
				{
					m_occupiedNodes.Release();
				}
				if (IsCompleted)
				{
					CancelWaitingConsumers();
				}
			}
		}
		return flag;
	}

	[global::__DynamicallyInvokable]
	public static int AddToAny(BlockingCollection<T>[] collections, T item)
	{
		return TryAddToAny(collections, item, -1, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int AddToAny(BlockingCollection<T>[] collections, T item, CancellationToken cancellationToken)
	{
		return TryAddToAny(collections, item, -1, cancellationToken);
	}

	[global::__DynamicallyInvokable]
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item)
	{
		return TryAddToAny(collections, item, 0, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item, TimeSpan timeout)
	{
		ValidateTimeout(timeout);
		return TryAddToAnyCore(collections, item, (int)timeout.TotalMilliseconds, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryAddToAnyCore(collections, item, millisecondsTimeout, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int TryAddToAny(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryAddToAnyCore(collections, item, millisecondsTimeout, cancellationToken);
	}

	private static int TryAddToAnyCore(BlockingCollection<T>[] collections, T item, int millisecondsTimeout, CancellationToken externalCancellationToken)
	{
		ValidateCollectionsArray(collections, isAddOperation: true);
		int num = millisecondsTimeout;
		uint startTime = 0u;
		if (millisecondsTimeout != -1)
		{
			startTime = (uint)Environment.TickCount;
		}
		int num2 = TryAddToAnyFast(collections, item);
		if (num2 > -1)
		{
			return num2;
		}
		CancellationToken[] cancellationTokens;
		List<WaitHandle> handles = GetHandles(collections, externalCancellationToken, isAddOperation: true, out cancellationTokens);
		while (millisecondsTimeout == -1 || num >= 0)
		{
			num2 = -1;
			using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationTokens))
			{
				handles.Add(cancellationTokenSource.Token.WaitHandle);
				num2 = WaitHandle.WaitAny(handles.ToArray(), num, exitContext: false);
				handles.RemoveAt(handles.Count - 1);
				if (cancellationTokenSource.IsCancellationRequested)
				{
					if (externalCancellationToken.IsCancellationRequested)
					{
						throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), externalCancellationToken);
					}
					throw new ArgumentException(SR.GetString("BlockingCollection_CantAddAnyWhenCompleted"), "collections");
				}
			}
			if (num2 == 258)
			{
				return -1;
			}
			if (collections[num2].TryAdd(item))
			{
				return num2;
			}
			if (millisecondsTimeout != -1)
			{
				num = UpdateTimeOut(startTime, millisecondsTimeout);
			}
		}
		return -1;
	}

	private static int TryAddToAnyFast(BlockingCollection<T>[] collections, T item)
	{
		for (int i = 0; i < collections.Length; i++)
		{
			if (collections[i].m_freeNodes == null)
			{
				collections[i].TryAdd(item);
				return i;
			}
		}
		return -1;
	}

	private static List<WaitHandle> GetHandles(BlockingCollection<T>[] collections, CancellationToken externalCancellationToken, bool isAddOperation, out CancellationToken[] cancellationTokens)
	{
		List<WaitHandle> list = new List<WaitHandle>(collections.Length + 1);
		List<CancellationToken> list2 = new List<CancellationToken>(collections.Length + 1);
		list2.Add(externalCancellationToken);
		if (isAddOperation)
		{
			for (int i = 0; i < collections.Length; i++)
			{
				if (collections[i].m_freeNodes != null)
				{
					list.Add(collections[i].m_freeNodes.AvailableWaitHandle);
					list2.Add(collections[i].m_ProducersCancellationTokenSource.Token);
				}
			}
		}
		else
		{
			for (int j = 0; j < collections.Length; j++)
			{
				if (!collections[j].IsCompleted)
				{
					list.Add(collections[j].m_occupiedNodes.AvailableWaitHandle);
					list2.Add(collections[j].m_ConsumersCancellationTokenSource.Token);
				}
			}
		}
		cancellationTokens = list2.ToArray();
		return list;
	}

	private static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
	{
		if (originalWaitMillisecondsTimeout == 0)
		{
			return 0;
		}
		uint num = (uint)Environment.TickCount - startTime;
		if (num > int.MaxValue)
		{
			return 0;
		}
		int num2 = originalWaitMillisecondsTimeout - (int)num;
		if (num2 <= 0)
		{
			return 0;
		}
		return num2;
	}

	[global::__DynamicallyInvokable]
	public static int TakeFromAny(BlockingCollection<T>[] collections, out T item)
	{
		return TakeFromAny(collections, out item, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int TakeFromAny(BlockingCollection<T>[] collections, out T item, CancellationToken cancellationToken)
	{
		return TryTakeFromAnyCore(collections, out item, -1, isTakeOperation: true, cancellationToken);
	}

	[global::__DynamicallyInvokable]
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item)
	{
		return TryTakeFromAny(collections, out item, 0);
	}

	[global::__DynamicallyInvokable]
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, TimeSpan timeout)
	{
		ValidateTimeout(timeout);
		return TryTakeFromAnyCore(collections, out item, (int)timeout.TotalMilliseconds, isTakeOperation: false, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryTakeFromAnyCore(collections, out item, millisecondsTimeout, isTakeOperation: false, CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public static int TryTakeFromAny(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ValidateMillisecondsTimeout(millisecondsTimeout);
		return TryTakeFromAnyCore(collections, out item, millisecondsTimeout, isTakeOperation: false, cancellationToken);
	}

	private static int TryTakeFromAnyCore(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, bool isTakeOperation, CancellationToken externalCancellationToken)
	{
		ValidateCollectionsArray(collections, isAddOperation: false);
		for (int i = 0; i < collections.Length; i++)
		{
			if (!collections[i].IsCompleted && collections[i].m_occupiedNodes.CurrentCount > 0 && collections[i].TryTake(out item))
			{
				return i;
			}
		}
		return TryTakeFromAnyCoreSlow(collections, out item, millisecondsTimeout, isTakeOperation, externalCancellationToken);
	}

	private static int TryTakeFromAnyCoreSlow(BlockingCollection<T>[] collections, out T item, int millisecondsTimeout, bool isTakeOperation, CancellationToken externalCancellationToken)
	{
		int num = millisecondsTimeout;
		uint startTime = 0u;
		if (millisecondsTimeout != -1)
		{
			startTime = (uint)Environment.TickCount;
		}
		while (millisecondsTimeout == -1 || num >= 0)
		{
			CancellationToken[] cancellationTokens;
			List<WaitHandle> handles = GetHandles(collections, externalCancellationToken, isAddOperation: false, out cancellationTokens);
			if (handles.Count == 0 && isTakeOperation)
			{
				throw new ArgumentException(SR.GetString("BlockingCollection_CantTakeAnyWhenAllDone"), "collections");
			}
			if (handles.Count == 0)
			{
				break;
			}
			using (CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationTokens))
			{
				handles.Add(cancellationTokenSource.Token.WaitHandle);
				int num2 = WaitHandle.WaitAny(handles.ToArray(), num, exitContext: false);
				if (cancellationTokenSource.IsCancellationRequested && externalCancellationToken.IsCancellationRequested)
				{
					throw new OperationCanceledException(SR.GetString("Common_OperationCanceled"), externalCancellationToken);
				}
				if (!cancellationTokenSource.IsCancellationRequested)
				{
					if (num2 == 258)
					{
						break;
					}
					if (collections.Length != handles.Count - 1)
					{
						for (int i = 0; i < collections.Length; i++)
						{
							if (collections[i].m_occupiedNodes.AvailableWaitHandle == handles[num2])
							{
								num2 = i;
								break;
							}
						}
					}
					if (collections[num2].TryTake(out item))
					{
						return num2;
					}
				}
			}
			if (millisecondsTimeout != -1)
			{
				num = UpdateTimeOut(startTime, millisecondsTimeout);
			}
		}
		item = default(T);
		return -1;
	}

	[global::__DynamicallyInvokable]
	public void CompleteAdding()
	{
		CheckDisposed();
		if (IsAddingCompleted)
		{
			return;
		}
		SpinWait spinWait = default(SpinWait);
		while (true)
		{
			int currentAdders = m_currentAdders;
			if ((currentAdders & int.MinValue) != 0)
			{
				spinWait.Reset();
				while (m_currentAdders != int.MinValue)
				{
					spinWait.SpinOnce();
				}
				return;
			}
			if (Interlocked.CompareExchange(ref m_currentAdders, currentAdders | int.MinValue, currentAdders) == currentAdders)
			{
				break;
			}
			spinWait.SpinOnce();
		}
		spinWait.Reset();
		while (m_currentAdders != int.MinValue)
		{
			spinWait.SpinOnce();
		}
		if (Count == 0)
		{
			CancelWaitingConsumers();
		}
		CancelWaitingProducers();
	}

	private void CancelWaitingConsumers()
	{
		m_ConsumersCancellationTokenSource.Cancel();
	}

	private void CancelWaitingProducers()
	{
		m_ProducersCancellationTokenSource.Cancel();
	}

	[global::__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[global::__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		if (!m_isDisposed)
		{
			if (m_freeNodes != null)
			{
				m_freeNodes.Dispose();
			}
			m_occupiedNodes.Dispose();
			m_isDisposed = true;
		}
	}

	[global::__DynamicallyInvokable]
	public T[] ToArray()
	{
		CheckDisposed();
		return m_collection.ToArray();
	}

	[global::__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		((ICollection)this).CopyTo((Array)array, index);
	}

	[global::__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		CheckDisposed();
		T[] array2 = m_collection.ToArray();
		try
		{
			Array.Copy(array2, 0, array, index, array2.Length);
		}
		catch (ArgumentNullException)
		{
			throw new ArgumentNullException("array");
		}
		catch (ArgumentOutOfRangeException)
		{
			throw new ArgumentOutOfRangeException("index", index, SR.GetString("BlockingCollection_CopyTo_NonNegative"));
		}
		catch (ArgumentException)
		{
			throw new ArgumentException(SR.GetString("BlockingCollection_CopyTo_TooManyElems"), "index");
		}
		catch (RankException)
		{
			throw new ArgumentException(SR.GetString("BlockingCollection_CopyTo_MultiDim"), "array");
		}
		catch (InvalidCastException)
		{
			throw new ArgumentException(SR.GetString("BlockingCollection_CopyTo_IncorrectType"), "array");
		}
		catch (ArrayTypeMismatchException)
		{
			throw new ArgumentException(SR.GetString("BlockingCollection_CopyTo_IncorrectType"), "array");
		}
	}

	[global::__DynamicallyInvokable]
	public IEnumerable<T> GetConsumingEnumerable()
	{
		return GetConsumingEnumerable(CancellationToken.None);
	}

	[global::__DynamicallyInvokable]
	public IEnumerable<T> GetConsumingEnumerable(CancellationToken cancellationToken)
	{
		CancellationTokenSource linkedTokenSource = null;
		try
		{
			linkedTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, m_ConsumersCancellationTokenSource.Token);
			while (!IsCompleted)
			{
				if (TryTakeWithNoTimeValidation(out var item, -1, cancellationToken, linkedTokenSource))
				{
					yield return item;
				}
			}
		}
		finally
		{
			linkedTokenSource?.Dispose();
		}
	}

	[global::__DynamicallyInvokable]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		CheckDisposed();
		return m_collection.GetEnumerator();
	}

	[global::__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<T>)this).GetEnumerator();
	}

	private static void ValidateCollectionsArray(BlockingCollection<T>[] collections, bool isAddOperation)
	{
		if (collections == null)
		{
			throw new ArgumentNullException("collections");
		}
		if (collections.Length < 1)
		{
			throw new ArgumentException(SR.GetString("BlockingCollection_ValidateCollectionsArray_ZeroSize"), "collections");
		}
		if ((!IsSTAThread && collections.Length > 63) || (IsSTAThread && collections.Length > 62))
		{
			throw new ArgumentOutOfRangeException("collections", SR.GetString("BlockingCollection_ValidateCollectionsArray_LargeSize"));
		}
		for (int i = 0; i < collections.Length; i++)
		{
			if (collections[i] == null)
			{
				throw new ArgumentException(SR.GetString("BlockingCollection_ValidateCollectionsArray_NullElems"), "collections");
			}
			if (collections[i].m_isDisposed)
			{
				throw new ObjectDisposedException("collections", SR.GetString("BlockingCollection_ValidateCollectionsArray_DispElems"));
			}
			if (isAddOperation && collections[i].IsAddingCompleted)
			{
				throw new ArgumentException(SR.GetString("BlockingCollection_CantAddAnyWhenCompleted"), "collections");
			}
		}
	}

	private static void ValidateTimeout(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if ((num < 0 || num > int.MaxValue) && num != -1)
		{
			throw new ArgumentOutOfRangeException("timeout", timeout, string.Format(CultureInfo.InvariantCulture, SR.GetString("BlockingCollection_TimeoutInvalid"), new object[1] { int.MaxValue }));
		}
	}

	private static void ValidateMillisecondsTimeout(int millisecondsTimeout)
	{
		if (millisecondsTimeout < 0 && millisecondsTimeout != -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", millisecondsTimeout, string.Format(CultureInfo.InvariantCulture, SR.GetString("BlockingCollection_TimeoutInvalid"), new object[1] { int.MaxValue }));
		}
	}

	private void CheckDisposed()
	{
		if (m_isDisposed)
		{
			throw new ObjectDisposedException("BlockingCollection", SR.GetString("BlockingCollection_Disposed"));
		}
	}
}
