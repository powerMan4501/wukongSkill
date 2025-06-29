using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

[ComVisible(false)]
internal static class LongPathDirectory
{
	[SecurityCritical]
	internal static void CreateDirectory(string path)
	{
		string fullPath = LongPath.NormalizePath(path);
		string demandDir = GetDemandDir(fullPath, thisDirOnly: true);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Read, demandDir, checkForDuplicates: false, needFullPath: false);
		InternalCreateDirectory(fullPath, path, null);
	}

	[SecurityCritical]
	private unsafe static void InternalCreateDirectory(string fullPath, string path, object dirSecurityObj)
	{
		DirectorySecurity directorySecurity = (DirectorySecurity)dirSecurityObj;
		int num = fullPath.Length;
		if (num >= 2 && Path.IsDirectorySeparator(fullPath[num - 1]))
		{
			num--;
		}
		int rootLength = LongPath.GetRootLength(fullPath);
		if (num == 2 && Path.IsDirectorySeparator(fullPath[1]))
		{
			throw new IOException(Environment.GetResourceString("IO.IO_CannotCreateDirectory", path));
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
			if (text2.Length >= 32767)
			{
				throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
			}
			flag2 = Win32Native.CreateDirectory(PathInternal.EnsureExtendedPrefix(text2), sECURITY_ATTRIBUTES);
			if (flag2 || num3 != 0)
			{
				continue;
			}
			int lastError = Marshal.GetLastWin32Error();
			if (lastError != 183)
			{
				num3 = lastError;
			}
			else if (LongPathFile.InternalExists(text2) || (!InternalExists(text2, out lastError) && lastError == 5))
			{
				num3 = lastError;
				try
				{
					FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, GetDemandDir(text2, thisDirOnly: true), checkForDuplicates: false, needFullPath: false);
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

	[SecurityCritical]
	internal static void Move(string sourceDirName, string destDirName)
	{
		string text = LongPath.NormalizePath(sourceDirName);
		string demandDir = GetDemandDir(text, thisDirOnly: false);
		if (demandDir.Length >= 32767)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		string fullPath = LongPath.NormalizePath(destDirName);
		string demandDir2 = GetDemandDir(fullPath, thisDirOnly: false);
		if (demandDir2.Length >= 32767)
		{
			throw new PathTooLongException(Environment.GetResourceString("IO.PathTooLong"));
		}
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, demandDir, checkForDuplicates: false, needFullPath: false);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, demandDir2, checkForDuplicates: false, needFullPath: false);
		if (string.Compare(demandDir, demandDir2, StringComparison.OrdinalIgnoreCase) == 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SourceDestMustBeDifferent"));
		}
		string pathRoot = LongPath.GetPathRoot(demandDir);
		string pathRoot2 = LongPath.GetPathRoot(demandDir2);
		if (string.Compare(pathRoot, pathRoot2, StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_SourceDestMustHaveSameRoot"));
		}
		string src = PathInternal.EnsureExtendedPrefix(sourceDirName);
		string dst = PathInternal.EnsureExtendedPrefix(destDirName);
		if (!Win32Native.MoveFile(src, dst))
		{
			int num = Marshal.GetLastWin32Error();
			if (num == 2)
			{
				num = 3;
				__Error.WinIOError(num, text);
			}
			if (num == 5)
			{
				throw new IOException(Environment.GetResourceString("UnauthorizedAccess_IODenied_Path", sourceDirName), Win32Native.MakeHRFromErrorCode(num));
			}
			__Error.WinIOError(num, string.Empty);
		}
	}

	[SecurityCritical]
	internal static void Delete(string path, bool recursive)
	{
		string fullPath = LongPath.NormalizePath(path);
		InternalDelete(fullPath, path, recursive);
	}

	[SecurityCritical]
	private static void InternalDelete(string fullPath, string userPath, bool recursive)
	{
		string demandDir = GetDemandDir(fullPath, !recursive);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, demandDir, checkForDuplicates: false, needFullPath: false);
		string text = Path.AddLongPathPrefix(fullPath);
		Win32Native.WIN32_FILE_ATTRIBUTE_DATA data = default(Win32Native.WIN32_FILE_ATTRIBUTE_DATA);
		int num = File.FillAttributeInfo(text, ref data, tryagain: false, returnErrorOnNotFound: true);
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
		DeleteHelper(text, userPath, recursive, throwOnTopLevelDirectoryNotFound: true);
	}

	[SecurityCritical]
	private static void DeleteHelper(string fullPath, string userPath, bool recursive, bool throwOnTopLevelDirectoryNotFound)
	{
		Exception ex = null;
		int lastWin32Error;
		if (recursive)
		{
			Win32Native.WIN32_FIND_DATA data = default(Win32Native.WIN32_FIND_DATA);
			string text = null;
			text = ((!fullPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal)) ? (fullPath + Path.DirectorySeparatorChar + "*") : (fullPath + "*"));
			using (SafeFindHandle safeFindHandle = Win32Native.FindFirstFile(text, ref data))
			{
				if (safeFindHandle.IsInvalid)
				{
					lastWin32Error = Marshal.GetLastWin32Error();
					__Error.WinIOError(lastWin32Error, userPath);
				}
				do
				{
					if ((data.dwFileAttributes & 0x10) != 0)
					{
						if (data.IsRelativeDirectory)
						{
							continue;
						}
						if ((data.dwFileAttributes & 0x400) == 0)
						{
							string fullPath2 = LongPath.InternalCombine(fullPath, data.cFileName);
							string userPath2 = LongPath.InternalCombine(userPath, data.cFileName);
							try
							{
								DeleteHelper(fullPath2, userPath2, recursive, throwOnTopLevelDirectoryNotFound: false);
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
							string mountPoint = LongPath.InternalCombine(fullPath, data.cFileName + Path.DirectorySeparatorChar);
							if (!Win32Native.DeleteVolumeMountPoint(mountPoint))
							{
								lastWin32Error = Marshal.GetLastWin32Error();
								if (lastWin32Error != 3)
								{
									try
									{
										__Error.WinIOError(lastWin32Error, data.cFileName);
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
						string path = LongPath.InternalCombine(fullPath, data.cFileName);
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
							__Error.WinIOError(lastWin32Error, data.cFileName);
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
					string path2 = LongPath.InternalCombine(fullPath, data.cFileName);
					if (Win32Native.DeleteFile(path2))
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
						__Error.WinIOError(lastWin32Error, data.cFileName);
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
		__Error.WinIOError(lastWin32Error, userPath);
	}

	[SecurityCritical]
	internal static bool Exists(string path)
	{
		try
		{
			if (path == null)
			{
				return false;
			}
			if (path.Length == 0)
			{
				return false;
			}
			string text = LongPath.NormalizePath(path);
			string demandDir = GetDemandDir(text, thisDirOnly: true);
			FileIOPermission.QuickDemand(FileIOPermissionAccess.Read, demandDir, checkForDuplicates: false, needFullPath: false);
			return InternalExists(text);
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
		string path2 = Path.AddLongPathPrefix(path);
		return Directory.InternalExists(path2, out lastError);
	}

	private static string GetDemandDir(string fullPath, bool thisDirOnly)
	{
		fullPath = Path.RemoveLongPathPrefix(fullPath);
		if (thisDirOnly)
		{
			if (fullPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal) || fullPath.EndsWith(Path.AltDirectorySeparatorChar.ToString(), StringComparison.Ordinal))
			{
				return fullPath + ".";
			}
			return fullPath + Path.DirectorySeparatorChar + ".";
		}
		if (!fullPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal) && !fullPath.EndsWith(Path.AltDirectorySeparatorChar.ToString(), StringComparison.Ordinal))
		{
			return fullPath + Path.DirectorySeparatorChar;
		}
		return fullPath;
	}

	private static string InternalGetDirectoryRoot(string path)
	{
		return path?.Substring(0, LongPath.GetRootLength(path));
	}
}
