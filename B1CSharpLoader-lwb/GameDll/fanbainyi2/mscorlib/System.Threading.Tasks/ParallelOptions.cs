namespace System.Threading.Tasks;

[__DynamicallyInvokable]
public class ParallelOptions
{
	private TaskScheduler m_scheduler;

	private int m_maxDegreeOfParallelism;

	private CancellationToken m_cancellationToken;

	[__DynamicallyInvokable]
	public TaskScheduler TaskScheduler
	{
		[__DynamicallyInvokable]
		get
		{
			return m_scheduler;
		}
		[__DynamicallyInvokable]
		set
		{
			m_scheduler = value;
		}
	}

	internal TaskScheduler EffectiveTaskScheduler
	{
		get
		{
			if (m_scheduler == null)
			{
				return TaskScheduler.Current;
			}
			return m_scheduler;
		}
	}

	[__DynamicallyInvokable]
	public int MaxDegreeOfParallelism
	{
		[__DynamicallyInvokable]
		get
		{
			return m_maxDegreeOfParallelism;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == 0 || value < -1)
			{
				throw new ArgumentOutOfRangeException("MaxDegreeOfParallelism");
			}
			m_maxDegreeOfParallelism = value;
		}
	}

	[__DynamicallyInvokable]
	public CancellationToken CancellationToken
	{
		[__DynamicallyInvokable]
		get
		{
			return m_cancellationToken;
		}
		[__DynamicallyInvokable]
		set
		{
			m_cancellationToken = value;
		}
	}

	internal int EffectiveMaxConcurrencyLevel
	{
		get
		{
			int num = MaxDegreeOfParallelism;
			int maximumConcurrencyLevel = EffectiveTaskScheduler.MaximumConcurrencyLevel;
			if (maximumConcurrencyLevel > 0 && maximumConcurrencyLevel != int.MaxValue)
			{
				num = ((num == -1) ? maximumConcurrencyLevel : Math.Min(maximumConcurrencyLevel, num));
			}
			return num;
		}
	}

	[__DynamicallyInvokable]
	public ParallelOptions()
	{
		m_scheduler = TaskScheduler.Default;
		m_maxDegreeOfParallelism = -1;
		m_cancellationToken = CancellationToken.None;
	}
}
