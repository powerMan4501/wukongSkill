using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.IO;

[ComVisible(true)]
[__DynamicallyInvokable]
public static class Path
{
	[__DynamicallyInvokable]
	public static readonly char DirectorySeparatorChar = '\\';

	internal const string DirectorySeparatorCharAsString = "\\";

	[__DynamicallyInvokable]
	public static readonly char AltDirectorySeparatorChar = '/';

	[__DynamicallyInvokable]
	public static readonly char VolumeSeparatorChar = ':';

	[Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
	public static readonly char[] InvalidPathChars = new char[36]
	{
		'"', '<', '>', '|', '\0', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005',
		'\u0006', '\a', '\b', '\t', '\n', '\v', '\f', '\r', '\u000e', '\u000f',
		'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
		'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f'
	};

	internal static readonly char[] TrimEndChars = LongPathHelper.s_trimEndChars;

	private static readonly char[] RealInvalidPathChars = PathInternal.InvalidPathChars;

	private static readonly char[] InvalidPathCharsWithAdditionalChecks = new char[38]
	{
		'"', '<', '>', '|', '\0', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005',
		'\u0006', '\a', '\b', '\t', '\n', '\v', '\f', '\r', '\u000e', '\u000f',
		'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
		'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '*', '?'
	};

	private static readonly char[] InvalidFileNameChars = new char[41]
	{
		'"', '<', '>', '|', '\0', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005',
		'\u0006', '\a', '\b', '\t', '\n', '\v', '\f', '\r', '\u000e', '\u000f',
		'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
		'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', ':', '*', '?', '\\',
		'/'
	};

	[__DynamicallyInvokable]
	public static readonly char PathSeparator = ';';

	internal static readonly int MaxPath = 260;

	private static readonly int MaxDirectoryLength = PathInternal.MaxComponentLength;

	private static int GetTempPathVersion = 0;

	internal const int MAX_PATH = 260;

	internal const int MAX_DIRECTORY_PATH = 248;

	internal const int MaxLongPath = 32767;

	private const string LongPathPrefix = "\\\\?\\";

	private const string UNCPathPrefix = "\\\\";

	private const string UNCLongPathPrefixToInsert = "?\\UNC\\";

	private const string UNCLongPathPrefix = "\\\\?\\UNC\\";

	private static readonly char[] s_Base32Char = new char[32]
	{
		'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
		'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
		'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3',
		'4', '5'
	};

	[__DynamicallyInvokable]
	public static string ChangeExtension(string path, string extension)
	{
		if (path != null)
		{
			CheckInvalidPathChars(path);
			string text = path;
			int num = path.Length;
			while (--num >= 0)
			{
				char c = path[num];
				if (c == '.')
				{
					text = path.Substring(0, num);
					break;
				}
				if (c == DirectorySeparatorChar || c == AltDirectorySeparatorChar || c == VolumeSeparatorChar)
				{
					break;
				}
			}
			if (extension != null && path.Length != 0)
			{
				if (extension.Length == 0 || extension[0] != '.')
				{
					text += ".";
				}
				text += extension;
			}
			return text;
		}
		return null;
	}

	[__DynamicallyInvokable]
	public static string GetDirectoryName(string path)
	{
		return InternalGetDirectoryName(path);
	}

	[SecuritySafeCritical]
	private static string InternalGetDirectoryName(string path)
	{
		if (path != null)
		{
			CheckInvalidPathChars(path);
			string text = NormalizePath(path, fullCheck: false, AppContextSwitches.UseLegacyPathHandling);
			if (path.Length > 0 && !CodeAccessSecurityEngine.QuickCheckForAllDemands())
			{
				try
				{
					string text2 = RemoveLongPathPrefix(path);
					int i;
					for (i = 0; i < text2.Length && text2[i] != '?' && text2[i] != '*'; i++)
					{
					}
					if (i > 0)
					{
						GetFullPath(text2.Substring(0, i));
					}
				}
				catch (SecurityException)
				{
					if (path.IndexOf("~", StringComparison.Ordinal) != -1)
					{
						text = NormalizePath(path, fullCheck: false, expandShortPaths: false);
					}
				}
				catch (PathTooLongException)
				{
				}
				catch (NotSupportedException)
				{
				}
				catch (IOException)
				{
				}
				catch (ArgumentException)
				{
				}
			}
			path = text;
			int rootLength = GetRootLength(path);
			int length = path.Length;
			if (length > rootLength)
			{
				length = path.Length;
				if (length == rootLength)
				{
					return null;
				}
				while (length > rootLength && path[--length] != DirectorySeparatorChar && path[length] != AltDirectorySeparatorChar)
				{
				}
				return path.Substring(0, length);
			}
		}
		return null;
	}

	internal static int GetRootLength(string path)
	{
		CheckInvalidPathChars(path);
		if (AppContextSwitches.UseLegacyPathHandling)
		{
			return LegacyGetRootLength(path);
		}
		return PathInternal.GetRootLength(path);
	}

	private static int LegacyGetRootLength(string path)
	{
		int i = 0;
		int length = path.Length;
		if (length >= 1 && IsDirectorySeparator(path[0]))
		{
			i = 1;
			if (length >= 2 && IsDirectorySeparator(path[1]))
			{
				i = 2;
				int num = 2;
				for (; i < length; i++)
				{
					if ((path[i] == DirectorySeparatorChar || path[i] == AltDirectorySeparatorChar) && --num <= 0)
					{
						break;
					}
				}
			}
		}
		else if (length >= 2 && path[1] == VolumeSeparatorChar)
		{
			i = 2;
			if (length >= 3 && IsDirectorySeparator(path[2]))
			{
				i++;
			}
		}
		return i;
	}

	internal static bool IsDirectorySeparator(char c)
	{
		if (c != DirectorySeparatorChar)
		{
			return c == AltDirectorySeparatorChar;
		}
		return true;
	}

	[__DynamicallyInvokable]
	public static char[] GetInvalidPathChars()
	{
		return (char[])RealInvalidPathChars.Clone();
	}

	[__DynamicallyInvokable]
	public static char[] GetInvalidFileNameChars()
	{
		return (char[])InvalidFileNameChars.Clone();
	}

	[__DynamicallyInvokable]
	public static string GetExtension(string path)
	{
		if (path == null)
		{
			return null;
		}
		CheckInvalidPathChars(path);
		int length = path.Length;
		int num = length;
		while (--num >= 0)
		{
			char c = path[num];
			if (c == '.')
			{
				if (num != length - 1)
				{
					return path.Substring(num, length - num);
				}
				return string.Empty;
			}
			if (c == DirectorySeparatorChar || c == AltDirectorySeparatorChar || c == VolumeSeparatorChar)
			{
				break;
			}
		}
		return string.Empty;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string GetFullPath(string path)
	{
		string fullPathInternal = GetFullPathInternal(path);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, fullPathInternal, checkForDuplicates: false, needFullPath: false);
		return fullPathInternal;
	}

	[SecurityCritical]
	internal static string UnsafeGetFullPath(string path)
	{
		string fullPathInternal = GetFullPathInternal(path);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, fullPathInternal, checkForDuplicates: false, needFullPath: false);
		return fullPathInternal;
	}

	internal static string GetFullPathInternal(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return NormalizePath(path, fullCheck: true);
	}

	[SecuritySafeCritical]
	internal static string NormalizePath(string path, bool fullCheck)
	{
		return NormalizePath(path, fullCheck, AppContextSwitches.BlockLongPaths ? 260 : 32767);
	}

	[SecuritySafeCritical]
	internal static string NormalizePath(string path, bool fullCheck, bool expandShortPaths)
	{
		return NormalizePath(path, fullCheck, MaxPath, expandShortPaths);
	}

	[SecuritySafeCritical]
	internal static string NormalizePath(string path, bool fullCheck, int maxPathLength)
	{
		return NormalizePath(path, fullCheck, maxPathLength, expandShortPaths: true);
	}

	[SecuritySafeCritical]
	internal static string NormalizePath(string path, bool fullCheck, int maxPathLength, bool expandShortPaths)
	{
		if (AppContextSwitches.UseLegacyPathHandling)
		{
			return LegacyNormalizePath(path, fullCheck, maxPathLength, expandShortPaths);
		}
		if (PathInternal.IsExtended(path))
		{
			return path;
		}
		string text = null;
		text = (fullCheck ? NewNormalizePath(path, maxPathLength, expandShortPaths: true) : NewNormalizePathLimitedChecks(path, maxPathLength, expandShortPaths));
		if (string.IsNullOrWhiteSpace(text))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
		}
		return text;
	}

	[SecuritySafeCritical]
	private static string NewNormalizePathLimitedChecks(string path, int maxPathLength, bool expandShortPaths)
	{
		string text = PathInternal.NormalizeDirectorySeparators(path);
		if (PathInternal.IsPathTooLong(text) || PathInternal.AreSegmentsTooLong(text))
		{
			throw new PathTooLongException();
		}
		if (expandShortPaths && text.IndexOf('~') != -1)
		{
			try
			{
				return LongPathHelper.GetLongPathName(text);
			}
			catch
			{
			}
		}
		return text;
	}

	[SecuritySafeCritical]
	private static string NewNormalizePath(string path, int maxPathLength, bool expandShortPaths)
	{
		if (path.IndexOf('\0') != -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
		}
		if (string.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
		}
		return LongPathHelper.Normalize(path, (uint)maxPathLength, !PathInternal.IsDevice(path), expandShortPaths);
	}

	[SecurityCritical]
	internal unsafe static string LegacyNormalizePath(string path, bool fullCheck, int maxPathLength, bool expandShortPaths)
	{
		if (fullCheck)
		{
			path = path.TrimEnd(TrimEndChars);
			if (PathInternal.AnyPathHasIllegalCharacters(path))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
			}
		}
		int i = 0;
		PathHelper pathHelper;
		if (path.Length + 1 <= MaxPath)
		{
			char* charArrayPtr = stackalloc char[MaxPath];
			pathHelper = new PathHelper(charArrayPtr, MaxPath);
		}
		else
		{
			pathHelper = new PathHelper(path.Length + MaxPath, maxPathLength);
		}
		uint num = 0u;
		uint num2 = 0u;
		bool flag = false;
		uint num3 = 0u;
		int num4 = -1;
		bool flag2 = false;
		bool flag3 = true;
		int num5 = 0;
		bool flag4 = false;
		if (path.Length > 0 && (path[0] == DirectorySeparatorChar || path[0] == AltDirectorySeparatorChar))
		{
			pathHelper.Append('\\');
			i++;
			num4 = 0;
		}
		for (; i < path.Length; i++)
		{
			char c = path[i];
			if (c == DirectorySeparatorChar || c == AltDirectorySeparatorChar)
			{
				if (num3 == 0)
				{
					if (num2 != 0)
					{
						int num6 = num4 + 1;
						if (path[num6] != '.')
						{
							throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
						}
						if (num2 >= 2)
						{
							if (flag2 && num2 > 2)
							{
								throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
							}
							if (path[num6 + 1] == '.')
							{
								for (int j = num6 + 2; j < num6 + num2; j++)
								{
									if (path[j] != '.')
									{
										throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
									}
								}
								num2 = 2u;
							}
							else
							{
								if (num2 > 1)
								{
									throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
								}
								num2 = 1u;
							}
						}
						if (num2 == 2)
						{
							pathHelper.Append('.');
						}
						pathHelper.Append('.');
						flag = false;
					}
					if (num != 0 && flag3 && i + 1 < path.Length && (path[i + 1] == DirectorySeparatorChar || path[i + 1] == AltDirectorySeparatorChar))
					{
						pathHelper.Append(DirectorySeparatorChar);
					}
				}
				num2 = 0u;
				num = 0u;
				if (!flag)
				{
					flag = true;
					pathHelper.Append(DirectorySeparatorChar);
				}
				num3 = 0u;
				num4 = i;
				flag2 = false;
				flag3 = false;
				if (flag4)
				{
					pathHelper.TryExpandShortFileName();
					flag4 = false;
				}
				int num7 = pathHelper.Length - 1;
				if (num7 - num5 > MaxDirectoryLength)
				{
					throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
				}
				num5 = num7;
				continue;
			}
			switch (c)
			{
			case '.':
				num2++;
				continue;
			case ' ':
				num++;
				continue;
			}
			if (c == '~' && expandShortPaths)
			{
				flag4 = true;
			}
			flag = false;
			if (flag3 && c == VolumeSeparatorChar)
			{
				char c2 = ((i > 0) ? path[i - 1] : ' ');
				if (num2 != 0 || num3 < 1 || c2 == ' ')
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
				}
				flag2 = true;
				if (num3 > 1)
				{
					int k;
					for (k = 0; k < pathHelper.Length && pathHelper[k] == ' '; k++)
					{
					}
					if (num3 - k == 1)
					{
						pathHelper.Length = 0;
						pathHelper.Append(c2);
					}
				}
				num3 = 0u;
			}
			else
			{
				num3 += 1 + num2 + num;
			}
			if (num2 != 0 || num != 0)
			{
				int num8 = ((num4 >= 0) ? (i - num4 - 1) : i);
				if (num8 > 0)
				{
					for (int l = 0; l < num8; l++)
					{
						pathHelper.Append(path[num4 + 1 + l]);
					}
				}
				num2 = 0u;
				num = 0u;
			}
			pathHelper.Append(c);
			num4 = i;
		}
		if (pathHelper.Length - 1 - num5 > MaxDirectoryLength)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		if (num3 == 0 && num2 != 0)
		{
			int num9 = num4 + 1;
			if (path[num9] != '.')
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
			}
			if (num2 >= 2)
			{
				if (flag2 && num2 > 2)
				{
					throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
				}
				if (path[num9 + 1] == '.')
				{
					for (int m = num9 + 2; m < num9 + num2; m++)
					{
						if (path[m] != '.')
						{
							throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
						}
					}
					num2 = 2u;
				}
				else
				{
					if (num2 > 1)
					{
						throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
					}
					num2 = 1u;
				}
			}
			if (num2 == 2)
			{
				pathHelper.Append('.');
			}
			pathHelper.Append('.');
		}
		if (pathHelper.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegal"));
		}
		if (fullCheck && (pathHelper.OrdinalStartsWith("http:", ignoreCase: false) || pathHelper.OrdinalStartsWith("file:", ignoreCase: false)))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathUriFormatNotSupported"));
		}
		if (flag4)
		{
			pathHelper.TryExpandShortFileName();
		}
		int num10 = 1;
		if (fullCheck)
		{
			num10 = pathHelper.GetFullPathName();
			flag4 = false;
			for (int n = 0; n < pathHelper.Length; n++)
			{
				if (flag4)
				{
					break;
				}
				if (pathHelper[n] == '~' && expandShortPaths)
				{
					flag4 = true;
				}
			}
			if (flag4 && !pathHelper.TryExpandShortFileName())
			{
				int num11 = -1;
				for (int num12 = pathHelper.Length - 1; num12 >= 0; num12--)
				{
					if (pathHelper[num12] == DirectorySeparatorChar)
					{
						num11 = num12;
						break;
					}
				}
				if (num11 >= 0)
				{
					if (pathHelper.Length >= maxPathLength)
					{
						throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
					}
					int lenSavedName = pathHelper.Length - num11 - 1;
					pathHelper.Fixup(lenSavedName, num11);
				}
			}
		}
		if (num10 != 0 && pathHelper.Length > 1 && pathHelper[0] == '\\' && pathHelper[1] == '\\')
		{
			int num13;
			for (num13 = 2; num13 < num10; num13++)
			{
				if (pathHelper[num13] == '\\')
				{
					num13++;
					break;
				}
			}
			if (num13 == num10)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PathIllegalUNC"));
			}
			if (pathHelper.OrdinalStartsWith("\\\\?\\globalroot", ignoreCase: true))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_PathGlobalRoot"));
			}
		}
		if (pathHelper.Length >= maxPathLength)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		if (num10 == 0)
		{
			int num14 = Marshal.GetLastWin32Error();
			if (num14 == 0)
			{
				num14 = 161;
			}
			__Error.WinIOError(num14, path);
			return null;
		}
		string text = pathHelper.ToString();
		if (string.Equals(text, path, StringComparison.Ordinal))
		{
			text = path;
		}
		return text;
	}

	internal static bool HasLongPathPrefix(string path)
	{
		if (AppContextSwitches.UseLegacyPathHandling)
		{
			return path.StartsWith("\\\\?\\", StringComparison.Ordinal);
		}
		return PathInternal.IsExtended(path);
	}

	internal static string AddLongPathPrefix(string path)
	{
		if (AppContextSwitches.UseLegacyPathHandling)
		{
			if (path.StartsWith("\\\\?\\", StringComparison.Ordinal))
			{
				return path;
			}
			if (path.StartsWith("\\\\", StringComparison.Ordinal))
			{
				return path.Insert(2, "?\\UNC\\");
			}
			return "\\\\?\\" + path;
		}
		return PathInternal.EnsureExtendedPrefix(path);
	}

	internal static string RemoveLongPathPrefix(string path)
	{
		if (AppContextSwitches.UseLegacyPathHandling)
		{
			if (!path.StartsWith("\\\\?\\", StringComparison.Ordinal))
			{
				return path;
			}
			if (path.StartsWith("\\\\?\\UNC\\", StringComparison.OrdinalIgnoreCase))
			{
				return path.Remove(2, 6);
			}
			return path.Substring(4);
		}
		return PathInternal.RemoveExtendedPrefix(path);
	}

	internal static StringBuilder RemoveLongPathPrefix(StringBuilder pathSB)
	{
		if (AppContextSwitches.UseLegacyPathHandling)
		{
			if (!PathInternal.StartsWithOrdinal(pathSB, "\\\\?\\"))
			{
				return pathSB;
			}
			if (PathInternal.StartsWithOrdinal(pathSB, "\\\\?\\UNC\\", ignoreCase: true))
			{
				return pathSB.Remove(2, 6);
			}
			return pathSB.Remove(0, 4);
		}
		return PathInternal.RemoveExtendedPrefix(pathSB);
	}

	[__DynamicallyInvokable]
	public static string GetFileName(string path)
	{
		if (path != null)
		{
			CheckInvalidPathChars(path);
			int length = path.Length;
			int num = length;
			while (--num >= 0)
			{
				char c = path[num];
				if (c == DirectorySeparatorChar || c == AltDirectorySeparatorChar || c == VolumeSeparatorChar)
				{
					return path.Substring(num + 1, length - num - 1);
				}
			}
		}
		return path;
	}

	[__DynamicallyInvokable]
	public static string GetFileNameWithoutExtension(string path)
	{
		path = GetFileName(path);
		if (path != null)
		{
			int length;
			if ((length = path.LastIndexOf('.')) == -1)
			{
				return path;
			}
			return path.Substring(0, length);
		}
		return null;
	}

	[__DynamicallyInvokable]
	public static string GetPathRoot(string path)
	{
		if (path == null)
		{
			return null;
		}
		path = NormalizePath(path, fullCheck: false, expandShortPaths: false);
		return path.Substring(0, GetRootLength(path));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string GetTempPath()
	{
		new EnvironmentPermission(PermissionState.Unrestricted).Demand();
		StringBuilder stringBuilder = new StringBuilder(260);
		int num = GetTempPathVersion;
		if (num == 0)
		{
			num = 1;
			string environmentVariable = Environment.GetEnvironmentVariable("COMPlus_Disable_GetTempPath2");
			if (!string.Equals(environmentVariable, "true", StringComparison.Ordinal) && Win32Native.DoesWin32MethodExist("kernel32.dll", "GetTempPath2W") && Win32Native.DoesWin32MethodExist("kernel32.dll", "GetTempPath2A"))
			{
				num = 2;
			}
			GetTempPathVersion = num;
		}
		uint num2 = ((num == 2) ? Win32Native.GetTempPath2(260, stringBuilder) : Win32Native.GetTempPath(260, stringBuilder));
		string path = stringBuilder.ToString();
		if (num2 == 0)
		{
			__Error.WinIOError();
		}
		return GetFullPathInternal(path);
	}

	internal static bool IsRelative(string path)
	{
		return PathInternal.IsPartiallyQualified(path);
	}

	[__DynamicallyInvokable]
	public static string GetRandomFileName()
	{
		byte[] array = new byte[10];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = null;
		try
		{
			rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			rNGCryptoServiceProvider.GetBytes(array);
			char[] array2 = ToBase32StringSuitableForDirName(array).ToCharArray();
			array2[8] = '.';
			return new string(array2, 0, 12);
		}
		finally
		{
			rNGCryptoServiceProvider?.Dispose();
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string GetTempFileName()
	{
		return InternalGetTempFileName(checkHost: true);
	}

	[SecurityCritical]
	internal static string UnsafeGetTempFileName()
	{
		return InternalGetTempFileName(checkHost: false);
	}

	[SecurityCritical]
	private static string InternalGetTempFileName(bool checkHost)
	{
		string tempPath = GetTempPath();
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, tempPath);
		StringBuilder stringBuilder = new StringBuilder(260);
		if (Win32Native.GetTempFileName(tempPath, "tmp", 0u, stringBuilder) == 0)
		{
			__Error.WinIOError();
		}
		return stringBuilder.ToString();
	}

	[__DynamicallyInvokable]
	public static bool HasExtension(string path)
	{
		if (path != null)
		{
			CheckInvalidPathChars(path);
			int num = path.Length;
			while (--num >= 0)
			{
				char c = path[num];
				if (c == '.')
				{
					if (num != path.Length - 1)
					{
						return true;
					}
					return false;
				}
				if (c == DirectorySeparatorChar || c == AltDirectorySeparatorChar || c == VolumeSeparatorChar)
				{
					break;
				}
			}
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsPathRooted(string path)
	{
		if (path != null)
		{
			CheckInvalidPathChars(path);
			int length = path.Length;
			if ((length >= 1 && (path[0] == DirectorySeparatorChar || path[0] == AltDirectorySeparatorChar)) || (length >= 2 && path[1] == VolumeSeparatorChar))
			{
				return true;
			}
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static string Combine(string path1, string path2)
	{
		if (path1 == null || path2 == null)
		{
			throw new ArgumentNullException((path1 == null) ? "path1" : "path2");
		}
		CheckInvalidPathChars(path1);
		CheckInvalidPathChars(path2);
		return CombineNoChecks(path1, path2);
	}

	[__DynamicallyInvokable]
	public static string Combine(string path1, string path2, string path3)
	{
		if (path1 == null || path2 == null || path3 == null)
		{
			throw new ArgumentNullException((path1 == null) ? "path1" : ((path2 == null) ? "path2" : "path3"));
		}
		CheckInvalidPathChars(path1);
		CheckInvalidPathChars(path2);
		CheckInvalidPathChars(path3);
		return CombineNoChecks(CombineNoChecks(path1, path2), path3);
	}

	public static string Combine(string path1, string path2, string path3, string path4)
	{
		if (path1 == null || path2 == null || path3 == null || path4 == null)
		{
			throw new ArgumentNullException((path1 == null) ? "path1" : ((path2 == null) ? "path2" : ((path3 == null) ? "path3" : "path4")));
		}
		CheckInvalidPathChars(path1);
		CheckInvalidPathChars(path2);
		CheckInvalidPathChars(path3);
		CheckInvalidPathChars(path4);
		return CombineNoChecks(CombineNoChecks(CombineNoChecks(path1, path2), path3), path4);
	}

	[__DynamicallyInvokable]
	public static string Combine(params string[] paths)
	{
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < paths.Length; i++)
		{
			if (paths[i] == null)
			{
				throw new ArgumentNullException("paths");
			}
			if (paths[i].Length != 0)
			{
				CheckInvalidPathChars(paths[i]);
				if (IsPathRooted(paths[i]))
				{
					num2 = i;
					num = paths[i].Length;
				}
				else
				{
					num += paths[i].Length;
				}
				char c = paths[i][paths[i].Length - 1];
				if (c != DirectorySeparatorChar && c != AltDirectorySeparatorChar && c != VolumeSeparatorChar)
				{
					num++;
				}
			}
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire(num);
		for (int j = num2; j < paths.Length; j++)
		{
			if (paths[j].Length == 0)
			{
				continue;
			}
			if (stringBuilder.Length == 0)
			{
				stringBuilder.Append(paths[j]);
				continue;
			}
			char c2 = stringBuilder[stringBuilder.Length - 1];
			if (c2 != DirectorySeparatorChar && c2 != AltDirectorySeparatorChar && c2 != VolumeSeparatorChar)
			{
				stringBuilder.Append(DirectorySeparatorChar);
			}
			stringBuilder.Append(paths[j]);
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	internal static string CombineNoChecks(string path1, string path2)
	{
		if (path2.Length == 0)
		{
			return path1;
		}
		if (path1.Length == 0)
		{
			return path2;
		}
		if (IsPathRooted(path2))
		{
			return path2;
		}
		char c = path1[path1.Length - 1];
		if (c != DirectorySeparatorChar && c != AltDirectorySeparatorChar && c != VolumeSeparatorChar)
		{
			return path1 + "\\" + path2;
		}
		return path1 + path2;
	}

	internal static string ToBase32StringSuitableForDirName(byte[] buff)
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		int num = buff.Length;
		int num2 = 0;
		do
		{
			byte b = (byte)((num2 < num) ? buff[num2++] : 0);
			byte b2 = (byte)((num2 < num) ? buff[num2++] : 0);
			byte b3 = (byte)((num2 < num) ? buff[num2++] : 0);
			byte b4 = (byte)((num2 < num) ? buff[num2++] : 0);
			byte b5 = (byte)((num2 < num) ? buff[num2++] : 0);
			stringBuilder.Append(s_Base32Char[b & 0x1F]);
			stringBuilder.Append(s_Base32Char[b2 & 0x1F]);
			stringBuilder.Append(s_Base32Char[b3 & 0x1F]);
			stringBuilder.Append(s_Base32Char[b4 & 0x1F]);
			stringBuilder.Append(s_Base32Char[b5 & 0x1F]);
			stringBuilder.Append(s_Base32Char[((b & 0xE0) >> 5) | ((b4 & 0x60) >> 2)]);
			stringBuilder.Append(s_Base32Char[((b2 & 0xE0) >> 5) | ((b5 & 0x60) >> 2)]);
			b3 >>= 5;
			if ((b4 & 0x80) != 0)
			{
				b3 |= 8;
			}
			if ((b5 & 0x80) != 0)
			{
				b3 |= 0x10;
			}
			stringBuilder.Append(s_Base32Char[b3]);
		}
		while (num2 < num);
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	internal static void CheckSearchPattern(string searchPattern)
	{
		int num;
		while ((num = searchPattern.IndexOf("..", StringComparison.Ordinal)) != -1)
		{
			if (num + 2 == searchPattern.Length)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidSearchPattern"));
			}
			if (searchPattern[num + 2] == DirectorySeparatorChar || searchPattern[num + 2] == AltDirectorySeparatorChar)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidSearchPattern"));
			}
			searchPattern = searchPattern.Substring(num + 2);
		}
	}

	internal static void CheckInvalidPathChars(string path, bool checkAdditional = false)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (PathInternal.HasIllegalCharacters(path, checkAdditional))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidPathChars"));
		}
	}

	internal static string InternalCombine(string path1, string path2)
	{
		if (path1 == null || path2 == null)
		{
			throw new ArgumentNullException((path1 == null) ? "path1" : "path2");
		}
		CheckInvalidPathChars(path1);
		CheckInvalidPathChars(path2);
		if (path2.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathEmpty"), "path2");
		}
		if (IsPathRooted(path2))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_Path2IsRooted"), "path2");
		}
		int length = path1.Length;
		if (length == 0)
		{
			return path2;
		}
		char c = path1[length - 1];
		if (c != DirectorySeparatorChar && c != AltDirectorySeparatorChar && c != VolumeSeparatorChar)
		{
			return path1 + "\\" + path2;
		}
		return path1 + path2;
	}
}
