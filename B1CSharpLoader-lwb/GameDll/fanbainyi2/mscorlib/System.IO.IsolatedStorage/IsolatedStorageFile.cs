using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.IsolatedStorage;

[ComVisible(true)]
public sealed class IsolatedStorageFile : IsolatedStorage, IDisposable
{
	private const int s_BlockSize = 1024;

	private const int s_DirSize = 1024;

	private const string s_name = "file.store";

	internal const string s_Files = "Files";

	internal const string s_AssemFiles = "AssemFiles";

	internal const string s_AppFiles = "AppFiles";

	internal const string s_IDFile = "identity.dat";

	internal const string s_InfoFile = "info.dat";

	internal const string s_AppInfoFile = "appinfo.dat";

	private static volatile string s_RootDirUser;

	private static volatile string s_RootDirMachine;

	private static volatile string s_RootDirRoaming;

	private static volatile string s_appDataDir;

	private static volatile FileIOPermission s_PermUser;

	private static volatile FileIOPermission s_PermMachine;

	private static volatile FileIOPermission s_PermRoaming;

	private static volatile IsolatedStorageFilePermission s_PermAdminUser;

	private FileIOPermission m_fiop;

	private string m_RootDir;

	private string m_InfoFile;

	private string m_SyncObjectName;

	[SecurityCritical]
	private SafeIsolatedStorageFileHandle m_handle;

	private bool m_closed;

	private bool m_bDisposed;

	private object m_internalLock = new object();

	private IsolatedStorageScope m_StoreScope;

	public override long UsedSize
	{
		[SecuritySafeCritical]
		get
		{
			if (IsRoaming())
			{
				throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_CurrentSizeUndefined"));
			}
			lock (m_internalLock)
			{
				if (m_bDisposed)
				{
					throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
				}
				if (m_closed)
				{
					throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
				}
				if (InvalidFileHandle)
				{
					m_handle = Open(m_InfoFile, GetSyncObjectName());
				}
				return (long)GetUsage(m_handle);
			}
		}
	}

	[CLSCompliant(false)]
	[Obsolete("IsolatedStorageFile.CurrentSize has been deprecated because it is not CLS Compliant.  To get the current size use IsolatedStorageFile.UsedSize")]
	public override ulong CurrentSize
	{
		[SecuritySafeCritical]
		get
		{
			if (IsRoaming())
			{
				throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_CurrentSizeUndefined"));
			}
			lock (m_internalLock)
			{
				if (m_bDisposed)
				{
					throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
				}
				if (m_closed)
				{
					throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
				}
				if (InvalidFileHandle)
				{
					m_handle = Open(m_InfoFile, GetSyncObjectName());
				}
				return GetUsage(m_handle);
			}
		}
	}

	[ComVisible(false)]
	public override long AvailableFreeSpace
	{
		[SecuritySafeCritical]
		get
		{
			if (IsRoaming())
			{
				return long.MaxValue;
			}
			long usage;
			lock (m_internalLock)
			{
				if (m_bDisposed)
				{
					throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
				}
				if (m_closed)
				{
					throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
				}
				if (InvalidFileHandle)
				{
					m_handle = Open(m_InfoFile, GetSyncObjectName());
				}
				usage = (long)GetUsage(m_handle);
			}
			return Quota - usage;
		}
	}

	[ComVisible(false)]
	public override long Quota
	{
		get
		{
			if (IsRoaming())
			{
				return long.MaxValue;
			}
			return base.Quota;
		}
		[SecuritySafeCritical]
		internal set
		{
			bool locked = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				Lock(ref locked);
				lock (m_internalLock)
				{
					if (InvalidFileHandle)
					{
						m_handle = Open(m_InfoFile, GetSyncObjectName());
					}
					SetQuota(m_handle, value);
				}
			}
			finally
			{
				if (locked)
				{
					Unlock();
				}
			}
			base.Quota = value;
		}
	}

	[ComVisible(false)]
	public static bool IsEnabled => true;

	[CLSCompliant(false)]
	[Obsolete("IsolatedStorageFile.MaximumSize has been deprecated because it is not CLS Compliant.  To get the maximum size use IsolatedStorageFile.Quota")]
	public override ulong MaximumSize
	{
		get
		{
			if (IsRoaming())
			{
				return 9223372036854775807uL;
			}
			return base.MaximumSize;
		}
	}

	internal string RootDirectory => m_RootDir;

	internal bool Disposed => m_bDisposed;

	private bool InvalidFileHandle
	{
		[SecuritySafeCritical]
		get
		{
			if (m_handle != null && !m_handle.IsClosed)
			{
				return m_handle.IsInvalid;
			}
			return true;
		}
	}

	internal IsolatedStorageFile()
	{
	}

	public static IsolatedStorageFile GetUserStoreForDomain()
	{
		return GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null);
	}

	public static IsolatedStorageFile GetUserStoreForAssembly()
	{
		return GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
	}

	public static IsolatedStorageFile GetUserStoreForApplication()
	{
		return GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Application, null);
	}

	[ComVisible(false)]
	public static IsolatedStorageFile GetUserStoreForSite()
	{
		throw new NotSupportedException(Environment.GetResourceString("IsolatedStorage_NotValidOnDesktop"));
	}

	public static IsolatedStorageFile GetMachineStoreForDomain()
	{
		return GetStore(IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine, null, null);
	}

	public static IsolatedStorageFile GetMachineStoreForAssembly()
	{
		return GetStore(IsolatedStorageScope.Assembly | IsolatedStorageScope.Machine, null, null);
	}

	public static IsolatedStorageFile GetMachineStoreForApplication()
	{
		return GetStore(IsolatedStorageScope.Machine | IsolatedStorageScope.Application, null);
	}

	[SecuritySafeCritical]
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
	{
		if (domainEvidenceType != null)
		{
			DemandAdminPermission();
		}
		IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile();
		isolatedStorageFile.InitStore(scope, domainEvidenceType, assemblyEvidenceType);
		isolatedStorageFile.Init(scope);
		return isolatedStorageFile;
	}

	internal void EnsureStoreIsValid()
	{
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
	}

	[SecuritySafeCritical]
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object domainIdentity, object assemblyIdentity)
	{
		if (assemblyIdentity == null)
		{
			throw new ArgumentNullException("assemblyIdentity");
		}
		if (IsolatedStorage.IsDomain(scope) && domainIdentity == null)
		{
			throw new ArgumentNullException("domainIdentity");
		}
		DemandAdminPermission();
		IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile();
		isolatedStorageFile.InitStore(scope, domainIdentity, assemblyIdentity, null);
		isolatedStorageFile.Init(scope);
		return isolatedStorageFile;
	}

	[SecuritySafeCritical]
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Evidence domainEvidence, Type domainEvidenceType, Evidence assemblyEvidence, Type assemblyEvidenceType)
	{
		if (assemblyEvidence == null)
		{
			throw new ArgumentNullException("assemblyEvidence");
		}
		if (IsolatedStorage.IsDomain(scope) && domainEvidence == null)
		{
			throw new ArgumentNullException("domainEvidence");
		}
		DemandAdminPermission();
		IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile();
		isolatedStorageFile.InitStore(scope, domainEvidence, domainEvidenceType, assemblyEvidence, assemblyEvidenceType, null, null);
		isolatedStorageFile.Init(scope);
		return isolatedStorageFile;
	}

	[SecuritySafeCritical]
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type applicationEvidenceType)
	{
		if (applicationEvidenceType != null)
		{
			DemandAdminPermission();
		}
		IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile();
		isolatedStorageFile.InitStore(scope, applicationEvidenceType);
		isolatedStorageFile.Init(scope);
		return isolatedStorageFile;
	}

	[SecuritySafeCritical]
	public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object applicationIdentity)
	{
		if (applicationIdentity == null)
		{
			throw new ArgumentNullException("applicationIdentity");
		}
		DemandAdminPermission();
		IsolatedStorageFile isolatedStorageFile = new IsolatedStorageFile();
		isolatedStorageFile.InitStore(scope, null, null, applicationIdentity);
		isolatedStorageFile.Init(scope);
		return isolatedStorageFile;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public override bool IncreaseQuotaTo(long newQuotaSize)
	{
		if (newQuotaSize <= Quota)
		{
			throw new ArgumentException(Environment.GetResourceString("IsolatedStorage_OldQuotaLarger"));
		}
		if (m_StoreScope != (IsolatedStorageScope.User | IsolatedStorageScope.Application))
		{
			throw new NotSupportedException(Environment.GetResourceString("IsolatedStorage_OnlyIncreaseUserApplicationStore"));
		}
		IsolatedStorageSecurityState isolatedStorageSecurityState = IsolatedStorageSecurityState.CreateStateToIncreaseQuotaForApplication(newQuotaSize, Quota - AvailableFreeSpace);
		try
		{
			isolatedStorageSecurityState.EnsureState();
		}
		catch (IsolatedStorageException)
		{
			return false;
		}
		Quota = newQuotaSize;
		return true;
	}

	[SecuritySafeCritical]
	internal void Reserve(ulong lReserve)
	{
		if (IsRoaming())
		{
			return;
		}
		ulong quota = (ulong)Quota;
		lock (m_internalLock)
		{
			if (m_bDisposed)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (m_closed)
			{
				throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (InvalidFileHandle)
			{
				m_handle = Open(m_InfoFile, GetSyncObjectName());
			}
			Reserve(m_handle, quota, lReserve, fFree: false);
		}
	}

	internal void Unreserve(ulong lFree)
	{
		if (!IsRoaming())
		{
			ulong quota = (ulong)Quota;
			Unreserve(lFree, quota);
		}
	}

	[SecuritySafeCritical]
	internal void Unreserve(ulong lFree, ulong quota)
	{
		if (IsRoaming())
		{
			return;
		}
		lock (m_internalLock)
		{
			if (m_bDisposed)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (m_closed)
			{
				throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (InvalidFileHandle)
			{
				m_handle = Open(m_InfoFile, GetSyncObjectName());
			}
			Reserve(m_handle, quota, lFree, fFree: true);
		}
	}

	[SecuritySafeCritical]
	public void DeleteFile(string file)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		long num = 0L;
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Lock(ref locked);
			try
			{
				string fullPath = GetFullPath(file);
				num = LongPathFile.GetLength(fullPath);
				LongPathFile.Delete(fullPath);
			}
			catch
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DeleteFile"));
			}
			Unreserve(RoundToBlockSize((ulong)num));
		}
		finally
		{
			if (locked)
			{
				Unlock();
			}
		}
		CodeAccessPermission.RevertAll();
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public bool FileExists(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string fullPath = GetFullPath(path);
		string text = LongPath.NormalizePath(fullPath);
		if (path.EndsWith(Path.DirectorySeparatorChar + ".", StringComparison.Ordinal))
		{
			text = ((!text.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal)) ? (text + Path.DirectorySeparatorChar + ".") : (text + "."));
		}
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			return false;
		}
		bool result = LongPathFile.Exists(text);
		CodeAccessPermission.RevertAll();
		return result;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public bool DirectoryExists(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string fullPath = GetFullPath(path);
		string text = LongPath.NormalizePath(fullPath);
		if (fullPath.EndsWith(Path.DirectorySeparatorChar + ".", StringComparison.Ordinal))
		{
			text = ((!text.EndsWith(Path.DirectorySeparatorChar)) ? (text + Path.DirectorySeparatorChar + ".") : (text + "."));
		}
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			return false;
		}
		bool result = LongPathDirectory.Exists(text);
		CodeAccessPermission.RevertAll();
		return result;
	}

	[SecuritySafeCritical]
	public void CreateDirectory(string dir)
	{
		if (dir == null)
		{
			throw new ArgumentNullException("dir");
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string fullPath = GetFullPath(dir);
		string text = LongPath.NormalizePath(fullPath);
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_CreateDirectory"));
		}
		string[] array = DirectoriesToCreate(text);
		if (array == null || array.Length == 0)
		{
			if (!LongPathDirectory.Exists(fullPath))
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_CreateDirectory"));
			}
			return;
		}
		Reserve(1024uL * (ulong)array.Length);
		try
		{
			LongPathDirectory.CreateDirectory(array[array.Length - 1]);
		}
		catch
		{
			Unreserve(1024uL * (ulong)array.Length);
			try
			{
				LongPathDirectory.Delete(array[0], recursive: true);
			}
			catch
			{
			}
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_CreateDirectory"));
		}
		CodeAccessPermission.RevertAll();
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public DateTimeOffset GetCreationTime(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "path");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string fullPath = GetFullPath(path);
		string text = LongPath.NormalizePath(fullPath);
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			return new DateTimeOffset(1601, 1, 1, 0, 0, 0, TimeSpan.Zero).ToLocalTime();
		}
		DateTimeOffset creationTime = LongPathFile.GetCreationTime(text);
		CodeAccessPermission.RevertAll();
		return creationTime;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public DateTimeOffset GetLastAccessTime(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "path");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string fullPath = GetFullPath(path);
		string text = LongPath.NormalizePath(fullPath);
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			return new DateTimeOffset(1601, 1, 1, 0, 0, 0, TimeSpan.Zero).ToLocalTime();
		}
		DateTimeOffset lastAccessTime = LongPathFile.GetLastAccessTime(text);
		CodeAccessPermission.RevertAll();
		return lastAccessTime;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public DateTimeOffset GetLastWriteTime(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "path");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string fullPath = GetFullPath(path);
		string text = LongPath.NormalizePath(fullPath);
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			return new DateTimeOffset(1601, 1, 1, 0, 0, 0, TimeSpan.Zero).ToLocalTime();
		}
		DateTimeOffset lastWriteTime = LongPathFile.GetLastWriteTime(text);
		CodeAccessPermission.RevertAll();
		return lastWriteTime;
	}

	[ComVisible(false)]
	public void CopyFile(string sourceFileName, string destinationFileName)
	{
		if (sourceFileName == null)
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (destinationFileName == null)
		{
			throw new ArgumentNullException("destinationFileName");
		}
		if (sourceFileName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "sourceFileName");
		}
		if (destinationFileName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "destinationFileName");
		}
		CopyFile(sourceFileName, destinationFileName, overwrite: false);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite)
	{
		if (sourceFileName == null)
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (destinationFileName == null)
		{
			throw new ArgumentNullException("destinationFileName");
		}
		if (sourceFileName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "sourceFileName");
		}
		if (destinationFileName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "destinationFileName");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string text = LongPath.NormalizePath(GetFullPath(sourceFileName));
		string text2 = LongPath.NormalizePath(GetFullPath(destinationFileName));
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
			Demand(new FileIOPermission(FileIOPermissionAccess.Write, new string[1] { text2 }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Lock(ref locked);
			long num = 0L;
			try
			{
				num = LongPathFile.GetLength(text);
			}
			catch (FileNotFoundException)
			{
				throw new FileNotFoundException(Environment.GetResourceString("IO.PathNotFound_Path", sourceFileName));
			}
			catch (DirectoryNotFoundException)
			{
				throw new DirectoryNotFoundException(Environment.GetResourceString("IO.PathNotFound_Path", sourceFileName));
			}
			catch
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
			}
			long num2 = 0L;
			if (LongPathFile.Exists(text2))
			{
				try
				{
					num2 = LongPathFile.GetLength(text2);
				}
				catch
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
				}
			}
			if (num2 < num)
			{
				Reserve(RoundToBlockSize((ulong)(num - num2)));
			}
			try
			{
				LongPathFile.Copy(text, text2, overwrite);
			}
			catch (FileNotFoundException)
			{
				if (num2 < num)
				{
					Unreserve(RoundToBlockSize((ulong)(num - num2)));
				}
				throw new FileNotFoundException(Environment.GetResourceString("IO.PathNotFound_Path", sourceFileName));
			}
			catch
			{
				if (num2 < num)
				{
					Unreserve(RoundToBlockSize((ulong)(num - num2)));
				}
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
			}
			if (num2 > num && overwrite)
			{
				Unreserve(RoundToBlockSizeFloor((ulong)(num2 - num)));
			}
		}
		finally
		{
			if (locked)
			{
				Unlock();
			}
		}
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public void MoveFile(string sourceFileName, string destinationFileName)
	{
		if (sourceFileName == null)
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (destinationFileName == null)
		{
			throw new ArgumentNullException("destinationFileName");
		}
		if (sourceFileName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "sourceFileName");
		}
		if (destinationFileName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "destinationFileName");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string text = LongPath.NormalizePath(GetFullPath(sourceFileName));
		string text2 = LongPath.NormalizePath(GetFullPath(destinationFileName));
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
			Demand(new FileIOPermission(FileIOPermissionAccess.Write, new string[1] { text2 }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
		try
		{
			LongPathFile.Move(text, text2);
		}
		catch (FileNotFoundException)
		{
			throw new FileNotFoundException(Environment.GetResourceString("IO.PathNotFound_Path", sourceFileName));
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
		CodeAccessPermission.RevertAll();
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName)
	{
		if (sourceDirectoryName == null)
		{
			throw new ArgumentNullException("sourceDirectoryName");
		}
		if (destinationDirectoryName == null)
		{
			throw new ArgumentNullException("destinationDirectoryName");
		}
		if (sourceDirectoryName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "sourceDirectoryName");
		}
		if (destinationDirectoryName.Trim().Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyPath"), "destinationDirectoryName");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string text = LongPath.NormalizePath(GetFullPath(sourceDirectoryName));
		string text2 = LongPath.NormalizePath(GetFullPath(destinationDirectoryName));
		try
		{
			Demand(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.Write, new string[1] { text }, checkForDuplicates: false, needFullPath: false));
			Demand(new FileIOPermission(FileIOPermissionAccess.Write, new string[1] { text2 }, checkForDuplicates: false, needFullPath: false));
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
		try
		{
			LongPathDirectory.Move(text, text2);
		}
		catch (DirectoryNotFoundException)
		{
			throw new DirectoryNotFoundException(Environment.GetResourceString("IO.PathNotFound_Path", sourceDirectoryName));
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
		CodeAccessPermission.RevertAll();
	}

	[SecurityCritical]
	private string[] DirectoriesToCreate(string fullPath)
	{
		List<string> list = new List<string>();
		int num = fullPath.Length;
		if (num >= 2 && fullPath[num - 1] == SeparatorExternal)
		{
			num--;
		}
		int i = LongPath.GetRootLength(fullPath);
		while (i < num)
		{
			for (i++; i < num && fullPath[i] != SeparatorExternal; i++)
			{
			}
			string text = fullPath.Substring(0, i);
			if (!LongPathDirectory.InternalExists(text))
			{
				list.Add(text);
			}
		}
		if (list.Count != 0)
		{
			return list.ToArray();
		}
		return null;
	}

	[SecuritySafeCritical]
	public void DeleteDirectory(string dir)
	{
		if (dir == null)
		{
			throw new ArgumentNullException("dir");
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Lock(ref locked);
			try
			{
				string text = LongPath.NormalizePath(GetFullPath(dir));
				if (text.Equals(LongPath.NormalizePath(GetFullPath(".")), StringComparison.Ordinal))
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DeleteDirectory"));
				}
				LongPathDirectory.Delete(text, recursive: false);
			}
			catch
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DeleteDirectory"));
			}
			Unreserve(1024uL);
		}
		finally
		{
			if (locked)
			{
				Unlock();
			}
		}
		CodeAccessPermission.RevertAll();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private static void Demand(CodeAccessPermission permission)
	{
		permission.Demand();
	}

	[ComVisible(false)]
	public string[] GetFileNames()
	{
		return GetFileNames("*");
	}

	[SecuritySafeCritical]
	public string[] GetFileNames(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string[] fileDirectoryNames = GetFileDirectoryNames(GetFullPath(searchPattern), searchPattern, file: true);
		CodeAccessPermission.RevertAll();
		return fileDirectoryNames;
	}

	[ComVisible(false)]
	public string[] GetDirectoryNames()
	{
		return GetDirectoryNames("*");
	}

	[SecuritySafeCritical]
	public string[] GetDirectoryNames(string searchPattern)
	{
		if (searchPattern == null)
		{
			throw new ArgumentNullException("searchPattern");
		}
		if (m_bDisposed)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		if (m_closed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
		}
		m_fiop.Assert();
		m_fiop.PermitOnly();
		string[] fileDirectoryNames = GetFileDirectoryNames(GetFullPath(searchPattern), searchPattern, file: false);
		CodeAccessPermission.RevertAll();
		return fileDirectoryNames;
	}

	private static string NormalizeSearchPattern(string searchPattern)
	{
		string text = searchPattern.TrimEnd(Path.TrimEndChars);
		Path.CheckSearchPattern(text);
		return text;
	}

	[ComVisible(false)]
	public IsolatedStorageFileStream OpenFile(string path, FileMode mode)
	{
		return new IsolatedStorageFileStream(path, mode, this);
	}

	[ComVisible(false)]
	public IsolatedStorageFileStream OpenFile(string path, FileMode mode, FileAccess access)
	{
		return new IsolatedStorageFileStream(path, mode, access, this);
	}

	[ComVisible(false)]
	public IsolatedStorageFileStream OpenFile(string path, FileMode mode, FileAccess access, FileShare share)
	{
		return new IsolatedStorageFileStream(path, mode, access, share, this);
	}

	[ComVisible(false)]
	public IsolatedStorageFileStream CreateFile(string path)
	{
		return new IsolatedStorageFileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None, this);
	}

	[SecuritySafeCritical]
	public override void Remove()
	{
		string text = null;
		RemoveLogicalDir();
		Close();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(GetRootDir(base.Scope));
		if (IsApp())
		{
			stringBuilder.Append(base.AppName);
			stringBuilder.Append(SeparatorExternal);
		}
		else
		{
			if (IsDomain())
			{
				stringBuilder.Append(base.DomainName);
				stringBuilder.Append(SeparatorExternal);
				text = stringBuilder.ToString();
			}
			stringBuilder.Append(base.AssemName);
			stringBuilder.Append(SeparatorExternal);
		}
		string text2 = stringBuilder.ToString();
		new FileIOPermission(FileIOPermissionAccess.AllAccess, text2).Assert();
		if (ContainsUnknownFiles(text2))
		{
			return;
		}
		try
		{
			LongPathDirectory.Delete(text2, recursive: true);
		}
		catch
		{
			return;
		}
		if (!IsDomain())
		{
			return;
		}
		CodeAccessPermission.RevertAssert();
		new FileIOPermission(FileIOPermissionAccess.AllAccess, text).Assert();
		if (ContainsUnknownFiles(text))
		{
			return;
		}
		try
		{
			LongPathDirectory.Delete(text, recursive: true);
		}
		catch
		{
		}
	}

	[SecuritySafeCritical]
	private void RemoveLogicalDir()
	{
		m_fiop.Assert();
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Lock(ref locked);
			if (Directory.Exists(RootDirectory))
			{
				ulong lFree = (ulong)(IsRoaming() ? 0 : (Quota - AvailableFreeSpace));
				ulong quota = (ulong)Quota;
				try
				{
					LongPathDirectory.Delete(RootDirectory, recursive: true);
				}
				catch
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DeleteDirectories"));
				}
				Unreserve(lFree, quota);
			}
		}
		finally
		{
			if (locked)
			{
				Unlock();
			}
		}
	}

	private bool ContainsUnknownFiles(string rootDir)
	{
		string[] fileDirectoryNames;
		string[] fileDirectoryNames2;
		try
		{
			fileDirectoryNames = GetFileDirectoryNames(rootDir + "*", "*", file: true);
			fileDirectoryNames2 = GetFileDirectoryNames(rootDir + "*", "*", file: false);
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DeleteDirectories"));
		}
		if (fileDirectoryNames2 != null && fileDirectoryNames2.Length != 0)
		{
			if (fileDirectoryNames2.Length > 1)
			{
				return true;
			}
			if (IsApp())
			{
				if (NotAppFilesDir(fileDirectoryNames2[0]))
				{
					return true;
				}
			}
			else if (IsDomain())
			{
				if (NotFilesDir(fileDirectoryNames2[0]))
				{
					return true;
				}
			}
			else if (NotAssemFilesDir(fileDirectoryNames2[0]))
			{
				return true;
			}
		}
		if (fileDirectoryNames == null || fileDirectoryNames.Length == 0)
		{
			return false;
		}
		if (IsRoaming())
		{
			if (fileDirectoryNames.Length > 1 || NotIDFile(fileDirectoryNames[0]))
			{
				return true;
			}
			return false;
		}
		if (fileDirectoryNames.Length > 2 || (NotIDFile(fileDirectoryNames[0]) && NotInfoFile(fileDirectoryNames[0])) || (fileDirectoryNames.Length == 2 && NotIDFile(fileDirectoryNames[1]) && NotInfoFile(fileDirectoryNames[1])))
		{
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	public void Close()
	{
		if (IsRoaming())
		{
			return;
		}
		lock (m_internalLock)
		{
			if (!m_closed)
			{
				m_closed = true;
				if (m_handle != null)
				{
					m_handle.Dispose();
				}
				GC.SuppressFinalize(this);
			}
		}
	}

	public void Dispose()
	{
		Close();
		m_bDisposed = true;
	}

	~IsolatedStorageFile()
	{
		Dispose();
	}

	private static bool NotIDFile(string file)
	{
		return string.Compare(file, "identity.dat", StringComparison.Ordinal) != 0;
	}

	private static bool NotInfoFile(string file)
	{
		if (string.Compare(file, "info.dat", StringComparison.Ordinal) != 0)
		{
			return string.Compare(file, "appinfo.dat", StringComparison.Ordinal) != 0;
		}
		return false;
	}

	private static bool NotFilesDir(string dir)
	{
		return string.Compare(dir, "Files", StringComparison.Ordinal) != 0;
	}

	internal static bool NotAssemFilesDir(string dir)
	{
		return string.Compare(dir, "AssemFiles", StringComparison.Ordinal) != 0;
	}

	internal static bool NotAppFilesDir(string dir)
	{
		return string.Compare(dir, "AppFiles", StringComparison.Ordinal) != 0;
	}

	[SecuritySafeCritical]
	public static void Remove(IsolatedStorageScope scope)
	{
		VerifyGlobalScope(scope);
		DemandAdminPermission();
		string rootDir = GetRootDir(scope);
		new FileIOPermission(FileIOPermissionAccess.Write, rootDir).Assert();
		try
		{
			LongPathDirectory.Delete(rootDir, recursive: true);
			LongPathDirectory.CreateDirectory(rootDir);
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_DeleteDirectories"));
		}
	}

	[SecuritySafeCritical]
	public static IEnumerator GetEnumerator(IsolatedStorageScope scope)
	{
		VerifyGlobalScope(scope);
		DemandAdminPermission();
		return new IsolatedStorageFileEnumerator(scope);
	}

	internal string GetFullPath(string path)
	{
		if (path == string.Empty)
		{
			return RootDirectory;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(RootDirectory);
		if (path[0] == SeparatorExternal)
		{
			stringBuilder.Append(path.Substring(1));
		}
		else
		{
			stringBuilder.Append(path);
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	private static string GetDataDirectoryFromActivationContext()
	{
		if (s_appDataDir == null)
		{
			ActivationContext activationContext = AppDomain.CurrentDomain.ActivationContext;
			if (activationContext == null)
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_ApplicationMissingIdentity"));
			}
			string text = activationContext.DataDirectory;
			if (text != null && text[text.Length - 1] != '\\')
			{
				text += "\\";
			}
			s_appDataDir = text;
		}
		return s_appDataDir;
	}

	[SecuritySafeCritical]
	internal void Init(IsolatedStorageScope scope)
	{
		GetGlobalFileIOPerm(scope).Assert();
		m_StoreScope = scope;
		StringBuilder stringBuilder = new StringBuilder();
		if (IsolatedStorage.IsApp(scope))
		{
			stringBuilder.Append(GetRootDir(scope));
			if (s_appDataDir == null)
			{
				stringBuilder.Append(base.AppName);
				stringBuilder.Append(SeparatorExternal);
			}
			try
			{
				LongPathDirectory.CreateDirectory(stringBuilder.ToString());
			}
			catch
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
			}
			CreateIDFile(stringBuilder.ToString(), IsolatedStorageScope.Application);
			m_InfoFile = stringBuilder.ToString() + "appinfo.dat";
			stringBuilder.Append("AppFiles");
		}
		else
		{
			stringBuilder.Append(GetRootDir(scope));
			if (IsolatedStorage.IsDomain(scope))
			{
				stringBuilder.Append(base.DomainName);
				stringBuilder.Append(SeparatorExternal);
				try
				{
					LongPathDirectory.CreateDirectory(stringBuilder.ToString());
					CreateIDFile(stringBuilder.ToString(), IsolatedStorageScope.Domain);
				}
				catch
				{
					throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
				}
				m_InfoFile = stringBuilder.ToString() + "info.dat";
			}
			stringBuilder.Append(base.AssemName);
			stringBuilder.Append(SeparatorExternal);
			try
			{
				LongPathDirectory.CreateDirectory(stringBuilder.ToString());
				CreateIDFile(stringBuilder.ToString(), IsolatedStorageScope.Assembly);
			}
			catch
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
			}
			if (IsolatedStorage.IsDomain(scope))
			{
				stringBuilder.Append("Files");
			}
			else
			{
				m_InfoFile = stringBuilder.ToString() + "info.dat";
				stringBuilder.Append("AssemFiles");
			}
		}
		stringBuilder.Append(SeparatorExternal);
		string text = stringBuilder.ToString();
		try
		{
			LongPathDirectory.CreateDirectory(text);
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
		}
		m_RootDir = text;
		m_fiop = new FileIOPermission(FileIOPermissionAccess.AllAccess, text);
		if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Application))
		{
			UpdateQuotaFromInfoFile();
		}
	}

	[SecurityCritical]
	private void UpdateQuotaFromInfoFile()
	{
		bool locked = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Lock(ref locked);
			lock (m_internalLock)
			{
				if (InvalidFileHandle)
				{
					m_handle = Open(m_InfoFile, GetSyncObjectName());
				}
				long quota = 0L;
				if (GetQuota(m_handle, out quota))
				{
					base.Quota = quota;
				}
			}
		}
		finally
		{
			if (locked)
			{
				Unlock();
			}
		}
	}

	[SecuritySafeCritical]
	internal bool InitExistingStore(IsolatedStorageScope scope)
	{
		StringBuilder stringBuilder = new StringBuilder();
		m_StoreScope = scope;
		stringBuilder.Append(GetRootDir(scope));
		if (IsolatedStorage.IsApp(scope))
		{
			stringBuilder.Append(base.AppName);
			stringBuilder.Append(SeparatorExternal);
			m_InfoFile = stringBuilder.ToString() + "appinfo.dat";
			stringBuilder.Append("AppFiles");
		}
		else
		{
			if (IsolatedStorage.IsDomain(scope))
			{
				stringBuilder.Append(base.DomainName);
				stringBuilder.Append(SeparatorExternal);
				m_InfoFile = stringBuilder.ToString() + "info.dat";
			}
			stringBuilder.Append(base.AssemName);
			stringBuilder.Append(SeparatorExternal);
			if (IsolatedStorage.IsDomain(scope))
			{
				stringBuilder.Append("Files");
			}
			else
			{
				m_InfoFile = stringBuilder.ToString() + "info.dat";
				stringBuilder.Append("AssemFiles");
			}
		}
		stringBuilder.Append(SeparatorExternal);
		FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.AllAccess, stringBuilder.ToString());
		fileIOPermission.Assert();
		if (!LongPathDirectory.Exists(stringBuilder.ToString()))
		{
			return false;
		}
		m_RootDir = stringBuilder.ToString();
		m_fiop = fileIOPermission;
		if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Application))
		{
			UpdateQuotaFromInfoFile();
		}
		return true;
	}

	protected override IsolatedStoragePermission GetPermission(PermissionSet ps)
	{
		if (ps == null)
		{
			return null;
		}
		if (ps.IsUnrestricted())
		{
			return new IsolatedStorageFilePermission(PermissionState.Unrestricted);
		}
		return (IsolatedStoragePermission)ps.GetPermission(typeof(IsolatedStorageFilePermission));
	}

	internal void UndoReserveOperation(ulong oldLen, ulong newLen)
	{
		oldLen = RoundToBlockSize(oldLen);
		if (newLen > oldLen)
		{
			Unreserve(RoundToBlockSize(newLen - oldLen));
		}
	}

	internal void Reserve(ulong oldLen, ulong newLen)
	{
		oldLen = RoundToBlockSize(oldLen);
		if (newLen > oldLen)
		{
			Reserve(RoundToBlockSize(newLen - oldLen));
		}
	}

	internal void ReserveOneBlock()
	{
		Reserve(1024uL);
	}

	internal void UnreserveOneBlock()
	{
		Unreserve(1024uL);
	}

	internal static ulong RoundToBlockSize(ulong num)
	{
		if (num < 1024)
		{
			return 1024uL;
		}
		ulong num2 = num % 1024;
		if (num2 != 0L)
		{
			num += 1024 - num2;
		}
		return num;
	}

	internal static ulong RoundToBlockSizeFloor(ulong num)
	{
		if (num < 1024)
		{
			return 0uL;
		}
		ulong num2 = num % 1024;
		num -= num2;
		return num;
	}

	[SecurityCritical]
	internal static string GetRootDir(IsolatedStorageScope scope)
	{
		if (IsolatedStorage.IsRoaming(scope))
		{
			if (s_RootDirRoaming == null)
			{
				string s = null;
				GetRootDir(scope, JitHelpers.GetStringHandleOnStack(ref s));
				s_RootDirRoaming = s;
			}
			return s_RootDirRoaming;
		}
		if (IsolatedStorage.IsMachine(scope))
		{
			if (s_RootDirMachine == null)
			{
				InitGlobalsMachine(scope);
			}
			return s_RootDirMachine;
		}
		if (s_RootDirUser == null)
		{
			InitGlobalsNonRoamingUser(scope);
		}
		return s_RootDirUser;
	}

	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	private static void InitGlobalsMachine(IsolatedStorageScope scope)
	{
		string s = null;
		GetRootDir(scope, JitHelpers.GetStringHandleOnStack(ref s));
		new FileIOPermission(FileIOPermissionAccess.AllAccess, s).Assert();
		string text = GetMachineRandomDirectory(s);
		if (text == null)
		{
			Mutex mutex = CreateMutexNotOwned(s);
			if (!mutex.WaitOne())
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
			}
			try
			{
				text = GetMachineRandomDirectory(s);
				if (text == null)
				{
					string randomFileName = Path.GetRandomFileName();
					string randomFileName2 = Path.GetRandomFileName();
					try
					{
						CreateDirectoryWithDacl(s + randomFileName);
						CreateDirectoryWithDacl(s + randomFileName + "\\" + randomFileName2);
					}
					catch
					{
						throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
					}
					text = randomFileName + "\\" + randomFileName2;
				}
			}
			finally
			{
				mutex.ReleaseMutex();
			}
		}
		s_RootDirMachine = s + text + "\\";
	}

	[SecuritySafeCritical]
	private static void InitGlobalsNonRoamingUser(IsolatedStorageScope scope)
	{
		string s = null;
		if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Application))
		{
			s = GetDataDirectoryFromActivationContext();
			if (s != null)
			{
				s_RootDirUser = s;
				return;
			}
		}
		GetRootDir(scope, JitHelpers.GetStringHandleOnStack(ref s));
		new FileIOPermission(FileIOPermissionAccess.AllAccess, s).Assert();
		bool bMigrateNeeded = false;
		string sOldStoreLocation = null;
		string text = GetRandomDirectory(s, out bMigrateNeeded, out sOldStoreLocation);
		if (text == null)
		{
			Mutex mutex = CreateMutexNotOwned(s);
			if (!mutex.WaitOne())
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
			}
			try
			{
				text = GetRandomDirectory(s, out bMigrateNeeded, out sOldStoreLocation);
				if (text == null)
				{
					text = ((!bMigrateNeeded) ? CreateRandomDirectory(s) : MigrateOldIsoStoreDirectory(s, sOldStoreLocation));
				}
			}
			finally
			{
				mutex.ReleaseMutex();
			}
		}
		s_RootDirUser = s + text + "\\";
	}

	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static string MigrateOldIsoStoreDirectory(string rootDir, string oldRandomDirectory)
	{
		string randomFileName = Path.GetRandomFileName();
		string randomFileName2 = Path.GetRandomFileName();
		string text = rootDir + randomFileName;
		string destDirName = text + "\\" + randomFileName2;
		try
		{
			LongPathDirectory.CreateDirectory(text);
			LongPathDirectory.Move(rootDir + oldRandomDirectory, destDirName);
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
		}
		return randomFileName + "\\" + randomFileName2;
	}

	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static string CreateRandomDirectory(string rootDir)
	{
		string text;
		string path;
		do
		{
			text = Path.GetRandomFileName() + "\\" + Path.GetRandomFileName();
			path = rootDir + text;
		}
		while (LongPathDirectory.Exists(path));
		try
		{
			LongPathDirectory.CreateDirectory(path);
			return text;
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Init"));
		}
	}

	internal static string GetRandomDirectory(string rootDir, out bool bMigrateNeeded, out string sOldStoreLocation)
	{
		bMigrateNeeded = false;
		sOldStoreLocation = null;
		string[] fileDirectoryNames = GetFileDirectoryNames(rootDir + "*", "*", file: false);
		for (int i = 0; i < fileDirectoryNames.Length; i++)
		{
			if (fileDirectoryNames[i].Length != 12)
			{
				continue;
			}
			string[] fileDirectoryNames2 = GetFileDirectoryNames(rootDir + fileDirectoryNames[i] + "\\*", "*", file: false);
			for (int j = 0; j < fileDirectoryNames2.Length; j++)
			{
				if (fileDirectoryNames2[j].Length == 12)
				{
					return fileDirectoryNames[i] + "\\" + fileDirectoryNames2[j];
				}
			}
		}
		for (int k = 0; k < fileDirectoryNames.Length; k++)
		{
			if (fileDirectoryNames[k].Length == 24)
			{
				bMigrateNeeded = true;
				sOldStoreLocation = fileDirectoryNames[k];
				return null;
			}
		}
		return null;
	}

	internal static string GetMachineRandomDirectory(string rootDir)
	{
		string[] fileDirectoryNames = GetFileDirectoryNames(rootDir + "*", "*", file: false);
		for (int i = 0; i < fileDirectoryNames.Length; i++)
		{
			if (fileDirectoryNames[i].Length != 12)
			{
				continue;
			}
			string[] fileDirectoryNames2 = GetFileDirectoryNames(rootDir + fileDirectoryNames[i] + "\\*", "*", file: false);
			for (int j = 0; j < fileDirectoryNames2.Length; j++)
			{
				if (fileDirectoryNames2[j].Length == 12)
				{
					return fileDirectoryNames[i] + "\\" + fileDirectoryNames2[j];
				}
			}
		}
		return null;
	}

	[SecurityCritical]
	internal static Mutex CreateMutexNotOwned(string pathName)
	{
		return new Mutex(initiallyOwned: false, "Global\\" + GetStrongHashSuitableForObjectName(pathName));
	}

	internal static string GetStrongHashSuitableForObjectName(string name)
	{
		MemoryStream memoryStream = new MemoryStream();
		new BinaryWriter(memoryStream).Write(name.ToUpper(CultureInfo.InvariantCulture));
		memoryStream.Position = 0L;
		return Path.ToBase32StringSuitableForDirName(new SHA1CryptoServiceProvider().ComputeHash(memoryStream));
	}

	private string GetSyncObjectName()
	{
		if (m_SyncObjectName == null)
		{
			m_SyncObjectName = GetStrongHashSuitableForObjectName(m_InfoFile);
		}
		return m_SyncObjectName;
	}

	[SecuritySafeCritical]
	internal void Lock(ref bool locked)
	{
		locked = false;
		if (IsRoaming())
		{
			return;
		}
		lock (m_internalLock)
		{
			if (m_bDisposed)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (m_closed)
			{
				throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (InvalidFileHandle)
			{
				m_handle = Open(m_InfoFile, GetSyncObjectName());
			}
			locked = Lock(m_handle, fLock: true);
		}
	}

	[SecuritySafeCritical]
	internal void Unlock()
	{
		if (IsRoaming())
		{
			return;
		}
		lock (m_internalLock)
		{
			if (m_bDisposed)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (m_closed)
			{
				throw new InvalidOperationException(Environment.GetResourceString("IsolatedStorage_StoreNotOpen"));
			}
			if (InvalidFileHandle)
			{
				m_handle = Open(m_InfoFile, GetSyncObjectName());
			}
			Lock(m_handle, fLock: false);
		}
	}

	[SecurityCritical]
	internal static FileIOPermission GetGlobalFileIOPerm(IsolatedStorageScope scope)
	{
		if (IsolatedStorage.IsRoaming(scope))
		{
			if (s_PermRoaming == null)
			{
				s_PermRoaming = new FileIOPermission(FileIOPermissionAccess.AllAccess, GetRootDir(scope));
			}
			return s_PermRoaming;
		}
		if (IsolatedStorage.IsMachine(scope))
		{
			if (s_PermMachine == null)
			{
				s_PermMachine = new FileIOPermission(FileIOPermissionAccess.AllAccess, GetRootDir(scope));
			}
			return s_PermMachine;
		}
		if (s_PermUser == null)
		{
			s_PermUser = new FileIOPermission(FileIOPermissionAccess.AllAccess, GetRootDir(scope));
		}
		return s_PermUser;
	}

	[SecurityCritical]
	private static void DemandAdminPermission()
	{
		if (s_PermAdminUser == null)
		{
			s_PermAdminUser = new IsolatedStorageFilePermission(IsolatedStorageContainment.AdministerIsolatedStorageByUser, 0L, PermanentData: false);
		}
		s_PermAdminUser.Demand();
	}

	internal static void VerifyGlobalScope(IsolatedStorageScope scope)
	{
		if (scope != IsolatedStorageScope.User && scope != (IsolatedStorageScope.User | IsolatedStorageScope.Roaming) && scope != IsolatedStorageScope.Machine)
		{
			throw new ArgumentException(Environment.GetResourceString("IsolatedStorage_Scope_U_R_M"));
		}
	}

	[SecuritySafeCritical]
	internal void CreateIDFile(string path, IsolatedStorageScope scope)
	{
		try
		{
			using FileStream fileStream = new FileStream(path + "identity.dat", FileMode.OpenOrCreate);
			MemoryStream identityStream = GetIdentityStream(scope);
			byte[] buffer = identityStream.GetBuffer();
			fileStream.Write(buffer, 0, (int)identityStream.Length);
			identityStream.Close();
		}
		catch
		{
		}
	}

	[SecuritySafeCritical]
	internal static string[] GetFileDirectoryNames(string path, string userSearchPattern, bool file)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path", Environment.GetResourceString("ArgumentNull_Path"));
		}
		userSearchPattern = NormalizeSearchPattern(userSearchPattern);
		if (userSearchPattern.Length == 0)
		{
			return new string[0];
		}
		bool flag = false;
		char c = path[path.Length - 1];
		if (c == Path.DirectorySeparatorChar || c == Path.AltDirectorySeparatorChar || c == '.')
		{
			flag = true;
		}
		string text = LongPath.NormalizePath(path);
		if (flag && text[text.Length - 1] != c)
		{
			text += "\\*";
		}
		string text2 = LongPath.GetDirectoryName(text);
		if (text2 != null)
		{
			text2 += "\\";
		}
		try
		{
			new FileIOPermission(FileIOPermissionAccess.Read, new string[1] { (text2 == null) ? text : text2 }, checkForDuplicates: false, needFullPath: false).Demand();
		}
		catch
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
		string[] array = new string[10];
		int num = 0;
		Win32Native.WIN32_FIND_DATA data = default(Win32Native.WIN32_FIND_DATA);
		SafeFindHandle safeFindHandle = Win32Native.FindFirstFile(Path.AddLongPathPrefix(text), ref data);
		int lastWin32Error;
		if (safeFindHandle.IsInvalid)
		{
			lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 2)
			{
				return new string[0];
			}
			__Error.WinIOError(lastWin32Error, userSearchPattern);
		}
		int num2 = 0;
		do
		{
			if ((!file) ? data.IsNormalDirectory : data.IsFile)
			{
				num2++;
				if (num == array.Length)
				{
					Array.Resize(ref array, 2 * array.Length);
				}
				array[num++] = data.cFileName;
			}
		}
		while (Win32Native.FindNextFile(safeFindHandle, ref data));
		lastWin32Error = Marshal.GetLastWin32Error();
		safeFindHandle.Close();
		if (lastWin32Error != 0 && lastWin32Error != 18)
		{
			__Error.WinIOError(lastWin32Error, userSearchPattern);
		}
		if (!file && num2 == 1 && (data.dwFileAttributes & 0x10) != 0)
		{
			return new string[1] { data.cFileName };
		}
		if (num == array.Length)
		{
			return array;
		}
		Array.Resize(ref array, num);
		return array;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern ulong GetUsage(SafeIsolatedStorageFileHandle handle);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern SafeIsolatedStorageFileHandle Open(string infoFile, string syncName);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void Reserve(SafeIsolatedStorageFileHandle handle, ulong plQuota, ulong plReserve, [MarshalAs(UnmanagedType.Bool)] bool fFree);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void GetRootDir(IsolatedStorageScope scope, StringHandleOnStack retRootDir);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool Lock(SafeIsolatedStorageFileHandle handle, [MarshalAs(UnmanagedType.Bool)] bool fLock);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern void CreateDirectoryWithDacl(string path);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetQuota(SafeIsolatedStorageFileHandle scope, out long quota);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern void SetQuota(SafeIsolatedStorageFileHandle scope, long quota);
}
