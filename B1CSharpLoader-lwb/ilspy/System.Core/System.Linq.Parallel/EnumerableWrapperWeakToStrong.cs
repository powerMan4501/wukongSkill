using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class EnumerableWrapperWeakToStrong : IEnumerable<object>, IEnumerable
{
	private class WrapperEnumeratorWeakToStrong : IEnumerator<object>, IDisposable, IEnumerator
	{
		private IEnumerator m_wrappedEnumerator;

		object IEnumerator.Current => m_wrappedEnumerator.Current;

		object IEnumerator<object>.Current => m_wrappedEnumerator.Current;

		internal WrapperEnumeratorWeakToStrong(IEnumerator wrappedEnumerator)
		{
			m_wrappedEnumerator = wrappedEnumerator;
		}

		void IDisposable.Dispose()
		{
			if (m_wrappedEnumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}

		bool IEnumerator.MoveNext()
		{
			return m_wrappedEnumerator.MoveNext();
		}

		void IEnumerator.Reset()
		{
			m_wrappedEnumerator.Reset();
		}
	}

	private readonly IEnumerable m_wrappedEnumerable;

	internal EnumerableWrapperWeakToStrong(IEnumerable wrappedEnumerable)
	{
		m_wrappedEnumerable = wrappedEnumerable;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<object>)this).GetEnumerator();
	}

	public IEnumerator<object> GetEnumerator()
	{
		return new WrapperEnumeratorWeakToStrong(m_wrappedEnumerable.GetEnumerator());
	}
}
