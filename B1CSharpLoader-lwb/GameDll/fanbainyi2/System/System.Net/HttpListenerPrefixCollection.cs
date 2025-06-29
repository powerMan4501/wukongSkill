using System.Collections;
using System.Collections.Generic;

namespace System.Net;

public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
{
	private HttpListener m_HttpListener;

	public int Count => m_HttpListener.m_UriPrefixes.Count;

	public bool IsSynchronized => false;

	public bool IsReadOnly => false;

	internal HttpListenerPrefixCollection(HttpListener listener)
	{
		m_HttpListener = listener;
	}

	public void CopyTo(Array array, int offset)
	{
		m_HttpListener.CheckDisposed();
		if (Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("array", SR.GetString("net_array_too_small"));
		}
		if (offset + Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		int num = 0;
		foreach (string key in m_HttpListener.m_UriPrefixes.Keys)
		{
			array.SetValue(key, offset + num++);
		}
	}

	public void CopyTo(string[] array, int offset)
	{
		m_HttpListener.CheckDisposed();
		if (Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("array", SR.GetString("net_array_too_small"));
		}
		if (offset + Count > array.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		int num = 0;
		foreach (string key in m_HttpListener.m_UriPrefixes.Keys)
		{
			array[offset + num++] = key;
		}
	}

	public void Add(string uriPrefix)
	{
		m_HttpListener.AddPrefix(uriPrefix);
	}

	public bool Contains(string uriPrefix)
	{
		return m_HttpListener.m_UriPrefixes.Contains(uriPrefix);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<string> GetEnumerator()
	{
		return new ListenerPrefixEnumerator(m_HttpListener.m_UriPrefixes.Keys.GetEnumerator());
	}

	public bool Remove(string uriPrefix)
	{
		return m_HttpListener.RemovePrefix(uriPrefix);
	}

	public void Clear()
	{
		m_HttpListener.RemoveAll(clear: true);
	}
}
