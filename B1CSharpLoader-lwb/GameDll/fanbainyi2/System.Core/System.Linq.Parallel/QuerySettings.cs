using System.Threading;
using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal struct QuerySettings
{
	private TaskScheduler m_taskScheduler;

	private int? m_degreeOfParallelism;

	private CancellationState m_cancellationState;

	private ParallelExecutionMode? m_executionMode;

	private ParallelMergeOptions? m_mergeOptions;

	private int m_queryId;

	internal CancellationState CancellationState
	{
		get
		{
			return m_cancellationState;
		}
		set
		{
			m_cancellationState = value;
		}
	}

	internal TaskScheduler TaskScheduler
	{
		get
		{
			return m_taskScheduler;
		}
		set
		{
			m_taskScheduler = value;
		}
	}

	internal int? DegreeOfParallelism
	{
		get
		{
			return m_degreeOfParallelism;
		}
		set
		{
			m_degreeOfParallelism = value;
		}
	}

	internal ParallelExecutionMode? ExecutionMode
	{
		get
		{
			return m_executionMode;
		}
		set
		{
			m_executionMode = value;
		}
	}

	internal ParallelMergeOptions? MergeOptions
	{
		get
		{
			return m_mergeOptions;
		}
		set
		{
			m_mergeOptions = value;
		}
	}

	internal int QueryId => m_queryId;

	internal static QuerySettings Empty => new QuerySettings(null, null, default(CancellationToken), null, null);

	internal QuerySettings(TaskScheduler taskScheduler, int? degreeOfParallelism, CancellationToken externalCancellationToken, ParallelExecutionMode? executionMode, ParallelMergeOptions? mergeOptions)
	{
		m_taskScheduler = taskScheduler;
		m_degreeOfParallelism = degreeOfParallelism;
		m_cancellationState = new CancellationState(externalCancellationToken);
		m_executionMode = executionMode;
		m_mergeOptions = mergeOptions;
		m_queryId = -1;
	}

	internal QuerySettings Merge(QuerySettings settings2)
	{
		if (TaskScheduler != null && settings2.TaskScheduler != null)
		{
			throw new InvalidOperationException(SR.GetString("ParallelQuery_DuplicateTaskScheduler"));
		}
		if (DegreeOfParallelism.HasValue && settings2.DegreeOfParallelism.HasValue)
		{
			throw new InvalidOperationException(SR.GetString("ParallelQuery_DuplicateDOP"));
		}
		if (CancellationState.ExternalCancellationToken.CanBeCanceled && settings2.CancellationState.ExternalCancellationToken.CanBeCanceled)
		{
			throw new InvalidOperationException(SR.GetString("ParallelQuery_DuplicateWithCancellation"));
		}
		if (ExecutionMode.HasValue && settings2.ExecutionMode.HasValue)
		{
			throw new InvalidOperationException(SR.GetString("ParallelQuery_DuplicateExecutionMode"));
		}
		if (MergeOptions.HasValue && settings2.MergeOptions.HasValue)
		{
			throw new InvalidOperationException(SR.GetString("ParallelQuery_DuplicateMergeOptions"));
		}
		TaskScheduler taskScheduler = ((TaskScheduler == null) ? settings2.TaskScheduler : TaskScheduler);
		int? degreeOfParallelism = (DegreeOfParallelism.HasValue ? DegreeOfParallelism : settings2.DegreeOfParallelism);
		CancellationToken externalCancellationToken = (CancellationState.ExternalCancellationToken.CanBeCanceled ? CancellationState.ExternalCancellationToken : settings2.CancellationState.ExternalCancellationToken);
		ParallelExecutionMode? executionMode = (ExecutionMode.HasValue ? ExecutionMode : settings2.ExecutionMode);
		ParallelMergeOptions? mergeOptions = (MergeOptions.HasValue ? MergeOptions : settings2.MergeOptions);
		return new QuerySettings(taskScheduler, degreeOfParallelism, externalCancellationToken, executionMode, mergeOptions);
	}

	internal QuerySettings WithPerExecutionSettings()
	{
		return WithPerExecutionSettings(new CancellationTokenSource(), new Shared<bool>(value: false));
	}

	internal QuerySettings WithPerExecutionSettings(CancellationTokenSource topLevelCancellationTokenSource, Shared<bool> topLevelDisposedFlag)
	{
		QuerySettings result = new QuerySettings(TaskScheduler, DegreeOfParallelism, CancellationState.ExternalCancellationToken, ExecutionMode, MergeOptions);
		result.CancellationState.InternalCancellationTokenSource = topLevelCancellationTokenSource;
		result.CancellationState.MergedCancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(result.CancellationState.InternalCancellationTokenSource.Token, result.CancellationState.ExternalCancellationToken);
		result.CancellationState.TopLevelDisposedFlag = topLevelDisposedFlag;
		result.m_queryId = PlinqEtwProvider.NextQueryId();
		return result;
	}

	internal QuerySettings WithDefaults()
	{
		QuerySettings result = this;
		if (result.TaskScheduler == null)
		{
			result.TaskScheduler = TaskScheduler.Default;
		}
		if (!result.DegreeOfParallelism.HasValue)
		{
			result.DegreeOfParallelism = Scheduling.GetDefaultDegreeOfParallelism();
		}
		if (!result.ExecutionMode.HasValue)
		{
			result.ExecutionMode = ParallelExecutionMode.Default;
		}
		if (!result.MergeOptions.HasValue)
		{
			result.MergeOptions = ParallelMergeOptions.Default;
		}
		if (result.MergeOptions == ParallelMergeOptions.Default)
		{
			result.MergeOptions = ParallelMergeOptions.AutoBuffered;
		}
		return result;
	}

	public void CleanStateAtQueryEnd()
	{
		m_cancellationState.MergedCancellationTokenSource.Dispose();
	}
}
