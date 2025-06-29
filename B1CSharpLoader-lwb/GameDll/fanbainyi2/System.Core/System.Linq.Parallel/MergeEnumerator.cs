using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal abstract class MergeEnumerator<TInputOutput> : IEnumerator<TInputOutput>, IDisposable, IEnumerator
{
	protected QueryTaskGroupState m_taskGroupState;

	public abstract TInputOutput Current { get; }

	object IEnumerator.Current => ((IEnumerator<TInputOutput>)this).Current;

	protected MergeEnumerator(QueryTaskGroupState taskGroupState)
	{
		m_taskGroupState = taskGroupState;
	}

	public abstract bool MoveNext();

	public virtual void Reset()
	{
	}

	public virtual void Dispose()
	{
		if (!m_taskGroupState.IsAlreadyEnded)
		{
			m_taskGroupState.QueryEnd(userInitiatedDispose: true);
		}
	}
}
