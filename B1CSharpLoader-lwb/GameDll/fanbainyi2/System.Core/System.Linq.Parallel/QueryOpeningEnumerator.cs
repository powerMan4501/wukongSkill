using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class QueryOpeningEnumerator<TOutput> : IEnumerator<TOutput>, IDisposable, IEnumerator
{
	private readonly QueryOperator<TOutput> m_queryOperator;

	private IEnumerator<TOutput> m_openedQueryEnumerator;

	private QuerySettings m_querySettings;

	private readonly ParallelMergeOptions? m_mergeOptions;

	private readonly bool m_suppressOrderPreservation;

	private int m_moveNextIteration;

	private bool m_hasQueryOpeningFailed;

	private readonly Shared<bool> m_topLevelDisposedFlag = new Shared<bool>(value: false);

	private readonly CancellationTokenSource m_topLevelCancellationTokenSource = new CancellationTokenSource();

	public TOutput Current
	{
		get
		{
			if (m_openedQueryEnumerator == null)
			{
				throw new InvalidOperationException(SR.GetString("PLINQ_CommonEnumerator_Current_NotStarted"));
			}
			return m_openedQueryEnumerator.Current;
		}
	}

	object IEnumerator.Current => ((IEnumerator<TOutput>)this).Current;

	internal QueryOpeningEnumerator(QueryOperator<TOutput> queryOperator, ParallelMergeOptions? mergeOptions, bool suppressOrderPreservation)
	{
		m_queryOperator = queryOperator;
		m_mergeOptions = mergeOptions;
		m_suppressOrderPreservation = suppressOrderPreservation;
	}

	public void Dispose()
	{
		m_topLevelDisposedFlag.Value = true;
		m_topLevelCancellationTokenSource.Cancel();
		if (m_openedQueryEnumerator != null)
		{
			m_openedQueryEnumerator.Dispose();
			m_querySettings.CleanStateAtQueryEnd();
		}
		QueryLifecycle.LogicalQueryExecutionEnd(m_querySettings.QueryId);
	}

	public bool MoveNext()
	{
		if (m_topLevelDisposedFlag.Value)
		{
			throw new ObjectDisposedException("enumerator", SR.GetString("PLINQ_DisposeRequested"));
		}
		if (m_openedQueryEnumerator == null)
		{
			OpenQuery();
		}
		bool result = m_openedQueryEnumerator.MoveNext();
		if ((m_moveNextIteration & 0x3F) == 0)
		{
			CancellationState.ThrowWithStandardMessageIfCanceled(m_querySettings.CancellationState.ExternalCancellationToken);
		}
		m_moveNextIteration++;
		return result;
	}

	private void OpenQuery()
	{
		if (m_hasQueryOpeningFailed)
		{
			throw new InvalidOperationException(SR.GetString("PLINQ_EnumerationPreviouslyFailed"));
		}
		try
		{
			m_querySettings = m_queryOperator.SpecifiedQuerySettings.WithPerExecutionSettings(m_topLevelCancellationTokenSource, m_topLevelDisposedFlag).WithDefaults();
			QueryLifecycle.LogicalQueryExecutionBegin(m_querySettings.QueryId);
			m_openedQueryEnumerator = m_queryOperator.GetOpenedEnumerator(m_mergeOptions, m_suppressOrderPreservation, forEffect: false, m_querySettings);
			CancellationState.ThrowWithStandardMessageIfCanceled(m_querySettings.CancellationState.ExternalCancellationToken);
		}
		catch
		{
			m_hasQueryOpeningFailed = true;
			throw;
		}
	}

	public void Reset()
	{
		throw new NotSupportedException();
	}
}
