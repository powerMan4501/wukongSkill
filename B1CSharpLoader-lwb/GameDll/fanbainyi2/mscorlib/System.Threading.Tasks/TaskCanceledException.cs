using System.Runtime.Serialization;

namespace System.Threading.Tasks;

[Serializable]
[__DynamicallyInvokable]
public class TaskCanceledException : OperationCanceledException
{
	[NonSerialized]
	private Task m_canceledTask;

	[__DynamicallyInvokable]
	public Task Task
	{
		[__DynamicallyInvokable]
		get
		{
			return m_canceledTask;
		}
	}

	[__DynamicallyInvokable]
	public TaskCanceledException()
		: base(Environment.GetResourceString("TaskCanceledException_ctor_DefaultMessage"))
	{
	}

	[__DynamicallyInvokable]
	public TaskCanceledException(string message)
		: base(message)
	{
	}

	[__DynamicallyInvokable]
	public TaskCanceledException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[__DynamicallyInvokable]
	public TaskCanceledException(Task task)
		: base(Environment.GetResourceString("TaskCanceledException_ctor_DefaultMessage"), task?.CancellationToken ?? default(CancellationToken))
	{
		m_canceledTask = task;
	}

	protected TaskCanceledException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
