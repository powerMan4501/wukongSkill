using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public sealed class FileInfo : FileSystemInfo
{
	private string _name;

	public override string Name => _name;

	public long Length
	{
		[SecuritySafeCritical]
		get
		{
			if (_dataInitialised == -1)
			{
				Refresh();
			}
			if (_dataInitialised != 0)
			{
				__Error.WinIOError(_dataInitialised, base.DisplayPath);
			}
			if ((_data.fileAttributes & 0x10) != 0)
			{
				__Error.WinIOError(2, base.DisplayPath);
			}
			return ((long)_data.fileSizeHigh << 32) | (_data.fileSizeLow & 0xFFFFFFFFu);
		}
	}

	public string DirectoryName
	{
		[SecuritySafeCritical]
		get
		{
			string directoryName = Path.GetDirectoryName(FullPath);
			if (directoryName != null)
			{
				FileIOPermission.QuickDemand(FileIOPermissionAccess.PathDiscovery, directoryName, checkForDuplicates: false, needFullPath: false);
			}
			return directoryName;
		}
	}

	public DirectoryInfo Directory
	{
		get
		{
			string directoryName = DirectoryName;
			if (directoryName == null)
			{
				return null;
			}
			return new DirectoryInfo(directoryName);
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return (base.Attributes & FileAttributes.ReadOnly) != 0;
		}
		set
		{
			if (value)
			{
				base.Attributes |= FileAttributes.ReadOnly;
			}
			else
			{
				base.Attributes &= ~FileAttributes.ReadOnly;
			}
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
				return (_data.fileAttributes & 0x10) == 0;
			}
			catch
			{
				return false;
			}
		}
	}

	[SecuritySafeCritical]
	public FileInfo(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		Init(fileName, checkHost: true);
	}

	[SecurityCritical]
	private void Init(string fileName, bool checkHost)
	{
		OriginalPath = fileName;
		string fullPathInternal = Path.GetFullPathInternal(fileName);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Read, fullPathInternal, checkForDuplicates: false, needFullPath: false);
		_name = Path.GetFileName(fileName);
		FullPath = fullPathInternal;
		base.DisplayPath = GetDisplayPath(fileName);
	}

	private string GetDisplayPath(string originalPath)
	{
		return originalPath;
	}

	[SecurityCritical]
	private FileInfo(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Read, FullPath, checkForDuplicates: false, needFullPath: false);
		_name = Path.GetFileName(OriginalPath);
		base.DisplayPath = GetDisplayPath(OriginalPath);
	}

	internal FileInfo(string fullPath, bool ignoreThis)
	{
		_name = Path.GetFileName(fullPath);
		OriginalPath = _name;
		FullPath = fullPath;
		base.DisplayPath = _name;
	}

	internal FileInfo(string fullPath, string fileName)
	{
		_name = fileName;
		OriginalPath = _name;
		FullPath = fullPath;
		base.DisplayPath = _name;
	}

	public FileSecurity GetAccessControl()
	{
		return File.GetAccessControl(FullPath, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	public FileSecurity GetAccessControl(AccessControlSections includeSections)
	{
		return File.GetAccessControl(FullPath, includeSections);
	}

	public void SetAccessControl(FileSecurity fileSecurity)
	{
		File.SetAccessControl(FullPath, fileSecurity);
	}

	[SecuritySafeCritical]
	public StreamReader OpenText()
	{
		return new StreamReader(FullPath, Encoding.UTF8, detectEncodingFromByteOrderMarks: true, StreamReader.DefaultBufferSize, checkHost: false);
	}

	public StreamWriter CreateText()
	{
		return new StreamWriter(FullPath, append: false);
	}

	public StreamWriter AppendText()
	{
		return new StreamWriter(FullPath, append: true);
	}

	public FileInfo CopyTo(string destFileName)
	{
		if (destFileName == null)
		{
			throw new ArgumentNullException("destFileName", Environment.GetResourceString("ArgumentNull_FileName"));
		}
		if (destFileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "destFileName");
		}
		destFileName = File.InternalCopy(FullPath, destFileName, overwrite: false, checkHost: true);
		return new FileInfo(destFileName, ignoreThis: false);
	}

	public FileInfo CopyTo(string destFileName, bool overwrite)
	{
		if (destFileName == null)
		{
			throw new ArgumentNullException("destFileName", Environment.GetResourceString("ArgumentNull_FileName"));
		}
		if (destFileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "destFileName");
		}
		destFileName = File.InternalCopy(FullPath, destFileName, overwrite, checkHost: true);
		return new FileInfo(destFileName, ignoreThis: false);
	}

	public FileStream Create()
	{
		return File.Create(FullPath);
	}

	[SecuritySafeCritical]
	public override void Delete()
	{
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, FullPath, checkForDuplicates: false, needFullPath: false);
		if (!Win32Native.DeleteFile(FullPath))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 2)
			{
				__Error.WinIOError(lastWin32Error, base.DisplayPath);
			}
		}
	}

	[ComVisible(false)]
	public void Decrypt()
	{
		File.Decrypt(FullPath);
	}

	[ComVisible(false)]
	public void Encrypt()
	{
		File.Encrypt(FullPath);
	}

	public FileStream Open(FileMode mode)
	{
		return Open(mode, FileAccess.ReadWrite, FileShare.None);
	}

	public FileStream Open(FileMode mode, FileAccess access)
	{
		return Open(mode, access, FileShare.None);
	}

	public FileStream Open(FileMode mode, FileAccess access, FileShare share)
	{
		return new FileStream(FullPath, mode, access, share);
	}

	public FileStream OpenRead()
	{
		return new FileStream(FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, useAsync: false);
	}

	public FileStream OpenWrite()
	{
		return new FileStream(FullPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
	}

	[SecuritySafeCritical]
	public void MoveTo(string destFileName)
	{
		if (destFileName == null)
		{
			throw new ArgumentNullException("destFileName");
		}
		if (destFileName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyFileName"), "destFileName");
		}
		string fullPathInternal = Path.GetFullPathInternal(destFileName);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, FullPath, checkForDuplicates: false, needFullPath: false);
		FileIOPermission.QuickDemand(FileIOPermissionAccess.Write, fullPathInternal, checkForDuplicates: false, needFullPath: false);
		if (!Win32Native.MoveFile(FullPath, fullPathInternal))
		{
			__Error.WinIOError();
		}
		FullPath = fullPathInternal;
		OriginalPath = destFileName;
		_name = Path.GetFileName(fullPathInternal);
		base.DisplayPath = GetDisplayPath(destFileName);
		_dataInitialised = -1;
	}

	[ComVisible(false)]
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName)
	{
		return Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors: false);
	}

	[ComVisible(false)]
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
	{
		File.Replace(FullPath, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
		return new FileInfo(destinationFileName);
	}

	public override string ToString()
	{
		return base.DisplayPath;
	}
}
