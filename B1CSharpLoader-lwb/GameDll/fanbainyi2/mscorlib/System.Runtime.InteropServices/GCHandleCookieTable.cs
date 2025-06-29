using System.Collections.Generic;
using System.Threading;

namespace System.Runtime.InteropServices;

internal class GCHandleCookieTable
{
	private const int InitialHandleCount = 10;

	private const int MaxListSize = 16777215;

	private const uint CookieMaskIndex = 16777215u;

	private const uint CookieMaskSentinal = 4278190080u;

	private Dictionary<IntPtr, IntPtr> m_HandleToCookieMap;

	private volatile IntPtr[] m_HandleList;

	private volatile byte[] m_CycleCounts;

	private int m_FreeIndex;

	private readonly object m_syncObject;

	internal GCHandleCookieTable()
	{
		m_HandleList = new IntPtr[10];
		m_CycleCounts = new byte[10];
		m_HandleToCookieMap = new Dictionary<IntPtr, IntPtr>(10);
		m_syncObject = new object();
		for (int i = 0; i < 10; i++)
		{
			m_HandleList[i] = IntPtr.Zero;
			m_CycleCounts[i] = 0;
		}
	}

	internal IntPtr FindOrAddHandle(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = IntPtr.Zero;
		lock (m_syncObject)
		{
			if (m_HandleToCookieMap.ContainsKey(handle))
			{
				return m_HandleToCookieMap[handle];
			}
			if (m_FreeIndex < m_HandleList.Length && Volatile.Read(ref m_HandleList[m_FreeIndex]) == IntPtr.Zero)
			{
				Volatile.Write(ref m_HandleList[m_FreeIndex], handle);
				intPtr = GetCookieFromData((uint)m_FreeIndex, m_CycleCounts[m_FreeIndex]);
				m_FreeIndex++;
			}
			else
			{
				for (m_FreeIndex = 0; m_FreeIndex < 16777215; m_FreeIndex++)
				{
					if (m_HandleList[m_FreeIndex] == IntPtr.Zero)
					{
						Volatile.Write(ref m_HandleList[m_FreeIndex], handle);
						intPtr = GetCookieFromData((uint)m_FreeIndex, m_CycleCounts[m_FreeIndex]);
						m_FreeIndex++;
						break;
					}
					if (m_FreeIndex + 1 == m_HandleList.Length)
					{
						GrowArrays();
					}
				}
			}
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException(Environment.GetResourceString("OutOfMemory_GCHandleMDA"));
			}
			m_HandleToCookieMap.Add(handle, intPtr);
			return intPtr;
		}
	}

	internal IntPtr GetHandle(IntPtr cookie)
	{
		IntPtr zero = IntPtr.Zero;
		if (!ValidateCookie(cookie))
		{
			return IntPtr.Zero;
		}
		return Volatile.Read(ref m_HandleList[GetIndexFromCookie(cookie)]);
	}

	internal void RemoveHandleIfPresent(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return;
		}
		lock (m_syncObject)
		{
			if (m_HandleToCookieMap.ContainsKey(handle))
			{
				IntPtr cookie = m_HandleToCookieMap[handle];
				if (ValidateCookie(cookie))
				{
					int indexFromCookie = GetIndexFromCookie(cookie);
					m_CycleCounts[indexFromCookie]++;
					Volatile.Write(ref m_HandleList[indexFromCookie], IntPtr.Zero);
					m_HandleToCookieMap.Remove(handle);
					m_FreeIndex = indexFromCookie;
				}
			}
		}
	}

	private bool ValidateCookie(IntPtr cookie)
	{
		GetDataFromCookie(cookie, out var index, out var xorData);
		if (index >= 16777215)
		{
			return false;
		}
		if (index >= m_HandleList.Length)
		{
			return false;
		}
		if (Volatile.Read(ref m_HandleList[index]) == IntPtr.Zero)
		{
			return false;
		}
		byte b = (byte)(AppDomain.CurrentDomain.Id % 255);
		byte b2 = (byte)(Volatile.Read(ref m_CycleCounts[index]) ^ b);
		if (xorData != b2)
		{
			return false;
		}
		return true;
	}

	private void GrowArrays()
	{
		int num = m_HandleList.Length;
		IntPtr[] array = new IntPtr[num * 2];
		byte[] array2 = new byte[num * 2];
		Array.Copy(m_HandleList, array, num);
		Array.Copy(m_CycleCounts, array2, num);
		m_HandleList = array;
		m_CycleCounts = array2;
	}

	private IntPtr GetCookieFromData(uint index, byte cycleCount)
	{
		byte b = (byte)(AppDomain.CurrentDomain.Id % 255);
		return (IntPtr)(((cycleCount ^ b) << 24) + index + 1);
	}

	private void GetDataFromCookie(IntPtr cookie, out int index, out byte xorData)
	{
		uint num = (uint)(int)cookie;
		index = (int)((num & 0xFFFFFF) - 1);
		xorData = (byte)((num & 0xFF000000u) >> 24);
	}

	private int GetIndexFromCookie(IntPtr cookie)
	{
		uint num = (uint)(int)cookie;
		return (int)((num & 0xFFFFFF) - 1);
	}
}
