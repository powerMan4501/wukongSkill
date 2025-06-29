namespace System.Threading.Tasks;

[__DynamicallyInvokable]
public class UnobservedTaskExceptionEventArgs : EventArgs
{
	private AggregateException m_exception;

	internal bool m_observed;

	[__DynamicallyInvokable]
	public bool Observed
	{
		[__DynamicallyInvokable]
		get
		{
			return m_observed;
		}
	}

	[__DynamicallyInvokable]
	public AggregateException Exception
	{
		[__DynamicallyInvokable]
		get
		{
			return m_exception;
		}
	}

	[__DynamicallyInvokable]
	public UnobservedTaskExceptionEventArgs(AggregateException exception)
	{
		m_exception = exception;
	}

	[__DynamicallyInvokable]
	public void SetObserved()
	{
		m_observed = true;
	}
}
