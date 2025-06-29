using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Permissions;

namespace System.Threading.Tasks;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public static class Parallel
{
	internal struct LoopTimer
	{
		private const int s_BaseNotifyPeriodMS = 100;

		private const int s_NotifyPeriodIncrementMS = 50;

		private int m_timeLimit;

		public LoopTimer(int nWorkerTaskIndex)
		{
			int num = 100 + nWorkerTaskIndex % PlatformHelper.ProcessorCount * 50;
			m_timeLimit = Environment.TickCount + num;
		}

		public bool LimitExceeded()
		{
			return Environment.TickCount > m_timeLimit;
		}
	}

	internal static int s_forkJoinContextID;

	internal const int DEFAULT_LOOP_STRIDE = 16;

	internal static ParallelOptions s_defaultParallelOptions = new ParallelOptions();

	[__DynamicallyInvokable]
	public static void Invoke(params Action[] actions)
	{
		Invoke(s_defaultParallelOptions, actions);
	}

	[__DynamicallyInvokable]
	public static void Invoke(ParallelOptions parallelOptions, params Action[] actions)
	{
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		if (parallelOptions.CancellationToken.CanBeCanceled && AppContextSwitches.ThrowExceptionIfDisposedCancellationTokenSource)
		{
			parallelOptions.CancellationToken.ThrowIfSourceDisposed();
		}
		if (parallelOptions.CancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(parallelOptions.CancellationToken);
		}
		Action[] actionsCopy = new Action[actions.Length];
		for (int i = 0; i < actionsCopy.Length; i++)
		{
			actionsCopy[i] = actions[i];
			if (actionsCopy[i] == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Parallel_Invoke_ActionNull"));
			}
		}
		int forkJoinContextID = 0;
		Task task = null;
		if (TplEtwProvider.Log.IsEnabled())
		{
			forkJoinContextID = Interlocked.Increment(ref s_forkJoinContextID);
			task = Task.InternalCurrent;
			TplEtwProvider.Log.ParallelInvokeBegin(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, TplEtwProvider.ForkJoinOperationType.ParallelInvoke, actionsCopy.Length);
		}
		if (actionsCopy.Length < 1)
		{
			return;
		}
		try
		{
			if (actionsCopy.Length > 10 || (parallelOptions.MaxDegreeOfParallelism != -1 && parallelOptions.MaxDegreeOfParallelism < actionsCopy.Length))
			{
				ConcurrentQueue<Exception> exceptionQ = null;
				try
				{
					int actionIndex = 0;
					ParallelForReplicatingTask parallelForReplicatingTask = new ParallelForReplicatingTask(parallelOptions, delegate
					{
						for (int num3 = Interlocked.Increment(ref actionIndex); num3 <= actionsCopy.Length; num3 = Interlocked.Increment(ref actionIndex))
						{
							try
							{
								actionsCopy[num3 - 1]();
							}
							catch (Exception item)
							{
								LazyInitializer.EnsureInitialized(ref exceptionQ, () => new ConcurrentQueue<Exception>());
								exceptionQ.Enqueue(item);
							}
							if (parallelOptions.CancellationToken.IsCancellationRequested)
							{
								throw new OperationCanceledException(parallelOptions.CancellationToken);
							}
						}
					}, TaskCreationOptions.None, InternalTaskOptions.SelfReplicating);
					parallelForReplicatingTask.RunSynchronously(parallelOptions.EffectiveTaskScheduler);
					parallelForReplicatingTask.Wait();
				}
				catch (Exception ex)
				{
					LazyInitializer.EnsureInitialized(ref exceptionQ, () => new ConcurrentQueue<Exception>());
					if (ex is AggregateException ex2)
					{
						foreach (Exception innerException in ex2.InnerExceptions)
						{
							exceptionQ.Enqueue(innerException);
						}
					}
					else
					{
						exceptionQ.Enqueue(ex);
					}
				}
				if (exceptionQ != null && exceptionQ.Count > 0)
				{
					ThrowIfReducableToSingleOCE(exceptionQ, parallelOptions.CancellationToken);
					throw new AggregateException(exceptionQ);
				}
				return;
			}
			Task[] array = new Task[actionsCopy.Length];
			if (parallelOptions.CancellationToken.IsCancellationRequested)
			{
				throw new OperationCanceledException(parallelOptions.CancellationToken);
			}
			for (int num = 1; num < array.Length; num++)
			{
				array[num] = Task.Factory.StartNew(actionsCopy[num], parallelOptions.CancellationToken, TaskCreationOptions.None, InternalTaskOptions.None, parallelOptions.EffectiveTaskScheduler);
			}
			array[0] = new Task(actionsCopy[0]);
			array[0].RunSynchronously(parallelOptions.EffectiveTaskScheduler);
			try
			{
				if (array.Length <= 4)
				{
					Task.FastWaitAll(array);
				}
				else
				{
					Task.WaitAll(array);
				}
			}
			catch (AggregateException ex3)
			{
				ThrowIfReducableToSingleOCE(ex3.InnerExceptions, parallelOptions.CancellationToken);
				throw;
			}
			finally
			{
				for (int num2 = 0; num2 < array.Length; num2++)
				{
					if (array[num2].IsCompleted)
					{
						array[num2].Dispose();
					}
				}
			}
		}
		finally
		{
			if (TplEtwProvider.Log.IsEnabled())
			{
				TplEtwProvider.Log.ParallelInvokeEnd(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID);
			}
		}
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForWorker<object>(fromInclusive, toExclusive, s_defaultParallelOptions, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(long fromInclusive, long toExclusive, Action<long> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForWorker64<object>(fromInclusive, toExclusive, s_defaultParallelOptions, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForWorker<object>(fromInclusive, toExclusive, parallelOptions, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForWorker64<object>(fromInclusive, toExclusive, parallelOptions, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(int fromInclusive, int toExclusive, Action<int, ParallelLoopState> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForWorker<object>(fromInclusive, toExclusive, s_defaultParallelOptions, null, body, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(long fromInclusive, long toExclusive, Action<long, ParallelLoopState> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForWorker64<object>(fromInclusive, toExclusive, s_defaultParallelOptions, null, body, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int, ParallelLoopState> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForWorker<object>(fromInclusive, toExclusive, parallelOptions, null, body, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long, ParallelLoopState> body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForWorker64<object>(fromInclusive, toExclusive, parallelOptions, null, body, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		return ForWorker(fromInclusive, toExclusive, s_defaultParallelOptions, null, null, body, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, Func<TLocal> localInit, Func<long, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		return ForWorker64(fromInclusive, toExclusive, s_defaultParallelOptions, null, null, body, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<int, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForWorker(fromInclusive, toExclusive, parallelOptions, null, null, body, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult For<TLocal>(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<long, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForWorker64(fromInclusive, toExclusive, parallelOptions, null, null, body, localInit, localFinally);
	}

	private static ParallelLoopResult ForWorker<TLocal>(int fromInclusive, int toExclusive, ParallelOptions parallelOptions, Action<int> body, Action<int, ParallelLoopState> bodyWithState, Func<int, ParallelLoopState, TLocal, TLocal> bodyWithLocal, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		ParallelLoopResult result = default(ParallelLoopResult);
		if (toExclusive <= fromInclusive)
		{
			result.m_completed = true;
			return result;
		}
		ParallelLoopStateFlags32 sharedPStateFlags = new ParallelLoopStateFlags32();
		TaskCreationOptions creationOptions = TaskCreationOptions.None;
		InternalTaskOptions internalOptions = InternalTaskOptions.SelfReplicating;
		if (parallelOptions.CancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(parallelOptions.CancellationToken);
		}
		int nNumExpectedWorkers = ((parallelOptions.EffectiveMaxConcurrencyLevel == -1) ? PlatformHelper.ProcessorCount : parallelOptions.EffectiveMaxConcurrencyLevel);
		RangeManager rangeManager = new RangeManager(fromInclusive, toExclusive, 1L, nNumExpectedWorkers);
		OperationCanceledException oce = null;
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		if (parallelOptions.CancellationToken.CanBeCanceled)
		{
			cancellationTokenRegistration = parallelOptions.CancellationToken.InternalRegisterWithoutEC(delegate
			{
				sharedPStateFlags.Cancel();
				oce = new OperationCanceledException(parallelOptions.CancellationToken);
			}, null);
		}
		int forkJoinContextID = 0;
		Task task = null;
		if (TplEtwProvider.Log.IsEnabled())
		{
			forkJoinContextID = Interlocked.Increment(ref s_forkJoinContextID);
			task = Task.InternalCurrent;
			TplEtwProvider.Log.ParallelLoopBegin(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, TplEtwProvider.ForkJoinOperationType.ParallelFor, fromInclusive, toExclusive);
		}
		ParallelForReplicatingTask rootTask = null;
		try
		{
			rootTask = new ParallelForReplicatingTask(parallelOptions, delegate
			{
				Task internalCurrent = Task.InternalCurrent;
				bool flag = internalCurrent == rootTask;
				RangeWorker rangeWorker = default(RangeWorker);
				object savedStateFromPreviousReplica = internalCurrent.SavedStateFromPreviousReplica;
				rangeWorker = ((!(savedStateFromPreviousReplica is RangeWorker)) ? rangeManager.RegisterNewWorker() : ((RangeWorker)savedStateFromPreviousReplica));
				if (!rangeWorker.FindNewWork32(out var nFromInclusiveLocal, out var nToExclusiveLocal) || sharedPStateFlags.ShouldExitLoop(nFromInclusiveLocal))
				{
					return;
				}
				if (TplEtwProvider.Log.IsEnabled())
				{
					TplEtwProvider.Log.ParallelFork(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, forkJoinContextID);
				}
				TLocal val = default(TLocal);
				bool flag2 = false;
				try
				{
					ParallelLoopState32 parallelLoopState = null;
					if (bodyWithState != null)
					{
						parallelLoopState = new ParallelLoopState32(sharedPStateFlags);
					}
					else if (bodyWithLocal != null)
					{
						parallelLoopState = new ParallelLoopState32(sharedPStateFlags);
						if (localInit != null)
						{
							val = localInit();
							flag2 = true;
						}
					}
					LoopTimer loopTimer = new LoopTimer(rootTask.ActiveChildCount);
					do
					{
						if (body != null)
						{
							for (int i = nFromInclusiveLocal; i < nToExclusiveLocal; i++)
							{
								if (sharedPStateFlags.LoopStateFlags != ParallelLoopStateFlags.PLS_NONE && sharedPStateFlags.ShouldExitLoop())
								{
									break;
								}
								body(i);
							}
						}
						else if (bodyWithState != null)
						{
							for (int j = nFromInclusiveLocal; j < nToExclusiveLocal && (sharedPStateFlags.LoopStateFlags == ParallelLoopStateFlags.PLS_NONE || !sharedPStateFlags.ShouldExitLoop(j)); j++)
							{
								parallelLoopState.CurrentIteration = j;
								bodyWithState(j, parallelLoopState);
							}
						}
						else
						{
							for (int k = nFromInclusiveLocal; k < nToExclusiveLocal && (sharedPStateFlags.LoopStateFlags == ParallelLoopStateFlags.PLS_NONE || !sharedPStateFlags.ShouldExitLoop(k)); k++)
							{
								parallelLoopState.CurrentIteration = k;
								val = bodyWithLocal(k, parallelLoopState, val);
							}
						}
						if (!flag && loopTimer.LimitExceeded())
						{
							internalCurrent.SavedStateForNextReplica = rangeWorker;
							break;
						}
					}
					while (rangeWorker.FindNewWork32(out nFromInclusiveLocal, out nToExclusiveLocal) && (sharedPStateFlags.LoopStateFlags == ParallelLoopStateFlags.PLS_NONE || !sharedPStateFlags.ShouldExitLoop(nFromInclusiveLocal)));
				}
				catch
				{
					sharedPStateFlags.SetExceptional();
					throw;
				}
				finally
				{
					if (localFinally != null && flag2)
					{
						localFinally(val);
					}
					if (TplEtwProvider.Log.IsEnabled())
					{
						TplEtwProvider.Log.ParallelJoin(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, forkJoinContextID);
					}
				}
			}, creationOptions, internalOptions);
			rootTask.RunSynchronously(parallelOptions.EffectiveTaskScheduler);
			rootTask.Wait();
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			if (oce != null)
			{
				throw oce;
			}
		}
		catch (AggregateException ex)
		{
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			ThrowIfReducableToSingleOCE(ex.InnerExceptions, parallelOptions.CancellationToken);
			throw;
		}
		catch (TaskSchedulerException)
		{
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			throw;
		}
		finally
		{
			int loopStateFlags = sharedPStateFlags.LoopStateFlags;
			result.m_completed = loopStateFlags == ParallelLoopStateFlags.PLS_NONE;
			if ((loopStateFlags & ParallelLoopStateFlags.PLS_BROKEN) != 0)
			{
				result.m_lowestBreakIteration = sharedPStateFlags.LowestBreakIteration;
			}
			if (rootTask != null && rootTask.IsCompleted)
			{
				rootTask.Dispose();
			}
			if (TplEtwProvider.Log.IsEnabled())
			{
				int num = 0;
				num = ((loopStateFlags == ParallelLoopStateFlags.PLS_NONE) ? (toExclusive - fromInclusive) : (((loopStateFlags & ParallelLoopStateFlags.PLS_BROKEN) == 0) ? (-1) : (sharedPStateFlags.LowestBreakIteration - fromInclusive)));
				TplEtwProvider.Log.ParallelLoopEnd(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, num);
			}
		}
		return result;
	}

	private static ParallelLoopResult ForWorker64<TLocal>(long fromInclusive, long toExclusive, ParallelOptions parallelOptions, Action<long> body, Action<long, ParallelLoopState> bodyWithState, Func<long, ParallelLoopState, TLocal, TLocal> bodyWithLocal, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		ParallelLoopResult result = default(ParallelLoopResult);
		if (toExclusive <= fromInclusive)
		{
			result.m_completed = true;
			return result;
		}
		ParallelLoopStateFlags64 sharedPStateFlags = new ParallelLoopStateFlags64();
		TaskCreationOptions creationOptions = TaskCreationOptions.None;
		InternalTaskOptions internalOptions = InternalTaskOptions.SelfReplicating;
		if (parallelOptions.CancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(parallelOptions.CancellationToken);
		}
		int nNumExpectedWorkers = ((parallelOptions.EffectiveMaxConcurrencyLevel == -1) ? PlatformHelper.ProcessorCount : parallelOptions.EffectiveMaxConcurrencyLevel);
		RangeManager rangeManager = new RangeManager(fromInclusive, toExclusive, 1L, nNumExpectedWorkers);
		OperationCanceledException oce = null;
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		if (parallelOptions.CancellationToken.CanBeCanceled)
		{
			cancellationTokenRegistration = parallelOptions.CancellationToken.InternalRegisterWithoutEC(delegate
			{
				sharedPStateFlags.Cancel();
				oce = new OperationCanceledException(parallelOptions.CancellationToken);
			}, null);
		}
		Task task = null;
		int forkJoinContextID = 0;
		if (TplEtwProvider.Log.IsEnabled())
		{
			forkJoinContextID = Interlocked.Increment(ref s_forkJoinContextID);
			task = Task.InternalCurrent;
			TplEtwProvider.Log.ParallelLoopBegin(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, TplEtwProvider.ForkJoinOperationType.ParallelFor, fromInclusive, toExclusive);
		}
		ParallelForReplicatingTask rootTask = null;
		try
		{
			rootTask = new ParallelForReplicatingTask(parallelOptions, delegate
			{
				Task internalCurrent = Task.InternalCurrent;
				bool flag = internalCurrent == rootTask;
				RangeWorker rangeWorker = default(RangeWorker);
				object savedStateFromPreviousReplica = internalCurrent.SavedStateFromPreviousReplica;
				rangeWorker = ((!(savedStateFromPreviousReplica is RangeWorker)) ? rangeManager.RegisterNewWorker() : ((RangeWorker)savedStateFromPreviousReplica));
				if (!rangeWorker.FindNewWork(out var nFromInclusiveLocal, out var nToExclusiveLocal) || sharedPStateFlags.ShouldExitLoop(nFromInclusiveLocal))
				{
					return;
				}
				if (TplEtwProvider.Log.IsEnabled())
				{
					TplEtwProvider.Log.ParallelFork(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, forkJoinContextID);
				}
				TLocal val = default(TLocal);
				bool flag2 = false;
				try
				{
					ParallelLoopState64 parallelLoopState = null;
					if (bodyWithState != null)
					{
						parallelLoopState = new ParallelLoopState64(sharedPStateFlags);
					}
					else if (bodyWithLocal != null)
					{
						parallelLoopState = new ParallelLoopState64(sharedPStateFlags);
						if (localInit != null)
						{
							val = localInit();
							flag2 = true;
						}
					}
					LoopTimer loopTimer = new LoopTimer(rootTask.ActiveChildCount);
					do
					{
						if (body != null)
						{
							for (long num2 = nFromInclusiveLocal; num2 < nToExclusiveLocal; num2++)
							{
								if (sharedPStateFlags.LoopStateFlags != ParallelLoopStateFlags.PLS_NONE && sharedPStateFlags.ShouldExitLoop())
								{
									break;
								}
								body(num2);
							}
						}
						else if (bodyWithState != null)
						{
							for (long num3 = nFromInclusiveLocal; num3 < nToExclusiveLocal && (sharedPStateFlags.LoopStateFlags == ParallelLoopStateFlags.PLS_NONE || !sharedPStateFlags.ShouldExitLoop(num3)); num3++)
							{
								parallelLoopState.CurrentIteration = num3;
								bodyWithState(num3, parallelLoopState);
							}
						}
						else
						{
							for (long num4 = nFromInclusiveLocal; num4 < nToExclusiveLocal && (sharedPStateFlags.LoopStateFlags == ParallelLoopStateFlags.PLS_NONE || !sharedPStateFlags.ShouldExitLoop(num4)); num4++)
							{
								parallelLoopState.CurrentIteration = num4;
								val = bodyWithLocal(num4, parallelLoopState, val);
							}
						}
						if (!flag && loopTimer.LimitExceeded())
						{
							internalCurrent.SavedStateForNextReplica = rangeWorker;
							break;
						}
					}
					while (rangeWorker.FindNewWork(out nFromInclusiveLocal, out nToExclusiveLocal) && (sharedPStateFlags.LoopStateFlags == ParallelLoopStateFlags.PLS_NONE || !sharedPStateFlags.ShouldExitLoop(nFromInclusiveLocal)));
				}
				catch
				{
					sharedPStateFlags.SetExceptional();
					throw;
				}
				finally
				{
					if (localFinally != null && flag2)
					{
						localFinally(val);
					}
					if (TplEtwProvider.Log.IsEnabled())
					{
						TplEtwProvider.Log.ParallelJoin(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, forkJoinContextID);
					}
				}
			}, creationOptions, internalOptions);
			rootTask.RunSynchronously(parallelOptions.EffectiveTaskScheduler);
			rootTask.Wait();
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			if (oce != null)
			{
				throw oce;
			}
		}
		catch (AggregateException ex)
		{
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			ThrowIfReducableToSingleOCE(ex.InnerExceptions, parallelOptions.CancellationToken);
			throw;
		}
		catch (TaskSchedulerException)
		{
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			throw;
		}
		finally
		{
			int loopStateFlags = sharedPStateFlags.LoopStateFlags;
			result.m_completed = loopStateFlags == ParallelLoopStateFlags.PLS_NONE;
			if ((loopStateFlags & ParallelLoopStateFlags.PLS_BROKEN) != 0)
			{
				result.m_lowestBreakIteration = sharedPStateFlags.LowestBreakIteration;
			}
			if (rootTask != null && rootTask.IsCompleted)
			{
				rootTask.Dispose();
			}
			if (TplEtwProvider.Log.IsEnabled())
			{
				long num = 0L;
				num = ((loopStateFlags == ParallelLoopStateFlags.PLS_NONE) ? (toExclusive - fromInclusive) : (((loopStateFlags & ParallelLoopStateFlags.PLS_BROKEN) == 0) ? (-1) : (sharedPStateFlags.LowestBreakIteration - fromInclusive)));
				TplEtwProvider.Log.ParallelLoopEnd(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, num);
			}
		}
		return result;
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForEachWorker<TSource, object>(source, s_defaultParallelOptions, body, null, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForEachWorker<TSource, object>(source, parallelOptions, body, null, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource, ParallelLoopState> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForEachWorker<TSource, object>(source, s_defaultParallelOptions, null, body, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForEachWorker<TSource, object>(source, parallelOptions, null, body, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, Action<TSource, ParallelLoopState, long> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return ForEachWorker<TSource, object>(source, s_defaultParallelOptions, null, null, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForEachWorker<TSource, object>(source, parallelOptions, null, null, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		return ForEachWorker(source, s_defaultParallelOptions, null, null, null, body, null, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForEachWorker(source, parallelOptions, null, null, null, body, null, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		return ForEachWorker(source, s_defaultParallelOptions, null, null, null, null, body, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return ForEachWorker(source, parallelOptions, null, null, null, null, body, localInit, localFinally);
	}

	private static ParallelLoopResult ForEachWorker<TSource, TLocal>(IEnumerable<TSource> source, ParallelOptions parallelOptions, Action<TSource> body, Action<TSource, ParallelLoopState> bodyWithState, Action<TSource, ParallelLoopState, long> bodyWithStateAndIndex, Func<TSource, ParallelLoopState, TLocal, TLocal> bodyWithStateAndLocal, Func<TSource, ParallelLoopState, long, TLocal, TLocal> bodyWithEverything, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		if (parallelOptions.CancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(parallelOptions.CancellationToken);
		}
		if (source is TSource[] array)
		{
			return ForEachWorker(array, parallelOptions, body, bodyWithState, bodyWithStateAndIndex, bodyWithStateAndLocal, bodyWithEverything, localInit, localFinally);
		}
		if (source is IList<TSource> list)
		{
			return ForEachWorker(list, parallelOptions, body, bodyWithState, bodyWithStateAndIndex, bodyWithStateAndLocal, bodyWithEverything, localInit, localFinally);
		}
		return PartitionerForEachWorker(Partitioner.Create(source), parallelOptions, body, bodyWithState, bodyWithStateAndIndex, bodyWithStateAndLocal, bodyWithEverything, localInit, localFinally);
	}

	private static ParallelLoopResult ForEachWorker<TSource, TLocal>(TSource[] array, ParallelOptions parallelOptions, Action<TSource> body, Action<TSource, ParallelLoopState> bodyWithState, Action<TSource, ParallelLoopState, long> bodyWithStateAndIndex, Func<TSource, ParallelLoopState, TLocal, TLocal> bodyWithStateAndLocal, Func<TSource, ParallelLoopState, long, TLocal, TLocal> bodyWithEverything, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		int lowerBound = array.GetLowerBound(0);
		int toExclusive = array.GetUpperBound(0) + 1;
		if (body != null)
		{
			return ForWorker<object>(lowerBound, toExclusive, parallelOptions, delegate(int i)
			{
				body(array[i]);
			}, null, null, null, null);
		}
		if (bodyWithState != null)
		{
			return ForWorker<object>(lowerBound, toExclusive, parallelOptions, null, delegate(int i, ParallelLoopState state)
			{
				bodyWithState(array[i], state);
			}, null, null, null);
		}
		if (bodyWithStateAndIndex != null)
		{
			return ForWorker<object>(lowerBound, toExclusive, parallelOptions, null, delegate(int i, ParallelLoopState state)
			{
				bodyWithStateAndIndex(array[i], state, i);
			}, null, null, null);
		}
		if (bodyWithStateAndLocal != null)
		{
			return ForWorker(lowerBound, toExclusive, parallelOptions, null, null, (int i, ParallelLoopState state, TLocal local) => bodyWithStateAndLocal(array[i], state, local), localInit, localFinally);
		}
		return ForWorker(lowerBound, toExclusive, parallelOptions, null, null, (int i, ParallelLoopState state, TLocal local) => bodyWithEverything(array[i], state, i, local), localInit, localFinally);
	}

	private static ParallelLoopResult ForEachWorker<TSource, TLocal>(IList<TSource> list, ParallelOptions parallelOptions, Action<TSource> body, Action<TSource, ParallelLoopState> bodyWithState, Action<TSource, ParallelLoopState, long> bodyWithStateAndIndex, Func<TSource, ParallelLoopState, TLocal, TLocal> bodyWithStateAndLocal, Func<TSource, ParallelLoopState, long, TLocal, TLocal> bodyWithEverything, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		if (body != null)
		{
			return ForWorker<object>(0, list.Count, parallelOptions, delegate(int i)
			{
				body(list[i]);
			}, null, null, null, null);
		}
		if (bodyWithState != null)
		{
			return ForWorker<object>(0, list.Count, parallelOptions, null, delegate(int i, ParallelLoopState state)
			{
				bodyWithState(list[i], state);
			}, null, null, null);
		}
		if (bodyWithStateAndIndex != null)
		{
			return ForWorker<object>(0, list.Count, parallelOptions, null, delegate(int i, ParallelLoopState state)
			{
				bodyWithStateAndIndex(list[i], state, i);
			}, null, null, null);
		}
		if (bodyWithStateAndLocal != null)
		{
			return ForWorker(0, list.Count, parallelOptions, null, null, (int i, ParallelLoopState state, TLocal local) => bodyWithStateAndLocal(list[i], state, local), localInit, localFinally);
		}
		return ForWorker(0, list.Count, parallelOptions, null, null, (int i, ParallelLoopState state, TLocal local) => bodyWithEverything(list[i], state, i, local), localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, Action<TSource> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return PartitionerForEachWorker<TSource, object>(source, s_defaultParallelOptions, body, null, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, Action<TSource, ParallelLoopState> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		return PartitionerForEachWorker<TSource, object>(source, s_defaultParallelOptions, null, body, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(OrderablePartitioner<TSource> source, Action<TSource, ParallelLoopState, long> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (!source.KeysNormalized)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_OrderedPartitionerKeysNotNormalized"));
		}
		return PartitionerForEachWorker<TSource, object>(source, s_defaultParallelOptions, null, null, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(Partitioner<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		return PartitionerForEachWorker(source, s_defaultParallelOptions, null, null, null, body, null, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(OrderablePartitioner<TSource> source, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (!source.KeysNormalized)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_OrderedPartitionerKeysNotNormalized"));
		}
		return PartitionerForEachWorker(source, s_defaultParallelOptions, null, null, null, null, body, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return PartitionerForEachWorker<TSource, object>(source, parallelOptions, body, null, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return PartitionerForEachWorker<TSource, object>(source, parallelOptions, null, body, null, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource>(OrderablePartitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource, ParallelLoopState, long> body)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		if (!source.KeysNormalized)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_OrderedPartitionerKeysNotNormalized"));
		}
		return PartitionerForEachWorker<TSource, object>(source, parallelOptions, null, null, body, null, null, null, null);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(Partitioner<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		return PartitionerForEachWorker(source, parallelOptions, null, null, null, body, null, localInit, localFinally);
	}

	[__DynamicallyInvokable]
	public static ParallelLoopResult ForEach<TSource, TLocal>(OrderablePartitioner<TSource> source, ParallelOptions parallelOptions, Func<TLocal> localInit, Func<TSource, ParallelLoopState, long, TLocal, TLocal> body, Action<TLocal> localFinally)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (localInit == null)
		{
			throw new ArgumentNullException("localInit");
		}
		if (localFinally == null)
		{
			throw new ArgumentNullException("localFinally");
		}
		if (parallelOptions == null)
		{
			throw new ArgumentNullException("parallelOptions");
		}
		if (!source.KeysNormalized)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_OrderedPartitionerKeysNotNormalized"));
		}
		return PartitionerForEachWorker(source, parallelOptions, null, null, null, null, body, localInit, localFinally);
	}

	private static ParallelLoopResult PartitionerForEachWorker<TSource, TLocal>(Partitioner<TSource> source, ParallelOptions parallelOptions, Action<TSource> simpleBody, Action<TSource, ParallelLoopState> bodyWithState, Action<TSource, ParallelLoopState, long> bodyWithStateAndIndex, Func<TSource, ParallelLoopState, TLocal, TLocal> bodyWithStateAndLocal, Func<TSource, ParallelLoopState, long, TLocal, TLocal> bodyWithEverything, Func<TLocal> localInit, Action<TLocal> localFinally)
	{
		OrderablePartitioner<TSource> orderedSource = source as OrderablePartitioner<TSource>;
		if (!source.SupportsDynamicPartitions)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_PartitionerNotDynamic"));
		}
		if (parallelOptions.CancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException(parallelOptions.CancellationToken);
		}
		int forkJoinContextID = 0;
		Task task = null;
		if (TplEtwProvider.Log.IsEnabled())
		{
			forkJoinContextID = Interlocked.Increment(ref s_forkJoinContextID);
			task = Task.InternalCurrent;
			TplEtwProvider.Log.ParallelLoopBegin(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, TplEtwProvider.ForkJoinOperationType.ParallelForEach, 0L, 0L);
		}
		ParallelLoopStateFlags64 sharedPStateFlags = new ParallelLoopStateFlags64();
		ParallelLoopResult result = default(ParallelLoopResult);
		OperationCanceledException oce = null;
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		if (parallelOptions.CancellationToken.CanBeCanceled)
		{
			cancellationTokenRegistration = parallelOptions.CancellationToken.InternalRegisterWithoutEC(delegate
			{
				sharedPStateFlags.Cancel();
				oce = new OperationCanceledException(parallelOptions.CancellationToken);
			}, null);
		}
		IEnumerable<TSource> partitionerSource = null;
		IEnumerable<KeyValuePair<long, TSource>> orderablePartitionerSource = null;
		if (orderedSource != null)
		{
			orderablePartitionerSource = orderedSource.GetOrderableDynamicPartitions();
			if (orderablePartitionerSource == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_PartitionerReturnedNull"));
			}
		}
		else
		{
			partitionerSource = source.GetDynamicPartitions();
			if (partitionerSource == null)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_PartitionerReturnedNull"));
			}
		}
		ParallelForReplicatingTask rootTask = null;
		Action action = delegate
		{
			Task internalCurrent = Task.InternalCurrent;
			if (TplEtwProvider.Log.IsEnabled())
			{
				TplEtwProvider.Log.ParallelFork(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, forkJoinContextID);
			}
			TLocal val = default(TLocal);
			bool flag = false;
			IDisposable disposable2 = null;
			try
			{
				ParallelLoopState64 parallelLoopState = null;
				if (bodyWithState != null || bodyWithStateAndIndex != null)
				{
					parallelLoopState = new ParallelLoopState64(sharedPStateFlags);
				}
				else if (bodyWithStateAndLocal != null || bodyWithEverything != null)
				{
					parallelLoopState = new ParallelLoopState64(sharedPStateFlags);
					if (localInit != null)
					{
						val = localInit();
						flag = true;
					}
				}
				bool flag2 = rootTask == internalCurrent;
				LoopTimer loopTimer = new LoopTimer(rootTask.ActiveChildCount);
				if (orderedSource != null)
				{
					IEnumerator<KeyValuePair<long, TSource>> enumerator = internalCurrent.SavedStateFromPreviousReplica as IEnumerator<KeyValuePair<long, TSource>>;
					if (enumerator == null)
					{
						enumerator = orderablePartitionerSource.GetEnumerator();
						if (enumerator == null)
						{
							throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_NullEnumerator"));
						}
					}
					disposable2 = enumerator;
					while (enumerator.MoveNext())
					{
						KeyValuePair<long, TSource> current = enumerator.Current;
						long key = current.Key;
						TSource value = current.Value;
						if (parallelLoopState != null)
						{
							parallelLoopState.CurrentIteration = key;
						}
						if (simpleBody != null)
						{
							simpleBody(value);
						}
						else if (bodyWithState != null)
						{
							bodyWithState(value, parallelLoopState);
						}
						else if (bodyWithStateAndIndex == null)
						{
							val = ((bodyWithStateAndLocal == null) ? bodyWithEverything(value, parallelLoopState, key, val) : bodyWithStateAndLocal(value, parallelLoopState, val));
						}
						else
						{
							bodyWithStateAndIndex(value, parallelLoopState, key);
						}
						if (sharedPStateFlags.ShouldExitLoop(key))
						{
							break;
						}
						if (!flag2 && loopTimer.LimitExceeded())
						{
							internalCurrent.SavedStateForNextReplica = enumerator;
							disposable2 = null;
							break;
						}
					}
				}
				else
				{
					IEnumerator<TSource> enumerator2 = internalCurrent.SavedStateFromPreviousReplica as IEnumerator<TSource>;
					if (enumerator2 == null)
					{
						enumerator2 = partitionerSource.GetEnumerator();
						if (enumerator2 == null)
						{
							throw new InvalidOperationException(Environment.GetResourceString("Parallel_ForEach_NullEnumerator"));
						}
					}
					disposable2 = enumerator2;
					if (parallelLoopState != null)
					{
						parallelLoopState.CurrentIteration = 0L;
					}
					while (enumerator2.MoveNext())
					{
						TSource current2 = enumerator2.Current;
						if (simpleBody != null)
						{
							simpleBody(current2);
						}
						else if (bodyWithState != null)
						{
							bodyWithState(current2, parallelLoopState);
						}
						else if (bodyWithStateAndLocal != null)
						{
							val = bodyWithStateAndLocal(current2, parallelLoopState, val);
						}
						if (sharedPStateFlags.LoopStateFlags != ParallelLoopStateFlags.PLS_NONE)
						{
							break;
						}
						if (!flag2 && loopTimer.LimitExceeded())
						{
							internalCurrent.SavedStateForNextReplica = enumerator2;
							disposable2 = null;
							break;
						}
					}
				}
			}
			catch
			{
				sharedPStateFlags.SetExceptional();
				throw;
			}
			finally
			{
				if (localFinally != null && flag)
				{
					localFinally(val);
				}
				disposable2?.Dispose();
				if (TplEtwProvider.Log.IsEnabled())
				{
					TplEtwProvider.Log.ParallelJoin(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, forkJoinContextID);
				}
			}
		};
		try
		{
			rootTask = new ParallelForReplicatingTask(parallelOptions, action, TaskCreationOptions.None, InternalTaskOptions.SelfReplicating);
			rootTask.RunSynchronously(parallelOptions.EffectiveTaskScheduler);
			rootTask.Wait();
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			if (oce != null)
			{
				throw oce;
			}
		}
		catch (AggregateException ex)
		{
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			ThrowIfReducableToSingleOCE(ex.InnerExceptions, parallelOptions.CancellationToken);
			throw;
		}
		catch (TaskSchedulerException)
		{
			if (parallelOptions.CancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration.Dispose();
			}
			throw;
		}
		finally
		{
			int loopStateFlags = sharedPStateFlags.LoopStateFlags;
			result.m_completed = loopStateFlags == ParallelLoopStateFlags.PLS_NONE;
			if ((loopStateFlags & ParallelLoopStateFlags.PLS_BROKEN) != 0)
			{
				result.m_lowestBreakIteration = sharedPStateFlags.LowestBreakIteration;
			}
			if (rootTask != null && rootTask.IsCompleted)
			{
				rootTask.Dispose();
			}
			IDisposable disposable = null;
			((orderablePartitionerSource == null) ? (partitionerSource as IDisposable) : (orderablePartitionerSource as IDisposable))?.Dispose();
			if (TplEtwProvider.Log.IsEnabled())
			{
				TplEtwProvider.Log.ParallelLoopEnd(task?.m_taskScheduler.Id ?? TaskScheduler.Current.Id, task?.Id ?? 0, forkJoinContextID, 0L);
			}
		}
		return result;
	}

	internal static void ThrowIfReducableToSingleOCE(IEnumerable<Exception> excCollection, CancellationToken ct)
	{
		bool flag = false;
		if (!ct.IsCancellationRequested)
		{
			return;
		}
		foreach (Exception item in excCollection)
		{
			flag = true;
			if (!(item is OperationCanceledException ex) || ex.CancellationToken != ct)
			{
				return;
			}
		}
		if (flag)
		{
			throw new OperationCanceledException(ct);
		}
	}
}
