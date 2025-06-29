using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Remoting.Contexts;

[Serializable]
[SecurityCritical]
[AttributeUsage(AttributeTargets.Class)]
[ComVisible(true)]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = SecurityPermissionFlag.Infrastructure)]
public class SynchronizationAttribute : ContextAttribute, IContributeServerContextSink, IContributeClientContextSink
{
	public const int NOT_SUPPORTED = 1;

	public const int SUPPORTED = 2;

	public const int REQUIRED = 4;

	public const int REQUIRES_NEW = 8;

	private const string PROPERTY_NAME = "Synchronization";

	private static readonly int _timeOut = -1;

	[NonSerialized]
	internal AutoResetEvent _asyncWorkEvent;

	[NonSerialized]
	private RegisteredWaitHandle _waitHandle;

	[NonSerialized]
	internal Queue _workItemQueue;

	[NonSerialized]
	internal bool _locked;

	internal bool _bReEntrant;

	internal int _flavor;

	[NonSerialized]
	private SynchronizationAttribute _cliCtxAttr;

	[NonSerialized]
	private string _syncLcid;

	[NonSerialized]
	private ArrayList _asyncLcidList;

	public virtual bool Locked
	{
		get
		{
			return _locked;
		}
		set
		{
			_locked = value;
		}
	}

	public virtual bool IsReEntrant => _bReEntrant;

	internal string SyncCallOutLCID
	{
		get
		{
			return _syncLcid;
		}
		set
		{
			_syncLcid = value;
		}
	}

	internal ArrayList AsyncCallOutLCIDList => _asyncLcidList;

	internal bool IsKnownLCID(IMessage reqMsg)
	{
		string logicalCallID = ((LogicalCallContext)reqMsg.Properties[Message.CallContextKey]).RemotingData.LogicalCallID;
		if (!logicalCallID.Equals(_syncLcid))
		{
			return _asyncLcidList.Contains(logicalCallID);
		}
		return true;
	}

	public SynchronizationAttribute()
		: this(4, reEntrant: false)
	{
	}

	public SynchronizationAttribute(bool reEntrant)
		: this(4, reEntrant)
	{
	}

	public SynchronizationAttribute(int flag)
		: this(flag, reEntrant: false)
	{
	}

	public SynchronizationAttribute(int flag, bool reEntrant)
		: base("Synchronization")
	{
		_bReEntrant = reEntrant;
		if ((uint)(flag - 1) <= 1u || flag == 4 || flag == 8)
		{
			_flavor = flag;
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "flag");
	}

	internal void Dispose()
	{
		if (_waitHandle != null)
		{
			_waitHandle.Unregister(null);
		}
	}

	[SecurityCritical]
	[ComVisible(true)]
	public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (msg == null)
		{
			throw new ArgumentNullException("msg");
		}
		bool result = true;
		if (_flavor == 8)
		{
			result = false;
		}
		else
		{
			SynchronizationAttribute synchronizationAttribute = (SynchronizationAttribute)ctx.GetProperty("Synchronization");
			if ((_flavor == 1 && synchronizationAttribute != null) || (_flavor == 4 && synchronizationAttribute == null))
			{
				result = false;
			}
			if (_flavor == 4)
			{
				_cliCtxAttr = synchronizationAttribute;
			}
		}
		return result;
	}

	[SecurityCritical]
	[ComVisible(true)]
	public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
	{
		if (_flavor != 1 && _flavor != 2 && ctorMsg != null)
		{
			if (_cliCtxAttr != null)
			{
				ctorMsg.ContextProperties.Add(_cliCtxAttr);
				_cliCtxAttr = null;
			}
			else
			{
				ctorMsg.ContextProperties.Add(this);
			}
		}
	}

	internal virtual void InitIfNecessary()
	{
		lock (this)
		{
			if (_asyncWorkEvent == null)
			{
				_asyncWorkEvent = new AutoResetEvent(initialState: false);
				_workItemQueue = new Queue();
				_asyncLcidList = new ArrayList();
				WaitOrTimerCallback callBack = DispatcherCallBack;
				_waitHandle = ThreadPool.RegisterWaitForSingleObject(_asyncWorkEvent, callBack, null, _timeOut, executeOnlyOnce: false);
			}
		}
	}

	private void DispatcherCallBack(object stateIgnored, bool ignored)
	{
		WorkItem work;
		lock (_workItemQueue)
		{
			work = (WorkItem)_workItemQueue.Dequeue();
		}
		ExecuteWorkItem(work);
		HandleWorkCompletion();
	}

	internal virtual void HandleThreadExit()
	{
		HandleWorkCompletion();
	}

	internal virtual void HandleThreadReEntry()
	{
		WorkItem workItem = new WorkItem(null, null, null);
		workItem.SetDummy();
		HandleWorkRequest(workItem);
	}

	internal virtual void HandleWorkCompletion()
	{
		WorkItem workItem = null;
		bool flag = false;
		lock (_workItemQueue)
		{
			if (_workItemQueue.Count >= 1)
			{
				workItem = (WorkItem)_workItemQueue.Peek();
				flag = true;
				workItem.SetSignaled();
			}
			else
			{
				_locked = false;
			}
		}
		if (!flag)
		{
			return;
		}
		if (workItem.IsAsync())
		{
			_asyncWorkEvent.Set();
			return;
		}
		lock (workItem)
		{
			Monitor.Pulse(workItem);
		}
	}

	internal virtual void HandleWorkRequest(WorkItem work)
	{
		if (!IsNestedCall(work._reqMsg))
		{
			if (work.IsAsync())
			{
				bool flag = true;
				lock (_workItemQueue)
				{
					work.SetWaiting();
					_workItemQueue.Enqueue(work);
					if (!_locked && _workItemQueue.Count == 1)
					{
						work.SetSignaled();
						_locked = true;
						_asyncWorkEvent.Set();
					}
					return;
				}
			}
			lock (work)
			{
				bool flag;
				lock (_workItemQueue)
				{
					if (!_locked && _workItemQueue.Count == 0)
					{
						_locked = true;
						flag = false;
					}
					else
					{
						flag = true;
						work.SetWaiting();
						_workItemQueue.Enqueue(work);
					}
				}
				if (flag)
				{
					Monitor.Wait(work);
					if (work.IsDummy())
					{
						lock (_workItemQueue)
						{
							_workItemQueue.Dequeue();
							return;
						}
					}
					DispatcherCallBack(null, ignored: true);
				}
				else if (!work.IsDummy())
				{
					work.SetSignaled();
					ExecuteWorkItem(work);
					HandleWorkCompletion();
				}
				return;
			}
		}
		work.SetSignaled();
		work.Execute();
	}

	internal void ExecuteWorkItem(WorkItem work)
	{
		work.Execute();
	}

	internal bool IsNestedCall(IMessage reqMsg)
	{
		bool flag = false;
		if (!IsReEntrant)
		{
			string syncCallOutLCID = SyncCallOutLCID;
			if (syncCallOutLCID != null)
			{
				LogicalCallContext logicalCallContext = (LogicalCallContext)reqMsg.Properties[Message.CallContextKey];
				if (logicalCallContext != null && syncCallOutLCID.Equals(logicalCallContext.RemotingData.LogicalCallID))
				{
					flag = true;
				}
			}
			if (!flag && AsyncCallOutLCIDList.Count > 0)
			{
				LogicalCallContext logicalCallContext2 = (LogicalCallContext)reqMsg.Properties[Message.CallContextKey];
				if (AsyncCallOutLCIDList.Contains(logicalCallContext2.RemotingData.LogicalCallID))
				{
					flag = true;
				}
			}
		}
		return flag;
	}

	[SecurityCritical]
	public virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
	{
		InitIfNecessary();
		return new SynchronizedServerContextSink(this, nextSink);
	}

	[SecurityCritical]
	public virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
	{
		InitIfNecessary();
		return new SynchronizedClientContextSink(this, nextSink);
	}
}
