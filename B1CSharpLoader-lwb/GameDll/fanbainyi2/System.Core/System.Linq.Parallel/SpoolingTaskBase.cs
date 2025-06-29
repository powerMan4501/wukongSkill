namespace System.Linq.Parallel;

internal abstract class SpoolingTaskBase : QueryTask
{
	protected SpoolingTaskBase(int taskIndex, QueryTaskGroupState groupState)
		: base(taskIndex, groupState)
	{
	}

	protected override void Work()
	{
		try
		{
			SpoolingWork();
		}
		catch (Exception ex)
		{
			if (!(ex is OperationCanceledException ex2) || !(ex2.CancellationToken == m_groupState.CancellationState.MergedCancellationToken) || !m_groupState.CancellationState.MergedCancellationToken.IsCancellationRequested)
			{
				m_groupState.CancellationState.InternalCancellationTokenSource.Cancel();
				throw;
			}
		}
		finally
		{
			SpoolingFinally();
		}
	}

	protected abstract void SpoolingWork();

	protected virtual void SpoolingFinally()
	{
	}
}
