using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Security.Permissions;

namespace System.Threading.Tasks;

[DebuggerDisplay("Concurrent={ConcurrentTaskCountForDebugger}, Exclusive={ExclusiveTaskCountForDebugger}, Mode={ModeForDebugger}")]
[DebuggerTypeProxy(typeof(DebugView))]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class ConcurrentExclusiveSchedulerPair
{
	private sealed class CompletionState : TaskCompletionSource<VoidTaskResult>
	{
		internal bool m_completionRequested;

		internal bool m_completionQueued;

		internal List<Exception> m_exceptions;
	}

	[DebuggerDisplay("Count={CountForDebugger}, MaxConcurrencyLevel={m_maxConcurrencyLevel}, Id={Id}")]
	[DebuggerTypeProxy(typeof(DebugView))]
	private sealed class ConcurrentExclusiveTaskScheduler : TaskScheduler
	{
		private sealed class DebugView
		{
			private readonly ConcurrentExclusiveTaskScheduler m_taskScheduler;

			public int MaximumConcurrencyLevel => m_taskScheduler.m_maxConcurrencyLevel;

			public IEnumerable<Task> ScheduledTasks => m_taskScheduler.m_tasks;

			public ConcurrentExclusiveSchedulerPair SchedulerPair => m_taskScheduler.m_pair;

			public DebugView(ConcurrentExclusiveTaskScheduler scheduler)
			{
				m_taskScheduler = scheduler;
			}
		}

		private static readonly Func<object, bool> s_tryExecuteTaskShim = TryExecuteTaskShim;

		private readonly ConcurrentExclusiveSchedulerPair m_pair;

		private readonly int m_maxConcurrencyLevel;

		private readonly ProcessingMode m_processingMode;

		internal readonly IProducerConsumerQueue<Task> m_tasks;

		public override int MaximumConcurrencyLevel => m_maxConcurrencyLevel;

		private int CountForDebugger => m_tasks.Count;

		internal ConcurrentExclusiveTaskScheduler(ConcurrentExclusiveSchedulerPair pair, int maxConcurrencyLevel, ProcessingMode processingMode)
		{
			m_pair = pair;
			m_maxConcurrencyLevel = maxConcurrencyLevel;
			m_processingMode = processingMode;
			IProducerConsumerQueue<Task> tasks;
			if (processingMode != ProcessingMode.ProcessingExclusiveTask)
			{
				IProducerConsumerQueue<Task> producerConsumerQueue = new MultiProducerMultiConsumerQueue<Task>();
				tasks = producerConsumerQueue;
			}
			else
			{
				IProducerConsumerQueue<Task> producerConsumerQueue = new SingleProducerSingleConsumerQueue<Task>();
				tasks = producerConsumerQueue;
			}
			m_tasks = tasks;
		}

		[SecurityCritical]
		protected internal override void QueueTask(Task task)
		{
			lock (m_pair.ValueLock)
			{
				if (m_pair.CompletionRequested)
				{
					throw new InvalidOperationException(GetType().Name);
				}
				m_tasks.Enqueue(task);
				m_pair.ProcessAsyncIfNecessary();
			}
		}

		[SecuritySafeCritical]
		internal void ExecuteTask(Task task)
		{
			TryExecuteTask(task);
		}

		[SecurityCritical]
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			if (!taskWasPreviouslyQueued && m_pair.CompletionRequested)
			{
				return false;
			}
			bool flag = m_pair.m_underlyingTaskScheduler == TaskScheduler.Default;
			if (flag && taskWasPreviouslyQueued && !Thread.CurrentThread.IsThreadPoolThread)
			{
				return false;
			}
			if (m_pair.m_threadProcessingMapping.TryGetValue(Thread.CurrentThread.ManagedThreadId, out var value) && value == m_processingMode)
			{
				if (!flag || taskWasPreviouslyQueued)
				{
					return TryExecuteTaskInlineOnTargetScheduler(task);
				}
				return TryExecuteTask(task);
			}
			return false;
		}

		private bool TryExecuteTaskInlineOnTargetScheduler(Task task)
		{
			Task<bool> task2 = new Task<bool>(s_tryExecuteTaskShim, Tuple.Create(this, task));
			try
			{
				task2.RunSynchronously(m_pair.m_underlyingTaskScheduler);
				return task2.Result;
			}
			catch
			{
				AggregateException exception = task2.Exception;
				throw;
			}
			finally
			{
				task2.Dispose();
			}
		}

		[SecuritySafeCritical]
		private static bool TryExecuteTaskShim(object state)
		{
			Tuple<ConcurrentExclusiveTaskScheduler, Task> tuple = (Tuple<ConcurrentExclusiveTaskScheduler, Task>)state;
			return tuple.Item1.TryExecuteTask(tuple.Item2);
		}

		[SecurityCritical]
		protected override IEnumerable<Task> GetScheduledTasks()
		{
			return m_tasks;
		}
	}

	private sealed class DebugView
	{
		private readonly ConcurrentExclusiveSchedulerPair m_pair;

		public ProcessingMode Mode => m_pair.ModeForDebugger;

		public IEnumerable<Task> ScheduledExclusive => m_pair.m_exclusiveTaskScheduler.m_tasks;

		public IEnumerable<Task> ScheduledConcurrent => m_pair.m_concurrentTaskScheduler.m_tasks;

		public int CurrentlyExecutingTaskCount
		{
			get
			{
				if (m_pair.m_processingCount != -1)
				{
					return m_pair.m_processingCount;
				}
				return 1;
			}
		}

		public TaskScheduler TargetScheduler => m_pair.m_underlyingTaskScheduler;

		public DebugView(ConcurrentExclusiveSchedulerPair pair)
		{
			m_pair = pair;
		}
	}

	[Flags]
	private enum ProcessingMode : byte
	{
		NotCurrentlyProcessing = 0,
		ProcessingExclusiveTask = 1,
		ProcessingConcurrentTasks = 2,
		Completing = 4,
		Completed = 8
	}

	private readonly ConcurrentDictionary<int, ProcessingMode> m_threadProcessingMapping = new ConcurrentDictionary<int, ProcessingMode>();

	private readonly ConcurrentExclusiveTaskScheduler m_concurrentTaskScheduler;

	private readonly ConcurrentExclusiveTaskScheduler m_exclusiveTaskScheduler;

	private readonly TaskScheduler m_underlyingTaskScheduler;

	private readonly int m_maxConcurrencyLevel;

	private readonly int m_maxItemsPerTask;

	private int m_processingCount;

	private CompletionState m_completionState;

	private const int UNLIMITED_PROCESSING = -1;

	private const int EXCLUSIVE_PROCESSING_SENTINEL = -1;

	private const int DEFAULT_MAXITEMSPERTASK = -1;

	private static int DefaultMaxConcurrencyLevel => Environment.ProcessorCount;

	private object ValueLock => m_threadProcessingMapping;

	[__DynamicallyInvokable]
	public Task Completion
	{
		[__DynamicallyInvokable]
		get
		{
			return EnsureCompletionStateInitialized().Task;
		}
	}

	private bool CompletionRequested
	{
		get
		{
			if (m_completionState != null)
			{
				return Volatile.Read(ref m_completionState.m_completionRequested);
			}
			return false;
		}
	}

	private bool ReadyToComplete
	{
		get
		{
			if (!CompletionRequested || m_processingCount != 0)
			{
				return false;
			}
			CompletionState completionState = EnsureCompletionStateInitialized();
			if (completionState.m_exceptions == null || completionState.m_exceptions.Count <= 0)
			{
				if (m_concurrentTaskScheduler.m_tasks.IsEmpty)
				{
					return m_exclusiveTaskScheduler.m_tasks.IsEmpty;
				}
				return false;
			}
			return true;
		}
	}

	[__DynamicallyInvokable]
	public TaskScheduler ConcurrentScheduler
	{
		[__DynamicallyInvokable]
		get
		{
			return m_concurrentTaskScheduler;
		}
	}

	[__DynamicallyInvokable]
	public TaskScheduler ExclusiveScheduler
	{
		[__DynamicallyInvokable]
		get
		{
			return m_exclusiveTaskScheduler;
		}
	}

	private int ConcurrentTaskCountForDebugger => m_concurrentTaskScheduler.m_tasks.Count;

	private int ExclusiveTaskCountForDebugger => m_exclusiveTaskScheduler.m_tasks.Count;

	private ProcessingMode ModeForDebugger
	{
		get
		{
			if (m_completionState != null && m_completionState.Task.IsCompleted)
			{
				return ProcessingMode.Completed;
			}
			ProcessingMode processingMode = ProcessingMode.NotCurrentlyProcessing;
			if (m_processingCount == -1)
			{
				processingMode |= ProcessingMode.ProcessingExclusiveTask;
			}
			if (m_processingCount >= 1)
			{
				processingMode |= ProcessingMode.ProcessingConcurrentTasks;
			}
			if (CompletionRequested)
			{
				processingMode |= ProcessingMode.Completing;
			}
			return processingMode;
		}
	}

	[__DynamicallyInvokable]
	public ConcurrentExclusiveSchedulerPair()
		: this(TaskScheduler.Default, DefaultMaxConcurrencyLevel, -1)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler)
		: this(taskScheduler, DefaultMaxConcurrencyLevel, -1)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel)
		: this(taskScheduler, maxConcurrencyLevel, -1)
	{
	}

	[__DynamicallyInvokable]
	public ConcurrentExclusiveSchedulerPair(TaskScheduler taskScheduler, int maxConcurrencyLevel, int maxItemsPerTask)
	{
		if (taskScheduler == null)
		{
			throw new ArgumentNullException("taskScheduler");
		}
		if (maxConcurrencyLevel == 0 || maxConcurrencyLevel < -1)
		{
			throw new ArgumentOutOfRangeException("maxConcurrencyLevel");
		}
		if (maxItemsPerTask == 0 || maxItemsPerTask < -1)
		{
			throw new ArgumentOutOfRangeException("maxItemsPerTask");
		}
		m_underlyingTaskScheduler = taskScheduler;
		m_maxConcurrencyLevel = maxConcurrencyLevel;
		m_maxItemsPerTask = maxItemsPerTask;
		int maximumConcurrencyLevel = taskScheduler.MaximumConcurrencyLevel;
		if (maximumConcurrencyLevel > 0 && maximumConcurrencyLevel < m_maxConcurrencyLevel)
		{
			m_maxConcurrencyLevel = maximumConcurrencyLevel;
		}
		if (m_maxConcurrencyLevel == -1)
		{
			m_maxConcurrencyLevel = int.MaxValue;
		}
		if (m_maxItemsPerTask == -1)
		{
			m_maxItemsPerTask = int.MaxValue;
		}
		m_exclusiveTaskScheduler = new ConcurrentExclusiveTaskScheduler(this, 1, ProcessingMode.ProcessingExclusiveTask);
		m_concurrentTaskScheduler = new ConcurrentExclusiveTaskScheduler(this, m_maxConcurrencyLevel, ProcessingMode.ProcessingConcurrentTasks);
	}

	[__DynamicallyInvokable]
	public void Complete()
	{
		lock (ValueLock)
		{
			if (!CompletionRequested)
			{
				RequestCompletion();
				CleanupStateIfCompletingAndQuiesced();
			}
		}
	}

	private CompletionState EnsureCompletionStateInitialized()
	{
		return LazyInitializer.EnsureInitialized(ref m_completionState, () => new CompletionState());
	}

	private void RequestCompletion()
	{
		EnsureCompletionStateInitialized().m_completionRequested = true;
	}

	private void CleanupStateIfCompletingAndQuiesced()
	{
		if (ReadyToComplete)
		{
			CompleteTaskAsync();
		}
	}

	private void CompleteTaskAsync()
	{
		CompletionState completionState = EnsureCompletionStateInitialized();
		if (!completionState.m_completionQueued)
		{
			completionState.m_completionQueued = true;
			ThreadPool.QueueUserWorkItem(delegate(object state)
			{
				CompletionState completionState2 = (CompletionState)state;
				List<Exception> exceptions = completionState2.m_exceptions;
				bool flag = ((exceptions != null && exceptions.Count > 0) ? completionState2.TrySetException(exceptions) : completionState2.TrySetResult(default(VoidTaskResult)));
			}, completionState);
		}
	}

	private void FaultWithTask(Task faultedTask)
	{
		CompletionState completionState = EnsureCompletionStateInitialized();
		if (completionState.m_exceptions == null)
		{
			completionState.m_exceptions = new List<Exception>();
		}
		completionState.m_exceptions.AddRange(faultedTask.Exception.InnerExceptions);
		RequestCompletion();
	}

	private void ProcessAsyncIfNecessary(bool fairly = false)
	{
		if (m_processingCount < 0)
		{
			return;
		}
		bool flag = !m_exclusiveTaskScheduler.m_tasks.IsEmpty;
		Task task = null;
		if (m_processingCount == 0 && flag)
		{
			m_processingCount = -1;
			try
			{
				task = new Task(delegate(object thisPair)
				{
					((ConcurrentExclusiveSchedulerPair)thisPair).ProcessExclusiveTasks();
				}, this, default(CancellationToken), GetCreationOptionsForTask(fairly));
				task.Start(m_underlyingTaskScheduler);
			}
			catch
			{
				m_processingCount = 0;
				FaultWithTask(task);
			}
		}
		else
		{
			int count = m_concurrentTaskScheduler.m_tasks.Count;
			if (count > 0 && !flag && m_processingCount < m_maxConcurrencyLevel)
			{
				for (int num = 0; num < count; num++)
				{
					if (m_processingCount >= m_maxConcurrencyLevel)
					{
						break;
					}
					m_processingCount++;
					try
					{
						task = new Task(delegate(object thisPair)
						{
							((ConcurrentExclusiveSchedulerPair)thisPair).ProcessConcurrentTasks();
						}, this, default(CancellationToken), GetCreationOptionsForTask(fairly));
						task.Start(m_underlyingTaskScheduler);
					}
					catch
					{
						m_processingCount--;
						FaultWithTask(task);
					}
				}
			}
		}
		CleanupStateIfCompletingAndQuiesced();
	}

	private void ProcessExclusiveTasks()
	{
		try
		{
			m_threadProcessingMapping[Thread.CurrentThread.ManagedThreadId] = ProcessingMode.ProcessingExclusiveTask;
			for (int i = 0; i < m_maxItemsPerTask; i++)
			{
				if (!m_exclusiveTaskScheduler.m_tasks.TryDequeue(out var result))
				{
					break;
				}
				if (!result.IsFaulted)
				{
					m_exclusiveTaskScheduler.ExecuteTask(result);
				}
			}
		}
		finally
		{
			m_threadProcessingMapping.TryRemove(Thread.CurrentThread.ManagedThreadId, out var _);
			lock (ValueLock)
			{
				m_processingCount = 0;
				ProcessAsyncIfNecessary(fairly: true);
			}
		}
	}

	private void ProcessConcurrentTasks()
	{
		try
		{
			m_threadProcessingMapping[Thread.CurrentThread.ManagedThreadId] = ProcessingMode.ProcessingConcurrentTasks;
			for (int i = 0; i < m_maxItemsPerTask; i++)
			{
				if (!m_concurrentTaskScheduler.m_tasks.TryDequeue(out var result))
				{
					break;
				}
				if (!result.IsFaulted)
				{
					m_concurrentTaskScheduler.ExecuteTask(result);
				}
				if (!m_exclusiveTaskScheduler.m_tasks.IsEmpty)
				{
					break;
				}
			}
		}
		finally
		{
			m_threadProcessingMapping.TryRemove(Thread.CurrentThread.ManagedThreadId, out var _);
			lock (ValueLock)
			{
				if (m_processingCount > 0)
				{
					m_processingCount--;
				}
				ProcessAsyncIfNecessary(fairly: true);
			}
		}
	}

	[Conditional("DEBUG")]
	internal static void ContractAssertMonitorStatus(object syncObj, bool held)
	{
	}

	internal static TaskCreationOptions GetCreationOptionsForTask(bool isReplacementReplica = false)
	{
		TaskCreationOptions taskCreationOptions = TaskCreationOptions.DenyChildAttach;
		if (isReplacementReplica)
		{
			taskCreationOptions |= TaskCreationOptions.PreferFairness;
		}
		return taskCreationOptions;
	}
}
