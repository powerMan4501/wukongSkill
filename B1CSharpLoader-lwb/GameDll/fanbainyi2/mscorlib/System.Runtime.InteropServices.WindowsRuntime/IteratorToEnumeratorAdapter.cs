using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class IteratorToEnumeratorAdapter<T> : IEnumerator<T>, IDisposable, IEnumerator
{
	private IIterator<T> m_iterator;

	private bool m_hadCurrent;

	private T m_current;

	private bool m_isInitialized;

	public T Current
	{
		get
		{
			if (!m_isInitialized)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
			}
			if (!m_hadCurrent)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
			}
			return m_current;
		}
	}

	object IEnumerator.Current
	{
		get
		{
			if (!m_isInitialized)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumNotStarted);
			}
			if (!m_hadCurrent)
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumEnded);
			}
			return m_current;
		}
	}

	internal IteratorToEnumeratorAdapter(IIterator<T> iterator)
	{
		m_iterator = iterator;
		m_hadCurrent = true;
		m_isInitialized = false;
	}

	[SecuritySafeCritical]
	public bool MoveNext()
	{
		if (!m_hadCurrent)
		{
			return false;
		}
		try
		{
			if (!m_isInitialized)
			{
				m_hadCurrent = m_iterator.HasCurrent;
				m_isInitialized = true;
			}
			else
			{
				m_hadCurrent = m_iterator.MoveNext();
			}
			if (m_hadCurrent)
			{
				m_current = m_iterator.Current;
			}
		}
		catch (Exception e)
		{
			if (Marshal.GetHRForException(e) != -2147483636)
			{
				throw;
			}
			ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_EnumFailedVersion);
		}
		return m_hadCurrent;
	}

	public void Reset()
	{
		throw new NotSupportedException();
	}

	public void Dispose()
	{
	}
}
