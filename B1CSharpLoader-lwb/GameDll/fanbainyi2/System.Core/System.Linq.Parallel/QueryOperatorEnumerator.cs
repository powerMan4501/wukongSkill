using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal abstract class QueryOperatorEnumerator<TElement, TKey>
{
	private class QueryOperatorClassicEnumerator : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		private QueryOperatorEnumerator<TElement, TKey> m_operatorEnumerator;

		private TElement m_current;

		public TElement Current => m_current;

		object IEnumerator.Current => m_current;

		internal QueryOperatorClassicEnumerator(QueryOperatorEnumerator<TElement, TKey> operatorEnumerator)
		{
			m_operatorEnumerator = operatorEnumerator;
		}

		public bool MoveNext()
		{
			TKey currentKey = default(TKey);
			return m_operatorEnumerator.MoveNext(ref m_current, ref currentKey);
		}

		public void Dispose()
		{
			m_operatorEnumerator.Dispose();
			m_operatorEnumerator = null;
		}

		public void Reset()
		{
			m_operatorEnumerator.Reset();
		}
	}

	internal abstract bool MoveNext(ref TElement currentElement, ref TKey currentKey);

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal virtual void Reset()
	{
	}

	internal IEnumerator<TElement> AsClassicEnumerator()
	{
		return new QueryOperatorClassicEnumerator(this);
	}
}
