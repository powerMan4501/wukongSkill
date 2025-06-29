using System.Runtime.InteropServices;
using System.Security;

namespace System.IO;

[ComVisible(false)]
internal static class LongPath
{
	[SecurityCritical]
	internal static string NormalizePath(string path)
	{
		return NormalizePath(path, fullCheck: true);
	}

	[SecurityCritical]
	internal static string NormalizePath(string path, bool fullCheck)
	{
		return Path.NormalizePath(path, fullCheck, 32767);
	}

	internal static string InternalCombine(string path1, string path2)
	{
		bool removed;
		string path3 = TryRemoveLongPathPrefix(path1, out removed);
		string text = Path.InternalCombine(path3, path2);
		if (removed)
		{
			text = Path.AddLongPathPrefix(text);
		}
		return text;
	}

	internal static int GetRootLength(string path)
	{
		bool removed;
		string path2 = TryRemoveLongPathPrefix(path, out removed);
		int num = Path.GetRootLength(path2);
		if (removed)
		{
			num += 4;
		}
		return num;
	}

	internal static bool IsPathRooted(string path)
	{
		string path2 = Path.RemoveLongPathPrefix(path);
		return Path.IsPathRooted(path2);
	}

	[SecurityCritical]
	internal static string GetPathRoot(string path)
	{
		if (path == null)
		{
			return null;
		}
		string path2 = TryRemoveLongPathPrefix(path, out var removed);
		path2 = NormalizePath(path2, fullCheck: false);
		string text = path.Substring(0, GetRootLength(path2));
		if (removed)
		{
			text = Path.AddLongPathPrefix(text);
		}
		return text;
	}

	[SecurityCritical]
	internal static string GetDirectoryName(string path)
	{
		if (path != null)
		{
			bool removed;
			string text = TryRemoveLongPathPrefix(path, out removed);
			Path.CheckInvalidPathChars(text);
			path = NormalizePath(text, fullCheck: false);
			int rootLength = GetRootLength(text);
			int length = text.Length;
			if (length > rootLength)
			{
				length = text.Length;
				if (length == rootLength)
				{
					return null;
				}
				while (length > rootLength && text[--length] != Path.DirectorySeparatorChar && text[length] != Path.AltDirectorySeparatorChar)
				{
				}
				string text2 = text.Substring(0, length);
				if (removed)
				{
					text2 = Path.AddLongPathPrefix(text2);
				}
				return text2;
			}
		}
		return null;
	}

	internal static string TryRemoveLongPathPrefix(string path, out bool removed)
	{
		removed = Path.HasLongPathPrefix(path);
		if (!removed)
		{
			return path;
		}
		return Path.RemoveLongPathPrefix(path);
	}
}
