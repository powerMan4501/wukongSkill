using System.Threading;
using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal class QueryTaskGroupState
{
	private Task m_rootTask;

	private int m_alreadyEnded;

	private CancellationState m_cancellationState;

	private int m_queryId;

	internal bool IsAlreadyEnded => m_alreadyEnded == 1;

	internal CancellationState CancellationState => m_cancellationState;

	internal int QueryId => m_queryId;

	internal QueryTaskGroupState(CancellationState cancellationState, int queryId)
	{
		m_cancellationState = cancellationState;
		m_queryId = queryId;
	}

	internal void QueryBegin(Task rootTask)
	{
		m_rootTask = rootTask;
	}

	internal void QueryEnd(bool userInitiatedDispose)
	{
		if (Interlocked.Exchange(ref m_alreadyEnded, 1) != 0)
		{
			return;
		}
		try
		{
			m_rootTask.Wait();
		}
		catch (AggregateException ex)
		{
			AggregateException ex2 = ex.Flatten();
			bool flag = true;
			for (int i = 0; i < ex2.InnerExceptions.Count; i++)
			{
				if (!(ex2.InnerExceptions[i] is OperationCanceledException { CancellationToken: { IsCancellationRequested: not false } } ex3) || ex3.CancellationToken != m_cancellationState.ExternalCancellationToken)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				throw ex2;
			}
		}
		finally
		{
			m_rootTask.Dispose();
		}
		if (m_cancellationState.MergedCancellationToken.IsCancellationRequested)
		{
			if (!m_cancellationState.TopLevelDisposedFlag.Value)
			{
				CancellationState.ThrowWithStandardMessageIfCanceled(m_cancellationState.ExternalCancellationToken);
			}
			if (!userInitiatedDispose)
			{
				throw new ObjectDisposedException("enumerator", SR.GetString("PLINQ_DisposeRequested"));
			}
		}
	}
}
