using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System.IO;

[Serializable]
[ComVisible(true)]
public sealed class DriveInfo : ISerializable
{
	private string _name;

	private const string NameField = "_name";

	public string Name => _name;

	public DriveType DriveType
	{
		[SecuritySafeCritical]
		get
		{
			return (DriveType)Win32Native.GetDriveType(Name);
		}
	}

	public string DriveFormat
	{
		[SecuritySafeCritical]
		get
		{
			StringBuilder volumeName = new StringBuilder(50);
			StringBuilder stringBuilder = new StringBuilder(50);
			int errorMode = Win32Native.SetErrorMode(1);
			try
			{
				if (!Win32Native.GetVolumeInformation(Name, volumeName, 50, out var _, out var _, out var _, stringBuilder, 50))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					__Error.WinIODriveError(Name, lastWin32Error);
				}
			}
			finally
			{
				Win32Native.SetErrorMode(errorMode);
			}
			return stringBuilder.ToString();
		}
	}

	public bool IsReady
	{
		[SecuritySafeCritical]
		get
		{
			return Directory.InternalExists(Name);
		}
	}

	public long AvailableFreeSpace
	{
		[SecuritySafeCritical]
		get
		{
			int errorMode = Win32Native.SetErrorMode(1);
			long freeBytesForUser;
			try
			{
				if (!Win32Native.GetDiskFreeSpaceEx(Name, out freeBytesForUser, out var _, out var _))
				{
					__Error.WinIODriveError(Name);
				}
			}
			finally
			{
				Win32Native.SetErrorMode(errorMode);
			}
			return freeBytesForUser;
		}
	}

	public long TotalFreeSpace
	{
		[SecuritySafeCritical]
		get
		{
			int errorMode = Win32Native.SetErrorMode(1);
			long freeBytes;
			try
			{
				if (!Win32Native.GetDiskFreeSpaceEx(Name, out var _, out var _, out freeBytes))
				{
					__Error.WinIODriveError(Name);
				}
			}
			finally
			{
				Win32Native.SetErrorMode(errorMode);
			}
			return freeBytes;
		}
	}

	public long TotalSize
	{
		[SecuritySafeCritical]
		get
		{
			int errorMode = Win32Native.SetErrorMode(1);
			long totalBytes;
			try
			{
				if (!Win32Native.GetDiskFreeSpaceEx(Name, out var _, out totalBytes, out var _))
				{
					__Error.WinIODriveError(Name);
				}
			}
			finally
			{
				Win32Native.SetErrorMode(errorMode);
			}
			return totalBytes;
		}
	}

	public DirectoryInfo RootDirectory => new DirectoryInfo(Name);

	public string VolumeLabel
	{
		[SecuritySafeCritical]
		get
		{
			StringBuilder stringBuilder = new StringBuilder(50);
			StringBuilder fileSystemName = new StringBuilder(50);
			int errorMode = Win32Native.SetErrorMode(1);
			try
			{
				if (!Win32Native.GetVolumeInformation(Name, stringBuilder, 50, out var _, out var _, out var _, fileSystemName, 50))
				{
					int num = Marshal.GetLastWin32Error();
					if (num == 13)
					{
						num = 15;
					}
					__Error.WinIODriveError(Name, num);
				}
			}
			finally
			{
				Win32Native.SetErrorMode(errorMode);
			}
			return stringBuilder.ToString();
		}
		[SecuritySafeCritical]
		set
		{
			string path = _name + ".";
			new FileIOPermission(FileIOPermissionAccess.Write, path).Demand();
			int errorMode = Win32Native.SetErrorMode(1);
			try
			{
				if (!Win32Native.SetVolumeLabel(Name, value))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 5)
					{
						throw new UnauthorizedAccessException(Environment.GetResourceString("InvalidOperation_SetVolumeLabelFailed"));
					}
					__Error.WinIODriveError(Name, lastWin32Error);
				}
			}
			finally
			{
				Win32Native.SetErrorMode(errorMode);
			}
		}
	}

	[SecuritySafeCritical]
	public DriveInfo(string driveName)
	{
		if (driveName == null)
		{
			throw new ArgumentNullException("driveName");
		}
		if (driveName.Length == 1)
		{
			_name = driveName + ":\\";
		}
		else
		{
			Path.CheckInvalidPathChars(driveName);
			_name = Path.GetPathRoot(driveName);
			if (_name == null || _name.Length == 0 || _name.StartsWith("\\\\", StringComparison.Ordinal))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDriveLetterOrRootDir"));
			}
		}
		if (_name.Length == 2 && _name[1] == ':')
		{
			_name += "\\";
		}
		char c = driveName[0];
		if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z'))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDriveLetterOrRootDir"));
		}
		string path = _name + ".";
		new FileIOPermission(FileIOPermissionAccess.PathDiscovery, path).Demand();
	}

	[SecurityCritical]
	private DriveInfo(SerializationInfo info, StreamingContext context)
	{
		_name = (string)info.GetValue("_name", typeof(string));
		string path = _name + ".";
		new FileIOPermission(FileIOPermissionAccess.PathDiscovery, path).Demand();
	}

	public static DriveInfo[] GetDrives()
	{
		string[] logicalDrives = Directory.GetLogicalDrives();
		DriveInfo[] array = new DriveInfo[logicalDrives.Length];
		for (int i = 0; i < logicalDrives.Length; i++)
		{
			array[i] = new DriveInfo(logicalDrives[i]);
		}
		return array;
	}

	public override string ToString()
	{
		return Name;
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("_name", _name, typeof(string));
	}
}
