using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32;

namespace System.IO;

internal struct PathHelper
{
	private int m_capacity;

	private int m_length;

	private int m_maxPath;

	[SecurityCritical]
	private unsafe char* m_arrayPtr;

	private StringBuilder m_sb;

	private bool useStackAlloc;

	private bool doNotTryExpandShortFileName;

	internal int Length
	{
		get
		{
			if (useStackAlloc)
			{
				return m_length;
			}
			return m_sb.Length;
		}
		set
		{
			if (useStackAlloc)
			{
				m_length = value;
			}
			else
			{
				m_sb.Length = value;
			}
		}
	}

	internal int Capacity => m_capacity;

	internal unsafe char this[int index]
	{
		[SecurityCritical]
		get
		{
			if (useStackAlloc)
			{
				return m_arrayPtr[index];
			}
			return m_sb[index];
		}
		[SecurityCritical]
		set
		{
			if (useStackAlloc)
			{
				m_arrayPtr[index] = value;
			}
			else
			{
				m_sb[index] = value;
			}
		}
	}

	[SecurityCritical]
	internal unsafe PathHelper(char* charArrayPtr, int length)
	{
		m_length = 0;
		m_sb = null;
		m_arrayPtr = charArrayPtr;
		m_capacity = length;
		m_maxPath = Path.MaxPath;
		useStackAlloc = true;
		doNotTryExpandShortFileName = false;
	}

	[SecurityCritical]
	internal unsafe PathHelper(int capacity, int maxPath)
	{
		m_length = 0;
		m_arrayPtr = null;
		useStackAlloc = false;
		m_sb = new StringBuilder(capacity);
		m_capacity = capacity;
		m_maxPath = maxPath;
		doNotTryExpandShortFileName = false;
	}

	[SecurityCritical]
	internal unsafe void Append(char value)
	{
		if (Length + 1 >= m_capacity)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		if (useStackAlloc)
		{
			m_arrayPtr[Length] = value;
			m_length++;
		}
		else
		{
			m_sb.Append(value);
		}
	}

	[SecurityCritical]
	internal unsafe int GetFullPathName()
	{
		if (useStackAlloc)
		{
			char* ptr = stackalloc char[Path.MaxPath + 1];
			int fullPathName = Win32Native.GetFullPathName(m_arrayPtr, Path.MaxPath + 1, ptr, IntPtr.Zero);
			if (fullPathName > Path.MaxPath)
			{
				char* ptr2 = stackalloc char[fullPathName];
				ptr = ptr2;
				fullPathName = Win32Native.GetFullPathName(m_arrayPtr, fullPathName, ptr, IntPtr.Zero);
			}
			if (fullPathName >= Path.MaxPath)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			if (fullPathName == 0 && *m_arrayPtr != 0)
			{
				__Error.WinIOError();
			}
			else if (fullPathName < Path.MaxPath)
			{
				ptr[fullPathName] = '\0';
			}
			doNotTryExpandShortFileName = false;
			string.wstrcpy(m_arrayPtr, ptr, fullPathName);
			Length = fullPathName;
			return fullPathName;
		}
		StringBuilder stringBuilder = new StringBuilder(m_capacity + 1);
		int fullPathName2 = Win32Native.GetFullPathName(m_sb.ToString(), m_capacity + 1, stringBuilder, IntPtr.Zero);
		if (fullPathName2 > m_maxPath)
		{
			stringBuilder.Length = fullPathName2;
			fullPathName2 = Win32Native.GetFullPathName(m_sb.ToString(), fullPathName2, stringBuilder, IntPtr.Zero);
		}
		if (fullPathName2 >= m_maxPath)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		if (fullPathName2 == 0 && m_sb[0] != 0)
		{
			if (Length >= m_maxPath)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			__Error.WinIOError();
		}
		doNotTryExpandShortFileName = false;
		m_sb = stringBuilder;
		return fullPathName2;
	}

	[SecurityCritical]
	internal unsafe bool TryExpandShortFileName()
	{
		if (doNotTryExpandShortFileName)
		{
			return false;
		}
		if (useStackAlloc)
		{
			NullTerminate();
			char* ptr = UnsafeGetArrayPtr();
			char* ptr2 = stackalloc char[Path.MaxPath + 1];
			int longPathName = Win32Native.GetLongPathName(ptr, ptr2, Path.MaxPath);
			if (longPathName >= Path.MaxPath)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			if (longPathName == 0)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error == 2 || lastWin32Error == 3)
				{
					doNotTryExpandShortFileName = true;
				}
				return false;
			}
			string.wstrcpy(ptr, ptr2, longPathName);
			Length = longPathName;
			NullTerminate();
			return true;
		}
		StringBuilder stringBuilder = GetStringBuilder();
		string text = stringBuilder.ToString();
		string text2 = text;
		bool flag = false;
		if (text2.Length > Path.MaxPath)
		{
			text2 = Path.AddLongPathPrefix(text2);
			flag = true;
		}
		stringBuilder.Capacity = m_capacity;
		stringBuilder.Length = 0;
		int num = Win32Native.GetLongPathName(text2, stringBuilder, m_capacity);
		if (num == 0)
		{
			int lastWin32Error2 = Marshal.GetLastWin32Error();
			if (2 == lastWin32Error2 || 3 == lastWin32Error2)
			{
				doNotTryExpandShortFileName = true;
			}
			stringBuilder.Length = 0;
			stringBuilder.Append(text);
			return false;
		}
		if (flag)
		{
			num -= 4;
		}
		if (num >= m_maxPath)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		stringBuilder = Path.RemoveLongPathPrefix(stringBuilder);
		Length = stringBuilder.Length;
		return true;
	}

	[SecurityCritical]
	internal unsafe void Fixup(int lenSavedName, int lastSlash)
	{
		if (useStackAlloc)
		{
			char* ptr = stackalloc char[lenSavedName];
			string.wstrcpy(ptr, m_arrayPtr + lastSlash + 1, lenSavedName);
			Length = lastSlash;
			NullTerminate();
			doNotTryExpandShortFileName = false;
			bool flag = TryExpandShortFileName();
			Append(Path.DirectorySeparatorChar);
			if (Length + lenSavedName >= Path.MaxPath)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			string.wstrcpy(m_arrayPtr + Length, ptr, lenSavedName);
			Length += lenSavedName;
		}
		else
		{
			string value = m_sb.ToString(lastSlash + 1, lenSavedName);
			Length = lastSlash;
			doNotTryExpandShortFileName = false;
			bool flag2 = TryExpandShortFileName();
			Append(Path.DirectorySeparatorChar);
			if (Length + lenSavedName >= m_maxPath)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			m_sb.Append(value);
		}
	}

	[SecurityCritical]
	internal unsafe bool OrdinalStartsWith(string compareTo, bool ignoreCase)
	{
		if (Length < compareTo.Length)
		{
			return false;
		}
		if (useStackAlloc)
		{
			NullTerminate();
			if (ignoreCase)
			{
				string value = new string(m_arrayPtr, 0, compareTo.Length);
				return compareTo.Equals(value, StringComparison.OrdinalIgnoreCase);
			}
			for (int i = 0; i < compareTo.Length; i++)
			{
				if (m_arrayPtr[i] != compareTo[i])
				{
					return false;
				}
			}
			return true;
		}
		if (ignoreCase)
		{
			return m_sb.ToString().StartsWith(compareTo, StringComparison.OrdinalIgnoreCase);
		}
		return m_sb.ToString().StartsWith(compareTo, StringComparison.Ordinal);
	}

	[SecuritySafeCritical]
	public unsafe override string ToString()
	{
		if (useStackAlloc)
		{
			return new string(m_arrayPtr, 0, Length);
		}
		return m_sb.ToString();
	}

	[SecurityCritical]
	private unsafe char* UnsafeGetArrayPtr()
	{
		return m_arrayPtr;
	}

	private StringBuilder GetStringBuilder()
	{
		return m_sb;
	}

	[SecurityCritical]
	private unsafe void NullTerminate()
	{
		m_arrayPtr[m_length] = '\0';
	}
}
