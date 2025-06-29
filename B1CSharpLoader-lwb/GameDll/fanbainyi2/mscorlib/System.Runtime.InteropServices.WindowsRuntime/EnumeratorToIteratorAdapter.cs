using System.Collections.Generic;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class EnumeratorToIteratorAdapter<T> : IIterator<T>, IBindableIterator
{
	private IEnumerator<T> m_enumerator;

	private bool m_firstItem = true;

	private bool m_hasCurrent;

	public T Current
	{
		get
		{
			if (m_firstItem)
			{
				m_firstItem = false;
				MoveNext();
			}
			if (!m_hasCurrent)
			{
				throw WindowsRuntimeMarshal.GetExceptionForHR(-2147483637, null);
			}
			return m_enumerator.Current;
		}
	}

	object IBindableIterator.Current => ((IIterator<T>)this).Current;

	public bool HasCurrent
	{
		get
		{
			if (m_firstItem)
			{
				m_firstItem = false;
				MoveNext();
			}
			return m_hasCurrent;
		}
	}

	internal EnumeratorToIteratorAdapter(IEnumerator<T> enumerator)
	{
		m_enumerator = enumerator;
	}

	public bool MoveNext()
	{
		try
		{
			m_hasCurrent = m_enumerator.MoveNext();
		}
		catch (InvalidOperationException innerException)
		{
			throw WindowsRuntimeMarshal.GetExceptionForHR(-2147483636, innerException);
		}
		return m_hasCurrent;
	}

	public int GetMany(T[] items)
	{
		if (items == null)
		{
			return 0;
		}
		int i;
		for (i = 0; i < items.Length; i++)
		{
			if (!HasCurrent)
			{
				break;
			}
			items[i] = Current;
			MoveNext();
		}
		if (typeof(T) == typeof(string))
		{
			string[] array = items as string[];
			for (int j = i; j < items.Length; j++)
			{
				array[j] = string.Empty;
			}
		}
		return i;
	}
}
