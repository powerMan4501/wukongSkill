using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System;

internal struct Utf8String
{
	[SecurityCritical]
	private unsafe void* m_pStringHeap;

	private int m_StringHeapByteLength;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern bool EqualsCaseSensitive(void* szLhs, void* szRhs, int cSz);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern bool EqualsCaseInsensitive(void* szLhs, void* szRhs, int cSz);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern uint HashCaseInsensitive(void* sz, int cSz);

	[SecurityCritical]
	private unsafe static int GetUtf8StringByteLength(void* pUtf8String)
	{
		int num = 0;
		for (byte* ptr = (byte*)pUtf8String; *ptr != 0; ptr++)
		{
			num++;
		}
		return num;
	}

	[SecurityCritical]
	internal unsafe Utf8String(void* pStringHeap)
	{
		m_pStringHeap = pStringHeap;
		if (pStringHeap != null)
		{
			m_StringHeapByteLength = GetUtf8StringByteLength(pStringHeap);
		}
		else
		{
			m_StringHeapByteLength = 0;
		}
	}

	[SecurityCritical]
	internal unsafe Utf8String(void* pUtf8String, int cUtf8String)
	{
		m_pStringHeap = pUtf8String;
		m_StringHeapByteLength = cUtf8String;
	}

	[SecuritySafeCritical]
	internal unsafe bool Equals(Utf8String s)
	{
		if (m_pStringHeap == null)
		{
			return s.m_StringHeapByteLength == 0;
		}
		if (s.m_StringHeapByteLength == m_StringHeapByteLength && m_StringHeapByteLength != 0)
		{
			return EqualsCaseSensitive(s.m_pStringHeap, m_pStringHeap, m_StringHeapByteLength);
		}
		return false;
	}

	[SecuritySafeCritical]
	internal unsafe bool EqualsCaseInsensitive(Utf8String s)
	{
		if (m_pStringHeap == null)
		{
			return s.m_StringHeapByteLength == 0;
		}
		if (s.m_StringHeapByteLength == m_StringHeapByteLength && m_StringHeapByteLength != 0)
		{
			return EqualsCaseInsensitive(s.m_pStringHeap, m_pStringHeap, m_StringHeapByteLength);
		}
		return false;
	}

	[SecuritySafeCritical]
	internal unsafe uint HashCaseInsensitive()
	{
		return HashCaseInsensitive(m_pStringHeap, m_StringHeapByteLength);
	}

	[SecuritySafeCritical]
	public unsafe override string ToString()
	{
		byte* ptr = stackalloc byte[(int)(uint)m_StringHeapByteLength];
		byte* ptr2 = (byte*)m_pStringHeap;
		for (int i = 0; i < m_StringHeapByteLength; i++)
		{
			ptr[i] = *ptr2;
			ptr2++;
		}
		if (m_StringHeapByteLength == 0)
		{
			return "";
		}
		int charCount = Encoding.UTF8.GetCharCount(ptr, m_StringHeapByteLength);
		char* ptr3 = stackalloc char[charCount];
		Encoding.UTF8.GetChars(ptr, m_StringHeapByteLength, ptr3, charCount);
		return new string(ptr3, 0, charCount);
	}
}
