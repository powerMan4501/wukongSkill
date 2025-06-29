using System.Security;

namespace System.Threading;

public class HostExecutionContext : IDisposable
{
	private object state;

	protected internal object State
	{
		get
		{
			return state;
		}
		set
		{
			state = value;
		}
	}

	public HostExecutionContext()
	{
	}

	public HostExecutionContext(object state)
	{
		this.state = state;
	}

	[SecuritySafeCritical]
	public virtual HostExecutionContext CreateCopy()
	{
		object obj = state;
		if (state is IUnknownSafeHandle)
		{
			obj = ((IUnknownSafeHandle)state).Clone();
		}
		return new HostExecutionContext(state);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
	}
}
