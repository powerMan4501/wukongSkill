using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Permissions;

namespace System.Threading.Tasks;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class TaskFactory<TResult>
{
	private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
	{
		internal static readonly AsyncCallback s_completeFromAsyncResult = CompleteFromAsyncResult;

		private TInstance m_thisRef;

		private Func<TInstance, IAsyncResult, TResult> m_endMethod;

		internal FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
		{
			m_thisRef = thisRef;
			m_endMethod = endMethod;
		}

		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult.AsyncState is FromAsyncTrimPromise<TInstance> { m_thisRef: var thisRef, m_endMethod: var endMethod } fromAsyncTrimPromise))
			{
				throw new ArgumentException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndCalledMultiple"), "asyncResult");
			}
			fromAsyncTrimPromise.m_thisRef = null;
			fromAsyncTrimPromise.m_endMethod = null;
			if (endMethod == null)
			{
				throw new ArgumentException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndCalledMultiple"), "asyncResult");
			}
			if (!asyncResult.CompletedSynchronously)
			{
				fromAsyncTrimPromise.Complete(thisRef, endMethod, asyncResult, requiresSynchronization: true);
			}
		}

		internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
		{
			bool flag = false;
			try
			{
				TResult result = endMethod(thisRef, asyncResult);
				if (requiresSynchronization)
				{
					flag = TrySetResult(result);
					return;
				}
				DangerousSetResult(result);
				flag = true;
			}
			catch (OperationCanceledException ex)
			{
				flag = TrySetCanceled(ex.CancellationToken, ex);
			}
			catch (Exception exceptionObject)
			{
				flag = TrySetException(exceptionObject);
			}
		}
	}

	private CancellationToken m_defaultCancellationToken;

	private TaskScheduler m_defaultScheduler;

	private TaskCreationOptions m_defaultCreationOptions;

	private TaskContinuationOptions m_defaultContinuationOptions;

	private TaskScheduler DefaultScheduler
	{
		get
		{
			if (m_defaultScheduler == null)
			{
				return TaskScheduler.Current;
			}
			return m_defaultScheduler;
		}
	}

	[__DynamicallyInvokable]
	public CancellationToken CancellationToken
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultCancellationToken;
		}
	}

	[__DynamicallyInvokable]
	public TaskScheduler Scheduler
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultScheduler;
		}
	}

	[__DynamicallyInvokable]
	public TaskCreationOptions CreationOptions
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultCreationOptions;
		}
	}

	[__DynamicallyInvokable]
	public TaskContinuationOptions ContinuationOptions
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultContinuationOptions;
		}
	}

	private TaskScheduler GetDefaultScheduler(Task currTask)
	{
		if (m_defaultScheduler != null)
		{
			return m_defaultScheduler;
		}
		if (currTask != null && (currTask.CreationOptions & TaskCreationOptions.HideScheduler) == 0)
		{
			return currTask.ExecutingTaskScheduler;
		}
		return TaskScheduler.Default;
	}

	[__DynamicallyInvokable]
	public TaskFactory()
		: this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, (TaskScheduler)null)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(CancellationToken cancellationToken)
		: this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, (TaskScheduler)null)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(TaskScheduler scheduler)
		: this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
		: this(default(CancellationToken), creationOptions, continuationOptions, (TaskScheduler)null)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
		TaskFactory.CheckCreationOptions(creationOptions);
		m_defaultCancellationToken = cancellationToken;
		m_defaultScheduler = scheduler;
		m_defaultCreationOptions = creationOptions;
		m_defaultContinuationOptions = continuationOptions;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<TResult> function)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, m_defaultCancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, cancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<TResult> function, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<object, TResult> function, object state)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, state, m_defaultCancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, state, cancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, state, m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, state, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler, ref stackMark);
	}

	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
	{
		Exception ex = null;
		OperationCanceledException ex2 = null;
		TResult result = default(TResult);
		try
		{
			if (endFunction != null)
			{
				result = endFunction(iar);
			}
			else
			{
				endAction(iar);
			}
		}
		catch (OperationCanceledException ex3)
		{
			ex2 = ex3;
		}
		catch (Exception ex4)
		{
			ex = ex4;
		}
		finally
		{
			if (ex2 != null)
			{
				promise.TrySetCanceled(ex2.CancellationToken, ex2);
			}
			else if (ex != null)
			{
				if (promise.TrySetException(ex) && ex is ThreadAbortException)
				{
					promise.m_contingentProperties.m_exceptionsHolder.MarkAsHandled(calledFromFinalizer: false);
				}
			}
			else
			{
				if (AsyncCausalityTracer.LoggingOn)
				{
					AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, promise.Id, AsyncCausalityStatus.Completed);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(promise.Id);
				}
				if (requiresSynchronization)
				{
					promise.TrySetResult(result);
				}
				else
				{
					promise.DangerousSetResult(result);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return FromAsyncImpl(asyncResult, endMethod, null, m_defaultCreationOptions, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return FromAsyncImpl(asyncResult, endMethod, null, creationOptions, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> FromAsync(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return FromAsyncImpl(asyncResult, endMethod, null, creationOptions, scheduler, ref stackMark);
	}

	internal static Task<TResult> FromAsyncImpl(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TaskCreationOptions creationOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (endFunction == null && endAction == null)
		{
			throw new ArgumentNullException("endMethod");
		}
		if (scheduler == null)
		{
			throw new ArgumentNullException("scheduler");
		}
		TaskFactory.CheckFromAsyncOptions(creationOptions, hasBeginMethod: false);
		Task<TResult> promise = new Task<TResult>((object)null, creationOptions);
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, promise.Id, "TaskFactory.FromAsync", 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(promise);
		}
		Task t = new Task(delegate
		{
			FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, requiresSynchronization: true);
		}, null, null, default(CancellationToken), TaskCreationOptions.None, InternalTaskOptions.None, null, ref stackMark);
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Verbose, t.Id, "TaskFactory.FromAsync Callback", 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(t);
		}
		if (asyncResult.IsCompleted)
		{
			try
			{
				t.InternalRunSynchronously(scheduler, waitForCompletion: false);
			}
			catch (Exception exceptionObject)
			{
				promise.TrySetException(exceptionObject);
			}
		}
		else
		{
			ThreadPool.RegisterWaitForSingleObject(asyncResult.AsyncWaitHandle, delegate
			{
				try
				{
					t.InternalRunSynchronously(scheduler, waitForCompletion: false);
				}
				catch (Exception exceptionObject2)
				{
					promise.TrySetException(exceptionObject2);
				}
			}, null, -1, executeOnlyOnce: true);
		}
		return promise;
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, state, creationOptions);
	}

	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
	{
		if (beginMethod == null)
		{
			throw new ArgumentNullException("beginMethod");
		}
		if (endFunction == null && endAction == null)
		{
			throw new ArgumentNullException("endMethod");
		}
		TaskFactory.CheckFromAsyncOptions(creationOptions, hasBeginMethod: true);
		Task<TResult> promise = new Task<TResult>(state, creationOptions);
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, promise.Id, "TaskFactory.FromAsync: " + beginMethod.Method.Name, 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(promise);
		}
		try
		{
			if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				IAsyncResult asyncResult = beginMethod(delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, requiresSynchronization: false);
				}
			}
			else
			{
				IAsyncResult asyncResult2 = beginMethod(delegate(IAsyncResult iar)
				{
					FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
				}, state);
			}
		}
		catch
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, promise.Id, AsyncCausalityStatus.Error);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(promise.Id);
			}
			promise.TrySetResult(default(TResult));
			throw;
		}
		return promise;
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, arg1, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, arg1, state, creationOptions);
	}

	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
	{
		if (beginMethod == null)
		{
			throw new ArgumentNullException("beginMethod");
		}
		if (endFunction == null && endAction == null)
		{
			throw new ArgumentNullException("endFunction");
		}
		TaskFactory.CheckFromAsyncOptions(creationOptions, hasBeginMethod: true);
		Task<TResult> promise = new Task<TResult>(state, creationOptions);
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, promise.Id, "TaskFactory.FromAsync: " + beginMethod.Method.Name, 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(promise);
		}
		try
		{
			if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				IAsyncResult asyncResult = beginMethod(arg1, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, requiresSynchronization: false);
				}
			}
			else
			{
				IAsyncResult asyncResult2 = beginMethod(arg1, delegate(IAsyncResult iar)
				{
					FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
				}, state);
			}
		}
		catch
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, promise.Id, AsyncCausalityStatus.Error);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(promise.Id);
			}
			promise.TrySetResult(default(TResult));
			throw;
		}
		return promise;
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, state, creationOptions);
	}

	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
	{
		if (beginMethod == null)
		{
			throw new ArgumentNullException("beginMethod");
		}
		if (endFunction == null && endAction == null)
		{
			throw new ArgumentNullException("endMethod");
		}
		TaskFactory.CheckFromAsyncOptions(creationOptions, hasBeginMethod: true);
		Task<TResult> promise = new Task<TResult>(state, creationOptions);
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, promise.Id, "TaskFactory.FromAsync: " + beginMethod.Method.Name, 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(promise);
		}
		try
		{
			if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				IAsyncResult asyncResult = beginMethod(arg1, arg2, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, requiresSynchronization: false);
				}
			}
			else
			{
				IAsyncResult asyncResult2 = beginMethod(arg1, arg2, delegate(IAsyncResult iar)
				{
					FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
				}, state);
			}
		}
		catch
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, promise.Id, AsyncCausalityStatus.Error);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(promise.Id);
			}
			promise.TrySetResult(default(TResult));
			throw;
		}
		return promise;
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, arg3, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
	{
		return FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, arg3, state, creationOptions);
	}

	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
	{
		if (beginMethod == null)
		{
			throw new ArgumentNullException("beginMethod");
		}
		if (endFunction == null && endAction == null)
		{
			throw new ArgumentNullException("endMethod");
		}
		TaskFactory.CheckFromAsyncOptions(creationOptions, hasBeginMethod: true);
		Task<TResult> promise = new Task<TResult>(state, creationOptions);
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, promise.Id, "TaskFactory.FromAsync: " + beginMethod.Method.Name, 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(promise);
		}
		try
		{
			if (BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
			{
				IAsyncResult asyncResult = beginMethod(arg1, arg2, arg3, delegate(IAsyncResult iar)
				{
					if (!iar.CompletedSynchronously)
					{
						FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
					}
				}, state);
				if (asyncResult.CompletedSynchronously)
				{
					FromAsyncCoreLogic(asyncResult, endFunction, endAction, promise, requiresSynchronization: false);
				}
			}
			else
			{
				IAsyncResult asyncResult2 = beginMethod(arg1, arg2, arg3, delegate(IAsyncResult iar)
				{
					FromAsyncCoreLogic(iar, endFunction, endAction, promise, requiresSynchronization: true);
				}, state);
			}
		}
		catch
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, promise.Id, AsyncCausalityStatus.Error);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(promise.Id);
			}
			promise.TrySetResult(default(TResult));
			throw;
		}
		return promise;
	}

	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
	{
		FromAsyncTrimPromise<TInstance> fromAsyncTrimPromise = new FromAsyncTrimPromise<TInstance>(thisRef, endMethod);
		IAsyncResult asyncResult = beginMethod(thisRef, args, FromAsyncTrimPromise<TInstance>.s_completeFromAsyncResult, fromAsyncTrimPromise);
		if (asyncResult.CompletedSynchronously)
		{
			fromAsyncTrimPromise.Complete(thisRef, endMethod, asyncResult, requiresSynchronization: false);
		}
		return fromAsyncTrimPromise;
	}

	private static Task<TResult> CreateCanceledTask(TaskContinuationOptions continuationOptions, CancellationToken ct)
	{
		Task.CreationOptionsFromContinuationOptions(continuationOptions, out var creationOptions, out var _);
		return new Task<TResult>(canceled: true, default(TResult), creationOptions, ct);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	internal static Task<TResult> ContinueWhenAllImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler, ref StackCrawlMark stackMark)
	{
		TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
		if (tasks == null)
		{
			throw new ArgumentNullException("tasks");
		}
		if (scheduler == null)
		{
			throw new ArgumentNullException("scheduler");
		}
		Task<TAntecedentResult>[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy(tasks);
		if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == 0)
		{
			return CreateCanceledTask(continuationOptions, cancellationToken);
		}
		Task<Task<TAntecedentResult>[]> task = TaskFactory.CommonCWAllLogic(tasksCopy);
		if (continuationFunction != null)
		{
			return task.ContinueWith(GenericDelegateCache<TAntecedentResult, TResult>.CWAllFuncDelegate, continuationFunction, scheduler, cancellationToken, continuationOptions, ref stackMark);
		}
		return task.ContinueWith(GenericDelegateCache<TAntecedentResult, TResult>.CWAllActionDelegate, continuationAction, scheduler, cancellationToken, continuationOptions, ref stackMark);
	}

	internal static Task<TResult> ContinueWhenAllImpl(Task[] tasks, Func<Task[], TResult> continuationFunction, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler, ref StackCrawlMark stackMark)
	{
		TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
		if (tasks == null)
		{
			throw new ArgumentNullException("tasks");
		}
		if (scheduler == null)
		{
			throw new ArgumentNullException("scheduler");
		}
		Task[] tasksCopy = TaskFactory.CheckMultiContinuationTasksAndCopy(tasks);
		if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == 0)
		{
			return CreateCanceledTask(continuationOptions, cancellationToken);
		}
		Task<Task[]> task = TaskFactory.CommonCWAllLogic(tasksCopy);
		if (continuationFunction != null)
		{
			return task.ContinueWith(delegate(Task<Task[]> completedTasks, object state)
			{
				completedTasks.NotifyDebuggerOfWaitCompletionIfNecessary();
				return ((Func<Task[], TResult>)state)(completedTasks.Result);
			}, continuationFunction, scheduler, cancellationToken, continuationOptions, ref stackMark);
		}
		return task.ContinueWith(delegate(Task<Task[]> completedTasks, object state)
		{
			completedTasks.NotifyDebuggerOfWaitCompletionIfNecessary();
			((Action<Task[]>)state)(completedTasks.Result);
			return default(TResult);
		}, continuationAction, scheduler, cancellationToken, continuationOptions, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	internal static Task<TResult> ContinueWhenAnyImpl(Task[] tasks, Func<Task, TResult> continuationFunction, Action<Task> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler, ref StackCrawlMark stackMark)
	{
		TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
		if (tasks == null)
		{
			throw new ArgumentNullException("tasks");
		}
		if (tasks.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_EmptyTaskList"), "tasks");
		}
		if (scheduler == null)
		{
			throw new ArgumentNullException("scheduler");
		}
		Task<Task> task = TaskFactory.CommonCWAnyLogic(tasks);
		if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == 0)
		{
			return CreateCanceledTask(continuationOptions, cancellationToken);
		}
		if (continuationFunction != null)
		{
			return task.ContinueWith((Task<Task> completedTask, object state) => ((Func<Task, TResult>)state)(completedTask.Result), continuationFunction, scheduler, cancellationToken, continuationOptions, ref stackMark);
		}
		return task.ContinueWith(delegate(Task<Task> completedTask, object state)
		{
			((Action<Task>)state)(completedTask.Result);
			return default(TResult);
		}, continuationAction, scheduler, cancellationToken, continuationOptions, ref stackMark);
	}

	internal static Task<TResult> ContinueWhenAnyImpl<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions, CancellationToken cancellationToken, TaskScheduler scheduler, ref StackCrawlMark stackMark)
	{
		TaskFactory.CheckMultiTaskContinuationOptions(continuationOptions);
		if (tasks == null)
		{
			throw new ArgumentNullException("tasks");
		}
		if (tasks.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_EmptyTaskList"), "tasks");
		}
		if (scheduler == null)
		{
			throw new ArgumentNullException("scheduler");
		}
		Task<Task> task = TaskFactory.CommonCWAnyLogic(tasks);
		if (cancellationToken.IsCancellationRequested && (continuationOptions & TaskContinuationOptions.LazyCancellation) == 0)
		{
			return CreateCanceledTask(continuationOptions, cancellationToken);
		}
		if (continuationFunction != null)
		{
			return task.ContinueWith(GenericDelegateCache<TAntecedentResult, TResult>.CWAnyFuncDelegate, continuationFunction, scheduler, cancellationToken, continuationOptions, ref stackMark);
		}
		return task.ContinueWith(GenericDelegateCache<TAntecedentResult, TResult>.CWAnyActionDelegate, continuationAction, scheduler, cancellationToken, continuationOptions, ref stackMark);
	}
}
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class TaskFactory
{
	private sealed class CompleteOnCountdownPromise : Task<Task[]>, ITaskCompletionAction
	{
		private readonly Task[] _tasks;

		private int _count;

		internal override bool ShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				if (base.ShouldNotifyDebuggerOfWaitCompletion)
				{
					return Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(_tasks);
				}
				return false;
			}
		}

		internal CompleteOnCountdownPromise(Task[] tasksCopy)
		{
			_tasks = tasksCopy;
			_count = tasksCopy.Length;
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, base.Id, "TaskFactory.ContinueWhenAll", 0uL);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(this);
			}
		}

		public void Invoke(Task completingTask)
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationRelation(CausalityTraceLevel.Important, base.Id, CausalityRelation.Join);
			}
			if (completingTask.IsWaitNotificationEnabled)
			{
				SetNotificationForWaitCompletion(enabled: true);
			}
			if (Interlocked.Decrement(ref _count) == 0)
			{
				if (AsyncCausalityTracer.LoggingOn)
				{
					AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, base.Id, AsyncCausalityStatus.Completed);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(base.Id);
				}
				TrySetResult(_tasks);
			}
		}
	}

	private sealed class CompleteOnCountdownPromise<T> : Task<Task<T>[]>, ITaskCompletionAction
	{
		private readonly Task<T>[] _tasks;

		private int _count;

		internal override bool ShouldNotifyDebuggerOfWaitCompletion
		{
			get
			{
				if (base.ShouldNotifyDebuggerOfWaitCompletion)
				{
					Task[] tasks = _tasks;
					return Task.AnyTaskRequiresNotifyDebuggerOfWaitCompletion(tasks);
				}
				return false;
			}
		}

		internal CompleteOnCountdownPromise(Task<T>[] tasksCopy)
		{
			_tasks = tasksCopy;
			_count = tasksCopy.Length;
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, base.Id, "TaskFactory.ContinueWhenAll<>", 0uL);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(this);
			}
		}

		public void Invoke(Task completingTask)
		{
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationRelation(CausalityTraceLevel.Important, base.Id, CausalityRelation.Join);
			}
			if (completingTask.IsWaitNotificationEnabled)
			{
				SetNotificationForWaitCompletion(enabled: true);
			}
			if (Interlocked.Decrement(ref _count) == 0)
			{
				if (AsyncCausalityTracer.LoggingOn)
				{
					AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, base.Id, AsyncCausalityStatus.Completed);
				}
				if (Task.s_asyncDebuggingEnabled)
				{
					Task.RemoveFromActiveTasks(base.Id);
				}
				TrySetResult(_tasks);
			}
		}
	}

	internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
	{
		private IList<Task> _tasks;

		private int m_firstTaskAlreadyCompleted;

		public CompleteOnInvokePromise(IList<Task> tasks)
		{
			_tasks = tasks;
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, base.Id, "TaskFactory.ContinueWhenAny", 0uL);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.AddToActiveTasks(this);
			}
		}

		public void Invoke(Task completingTask)
		{
			if (Interlocked.CompareExchange(ref m_firstTaskAlreadyCompleted, 1, 0) != 0)
			{
				return;
			}
			if (AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationRelation(CausalityTraceLevel.Important, base.Id, CausalityRelation.Choice);
				AsyncCausalityTracer.TraceOperationCompletion(CausalityTraceLevel.Required, base.Id, AsyncCausalityStatus.Completed);
			}
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(base.Id);
			}
			bool flag = TrySetResult(completingTask);
			IList<Task> tasks = _tasks;
			int count = tasks.Count;
			for (int i = 0; i < count; i++)
			{
				Task task = tasks[i];
				if (task != null && !task.IsCompleted)
				{
					task.RemoveContinuation(this);
				}
			}
			_tasks = null;
		}
	}

	private CancellationToken m_defaultCancellationToken;

	private TaskScheduler m_defaultScheduler;

	private TaskCreationOptions m_defaultCreationOptions;

	private TaskContinuationOptions m_defaultContinuationOptions;

	private TaskScheduler DefaultScheduler
	{
		get
		{
			if (m_defaultScheduler == null)
			{
				return TaskScheduler.Current;
			}
			return m_defaultScheduler;
		}
	}

	[__DynamicallyInvokable]
	public CancellationToken CancellationToken
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultCancellationToken;
		}
	}

	[__DynamicallyInvokable]
	public TaskScheduler Scheduler
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultScheduler;
		}
	}

	[__DynamicallyInvokable]
	public TaskCreationOptions CreationOptions
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultCreationOptions;
		}
	}

	[__DynamicallyInvokable]
	public TaskContinuationOptions ContinuationOptions
	{
		[__DynamicallyInvokable]
		get
		{
			return m_defaultContinuationOptions;
		}
	}

	private TaskScheduler GetDefaultScheduler(Task currTask)
	{
		if (m_defaultScheduler != null)
		{
			return m_defaultScheduler;
		}
		if (currTask != null && (currTask.CreationOptions & TaskCreationOptions.HideScheduler) == 0)
		{
			return currTask.ExecutingTaskScheduler;
		}
		return TaskScheduler.Default;
	}

	[__DynamicallyInvokable]
	public TaskFactory()
		: this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, null)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(CancellationToken cancellationToken)
		: this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, null)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(TaskScheduler scheduler)
		: this(default(CancellationToken), TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
		: this(default(CancellationToken), creationOptions, continuationOptions, null)
	{
	}

	[__DynamicallyInvokable]
	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		CheckMultiTaskContinuationOptions(continuationOptions);
		CheckCreationOptions(creationOptions);
		m_defaultCancellationToken = cancellationToken;
		m_defaultScheduler = scheduler;
		m_defaultCreationOptions = creationOptions;
		m_defaultContinuationOptions = continuationOptions;
	}

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
	{
		if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler | TaskCreationOptions.RunContinuationsAsynchronously)) != TaskCreationOptions.None)
		{
			throw new ArgumentOutOfRangeException("creationOptions");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action action)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task.InternalStartNew(internalCurrent, action, null, m_defaultCancellationToken, GetDefaultScheduler(internalCurrent), m_defaultCreationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action action, CancellationToken cancellationToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task.InternalStartNew(internalCurrent, action, null, cancellationToken, GetDefaultScheduler(internalCurrent), m_defaultCreationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action action, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task.InternalStartNew(internalCurrent, action, null, m_defaultCancellationToken, GetDefaultScheduler(internalCurrent), creationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, null, cancellationToken, scheduler, creationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, null, cancellationToken, scheduler, creationOptions, internalOptions, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action<object> action, object state)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task.InternalStartNew(internalCurrent, action, state, m_defaultCancellationToken, GetDefaultScheduler(internalCurrent), m_defaultCreationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task.InternalStartNew(internalCurrent, action, state, cancellationToken, GetDefaultScheduler(internalCurrent), m_defaultCreationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action<object> action, object state, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task.InternalStartNew(internalCurrent, action, state, m_defaultCancellationToken, GetDefaultScheduler(internalCurrent), creationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task.InternalStartNew(Task.InternalCurrentIfAttached(creationOptions), action, state, cancellationToken, scheduler, creationOptions, InternalTaskOptions.None, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<TResult> function)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, m_defaultCancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, cancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, state, m_defaultCancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, state, cancellationToken, m_defaultCreationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Task internalCurrent = Task.InternalCurrent;
		return Task<TResult>.StartNew(internalCurrent, function, state, m_defaultCancellationToken, creationOptions, InternalTaskOptions.None, GetDefaultScheduler(internalCurrent), ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Task<TResult>.StartNew(Task.InternalCurrentIfAttached(creationOptions), function, state, cancellationToken, creationOptions, InternalTaskOptions.None, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return FromAsync(asyncResult, endMethod, m_defaultCreationOptions, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return FromAsync(asyncResult, endMethod, creationOptions, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return FromAsync(asyncResult, endMethod, creationOptions, scheduler, ref stackMark);
	}

	private Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
	{
		return TaskFactory<VoidTaskResult>.FromAsyncImpl(asyncResult, null, endMethod, creationOptions, scheduler, ref stackMark);
	}

	[__DynamicallyInvokable]
	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state)
	{
		return FromAsync(beginMethod, endMethod, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<VoidTaskResult>.FromAsyncImpl(beginMethod, null, endMethod, state, creationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state)
	{
		return FromAsync(beginMethod, endMethod, arg1, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<VoidTaskResult>.FromAsyncImpl(beginMethod, null, endMethod, arg1, state, creationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
	{
		return FromAsync(beginMethod, endMethod, arg1, arg2, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<VoidTaskResult>.FromAsyncImpl(beginMethod, null, endMethod, arg1, arg2, state, creationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
	{
		return FromAsync(beginMethod, endMethod, arg1, arg2, arg3, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<VoidTaskResult>.FromAsyncImpl(beginMethod, null, endMethod, arg1, arg2, arg3, state, creationOptions);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, m_defaultCreationOptions, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.FromAsyncImpl(asyncResult, endMethod, null, creationOptions, scheduler, ref stackMark);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, state, creationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, arg1, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, arg1, state, creationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, state, creationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, arg3, state, m_defaultCreationOptions);
	}

	[__DynamicallyInvokable]
	public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
	{
		return TaskFactory<TResult>.FromAsyncImpl(beginMethod, endMethod, null, arg1, arg2, arg3, state, creationOptions);
	}

	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
	{
		if (hasBeginMethod)
		{
			if ((creationOptions & TaskCreationOptions.LongRunning) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions", Environment.GetResourceString("Task_FromAsync_LongRunning"));
			}
			if ((creationOptions & TaskCreationOptions.PreferFairness) != TaskCreationOptions.None)
			{
				throw new ArgumentOutOfRangeException("creationOptions", Environment.GetResourceString("Task_FromAsync_PreferFairness"));
			}
		}
		if ((creationOptions & ~(TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning | TaskCreationOptions.AttachedToParent | TaskCreationOptions.DenyChildAttach | TaskCreationOptions.HideScheduler)) != TaskCreationOptions.None)
		{
			throw new ArgumentOutOfRangeException("creationOptions");
		}
	}

	internal static Task<Task[]> CommonCWAllLogic(Task[] tasksCopy)
	{
		CompleteOnCountdownPromise completeOnCountdownPromise = new CompleteOnCountdownPromise(tasksCopy);
		for (int i = 0; i < tasksCopy.Length; i++)
		{
			if (tasksCopy[i].IsCompleted)
			{
				completeOnCountdownPromise.Invoke(tasksCopy[i]);
			}
			else
			{
				tasksCopy[i].AddCompletionAction(completeOnCountdownPromise);
			}
		}
		return completeOnCountdownPromise;
	}

	internal static Task<Task<T>[]> CommonCWAllLogic<T>(Task<T>[] tasksCopy)
	{
		CompleteOnCountdownPromise<T> completeOnCountdownPromise = new CompleteOnCountdownPromise<T>(tasksCopy);
		for (int i = 0; i < tasksCopy.Length; i++)
		{
			if (tasksCopy[i].IsCompleted)
			{
				completeOnCountdownPromise.Invoke(tasksCopy[i]);
			}
			else
			{
				tasksCopy[i].AddCompletionAction(completeOnCountdownPromise);
			}
		}
		return completeOnCountdownPromise;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, TaskContinuationOptions continuationOptions)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, TaskContinuationOptions continuationOptions)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAllImpl(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>[], TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAllImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
	{
		CompleteOnInvokePromise completeOnInvokePromise = new CompleteOnInvokePromise(tasks);
		bool flag = false;
		int count = tasks.Count;
		for (int i = 0; i < count; i++)
		{
			Task task = tasks[i];
			if (task == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_NullTask"), "tasks");
			}
			if (flag)
			{
				continue;
			}
			if (completeOnInvokePromise.IsCompleted)
			{
				flag = true;
				continue;
			}
			if (task.IsCompleted)
			{
				completeOnInvokePromise.Invoke(task);
				flag = true;
				continue;
			}
			task.AddCompletionAction(completeOnInvokePromise);
			if (completeOnInvokePromise.IsCompleted)
			{
				task.RemoveContinuation(completeOnInvokePromise);
			}
		}
		return completeOnInvokePromise;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, TaskContinuationOptions continuationOptions)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks, Func<Task<TAntecedentResult>, TResult> continuationFunction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationFunction == null)
		{
			throw new ArgumentNullException("continuationFunction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<TResult>.ContinueWhenAnyImpl(tasks, continuationFunction, null, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, m_defaultContinuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, m_defaultContinuationOptions, cancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, TaskContinuationOptions continuationOptions)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, continuationOptions, m_defaultCancellationToken, DefaultScheduler, ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[__DynamicallyInvokable]
	public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
	{
		if (continuationAction == null)
		{
			throw new ArgumentNullException("continuationAction");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return TaskFactory<VoidTaskResult>.ContinueWhenAnyImpl(tasks, null, continuationAction, continuationOptions, cancellationToken, scheduler, ref stackMark);
	}

	internal static Task[] CheckMultiContinuationTasksAndCopy(Task[] tasks)
	{
		if (tasks == null)
		{
			throw new ArgumentNullException("tasks");
		}
		if (tasks.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_EmptyTaskList"), "tasks");
		}
		Task[] array = new Task[tasks.Length];
		for (int i = 0; i < tasks.Length; i++)
		{
			array[i] = tasks[i];
			if (array[i] == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_NullTask"), "tasks");
			}
		}
		return array;
	}

	internal static Task<TResult>[] CheckMultiContinuationTasksAndCopy<TResult>(Task<TResult>[] tasks)
	{
		if (tasks == null)
		{
			throw new ArgumentNullException("tasks");
		}
		if (tasks.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_EmptyTaskList"), "tasks");
		}
		Task<TResult>[] array = new Task<TResult>[tasks.Length];
		for (int i = 0; i < tasks.Length; i++)
		{
			array[i] = tasks[i];
			if (array[i] == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Task_MultiTaskContinuation_NullTask"), "tasks");
			}
		}
		return array;
	}

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
	{
		if ((continuationOptions & (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously)) == (TaskContinuationOptions.LongRunning | TaskContinuationOptions.ExecuteSynchronously))
		{
			throw new ArgumentOutOfRangeException("continuationOptions", Environment.GetResourceString("Task_ContinueWith_ESandLR"));
		}
		if ((continuationOptions & ~(TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.PreferFairness | TaskContinuationOptions.LongRunning | TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.DenyChildAttach | TaskContinuationOptions.HideScheduler | TaskContinuationOptions.LazyCancellation | TaskContinuationOptions.NotOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously)) != TaskContinuationOptions.None)
		{
			throw new ArgumentOutOfRangeException("continuationOptions");
		}
		if ((continuationOptions & (TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.NotOnRanToCompletion)) != TaskContinuationOptions.None)
		{
			throw new ArgumentOutOfRangeException("continuationOptions", Environment.GetResourceString("Task_MultiTaskContinuation_FireOptions"));
		}
	}
}
