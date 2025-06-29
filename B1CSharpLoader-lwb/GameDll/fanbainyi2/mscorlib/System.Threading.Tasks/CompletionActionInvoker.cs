using System.Security;

namespace System.Threading.Tasks;

internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	private readonly ITaskCompletionAction m_action;

	private readonly Task m_completingTask;

	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask)
	{
		m_action = action;
		m_completingTask = completingTask;
	}

	[SecurityCritical]
	public void ExecuteWorkItem()
	{
		m_action.Invoke(m_completingTask);
	}

	[SecurityCritical]
	public void MarkAborted(ThreadAbortException tae)
	{
	}
}
