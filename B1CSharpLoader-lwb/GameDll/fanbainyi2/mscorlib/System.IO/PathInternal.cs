using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.IO;

internal static class PathInternal
{
	internal const string ExtendedPathPrefix = "\\\\?\\";

	internal const string UncPathPrefix = "\\\\";

	internal const string UncExtendedPrefixToInsert = "?\\UNC\\";

	internal const string UncExtendedPathPrefix = "\\\\?\\UNC\\";

	internal const string DevicePathPrefix = "\\\\.\\";

	internal const int DevicePrefixLength = 4;

	internal const int MaxShortPath = 260;

	internal const int MaxShortDirectoryPath = 248;

	internal const int MaxLongPath = 32767;

	internal static readonly int MaxComponentLength = 255;

	internal static readonly char[] InvalidPathChars = new char[36]
	{
		'"', '<', '>', '|', '\0', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005',
		'\u0006', '\a', '\b', '\t', '\n', '\v', '\f', '\r', '\u000e', '\u000f',
		'\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019',
		'\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f'
	};

	internal static bool HasInvalidVolumeSeparator(string path)
	{
		int num = ((!AppContextSwitches.UseLegacyPathHandling && IsExtended(path)) ? "\\\\?\\".Length : PathStartSkip(path));
		if ((path.Length > num && path[num] == Path.VolumeSeparatorChar) || (path.Length >= num + 2 && path[num + 1] == Path.VolumeSeparatorChar && !IsValidDriveChar(path[num])) || (path.Length > num + 2 && path.IndexOf(Path.VolumeSeparatorChar, num + 2) != -1))
		{
			return true;
		}
		return false;
	}

	internal static bool StartsWithOrdinal(StringBuilder builder, string value, bool ignoreCase = false)
	{
		if (value == null || builder.Length < value.Length)
		{
			return false;
		}
		if (ignoreCase)
		{
			for (int i = 0; i < value.Length; i++)
			{
				if (char.ToUpperInvariant(builder[i]) != char.ToUpperInvariant(value[i]))
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 0; j < value.Length; j++)
			{
				if (builder[j] != value[j])
				{
					return false;
				}
			}
		}
		return true;
	}

	internal static bool IsValidDriveChar(char value)
	{
		if (value < 'A' || value > 'Z')
		{
			if (value >= 'a')
			{
				return value <= 'z';
			}
			return false;
		}
		return true;
	}

	internal static bool IsPathTooLong(string fullPath)
	{
		if (AppContextSwitches.BlockLongPaths && (AppContextSwitches.UseLegacyPathHandling || !IsExtended(fullPath)))
		{
			return fullPath.Length >= 260;
		}
		return fullPath.Length >= 32767;
	}

	internal static bool AreSegmentsTooLong(string fullPath)
	{
		int length = fullPath.Length;
		int num = 0;
		for (int i = 0; i < length; i++)
		{
			if (IsDirectorySeparator(fullPath[i]))
			{
				if (i - num > MaxComponentLength)
				{
					return true;
				}
				num = i;
			}
		}
		if (length - 1 - num > MaxComponentLength)
		{
			return true;
		}
		return false;
	}

	internal static bool IsDirectoryTooLong(string fullPath)
	{
		if (AppContextSwitches.BlockLongPaths && (AppContextSwitches.UseLegacyPathHandling || !IsExtended(fullPath)))
		{
			return fullPath.Length >= 248;
		}
		return IsPathTooLong(fullPath);
	}

	internal static string EnsureExtendedPrefix(string path)
	{
		if (IsPartiallyQualified(path) || IsDevice(path))
		{
			return path;
		}
		if (path.StartsWith("\\\\", StringComparison.OrdinalIgnoreCase))
		{
			return path.Insert(2, "?\\UNC\\");
		}
		return "\\\\?\\" + path;
	}

	internal static string RemoveExtendedPrefix(string path)
	{
		if (!IsExtended(path))
		{
			return path;
		}
		if (IsExtendedUnc(path))
		{
			return path.Remove(2, 6);
		}
		return path.Substring(4);
	}

	internal static StringBuilder RemoveExtendedPrefix(StringBuilder path)
	{
		if (!IsExtended(path))
		{
			return path;
		}
		if (IsExtendedUnc(path))
		{
			return path.Remove(2, 6);
		}
		return path.Remove(0, 4);
	}

	internal static bool IsDevice(string path)
	{
		if (!IsExtended(path))
		{
			if (path.Length >= 4 && IsDirectorySeparator(path[0]) && IsDirectorySeparator(path[1]) && (path[2] == '.' || path[2] == '?'))
			{
				return IsDirectorySeparator(path[3]);
			}
			return false;
		}
		return true;
	}

	internal static bool IsDevice(StringBuffer path)
	{
		if (!IsExtended(path))
		{
			if (path.Length >= 4 && IsDirectorySeparator(path[0u]) && IsDirectorySeparator(path[1u]) && (path[2u] == '.' || path[2u] == '?'))
			{
				return IsDirectorySeparator(path[3u]);
			}
			return false;
		}
		return true;
	}

	internal static bool IsExtended(string path)
	{
		if (path.Length >= 4 && path[0] == '\\' && (path[1] == '\\' || path[1] == '?') && path[2] == '?')
		{
			return path[3] == '\\';
		}
		return false;
	}

	internal static bool IsExtended(StringBuilder path)
	{
		if (path.Length >= 4 && path[0] == '\\' && (path[1] == '\\' || path[1] == '?') && path[2] == '?')
		{
			return path[3] == '\\';
		}
		return false;
	}

	internal static bool IsExtended(StringBuffer path)
	{
		if (path.Length >= 4 && path[0u] == '\\' && (path[1u] == '\\' || path[1u] == '?') && path[2u] == '?')
		{
			return path[3u] == '\\';
		}
		return false;
	}

	internal static bool IsExtendedUnc(string path)
	{
		if (path.Length >= "\\\\?\\UNC\\".Length && IsExtended(path) && char.ToUpper(path[4]) == 'U' && char.ToUpper(path[5]) == 'N' && char.ToUpper(path[6]) == 'C')
		{
			return path[7] == '\\';
		}
		return false;
	}

	internal static bool IsExtendedUnc(StringBuilder path)
	{
		if (path.Length >= "\\\\?\\UNC\\".Length && IsExtended(path) && char.ToUpper(path[4]) == 'U' && char.ToUpper(path[5]) == 'N' && char.ToUpper(path[6]) == 'C')
		{
			return path[7] == '\\';
		}
		return false;
	}

	internal static bool HasIllegalCharacters(string path, bool checkAdditional = false)
	{
		if (!AppContextSwitches.UseLegacyPathHandling && IsDevice(path))
		{
			return false;
		}
		return AnyPathHasIllegalCharacters(path, checkAdditional);
	}

	internal static bool AnyPathHasIllegalCharacters(string path, bool checkAdditional = false)
	{
		if (path.IndexOfAny(InvalidPathChars) < 0)
		{
			if (checkAdditional)
			{
				return AnyPathHasWildCardCharacters(path);
			}
			return false;
		}
		return true;
	}

	internal static bool HasWildCardCharacters(string path)
	{
		int startIndex = ((!AppContextSwitches.UseLegacyPathHandling) ? (IsDevice(path) ? "\\\\?\\".Length : 0) : 0);
		return AnyPathHasWildCardCharacters(path, startIndex);
	}

	internal static bool AnyPathHasWildCardCharacters(string path, int startIndex = 0)
	{
		for (int i = startIndex; i < path.Length; i++)
		{
			char c = path[i];
			if (c == '*' || c == '?')
			{
				return true;
			}
		}
		return false;
	}

	[SecuritySafeCritical]
	internal unsafe static int GetRootLength(string path)
	{
		fixed (char* path2 = path)
		{
			return (int)GetRootLength(path2, (ulong)path.Length);
		}
	}

	[SecuritySafeCritical]
	internal unsafe static uint GetRootLength(StringBuffer path)
	{
		if (path.Length == 0)
		{
			return 0u;
		}
		return GetRootLength(path.CharPointer, path.Length);
	}

	[SecurityCritical]
	private unsafe static uint GetRootLength(char* path, ulong pathLength)
	{
		uint num = 0u;
		uint num2 = 2u;
		uint num3 = 2u;
		bool flag = StartsWithOrdinal(path, pathLength, "\\\\?\\");
		bool flag2 = StartsWithOrdinal(path, pathLength, "\\\\?\\UNC\\");
		if (flag)
		{
			if (flag2)
			{
				num3 = (uint)"\\\\?\\UNC\\".Length;
			}
			else
			{
				num2 += (uint)"\\\\?\\".Length;
			}
		}
		if ((!flag || flag2) && pathLength != 0 && IsDirectorySeparator(*path))
		{
			num = 1u;
			if (flag2 || (pathLength > 1 && IsDirectorySeparator(path[1])))
			{
				num = num3;
				int num4 = 2;
				for (; num < pathLength; num++)
				{
					if (IsDirectorySeparator(path[num]) && --num4 <= 0)
					{
						break;
					}
				}
			}
		}
		else if (pathLength >= num2 && path[num2 - 1] == Path.VolumeSeparatorChar)
		{
			num = num2;
			if (pathLength >= num2 + 1 && IsDirectorySeparator(path[num2]))
			{
				num++;
			}
		}
		return num;
	}

	[SecurityCritical]
	private unsafe static bool StartsWithOrdinal(char* source, ulong sourceLength, string value)
	{
		if (sourceLength < (ulong)value.Length)
		{
			return false;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] != source[i])
			{
				return false;
			}
		}
		return true;
	}

	internal static bool IsPartiallyQualified(string path)
	{
		if (path.Length < 2)
		{
			return true;
		}
		if (IsDirectorySeparator(path[0]))
		{
			if (path[1] != '?')
			{
				return !IsDirectorySeparator(path[1]);
			}
			return false;
		}
		if (path.Length >= 3 && path[1] == Path.VolumeSeparatorChar && IsDirectorySeparator(path[2]))
		{
			return !IsValidDriveChar(path[0]);
		}
		return true;
	}

	internal static bool IsPartiallyQualified(StringBuffer path)
	{
		if (path.Length < 2)
		{
			return true;
		}
		if (IsDirectorySeparator(path[0u]))
		{
			if (path[1u] != '?')
			{
				return !IsDirectorySeparator(path[1u]);
			}
			return false;
		}
		if (path.Length >= 3 && path[1u] == Path.VolumeSeparatorChar && IsDirectorySeparator(path[2u]))
		{
			return !IsValidDriveChar(path[0u]);
		}
		return true;
	}

	internal static int PathStartSkip(string path)
	{
		int i;
		for (i = 0; i < path.Length && path[i] == ' '; i++)
		{
		}
		if ((i > 0 && i < path.Length && IsDirectorySeparator(path[i])) || (i + 1 < path.Length && path[i + 1] == Path.VolumeSeparatorChar && IsValidDriveChar(path[i])))
		{
			return i;
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool IsDirectorySeparator(char c)
	{
		if (c != Path.DirectorySeparatorChar)
		{
			return c == Path.AltDirectorySeparatorChar;
		}
		return true;
	}

	internal static string NormalizeDirectorySeparators(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return path;
		}
		int num = PathStartSkip(path);
		if (num == 0)
		{
			bool flag = true;
			for (int i = 0; i < path.Length; i++)
			{
				char c = path[i];
				if (IsDirectorySeparator(c) && (c != Path.DirectorySeparatorChar || (i > 0 && i + 1 < path.Length && IsDirectorySeparator(path[i + 1]))))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return path;
			}
		}
		StringBuilder stringBuilder = StringBuilderCache.Acquire(path.Length);
		if (IsDirectorySeparator(path[num]))
		{
			num++;
			stringBuilder.Append(Path.DirectorySeparatorChar);
		}
		for (int j = num; j < path.Length; j++)
		{
			char c = path[j];
			if (IsDirectorySeparator(c))
			{
				if (j + 1 < path.Length && IsDirectorySeparator(path[j + 1]))
				{
					continue;
				}
				c = Path.DirectorySeparatorChar;
			}
			stringBuilder.Append(c);
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}
}
