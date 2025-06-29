using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public sealed class DirectoryInfo : FileSystemInfo
{
	private string[] demandDir;

	public override string Name => GetDirName(FullPath);

	public override string FullName
	{
		[SecuritySafeCritical]
		get
		{
			Directory.CheckPermissions(string.Empty, FullPath, checkHost: true, FileSecurityStateAccess.PathDiscovery);
			return FullPath;
		}
	}

	internal override string UnsafeGetFullName
	{
		[SecurityCritical]
		get
		{
			Directory.CheckPermissions(string.Empty, FullPath, checkHost: false, FileSecurityStateAccess.PathDiscovery);
			return FullPath;
		}
	}

	public DirectoryInfo Parent
	{
		[SecuritySafeCritical]
		get
		{
			string text = FullPath;
			if (text.Length > 3 && text.EndsWith(Path.DirectorySeparatorChar))
			{
				text = FullPath.Substring(0, FullPath.Length - 1);
			}
			string directoryName = Path.GetDirectoryName(text);
			if (directoryName == null)
			{
				return null;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(directoryName, junk: false);
			Directory.CheckPermissions(string.Empty, directoryInfo.FullPath, checkHost: true, FileSecurityStateAccess.Read | FileSecurityStateAccess.PathDiscovery);
			return directoryInfo;
		}
	}

	public override bool Exists
	{
		[SecuritySafeCritical]
		get
		{
			try
			{
				if (_dataInitialised == -1)
				{
					Refresh();
				}
				if (_dataInitialised != 0)
				{
					return false;
				}
				return _data.fileAttributes != -1 && (_data.fileAttributes & 0x10) != 0;
			}
			catch
			{
				return false;
			}
		}
	}

	public DirectoryInfo Root
	{
		[SecuritySafeCritical]
		get
		{
			int rootLength = Path.GetRootLength(FullPath);
			string text = FullPath.Substring(0, rootLength);
			string fullPath = Directory.GetDemandDir(text, thisDirOnly: true);
			FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, fullPath, checkForDuplicates: false, needFullPath: false);
			return new DirectoryInfo(text);
		}
	}

	[SecuritySafeCritical]
	public DirectoryInfo(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		Init(path, checkHost: true);
	}

	[SecurityCritical]
	private void Init(string path, bool checkHost)
	{
		if (path.Length == 2 && path[1] == ':')
		{
			OriginalPath = ".";
		}
		else
		{
			OriginalPath = path;
		}
		string fullPathAndCheckPermissions = Directory.GetFullPathAndCheckPermissions(path, checkHost);
		FullPath = fullPathAndCheckPermissions;
		base.DisplayPath = GetDisplayName(OriginalPath, FullPath);
	}

	internal DirectoryInfo(string fullPath, bool junk)
	{
		OriginalPath = Path.GetFileName(fullPath);
		FullPath = fullPath;
		base.DisplayPath = GetDisplayName(OriginalPath, FullPath);
	}

	internal DirectoryInfo(string fullPath, string fileName)
	{
		OriginalPath = fileName;
		FullPath = fullPath;
		base.DisplayPath = GetDisplayName(OriginalPath, FullPath);
	}

	[SecurityCritical]
	private DirectoryInfo(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		Directory.CheckPermissions(string.Empty, FullPath, checkHost: false);
		base.DisplayPath = GetDisplayName(OriginalPath, FullPath);
	}

	public DirectoryInfo CreateSubdirectory(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return CreateSubdirectory(path, null);
	}

	[SecuritySafeCritical]
	public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity)
	{
		return CreateSubdirectoryHelper(path, directorySecurity);
	}

	[SecurityCritical]
	private DirectoryInfo CreateSubdirectoryHelper(string path, object directorySecurity)
	{
		string path2 = Path.InternalCombine(FullPath, path);
		string fullPathInternal = Path.GetFullPathInternal(path2);
		if (string.Compare(FullPath, 0, fullPathInternal, 0, FullPath.Length, StringComparison.OrdinalIgnoreCase) != 0)
		{
			string displayablePath = __Error.GetDisplayablePath(base.DisplayPath, isInvalidPath: false);
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSubPath", path, displayablePath));
		}
		string fullPath = Directory.GetDemandDir(fullPathInternal, thisDirOnly: true);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, fullPath, checkForDuplicates: false, needFullPath: false);
		Directory.InternalCreateDirectory(fullPathInternal, path, directorySecurity);
		return new DirectoryInfo(fullPathInternal);
	}

	public void Create()
	{
		Directory.InternalCreateDirectory(FullPath, OriginalPath, null, checkHost: true);
	}

	public void Create(DirectorySecurity directorySecurity)
	{
		Directory.InternalCreateDirectory(FullPath, OriginalPath, directorySecurity, checkHost: true);
	}

	public DirectorySecurity GetAccessControl()
	{
		return Directory.GetAccessControl(FullPath, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	public DirectorySecurity GetAccessControl(AccessControlSections includeSections)
	{
		return Directory.GetAccessControl(FullPath, includeSections);
	}

	public void SetAccessControl(DirectorySecurity directorySecurity)
	{
		Directory.SetAccessControl(FullPath, directorySecurity);
	}

	public FileInfo[] GetFiles(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalGetFiles(searchPattern, SearchOption.TopDirectoryOnly);
	}

	public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalGetFiles(searchPattern, searchOption);
	}

	private FileInfo[] InternalGetFiles(string searchPattern, SearchOption searchOption)
	{
		IEnumerable<FileInfo> collection = FileSystemEnumerableFactory.CreateFileInfoIterator(FullPath, OriginalPath, searchPattern, searchOption);
		List<FileInfo> list = new List<FileInfo>(collection);
		return list.ToArray();
	}

	public FileInfo[] GetFiles()
	{
		return InternalGetFiles("*", SearchOption.TopDirectoryOnly);
	}

	public DirectoryInfo[] GetDirectories()
	{
		return InternalGetDirectories("*", SearchOption.TopDirectoryOnly);
	}

	public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalGetFileSystemInfos(searchPattern, SearchOption.TopDirectoryOnly);
	}

	public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalGetFileSystemInfos(searchPattern, searchOption);
	}

	private FileSystemInfo[] InternalGetFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		IEnumerable<FileSystemInfo> collection = FileSystemEnumerableFactory.CreateFileSystemInfoIterator(FullPath, OriginalPath, searchPattern, searchOption);
		List<FileSystemInfo> list = new List<FileSystemInfo>(collection);
		return list.ToArray();
	}

	public FileSystemInfo[] GetFileSystemInfos()
	{
		return InternalGetFileSystemInfos("*", SearchOption.TopDirectoryOnly);
	}

	public DirectoryInfo[] GetDirectories(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalGetDirectories(searchPattern, SearchOption.TopDirectoryOnly);
	}

	public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalGetDirectories(searchPattern, searchOption);
	}

	private DirectoryInfo[] InternalGetDirectories(string searchPattern, SearchOption searchOption)
	{
		IEnumerable<DirectoryInfo> collection = FileSystemEnumerableFactory.CreateDirectoryInfoIterator(FullPath, OriginalPath, searchPattern, searchOption);
		List<DirectoryInfo> list = new List<DirectoryInfo>(collection);
		return list.ToArray();
	}

	public IEnumerable<DirectoryInfo> EnumerateDirectories()
	{
		return InternalEnumerateDirectories("*", SearchOption.TopDirectoryOnly);
	}

	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalEnumerateDirectories(searchPattern, SearchOption.TopDirectoryOnly);
	}

	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalEnumerateDirectories(searchPattern, searchOption);
	}

	private IEnumerable<DirectoryInfo> InternalEnumerateDirectories(string searchPattern, SearchOption searchOption)
	{
		return FileSystemEnumerableFactory.CreateDirectoryInfoIterator(FullPath, OriginalPath, searchPattern, searchOption);
	}

	public IEnumerable<FileInfo> EnumerateFiles()
	{
		return InternalEnumerateFiles("*", SearchOption.TopDirectoryOnly);
	}

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalEnumerateFiles(searchPattern, SearchOption.TopDirectoryOnly);
	}

	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalEnumerateFiles(searchPattern, searchOption);
	}

	private IEnumerable<FileInfo> InternalEnumerateFiles(string searchPattern, SearchOption searchOption)
	{
		return FileSystemEnumerableFactory.CreateFileInfoIterator(FullPath, OriginalPath, searchPattern, searchOption);
	}

	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
	{
		return InternalEnumerateFileSystemInfos("*", SearchOption.TopDirectoryOnly);
	}

	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		return InternalEnumerateFileSystemInfos(searchPattern, SearchOption.TopDirectoryOnly);
	}

	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (searchOption != SearchOption.TopDirectoryOnly && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentOutOfRangeException("searchOption", Environment.GetResourceString("ArgumentOutOfRange_Enum"));
		}
		return InternalEnumerateFileSystemInfos(searchPattern, searchOption);
	}

	private IEnumerable<FileSystemInfo> InternalEnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		return FileSystemEnumerableFactory.CreateFileSystemInfoIterator(FullPath, OriginalPath, searchPattern, searchOption);
	}

	[SecuritySafeCritical]
	public void MoveTo(string destDirName)
	{
		if (destDirName == null)
		{
			throw new ArgumentNullException("destDirName");
		}
		if (destDirName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "destDirName");
		}
		Directory.CheckPermissions(base.DisplayPath, FullPath, checkHost: true, FileSecurityStateAccess.Read | FileSecurityStateAccess.Write);
		string text = Path.GetFullPathInternal(destDirName);
		if (!text.EndsWith(Path.DirectorySeparatorChar))
		{
			text += Path.DirectorySeparatorChar;
		}
		Directory.CheckPermissions(destDirName, text, checkHost: true, FileSecurityStateAccess.Read | FileSecurityStateAccess.Write);
		string text2 = ((!FullPath.EndsWith(Path.DirectorySeparatorChar)) ? (FullPath + Path.DirectorySeparatorChar) : FullPath);
		if (string.Compare(text2, text, StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SourceDestMustBeDifferent"));
		}
		string pathRoot = Path.GetPathRoot(text2);
		string pathRoot2 = Path.GetPathRoot(text);
		if (string.Compare(pathRoot, pathRoot2, StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SourceDestMustHaveSameRoot"));
		}
		if (!Win32Native.MoveFile(FullPath, destDirName))
		{
			int num = Marshal.GetLastWin32Error();
			if (num == 2)
			{
				num = 3;
				__Error.WinIOError(num, base.DisplayPath);
			}
			if (num == 5)
			{
				throw new IOException(Environment.GetResourceString("UnauthorizedAccess_IODenied_Path", base.DisplayPath));
			}
			__Error.WinIOError(num, string.Empty);
		}
		FullPath = text;
		OriginalPath = destDirName;
		base.DisplayPath = GetDisplayName(OriginalPath, FullPath);
		_dataInitialised = -1;
	}

	[SecuritySafeCritical]
	public override void Delete()
	{
		Directory.Delete(FullPath, OriginalPath, recursive: false, checkHost: true);
	}

	[SecuritySafeCritical]
	public void Delete(bool recursive)
	{
		Directory.Delete(FullPath, OriginalPath, recursive, checkHost: true);
	}

	public override string ToString()
	{
		return base.DisplayPath;
	}

	private static string GetDisplayName(string originalPath, string fullPath)
	{
		string text = "";
		if (originalPath.Length == 2 && originalPath[1] == ':')
		{
			return ".";
		}
		return originalPath;
	}

	private static string GetDirName(string fullPath)
	{
		string text = null;
		if (fullPath.Length > 3)
		{
			string path = fullPath;
			if (fullPath.EndsWith(Path.DirectorySeparatorChar))
			{
				path = fullPath.Substring(0, fullPath.Length - 1);
			}
			return Path.GetFileName(path);
		}
		return fullPath;
	}
}
