using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

[ComVisible(true)]
public static class Directory
{
	internal sealed class SearchData
	{
		public readonly string fullPath;

		public readonly string userPath;

		public readonly SearchOption searchOption;

		public SearchData(string fullPath, string userPath, SearchOption searchOption)
		{
			this.fullPath = fullPath;
			this.userPath = userPath;
			this.searchOption = searchOption;
		}
	}

	private const int FILE_ATTRIBUTE_DIRECTORY = 16;

	private const int GENERIC_WRITE = 1073741824;

	private const int FILE_SHARE_WRITE = 2;

	private const int FILE_SHARE_DELETE = 4;

	private const int OPEN_EXISTING = 3;

	private const int FILE_FLAG_BACKUP_SEMANTICS = 33554432;

	public static DirectoryInfo GetParent(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathEmpty"), "path");
		}
		string fullPathInternal = Path.GetFullPathInternal(path);
		string directoryName = Path.GetDirectoryName(fullPathInternal);
		if (directoryName == null)
		{
			return null;
		}
		return new DirectoryInfo(directoryName);
	}

	[SecuritySafeCritical]
	public static DirectoryInfo CreateDirectory(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathEmpty"));
		}
		return InternalCreateDirectoryHelper(path, checkHost: true);
	}

	[SecurityCritical]
	internal static DirectoryInfo UnsafeCreateDirectory(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathEmpty"));
		}
		return InternalCreateDirectoryHelper(path, checkHost: false);
	}

	[SecurityCritical]
	internal static DirectoryInfo InternalCreateDirectoryHelper(string path, bool checkHost)
	{
		string fullPathAndCheckPermissions = GetFullPathAndCheckPermissions(path, checkHost);
		InternalCreateDirectory(fullPathAndCheckPermissions, path, null, checkHost);
		return new DirectoryInfo(fullPathAndCheckPermissions, junk: false);
	}

	internal static string GetFullPathAndCheckPermissions(string path, bool checkHost, FileSecurityStateAccess access = FileSecurityStateAccess.Read)
	{
		string fullPathInternal = Path.GetFullPathInternal(path);
		CheckPermissions(path, fullPathInternal, checkHost, access);
		return fullPathInternal;
	}

	[SecuritySafeCritical]
	internal static void CheckPermissions(string displayPath, string fullPath, bool checkHost, FileSecurityStateAccess access = FileSecurityStateAccess.Read)
	{
		if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			FileIOPermission.EmulateFileIOPermissionChecks(fullPath);
		}
		else
		{
			FileIOPermission.QuickDemand((FileIOPermissionAccess)access, GetDemandDir(fullPath, thisDirOnly: true), checkForDuplicates: false, needFullPath: false);
		}
	}

	[SecuritySafeCritical]
	public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathEmpty"));
		}
		string fullPathAndCheckPermissions = GetFullPathAndCheckPermissions(path, checkHost: true);
		InternalCreateDirectory(fullPathAndCheckPermissions, path, directorySecurity);
		return new DirectoryInfo(fullPathAndCheckPermissions, junk: false);
	}

	internal static string GetDemandDir(string fullPath, bool thisDirOnly)
	{
		if (thisDirOnly)
		{
			if (fullPath.EndsWith(Path.DirectorySeparatorChar) || fullPath.EndsWith(Path.AltDirectorySeparatorChar))
			{
				return fullPath + ".";
			}
			return fullPath + "\\.";
		}
		if (!fullPath.EndsWith(Path.DirectorySeparatorChar) && !fullPath.EndsWith(Path.AltDirectorySeparatorChar))
		{
			return fullPath + "\\";
		}
		return fullPath;
	}

	internal static void InternalCreateDirectory(string fullPath, string path, object dirSecurityObj)
	{
		InternalCreateDirectory(fullPath, path, dirSecurityObj, checkHost: false);
	}

	[SecuritySafeCritical]
	internal unsafe static void InternalCreateDirectory(string fullPath, string path, object dirSecurityObj, bool checkHost)
	{
		DirectorySecurity directorySecurity = (DirectorySecurity)dirSecurityObj;
		int num = fullPath.Length;
		if (num >= 2 && Path.IsDirectorySeparator(fullPath[num - 1]))
		{
			num--;
		}
		int rootLength = Path.GetRootLength(fullPath);
		if (num == 2 && Path.IsDirectorySeparator(fullPath[1]))
		{
			throw new IOException(Environment.GetResourceString("IO.IO_CannotCreateDirectory", path));
		}
		if (InternalExists(fullPath))
		{
			return;
		}
		List<string> list = new List<string>();
		bool flag = false;
		if (num > rootLength)
		{
			int num2 = num - 1;
			while (num2 >= rootLength && !flag)
			{
				string text = fullPath.Substring(0, num2 + 1);
				if (!InternalExists(text))
				{
					list.Add(text);
				}
				else
				{
					flag = true;
				}
				while (num2 > rootLength && fullPath[num2] != Path.DirectorySeparatorChar && fullPath[num2] != Path.AltDirectorySeparatorChar)
				{
					num2--;
				}
				num2--;
			}
		}
		int count = list.Count;
		if (list.Count != 0 && !CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			string[] array = new string[list.Count];
			list.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] += "\\.";
			}
			AccessControlActions control = ((directorySecurity != null) ? AccessControlActions.Change : AccessControlActions.None);
			FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, control, array, checkForDuplicates: false, needFullPath: false);
		}
		Win32Native.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		if (directorySecurity != null)
		{
			sECURITY_ATTRIBUTES = new Win32Native.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf(sECURITY_ATTRIBUTES);
			byte[] securityDescriptorBinaryForm = directorySecurity.GetSecurityDescriptorBinaryForm();
			byte* ptr = stackalloc byte[(int)(uint)securityDescriptorBinaryForm.Length];
			Buffer.Memcpy(ptr, 0, securityDescriptorBinaryForm, 0, securityDescriptorBinaryForm.Length);
			sECURITY_ATTRIBUTES.pSecurityDescriptor = ptr;
		}
		bool flag2 = true;
		int num3 = 0;
		string maybeFullPath = path;
		while (list.Count > 0)
		{
			string text2 = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			if (PathInternal.IsDirectoryTooLong(text2))
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			flag2 = Win32Native.CreateDirectory(text2, sECURITY_ATTRIBUTES);
			if (flag2 || num3 != 0)
			{
				continue;
			}
			int lastError = Marshal.GetLastWin32Error();
			if (lastError != 183)
			{
				num3 = lastError;
			}
			else if (File.InternalExists(text2) || (!InternalExists(text2, out lastError) && lastError == 5))
			{
				num3 = lastError;
				try
				{
					CheckPermissions(string.Empty, text2, checkHost, FileSecurityStateAccess.PathDiscovery);
					maybeFullPath = text2;
				}
				catch (SecurityException)
				{
				}
			}
		}
		if (count == 0 && !flag)
		{
			string path2 = InternalGetDirectoryRoot(fullPath);
			if (!InternalExists(path2))
			{
				__Error.WinIOError(3, InternalGetDirectoryRoot(path));
			}
		}
		else if (!flag2 && num3 != 0)
		{
			__Error.WinIOError(num3, maybeFullPath);
		}
	}

	[SecuritySafeCritical]
	public static bool Exists(string path)
	{
		return InternalExistsHelper(path, checkHost: true);
	}

	[SecurityCritical]
	internal static bool UnsafeExists(string path)
	{
		return InternalExistsHelper(path, checkHost: false);
	}

	[SecurityCritical]
	internal static bool InternalExistsHelper(string path, bool checkHost)
	{
		if (path == null || path.Length == 0)
		{
			return false;
		}
		try
		{
			string fullPathAndCheckPermissions = GetFullPathAndCheckPermissions(path, checkHost);
			return InternalExists(fullPathAndCheckPermissions);
		}
		catch (ArgumentException)
		{
		}
		catch (NotSupportedException)
		{
		}
		catch (SecurityException)
		{
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		return false;
	}

	[SecurityCritical]
	internal static bool InternalExists(string path)
	{
		int lastError = 0;
		return InternalExists(path, out lastError);
	}

	[SecurityCritical]
	internal static bool InternalExists(string path, out int lastError)
	{
		Win32Native.WIN32_FILE_ATTRIBUTE_DATA data = default(Win32Native.WIN32_FILE_ATTRIBUTE_DATA);
		lastError = File.FillAttributeInfo(path, ref data, tryagain: false, returnErrorOnNotFound: true);
		if (lastError == 0 && data.fileAttributes != -1)
		{
			return (data.fileAttributes & 0x10) != 0;
		}
		return false;
	}

	public static void SetCreationTime(string path, DateTime creationTime)
	{
		SetCreationTimeUtc(path, creationTime.ToUniversalTime());
	}

	[SecuritySafeCritical]
	public unsafe static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
	{
		using SafeFileHandle hFile = OpenHandle(path);
		Win32Native.FILE_TIME fILE_TIME = new Win32Native.FILE_TIME(creationTimeUtc.ToFileTimeUtc());
		if (!Win32Native.SetFileTime(hFile, &fILE_TIME, null, null))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			__Error.WinIOError(lastWin32Error, path);
		}
	}

	public static DateTime GetCreationTime(string path)
	{
		return File.GetCreationTime(path);
	}

	public static DateTime GetCreationTimeUtc(string path)
	{
		return File.GetCreationTimeUtc(path);
	}

	public static void SetLastWriteTime(string path, DateTime lastWriteTime)
	{
		SetLastWriteTimeUtc(path, lastWriteTime.ToUniversalTime());
	}

	[SecuritySafeCritical]
	public unsafe static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
	{
		using SafeFileHandle hFile = OpenHandle(path);
		Win32Native.FILE_TIME fILE_TIME = new Win32Native.FILE_TIME(lastWriteTimeUtc.ToFileTimeUtc());
		if (!Win32Native.SetFileTime(hFile, null, null, &fILE_TIME))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			__Error.WinIOError(lastWin32Error, path);
		}
	}

	public static DateTime GetLastWriteTime(string path)
	{
		return File.GetLastWriteTime(path);
	}

	public static DateTime GetLastWriteTimeUtc(string path)
	{
		return File.GetLastWriteTimeUtc(path);
	}

	public static void SetLastAccessTime(string path, DateTime lastAccessTime)
	{
		SetLastAccessTimeUtc(path, lastAccessTime.ToUniversalTime());
	}

	[SecuritySafeCritical]
	public unsafe static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
	{
		using SafeFileHandle hFile = OpenHandle(path);
		Win32Native.FILE_TIME fILE_TIME = new Win32Native.FILE_TIME(lastAccessTimeUtc.ToFileTimeUtc());
		if (!Win32Native.SetFileTime(hFile, null, &fILE_TIME, null))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			__Error.WinIOError(lastWin32Error, path);
		}
	}

	public static DateTime GetLastAccessTime(string path)
	{
		return File.GetLastAccessTime(path);
	}

	public static DateTime GetLastAccessTimeUtc(string path)
	{
		return File.GetLastAccessTimeUtc(path);
	}

	public static DirectorySecurity GetAccessControl(string path)
	{
		return new DirectorySecurity(path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
	{
		return new DirectorySecurity(path, includeSections);
	}

	[SecuritySafeCritical]
	public static void SetAccessControl(string path, DirectorySecurity directorySecurity)
	{
		if (directorySecurity == null)
		{
			throw new ArgumentNullException("directorySecurity");
		}
		string fullPathInternal = Path.GetFullPathInternal(path);
		directorySecurity.Persist(fullPathInternal);
	}

	public static string[] GetFiles(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return InternalGetFiles(path, "*", SearchOption.TopDirectoryOnly);
	}

	public static string[] GetFiles(string path, string searchPattern)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalGetFiles(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalGetFiles(path, searchPattern, searchOption);
	}

	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return InternalGetFileDirectoryNames(path, path, searchPattern, includeFiles: true, includeDirs: false, searchOption, checkHost: true);
	}

	[SecurityCritical]
	internal static string[] UnsafeGetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return InternalGetFileDirectoryNames(path, path, searchPattern, includeFiles: true, includeDirs: false, searchOption, checkHost: false);
	}

	public static string[] GetDirectories(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return InternalGetDirectories(path, "*", SearchOption.TopDirectoryOnly);
	}

	public static string[] GetDirectories(string path, string searchPattern)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalGetDirectories(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalGetDirectories(path, searchPattern, searchOption);
	}

	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		return InternalGetFileDirectoryNames(path, path, searchPattern, includeFiles: false, includeDirs: true, searchOption, checkHost: true);
	}

	[SecurityCritical]
	internal static string[] UnsafeGetDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		return InternalGetFileDirectoryNames(path, path, searchPattern, includeFiles: false, includeDirs: true, searchOption, checkHost: false);
	}

	public static string[] GetFileSystemEntries(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return InternalGetFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly);
	}

	public static string[] GetFileSystemEntries(string path, string searchPattern)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalGetFileSystemEntries(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalGetFileSystemEntries(path, searchPattern, searchOption);
	}

	private static string[] InternalGetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
	{
		return InternalGetFileDirectoryNames(path, path, searchPattern, includeFiles: true, includeDirs: true, searchOption, checkHost: true);
	}

	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost)
	{
		IEnumerable<string> collection = FileSystemEnumerableFactory.CreateFileNameIterator(path, userPathOriginal, searchPattern, includeFiles, includeDirs, searchOption, checkHost);
		List<string> list = new List<string>(collection);
		return list.ToArray();
	}

	public static IEnumerable<string> EnumerateDirectories(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return InternalEnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly);
	}

	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalEnumerateDirectories(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalEnumerateDirectories(path, searchPattern, searchOption);
	}

	private static IEnumerable<string> InternalEnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemNames(path, searchPattern, searchOption, includeFiles: false, includeDirs: true);
	}

	public static IEnumerable<string> EnumerateFiles(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return InternalEnumerateFiles(path, "*", SearchOption.TopDirectoryOnly);
	}

	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalEnumerateFiles(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalEnumerateFiles(path, searchPattern, searchOption);
	}

	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemNames(path, searchPattern, searchOption, includeFiles: true, includeDirs: false);
	}

	public static IEnumerable<string> EnumerateFileSystemEntries(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return InternalEnumerateFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly);
	}

	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalEnumerateFileSystemEntries(path, searchPattern, SearchOption.TopDirectoryOnly);
	}

	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalEnumerateFileSystemEntries(path, searchPattern, searchOption);
	}

	private static IEnumerable<string> InternalEnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemNames(path, searchPattern, searchOption, includeFiles: true, includeDirs: true);
	}

	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs)
	{
		return FileSystemEnumerableFactory.CreateFileNameIterator(path, path, searchPattern, includeFiles, includeDirs, searchOption, checkHost: true);
	}

	[SecuritySafeCritical]
	public static string[] GetLogicalDrives()
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		int logicalDrives = Win32Native.GetLogicalDrives();
		if (logicalDrives == 0)
		{
			__Error.WinIOError();
		}
		uint num = (uint)logicalDrives;
		int num2 = 0;
		while (num != 0)
		{
			if ((num & 1) != 0)
			{
				num2++;
			}
			num >>= 1;
		}
		string[] array = new string[num2];
		char[] array2 = new char[3] { 'A', ':', '\\' };
		num = (uint)logicalDrives;
		num2 = 0;
		while (num != 0)
		{
			if ((num & 1) != 0)
			{
				array[num2++] = new string(array2);
			}
			num >>= 1;
			array2[0] += '\u0001';
		}
		return array;
	}

	[SecuritySafeCritical]
	public static string GetDirectoryRoot(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		string fullPathInternal = Path.GetFullPathInternal(path);
		string text = fullPathInternal.Substring(0, Path.GetRootLength(fullPathInternal));
		CheckPermissions(path, text, checkHost: true, FileSecurityStateAccess.PathDiscovery);
		return text;
	}

	internal static string InternalGetDirectoryRoot(string path)
	{
		return path?.Substring(0, Path.GetRootLength(path));
	}

	[SecuritySafeCritical]
	public static string GetCurrentDirectory()
	{
		return InternalGetCurrentDirectory(checkHost: true);
	}

	[SecurityCritical]
	internal static string UnsafeGetCurrentDirectory()
	{
		return InternalGetCurrentDirectory(checkHost: false);
	}

	[SecuritySafeCritical]
	private static string InternalGetCurrentDirectory(bool checkHost)
	{
		string text = (AppContextSwitches.UseLegacyPathHandling ? LegacyGetCurrentDirectory() : NewGetCurrentDirectory());
		CheckPermissions(string.Empty, text, checkHost: true, FileSecurityStateAccess.PathDiscovery);
		return text;
	}

	[SecurityCritical]
	private static string LegacyGetCurrentDirectory()
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire(261);
		if (Win32Native.GetCurrentDirectory(stringBuilder.Capacity, stringBuilder) == 0)
		{
			__Error.WinIOError();
		}
		string text = stringBuilder.ToString();
		if (text.IndexOf('~') >= 0)
		{
			int longPathName = Win32Native.GetLongPathName(text, stringBuilder, stringBuilder.Capacity);
			if (longPathName == 0 || longPathName >= 260)
			{
				int num = Marshal.GetLastWin32Error();
				if (longPathName >= 260)
				{
					num = 206;
				}
				if (num != 2 && num != 3 && num != 1 && num != 5)
				{
					__Error.WinIOError(num, string.Empty);
				}
			}
			text = stringBuilder.ToString();
		}
		StringBuilderCache.Release(stringBuilder);
		return text;
	}

	[SecurityCritical]
	private static string NewGetCurrentDirectory()
	{
		using StringBuffer stringBuffer = new StringBuffer(260u);
		uint num = 0u;
		while ((num = Win32Native.GetCurrentDirectoryW(stringBuffer.CharCapacity, stringBuffer.GetHandle())) > stringBuffer.CharCapacity)
		{
			stringBuffer.EnsureCharCapacity(num);
		}
		if (num == 0)
		{
			__Error.WinIOError();
		}
		stringBuffer.Length = num;
		if (stringBuffer.Contains('~'))
		{
			return LongPathHelper.GetLongPathName(stringBuffer);
		}
		return stringBuffer.ToString();
	}

	[SecuritySafeCritical]
	public static void SetCurrentDirectory(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("value");
		}
		if (path.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_PathEmpty"));
		}
		if (PathInternal.IsPathTooLong(path))
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string fullPathInternal = Path.GetFullPathInternal(path);
		if (!Win32Native.SetCurrentDirectory(fullPathInternal))
		{
			int num = Marshal.GetLastWin32Error();
			if (num == 2)
			{
				num = 3;
			}
			__Error.WinIOError(num, fullPathInternal);
		}
	}

	[SecuritySafeCritical]
	public static void Move(string sourceDirName, string destDirName)
	{
		InternalMove(sourceDirName, destDirName, checkHost: true);
	}

	[SecurityCritical]
	internal static void UnsafeMove(string sourceDirName, string destDirName)
	{
		InternalMove(sourceDirName, destDirName, checkHost: false);
	}

	[SecurityCritical]
	private static void InternalMove(string sourceDirName, string destDirName, bool checkHost)
	{
		if (sourceDirName == null)
		{
			throw new ArgumentNullException("sourceDirName");
		}
		if (sourceDirName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "sourceDirName");
		}
		if (destDirName == null)
		{
			throw new ArgumentNullException("destDirName");
		}
		if (destDirName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "destDirName");
		}
		string fullPathInternal = Path.GetFullPathInternal(sourceDirName);
		string demandDir = GetDemandDir(fullPathInternal, thisDirOnly: false);
		if (PathInternal.IsDirectoryTooLong(demandDir))
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		string fullPathInternal2 = Path.GetFullPathInternal(destDirName);
		string demandDir2 = GetDemandDir(fullPathInternal2, thisDirOnly: false);
		if (PathInternal.IsDirectoryTooLong(demandDir))
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, demandDir, checkForDuplicates: false, needFullPath: false);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, demandDir2, checkForDuplicates: false, needFullPath: false);
		if (string.Compare(demandDir, demandDir2, StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SourceDestMustBeDifferent"));
		}
		string pathRoot = Path.GetPathRoot(demandDir);
		string pathRoot2 = Path.GetPathRoot(demandDir2);
		if (string.Compare(pathRoot, pathRoot2, StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SourceDestMustHaveSameRoot"));
		}
		if (!Win32Native.MoveFile(sourceDirName, destDirName))
		{
			int num = Marshal.GetLastWin32Error();
			if (num == 2)
			{
				num = 3;
				__Error.WinIOError(num, fullPathInternal);
			}
			if (num == 5)
			{
				throw new IOException(Environment.GetResourceString("UnauthorizedAccess_IODenied_Path", sourceDirName), Win32Native.MakeHRFromErrorCode(num));
			}
			__Error.WinIOError(num, string.Empty);
		}
	}

	[SecuritySafeCritical]
	public static void Delete(string path)
	{
		string fullPathInternal = Path.GetFullPathInternal(path);
		Delete(fullPathInternal, path, recursive: false, checkHost: true);
	}

	[SecuritySafeCritical]
	public static void Delete(string path, bool recursive)
	{
		string fullPathInternal = Path.GetFullPathInternal(path);
		Delete(fullPathInternal, path, recursive, checkHost: true);
	}

	[SecurityCritical]
	internal static void UnsafeDelete(string path, bool recursive)
	{
		string fullPathInternal = Path.GetFullPathInternal(path);
		Delete(fullPathInternal, path, recursive, checkHost: false);
	}

	[SecurityCritical]
	internal static void Delete(string fullPath, string userPath, bool recursive, bool checkHost)
	{
		string demandDir = GetDemandDir(fullPath, !recursive);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, demandDir, checkForDuplicates: false, needFullPath: false);
		Win32Native.WIN32_FILE_ATTRIBUTE_DATA data = default(Win32Native.WIN32_FILE_ATTRIBUTE_DATA);
		int num = File.FillAttributeInfo(fullPath, ref data, tryagain: false, returnErrorOnNotFound: true);
		if (num != 0)
		{
			if (num == 2)
			{
				num = 3;
			}
			__Error.WinIOError(num, fullPath);
		}
		if ((data.fileAttributes & 0x400) != 0)
		{
			recursive = false;
		}
		Win32Native.WIN32_FIND_DATA data2 = default(Win32Native.WIN32_FIND_DATA);
		DeleteHelper(fullPath, userPath, recursive, throwOnTopLevelDirectoryNotFound: true, ref data2);
	}

	[SecurityCritical]
	private static void DeleteHelper(string fullPath, string userPath, bool recursive, bool throwOnTopLevelDirectoryNotFound, ref Win32Native.WIN32_FIND_DATA data)
	{
		Exception ex = null;
		int lastWin32Error;
		if (recursive)
		{
			using (SafeFindHandle safeFindHandle = Win32Native.FindFirstFile(fullPath + "\\*", ref data))
			{
				if (safeFindHandle.IsInvalid)
				{
					lastWin32Error = Marshal.GetLastWin32Error();
					__Error.WinIOError(lastWin32Error, fullPath);
				}
				do
				{
					if ((data.dwFileAttributes & 0x10) != 0)
					{
						if (data.IsRelativeDirectory)
						{
							continue;
						}
						string cFileName = data.cFileName;
						if ((data.dwFileAttributes & 0x400) == 0)
						{
							string fullPath2 = Path.CombineNoChecks(fullPath, cFileName);
							string userPath2 = Path.CombineNoChecks(userPath, cFileName);
							try
							{
								DeleteHelper(fullPath2, userPath2, recursive, throwOnTopLevelDirectoryNotFound: false, ref data);
							}
							catch (Exception ex2)
							{
								if (ex == null)
								{
									ex = ex2;
								}
							}
							continue;
						}
						if (data.dwReserved0 == -1610612733)
						{
							string mountPoint = Path.CombineNoChecks(fullPath, cFileName + Path.DirectorySeparatorChar);
							if (!Win32Native.DeleteVolumeMountPoint(mountPoint))
							{
								lastWin32Error = Marshal.GetLastWin32Error();
								if (lastWin32Error != 3)
								{
									try
									{
										__Error.WinIOError(lastWin32Error, cFileName);
									}
									catch (Exception ex3)
									{
										if (ex == null)
										{
											ex = ex3;
										}
									}
								}
							}
						}
						string path = Path.CombineNoChecks(fullPath, cFileName);
						if (Win32Native.RemoveDirectory(path))
						{
							continue;
						}
						lastWin32Error = Marshal.GetLastWin32Error();
						if (lastWin32Error == 3)
						{
							continue;
						}
						try
						{
							__Error.WinIOError(lastWin32Error, cFileName);
						}
						catch (Exception ex4)
						{
							if (ex == null)
							{
								ex = ex4;
							}
						}
						continue;
					}
					string cFileName2 = data.cFileName;
					if (Win32Native.DeleteFile(Path.CombineNoChecks(fullPath, cFileName2)))
					{
						continue;
					}
					lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 2)
					{
						continue;
					}
					try
					{
						__Error.WinIOError(lastWin32Error, cFileName2);
					}
					catch (Exception ex5)
					{
						if (ex == null)
						{
							ex = ex5;
						}
					}
				}
				while (Win32Native.FindNextFile(safeFindHandle, ref data));
				lastWin32Error = Marshal.GetLastWin32Error();
			}
			if (ex != null)
			{
				throw ex;
			}
			if (lastWin32Error != 0 && lastWin32Error != 18)
			{
				__Error.WinIOError(lastWin32Error, userPath);
			}
		}
		if (Win32Native.RemoveDirectory(fullPath))
		{
			return;
		}
		lastWin32Error = Marshal.GetLastWin32Error();
		if (lastWin32Error == 2)
		{
			lastWin32Error = 3;
		}
		switch (lastWin32Error)
		{
		case 5:
			throw new IOException(Environment.GetResourceString("UnauthorizedAccess_IODenied_Path", userPath));
		case 3:
			if (!throwOnTopLevelDirectoryNotFound)
			{
				return;
			}
			break;
		}
		__Error.WinIOError(lastWin32Error, fullPath);
	}

	[SecurityCritical]
	private static SafeFileHandle OpenHandle(string path)
	{
		string fullPathInternal = Path.GetFullPathInternal(path);
		string pathRoot = Path.GetPathRoot(fullPathInternal);
		if (pathRoot == fullPathInternal && pathRoot[1] == Path.VolumeSeparatorChar)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_PathIsVolume"));
		}
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, GetDemandDir(fullPathInternal, thisDirOnly: true), checkForDuplicates: false, needFullPath: false);
		SafeFileHandle safeFileHandle = Win32Native.SafeCreateFile(fullPathInternal, 1073741824, FileShare.Write | FileShare.Delete, null, FileMode.Open, 33554432, IntPtr.Zero);
		if (safeFileHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			__Error.WinIOError(lastWin32Error, fullPathInternal);
		}
		return safeFileHandle;
	}
}
