using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;

namespace System.IO;

internal class LongPathHelper
{
	private const int MaxShortName = 12;

	private const char LastAnsi = 'ÿ';

	private const char Delete = '\u007f';

	internal static readonly char[] s_trimEndChars = new char[8] { '\t', '\n', '\v', '\f', '\r', ' ', '\u0085', '\u00a0' };

	[ThreadStatic]
	private static StringBuffer t_fullPathBuffer;

	[SecurityCritical]
	internal unsafe static string Normalize(string path, uint maxPathLength, bool checkInvalidCharacters, bool expandShortPaths)
	{
		StringBuffer stringBuffer = t_fullPathBuffer ?? (t_fullPathBuffer = new StringBuffer(260u));
		try
		{
			GetFullPathName(path, stringBuffer);
			stringBuffer.TrimEnd(s_trimEndChars);
			if (stringBuffer.Length >= maxPathLength)
			{
				throw new PathTooLongException();
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = stringBuffer.Length > 1 && stringBuffer[0u] == '\\' && stringBuffer[1u] == '\\';
			bool flag4 = PathInternal.IsDevice(stringBuffer);
			bool flag5 = flag3 && !flag4;
			uint num = (flag3 ? 2u : 0u);
			uint num2 = (flag3 ? 1u : 0u);
			char* charPointer = stringBuffer.CharPointer;
			uint num3;
			for (; num < stringBuffer.Length; num++)
			{
				char c = charPointer[num];
				if (c >= '?' && c != '\\' && c != '|' && c != '~')
				{
					continue;
				}
				switch (c)
				{
				case '"':
				case '<':
				case '>':
				case '|':
					if (checkInvalidCharacters)
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
					}
					flag2 = false;
					break;
				case '~':
					flag2 = true;
					break;
				case '\\':
					num3 = num - num2 - 1;
					if (num3 > (uint)PathInternal.MaxComponentLength)
					{
						throw new PathTooLongException();
					}
					num2 = num;
					if (flag2)
					{
						if (num3 <= 12)
						{
							flag = true;
						}
						flag2 = false;
					}
					if (flag5)
					{
						if (num == stringBuffer.Length - 1)
						{
							throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegalUNC"));
						}
						flag5 = false;
					}
					break;
				default:
					if (checkInvalidCharacters && c < ' ')
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
					}
					break;
				}
			}
			if (flag5)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegalUNC"));
			}
			num3 = stringBuffer.Length - num2 - 1;
			if (num3 > (uint)PathInternal.MaxComponentLength)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			if (flag2 && num3 <= 12)
			{
				flag = true;
			}
			if (expandShortPaths && flag)
			{
				return TryExpandShortFileName(stringBuffer, path);
			}
			if (stringBuffer.Length == (uint)path.Length && stringBuffer.StartsWith(path))
			{
				return path;
			}
			return stringBuffer.ToString();
		}
		finally
		{
			stringBuffer.Free();
		}
	}

	[SecurityCritical]
	private unsafe static void GetFullPathName(string path, StringBuffer fullPath)
	{
		int num = PathInternal.PathStartSkip(path);
		fixed (char* ptr = path)
		{
			uint num2 = 0u;
			while ((num2 = Win32Native.GetFullPathNameW(ptr + num, fullPath.CharCapacity, fullPath.GetHandle(), IntPtr.Zero)) > fullPath.CharCapacity)
			{
				fullPath.EnsureCharCapacity(num2);
			}
			if (num2 == 0)
			{
				int num3 = Marshal.GetLastWin32Error();
				if (num3 == 0)
				{
					num3 = 161;
				}
				__Error.WinIOError(num3, path);
			}
			fullPath.Length = num2;
		}
	}

	[SecurityCritical]
	internal static string GetLongPathName(StringBuffer path)
	{
		using StringBuffer stringBuffer = new StringBuffer(path.Length);
		uint num = 0u;
		while ((num = Win32Native.GetLongPathNameW(path.GetHandle(), stringBuffer.GetHandle(), stringBuffer.CharCapacity)) > stringBuffer.CharCapacity)
		{
			stringBuffer.EnsureCharCapacity(num);
		}
		if (num == 0)
		{
			GetErrorAndThrow(path.ToString());
		}
		stringBuffer.Length = num;
		return stringBuffer.ToString();
	}

	[SecurityCritical]
	internal static string GetLongPathName(string path)
	{
		using StringBuffer stringBuffer = new StringBuffer((uint)path.Length);
		uint num = 0u;
		while ((num = Win32Native.GetLongPathNameW(path, stringBuffer.GetHandle(), stringBuffer.CharCapacity)) > stringBuffer.CharCapacity)
		{
			stringBuffer.EnsureCharCapacity(num);
		}
		if (num == 0)
		{
			GetErrorAndThrow(path);
		}
		stringBuffer.Length = num;
		return stringBuffer.ToString();
	}

	[SecurityCritical]
	private static void GetErrorAndThrow(string path)
	{
		int num = Marshal.GetLastWin32Error();
		if (num == 0)
		{
			num = 161;
		}
		__Error.WinIOError(num, path);
	}

	[SecuritySafeCritical]
	private static string TryExpandShortFileName(StringBuffer outputBuffer, string originalPath)
	{
		using StringBuffer stringBuffer = new StringBuffer(outputBuffer);
		bool flag = false;
		uint num = outputBuffer.Length - 1;
		uint num2 = num;
		uint rootLength = PathInternal.GetRootLength(outputBuffer);
		while (!flag)
		{
			uint longPathNameW = Win32Native.GetLongPathNameW(stringBuffer.GetHandle(), outputBuffer.GetHandle(), outputBuffer.CharCapacity);
			if (stringBuffer[num2] == '\0')
			{
				stringBuffer[num2] = '\\';
			}
			if (longPathNameW == 0)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (lastWin32Error != 2 && lastWin32Error != 3)
				{
					break;
				}
				num2--;
				while (num2 > rootLength && stringBuffer[num2] != '\\')
				{
					num2--;
				}
				if (num2 == rootLength)
				{
					break;
				}
				stringBuffer[num2] = '\0';
			}
			else if (longPathNameW > outputBuffer.CharCapacity)
			{
				outputBuffer.EnsureCharCapacity(longPathNameW);
			}
			else
			{
				flag = true;
				outputBuffer.Length = longPathNameW;
				if (num2 < num)
				{
					outputBuffer.Append(stringBuffer, num2, stringBuffer.Length - num2);
				}
			}
		}
		StringBuffer stringBuffer2 = (flag ? outputBuffer : stringBuffer);
		if (stringBuffer2.SubstringEquals(originalPath))
		{
			return originalPath;
		}
		return stringBuffer2.ToString();
	}
}
