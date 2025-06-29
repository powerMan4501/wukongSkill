using System.Collections;
using System.Threading;

namespace System.Net;

internal class ConnectionPool
{
	private enum State
	{
		Initializing,
		Running,
		ShuttingDown
	}

	private class AsyncConnectionPoolRequest
	{
		public object OwningObject;

		public GeneralAsyncDelegate AsyncCallback;

		public bool Completed;

		public ConnectionPool Pool;

		public int CreationTimeout;

		public AsyncConnectionPoolRequest(ConnectionPool pool, object owningObject, GeneralAsyncDelegate asyncCallback, int creationTimeout)
		{
			Pool = pool;
			OwningObject = owningObject;
			AsyncCallback = asyncCallback;
			CreationTimeout = creationTimeout;
		}
	}

	private static TimerThread.Callback s_CleanupCallback = CleanupCallbackWrapper;

	private static TimerThread.Callback s_CancelErrorCallback = CancelErrorCallbackWrapper;

	private static TimerThread.Queue s_CancelErrorQueue = TimerThread.GetOrCreateQueue(5000);

	private const int MaxQueueSize = 1048576;

	private const int SemaphoreHandleIndex = 0;

	private const int ErrorHandleIndex = 1;

	private const int CreationHandleIndex = 2;

	private const int WaitTimeout = 258;

	private const int WaitAbandoned = 128;

	private const int ErrorWait = 5000;

	private readonly TimerThread.Queue m_CleanupQueue;

	private State m_State;

	private InterlockedStack m_StackOld;

	private InterlockedStack m_StackNew;

	private int m_WaitCount;

	private WaitHandle[] m_WaitHandles;

	private Exception m_ResError;

	private volatile bool m_ErrorOccured;

	private TimerThread.Timer m_ErrorTimer;

	private ArrayList m_ObjectList;

	private int m_TotalObjects;

	private Queue m_QueuedRequests;

	private Thread m_AsyncThread;

	private int m_MaxPoolSize;

	private int m_MinPoolSize;

	private ServicePoint m_ServicePoint;

	private CreateConnectionDelegate m_CreateConnectionCallback;

	private Mutex CreationMutex => (Mutex)m_WaitHandles[2];

	private ManualResetEvent ErrorEvent => (ManualResetEvent)m_WaitHandles[1];

	private Semaphore Semaphore => (Semaphore)m_WaitHandles[0];

	internal int Count => m_TotalObjects;

	internal ServicePoint ServicePoint => m_ServicePoint;

	internal int MaxPoolSize => m_MaxPoolSize;

	internal int MinPoolSize => m_MinPoolSize;

	private bool ErrorOccurred => m_ErrorOccured;

	internal ConnectionPool(ServicePoint servicePoint, int maxPoolSize, int minPoolSize, int idleTimeout, CreateConnectionDelegate createConnectionCallback)
	{
		m_State = State.Initializing;
		m_CreateConnectionCallback = createConnectionCallback;
		m_MaxPoolSize = maxPoolSize;
		m_MinPoolSize = minPoolSize;
		m_ServicePoint = servicePoint;
		Initialize();
		if (idleTimeout > 0)
		{
			m_CleanupQueue = TimerThread.GetOrCreateQueue((idleTimeout == 1) ? 1 : (idleTimeout / 2));
			m_CleanupQueue.CreateTimer(s_CleanupCallback, this);
		}
	}

	private void Initialize()
	{
		m_StackOld = new InterlockedStack();
		m_StackNew = new InterlockedStack();
		m_QueuedRequests = new Queue();
		m_WaitHandles = new WaitHandle[3];
		m_WaitHandles[0] = new Semaphore(0, 1048576);
		m_WaitHandles[1] = new ManualResetEvent(initialState: false);
		m_WaitHandles[2] = new Mutex();
		m_ErrorTimer = null;
		m_ObjectList = new ArrayList();
		m_State = State.Running;
	}

	private void QueueRequest(AsyncConnectionPoolRequest asyncRequest)
	{
		lock (m_QueuedRequests)
		{
			m_QueuedRequests.Enqueue(asyncRequest);
			if (m_AsyncThread == null)
			{
				m_AsyncThread = new Thread(AsyncThread);
				m_AsyncThread.IsBackground = true;
				m_AsyncThread.Start();
			}
		}
	}

	private void AsyncThread()
	{
		while (true)
		{
			if (m_QueuedRequests.Count > 0)
			{
				bool continueLoop = true;
				AsyncConnectionPoolRequest asyncConnectionPoolRequest = null;
				lock (m_QueuedRequests)
				{
					asyncConnectionPoolRequest = (AsyncConnectionPoolRequest)m_QueuedRequests.Dequeue();
				}
				WaitHandle[] waitHandles = m_WaitHandles;
				PooledStream pooledStream = null;
				try
				{
					while (pooledStream == null && continueLoop)
					{
						int result = WaitHandle.WaitAny(waitHandles, asyncConnectionPoolRequest.CreationTimeout, exitContext: false);
						pooledStream = Get(asyncConnectionPoolRequest.OwningObject, result, ref continueLoop, ref waitHandles);
					}
					pooledStream.Activate(asyncConnectionPoolRequest.OwningObject, asyncConnectionPoolRequest.AsyncCallback);
				}
				catch (Exception state)
				{
					if (pooledStream != null)
					{
						PutConnection(pooledStream, asyncConnectionPoolRequest.OwningObject, asyncConnectionPoolRequest.CreationTimeout, canReuse: false);
					}
					asyncConnectionPoolRequest.AsyncCallback(asyncConnectionPoolRequest.OwningObject, state);
				}
				continue;
			}
			Thread.Sleep(500);
			lock (m_QueuedRequests)
			{
				if (m_QueuedRequests.Count == 0)
				{
					m_AsyncThread = null;
					break;
				}
			}
		}
	}

	private static void CleanupCallbackWrapper(TimerThread.Timer timer, int timeNoticed, object context)
	{
		ConnectionPool connectionPool = (ConnectionPool)context;
		try
		{
			connectionPool.CleanupCallback();
		}
		finally
		{
			connectionPool.m_CleanupQueue.CreateTimer(s_CleanupCallback, context);
		}
	}

	internal void ForceCleanup()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, "ConnectionPool::ForceCleanup");
		}
		while (Count > 0 && Semaphore.WaitOne(0, exitContext: false))
		{
			PooledStream pooledStream = (PooledStream)m_StackNew.Pop();
			if (pooledStream == null)
			{
				pooledStream = (PooledStream)m_StackOld.Pop();
			}
			Destroy(pooledStream);
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, "ConnectionPool::ForceCleanup");
		}
	}

	private void CleanupCallback()
	{
		while (Count > MinPoolSize && Semaphore.WaitOne(0, exitContext: false))
		{
			PooledStream pooledStream = (PooledStream)m_StackOld.Pop();
			if (pooledStream != null)
			{
				Destroy(pooledStream);
				continue;
			}
			Semaphore.ReleaseSemaphore();
			break;
		}
		if (!Semaphore.WaitOne(0, exitContext: false))
		{
			return;
		}
		while (true)
		{
			PooledStream pooledStream2 = (PooledStream)m_StackNew.Pop();
			if (pooledStream2 == null)
			{
				break;
			}
			m_StackOld.Push(pooledStream2);
		}
		Semaphore.ReleaseSemaphore();
	}

	private PooledStream Create(CreateConnectionDelegate createConnectionCallback)
	{
		PooledStream pooledStream = null;
		try
		{
			pooledStream = createConnectionCallback(this);
			if (pooledStream == null)
			{
				throw new InternalException();
			}
			if (!pooledStream.CanBePooled)
			{
				throw new InternalException();
			}
			pooledStream.PrePush(null);
			lock (m_ObjectList.SyncRoot)
			{
				m_ObjectList.Add(pooledStream);
				m_TotalObjects = m_ObjectList.Count;
			}
		}
		catch (Exception resError)
		{
			pooledStream = null;
			m_ResError = resError;
			Abort();
		}
		return pooledStream;
	}

	private void Destroy(PooledStream pooledStream)
	{
		if (pooledStream == null)
		{
			return;
		}
		try
		{
			lock (m_ObjectList.SyncRoot)
			{
				m_ObjectList.Remove(pooledStream);
				m_TotalObjects = m_ObjectList.Count;
			}
		}
		finally
		{
			pooledStream.Dispose();
		}
	}

	private static void CancelErrorCallbackWrapper(TimerThread.Timer timer, int timeNoticed, object context)
	{
		((ConnectionPool)context).CancelErrorCallback();
	}

	private void CancelErrorCallback()
	{
		TimerThread.Timer errorTimer = m_ErrorTimer;
		if (errorTimer != null && errorTimer.Cancel())
		{
			m_ErrorOccured = false;
			ErrorEvent.Reset();
			m_ErrorTimer = null;
			m_ResError = null;
		}
	}

	private PooledStream GetFromPool(object owningObject)
	{
		PooledStream pooledStream = null;
		pooledStream = (PooledStream)m_StackNew.Pop();
		if (pooledStream == null)
		{
			pooledStream = (PooledStream)m_StackOld.Pop();
		}
		pooledStream?.PostPop(owningObject);
		return pooledStream;
	}

	private PooledStream Get(object owningObject, int result, ref bool continueLoop, ref WaitHandle[] waitHandles)
	{
		PooledStream pooledStream = null;
		switch (result)
		{
		case 258:
			Interlocked.Decrement(ref m_WaitCount);
			continueLoop = false;
			throw new WebException(NetRes.GetWebStatusString("net_timeout", WebExceptionStatus.ConnectFailure), WebExceptionStatus.Timeout);
		case 1:
		{
			int num = Interlocked.Decrement(ref m_WaitCount);
			continueLoop = false;
			Exception resError = m_ResError;
			if (num == 0)
			{
				CancelErrorCallback();
			}
			throw resError;
		}
		case 2:
			try
			{
				continueLoop = true;
				pooledStream = UserCreateRequest();
				if (pooledStream != null)
				{
					pooledStream.PostPop(owningObject);
					Interlocked.Decrement(ref m_WaitCount);
					continueLoop = false;
				}
				else if (Count >= MaxPoolSize && MaxPoolSize != 0 && !ReclaimEmancipatedObjects())
				{
					waitHandles = new WaitHandle[2];
					waitHandles[0] = m_WaitHandles[0];
					waitHandles[1] = m_WaitHandles[1];
				}
			}
			finally
			{
				CreationMutex.ReleaseMutex();
			}
			break;
		default:
			Interlocked.Decrement(ref m_WaitCount);
			pooledStream = GetFromPool(owningObject);
			continueLoop = false;
			break;
		}
		return pooledStream;
	}

	internal void Abort()
	{
		if (m_ResError == null)
		{
			m_ResError = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}
		ErrorEvent.Set();
		m_ErrorOccured = true;
		m_ErrorTimer = s_CancelErrorQueue.CreateTimer(s_CancelErrorCallback, this);
	}

	internal PooledStream GetConnection(object owningObject, GeneralAsyncDelegate asyncCallback, int creationTimeout)
	{
		PooledStream pooledStream = null;
		bool continueLoop = true;
		bool flag = asyncCallback != null;
		if (m_State != State.Running)
		{
			throw new InternalException();
		}
		Interlocked.Increment(ref m_WaitCount);
		WaitHandle[] waitHandles = m_WaitHandles;
		if (flag)
		{
			int num = WaitHandle.WaitAny(waitHandles, 0, exitContext: false);
			if (num != 258)
			{
				pooledStream = Get(owningObject, num, ref continueLoop, ref waitHandles);
			}
			if (pooledStream == null)
			{
				AsyncConnectionPoolRequest asyncRequest = new AsyncConnectionPoolRequest(this, owningObject, asyncCallback, creationTimeout);
				QueueRequest(asyncRequest);
			}
		}
		else
		{
			while (pooledStream == null && continueLoop)
			{
				int num = WaitHandle.WaitAny(waitHandles, creationTimeout, exitContext: false);
				pooledStream = Get(owningObject, num, ref continueLoop, ref waitHandles);
			}
		}
		if (pooledStream != null)
		{
			if (!pooledStream.IsInitalizing)
			{
				asyncCallback = null;
			}
			try
			{
				if (!pooledStream.Activate(owningObject, asyncCallback))
				{
					pooledStream = null;
				}
			}
			catch
			{
				PutConnection(pooledStream, owningObject, creationTimeout, canReuse: false);
				throw;
			}
		}
		else if (!flag)
		{
			throw new InternalException();
		}
		return pooledStream;
	}

	internal void PutConnection(PooledStream pooledStream, object owningObject, int creationTimeout)
	{
		PutConnection(pooledStream, owningObject, creationTimeout, canReuse: true);
	}

	internal void PutConnection(PooledStream pooledStream, object owningObject, int creationTimeout, bool canReuse)
	{
		if (pooledStream == null)
		{
			throw new ArgumentNullException("pooledStream");
		}
		pooledStream.PrePush(owningObject);
		if (m_State != State.ShuttingDown)
		{
			pooledStream.Deactivate();
			if (m_WaitCount == 0)
			{
				CancelErrorCallback();
			}
			if (!canReuse || !pooledStream.CanBePooled)
			{
				try
				{
					Destroy(pooledStream);
					return;
				}
				finally
				{
					if (m_WaitCount > 0)
					{
						if (!CreationMutex.WaitOne(creationTimeout, exitContext: false))
						{
							Abort();
						}
						else
						{
							try
							{
								pooledStream = UserCreateRequest();
								if (pooledStream != null)
								{
									PutNew(pooledStream);
								}
							}
							finally
							{
								CreationMutex.ReleaseMutex();
							}
						}
					}
				}
			}
			PutNew(pooledStream);
		}
		else
		{
			Destroy(pooledStream);
		}
	}

	private void PutNew(PooledStream pooledStream)
	{
		m_StackNew.Push(pooledStream);
		Semaphore.ReleaseSemaphore();
	}

	private bool ReclaimEmancipatedObjects()
	{
		bool result = false;
		lock (m_ObjectList.SyncRoot)
		{
			object[] array = m_ObjectList.ToArray();
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					PooledStream pooledStream = (PooledStream)array[i];
					if (pooledStream == null)
					{
						continue;
					}
					bool lockTaken = false;
					try
					{
						Monitor.TryEnter(pooledStream, ref lockTaken);
						if (lockTaken && pooledStream.IsEmancipated)
						{
							PutConnection(pooledStream, null, -1);
							result = true;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(pooledStream);
						}
					}
				}
			}
		}
		return result;
	}

	private PooledStream UserCreateRequest()
	{
		PooledStream result = null;
		if (!ErrorOccurred && (Count < MaxPoolSize || MaxPoolSize == 0) && ((Count & 1) == 1 || !ReclaimEmancipatedObjects()))
		{
			result = Create(m_CreateConnectionCallback);
		}
		return result;
	}
}
