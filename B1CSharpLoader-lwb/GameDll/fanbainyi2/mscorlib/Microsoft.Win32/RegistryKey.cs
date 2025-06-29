using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32;

[ComVisible(true)]
public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	private enum RegistryInternalCheck
	{
		CheckSubKeyWritePermission,
		CheckSubKeyReadPermission,
		CheckSubKeyCreatePermission,
		CheckSubTreeReadPermission,
		CheckSubTreeWritePermission,
		CheckSubTreeReadWritePermission,
		CheckValueWritePermission,
		CheckValueCreatePermission,
		CheckValueReadPermission,
		CheckKeyReadPermission,
		CheckSubTreePermission,
		CheckOpenSubKeyWithWritablePermission,
		CheckOpenSubKeyPermission
	}

	internal static readonly IntPtr HKEY_CLASSES_ROOT = new IntPtr(int.MinValue);

	internal static readonly IntPtr HKEY_CURRENT_USER = new IntPtr(-2147483647);

	internal static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(-2147483646);

	internal static readonly IntPtr HKEY_USERS = new IntPtr(-2147483645);

	internal static readonly IntPtr HKEY_PERFORMANCE_DATA = new IntPtr(-2147483644);

	internal static readonly IntPtr HKEY_CURRENT_CONFIG = new IntPtr(-2147483643);

	internal static readonly IntPtr HKEY_DYN_DATA = new IntPtr(-2147483642);

	private const int STATE_DIRTY = 1;

	private const int STATE_SYSTEMKEY = 2;

	private const int STATE_WRITEACCESS = 4;

	private const int STATE_PERF_DATA = 8;

	private static readonly string[] hkeyNames = new string[7] { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_USER", "HKEY_LOCAL_MACHINE", "HKEY_USERS", "HKEY_PERFORMANCE_DATA", "HKEY_CURRENT_CONFIG", "HKEY_DYN_DATA" };

	private const int MaxKeyLength = 255;

	private const int MaxValueLength = 16383;

	[SecurityCritical]
	private volatile SafeRegistryHandle hkey;

	private volatile int state;

	private volatile string keyName;

	private volatile bool remoteKey;

	private volatile RegistryKeyPermissionCheck checkMode;

	private volatile RegistryView regView;

	private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

	private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

	private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

	public int SubKeyCount
	{
		[SecuritySafeCritical]
		get
		{
			CheckPermission(RegistryInternalCheck.CheckKeyReadPermission, null, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
			return InternalSubKeyCount();
		}
	}

	[ComVisible(false)]
	public RegistryView View
	{
		[SecuritySafeCritical]
		get
		{
			EnsureNotDisposed();
			return regView;
		}
	}

	[ComVisible(false)]
	public SafeRegistryHandle Handle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			EnsureNotDisposed();
			int errorCode = 6;
			if (IsSystemKey())
			{
				IntPtr hKey = (IntPtr)0;
				switch (keyName)
				{
				case "HKEY_CLASSES_ROOT":
					hKey = HKEY_CLASSES_ROOT;
					break;
				case "HKEY_CURRENT_USER":
					hKey = HKEY_CURRENT_USER;
					break;
				case "HKEY_LOCAL_MACHINE":
					hKey = HKEY_LOCAL_MACHINE;
					break;
				case "HKEY_USERS":
					hKey = HKEY_USERS;
					break;
				case "HKEY_PERFORMANCE_DATA":
					hKey = HKEY_PERFORMANCE_DATA;
					break;
				case "HKEY_CURRENT_CONFIG":
					hKey = HKEY_CURRENT_CONFIG;
					break;
				case "HKEY_DYN_DATA":
					hKey = HKEY_DYN_DATA;
					break;
				default:
					Win32Error(errorCode, null);
					break;
				}
				errorCode = Win32Native.RegOpenKeyEx(hKey, null, 0, GetRegistryKeyAccess(IsWritable()) | (int)regView, out var hkResult);
				if (errorCode == 0 && !hkResult.IsInvalid)
				{
					return hkResult;
				}
				Win32Error(errorCode, null);
				throw new IOException(Win32Native.GetMessage(errorCode), errorCode);
			}
			return hkey;
		}
	}

	public int ValueCount
	{
		[SecuritySafeCritical]
		get
		{
			CheckPermission(RegistryInternalCheck.CheckKeyReadPermission, null, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
			return InternalValueCount();
		}
	}

	public string Name
	{
		[SecuritySafeCritical]
		get
		{
			EnsureNotDisposed();
			return keyName;
		}
	}

	[SecurityCritical]
	private RegistryKey(SafeRegistryHandle hkey, bool writable, RegistryView view)
		: this(hkey, writable, systemkey: false, remoteKey: false, isPerfData: false, view)
	{
	}

	[SecurityCritical]
	private RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
	{
		this.hkey = hkey;
		keyName = "";
		this.remoteKey = remoteKey;
		regView = view;
		if (systemkey)
		{
			state |= 2;
		}
		if (writable)
		{
			state |= 4;
		}
		if (isPerfData)
		{
			state |= 8;
		}
		ValidateKeyView(view);
	}

	public void Close()
	{
		Dispose(disposing: true);
	}

	[SecuritySafeCritical]
	private void Dispose(bool disposing)
	{
		if (hkey == null)
		{
			return;
		}
		if (!IsSystemKey())
		{
			try
			{
				hkey.Dispose();
				return;
			}
			catch (IOException)
			{
				return;
			}
			finally
			{
				hkey = null;
			}
		}
		if (disposing && IsPerfDataKey())
		{
			SafeRegistryHandle.RegCloseKey(HKEY_PERFORMANCE_DATA);
		}
	}

	[SecuritySafeCritical]
	public void Flush()
	{
		if (hkey != null && IsDirty())
		{
			Win32Native.RegFlushKey(hkey);
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	public RegistryKey CreateSubKey(string subkey)
	{
		return CreateSubKey(subkey, checkMode);
	}

	[ComVisible(false)]
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
	{
		return CreateSubKeyInternal(subkey, permissionCheck, null, RegistryOptions.None);
	}

	[ComVisible(false)]
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions options)
	{
		return CreateSubKeyInternal(subkey, permissionCheck, null, options);
	}

	[ComVisible(false)]
	public RegistryKey CreateSubKey(string subkey, bool writable)
	{
		return CreateSubKeyInternal(subkey, (!writable) ? RegistryKeyPermissionCheck.ReadSubTree : RegistryKeyPermissionCheck.ReadWriteSubTree, null, RegistryOptions.None);
	}

	[ComVisible(false)]
	public RegistryKey CreateSubKey(string subkey, bool writable, RegistryOptions options)
	{
		return CreateSubKeyInternal(subkey, (!writable) ? RegistryKeyPermissionCheck.ReadSubTree : RegistryKeyPermissionCheck.ReadWriteSubTree, null, options);
	}

	[ComVisible(false)]
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistrySecurity registrySecurity)
	{
		return CreateSubKeyInternal(subkey, permissionCheck, registrySecurity, RegistryOptions.None);
	}

	[ComVisible(false)]
	public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions registryOptions, RegistrySecurity registrySecurity)
	{
		return CreateSubKeyInternal(subkey, permissionCheck, registrySecurity, registryOptions);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	private unsafe RegistryKey CreateSubKeyInternal(string subkey, RegistryKeyPermissionCheck permissionCheck, object registrySecurityObj, RegistryOptions registryOptions)
	{
		ValidateKeyOptions(registryOptions);
		ValidateKeyName(subkey);
		ValidateKeyMode(permissionCheck);
		EnsureWriteable();
		subkey = FixupName(subkey);
		if (!remoteKey)
		{
			RegistryKey registryKey = InternalOpenSubKey(subkey, permissionCheck != RegistryKeyPermissionCheck.ReadSubTree);
			if (registryKey != null)
			{
				CheckPermission(RegistryInternalCheck.CheckSubKeyWritePermission, subkey, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
				CheckPermission(RegistryInternalCheck.CheckSubTreePermission, subkey, subKeyWritable: false, permissionCheck);
				registryKey.checkMode = permissionCheck;
				return registryKey;
			}
		}
		CheckPermission(RegistryInternalCheck.CheckSubKeyCreatePermission, subkey, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		Win32Native.SECURITY_ATTRIBUTES sECURITY_ATTRIBUTES = null;
		RegistrySecurity registrySecurity = (RegistrySecurity)registrySecurityObj;
		if (registrySecurity != null)
		{
			sECURITY_ATTRIBUTES = new Win32Native.SECURITY_ATTRIBUTES();
			sECURITY_ATTRIBUTES.nLength = Marshal.SizeOf(sECURITY_ATTRIBUTES);
			byte[] securityDescriptorBinaryForm = registrySecurity.GetSecurityDescriptorBinaryForm();
			byte* ptr = stackalloc byte[(int)(uint)securityDescriptorBinaryForm.Length];
			Buffer.Memcpy(ptr, 0, securityDescriptorBinaryForm, 0, securityDescriptorBinaryForm.Length);
			sECURITY_ATTRIBUTES.pSecurityDescriptor = ptr;
		}
		int lpdwDisposition = 0;
		SafeRegistryHandle hkResult = null;
		int num = Win32Native.RegCreateKeyEx(hkey, subkey, 0, null, (int)registryOptions, GetRegistryKeyAccess(permissionCheck != RegistryKeyPermissionCheck.ReadSubTree) | (int)regView, sECURITY_ATTRIBUTES, out hkResult, out lpdwDisposition);
		if (num == 0 && !hkResult.IsInvalid)
		{
			RegistryKey registryKey2 = new RegistryKey(hkResult, permissionCheck != RegistryKeyPermissionCheck.ReadSubTree, systemkey: false, remoteKey, isPerfData: false, regView);
			CheckPermission(RegistryInternalCheck.CheckSubTreePermission, subkey, subKeyWritable: false, permissionCheck);
			registryKey2.checkMode = permissionCheck;
			if (subkey.Length == 0)
			{
				registryKey2.keyName = keyName;
			}
			else
			{
				registryKey2.keyName = keyName + "\\" + subkey;
			}
			return registryKey2;
		}
		if (num != 0)
		{
			Win32Error(num, keyName + "\\" + subkey);
		}
		return null;
	}

	public void DeleteSubKey(string subkey)
	{
		DeleteSubKey(subkey, throwOnMissingSubKey: true);
	}

	[SecuritySafeCritical]
	public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
	{
		ValidateKeyName(subkey);
		EnsureWriteable();
		subkey = FixupName(subkey);
		CheckPermission(RegistryInternalCheck.CheckSubKeyWritePermission, subkey, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		RegistryKey registryKey = InternalOpenSubKey(subkey, writable: false);
		if (registryKey != null)
		{
			try
			{
				if (registryKey.InternalSubKeyCount() > 0)
				{
					ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_RegRemoveSubKey);
				}
			}
			finally
			{
				registryKey.Close();
			}
			int num;
			try
			{
				num = Win32Native.RegDeleteKeyEx(hkey, subkey, (int)regView, 0);
			}
			catch (EntryPointNotFoundException)
			{
				num = Win32Native.RegDeleteKey(hkey, subkey);
			}
			switch (num)
			{
			case 2:
				if (throwOnMissingSubKey)
				{
					ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSubKeyAbsent);
				}
				break;
			default:
				Win32Error(num, null);
				break;
			case 0:
				break;
			}
		}
		else if (throwOnMissingSubKey)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSubKeyAbsent);
		}
	}

	public void DeleteSubKeyTree(string subkey)
	{
		DeleteSubKeyTree(subkey, throwOnMissingSubKey: true);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey)
	{
		ValidateKeyName(subkey);
		if (subkey.Length == 0 && IsSystemKey())
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegKeyDelHive);
		}
		EnsureWriteable();
		subkey = FixupName(subkey);
		CheckPermission(RegistryInternalCheck.CheckSubTreeWritePermission, subkey, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		RegistryKey registryKey = InternalOpenSubKey(subkey, writable: true);
		if (registryKey != null)
		{
			try
			{
				if (registryKey.InternalSubKeyCount() > 0)
				{
					string[] array = registryKey.InternalGetSubKeyNames();
					for (int i = 0; i < array.Length; i++)
					{
						registryKey.DeleteSubKeyTreeInternal(array[i]);
					}
				}
			}
			finally
			{
				registryKey.Close();
			}
			int num;
			try
			{
				num = Win32Native.RegDeleteKeyEx(hkey, subkey, (int)regView, 0);
			}
			catch (EntryPointNotFoundException)
			{
				num = Win32Native.RegDeleteKey(hkey, subkey);
			}
			if (num != 0)
			{
				Win32Error(num, null);
			}
		}
		else if (throwOnMissingSubKey)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSubKeyAbsent);
		}
	}

	[SecurityCritical]
	private void DeleteSubKeyTreeInternal(string subkey)
	{
		RegistryKey registryKey = InternalOpenSubKey(subkey, writable: true);
		if (registryKey != null)
		{
			try
			{
				if (registryKey.InternalSubKeyCount() > 0)
				{
					string[] array = registryKey.InternalGetSubKeyNames();
					for (int i = 0; i < array.Length; i++)
					{
						registryKey.DeleteSubKeyTreeInternal(array[i]);
					}
				}
			}
			finally
			{
				registryKey.Close();
			}
			int num;
			try
			{
				num = Win32Native.RegDeleteKeyEx(hkey, subkey, (int)regView, 0);
			}
			catch (EntryPointNotFoundException)
			{
				num = Win32Native.RegDeleteKey(hkey, subkey);
			}
			if (num != 0)
			{
				Win32Error(num, null);
			}
		}
		else
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSubKeyAbsent);
		}
	}

	public void DeleteValue(string name)
	{
		DeleteValue(name, throwOnMissingValue: true);
	}

	[SecuritySafeCritical]
	public void DeleteValue(string name, bool throwOnMissingValue)
	{
		EnsureWriteable();
		CheckPermission(RegistryInternalCheck.CheckValueWritePermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		int num = Win32Native.RegDeleteValue(hkey, name);
		if ((num == 2 || num == 206) && throwOnMissingValue)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSubKeyValueAbsent);
		}
	}

	[SecurityCritical]
	internal static RegistryKey GetBaseKey(IntPtr hKey)
	{
		return GetBaseKey(hKey, RegistryView.Default);
	}

	[SecurityCritical]
	internal static RegistryKey GetBaseKey(IntPtr hKey, RegistryView view)
	{
		int num = (int)hKey & 0xFFFFFFF;
		bool flag = hKey == HKEY_PERFORMANCE_DATA;
		SafeRegistryHandle safeRegistryHandle = new SafeRegistryHandle(hKey, flag);
		RegistryKey registryKey = new RegistryKey(safeRegistryHandle, writable: true, systemkey: true, remoteKey: false, flag, view);
		registryKey.checkMode = RegistryKeyPermissionCheck.Default;
		registryKey.keyName = hkeyNames[num];
		return registryKey;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
	{
		ValidateKeyView(view);
		CheckUnmanagedCodePermission();
		return GetBaseKey((IntPtr)(int)hKey, view);
	}

	public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName)
	{
		return OpenRemoteBaseKey(hKey, machineName, RegistryView.Default);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName, RegistryView view)
	{
		if (machineName == null)
		{
			throw new ArgumentNullException("machineName");
		}
		int num = (int)(hKey & (RegistryHive)268435455);
		if (num < 0 || num >= hkeyNames.Length || ((ulong)hKey & 0xFFFFFFF0uL) != 2147483648u)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RegKeyOutOfRange"));
		}
		ValidateKeyView(view);
		CheckUnmanagedCodePermission();
		SafeRegistryHandle result = null;
		int num2 = Win32Native.RegConnectRegistry(machineName, new SafeRegistryHandle(new IntPtr((int)hKey), ownsHandle: false), out result);
		switch (num2)
		{
		case 1114:
			throw new ArgumentException(Environment.GetResourceString("Arg_DllInitFailure"));
		default:
			Win32ErrorStatic(num2, null);
			break;
		case 0:
			break;
		}
		if (result.IsInvalid)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RegKeyNoRemoteConnect", machineName));
		}
		RegistryKey registryKey = new RegistryKey(result, writable: true, systemkey: false, remoteKey: true, (IntPtr)(int)hKey == HKEY_PERFORMANCE_DATA, view);
		registryKey.checkMode = RegistryKeyPermissionCheck.Default;
		registryKey.keyName = hkeyNames[num];
		return registryKey;
	}

	[SecuritySafeCritical]
	public RegistryKey OpenSubKey(string name, bool writable)
	{
		ValidateKeyName(name);
		EnsureNotDisposed();
		name = FixupName(name);
		CheckPermission(RegistryInternalCheck.CheckOpenSubKeyWithWritablePermission, name, writable, RegistryKeyPermissionCheck.Default);
		SafeRegistryHandle hkResult = null;
		int num = Win32Native.RegOpenKeyEx(hkey, name, 0, GetRegistryKeyAccess(writable) | (int)regView, out hkResult);
		if (num == 0 && !hkResult.IsInvalid)
		{
			RegistryKey registryKey = new RegistryKey(hkResult, writable, systemkey: false, remoteKey, isPerfData: false, regView);
			registryKey.checkMode = GetSubKeyPermissonCheck(writable);
			registryKey.keyName = keyName + "\\" + name;
			return registryKey;
		}
		if (num == 5 || num == 1346)
		{
			ThrowHelper.ThrowSecurityException(ExceptionResource.Security_RegistryPermission);
		}
		return null;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck)
	{
		ValidateKeyMode(permissionCheck);
		return InternalOpenSubKey(name, permissionCheck, GetRegistryKeyAccess(permissionCheck));
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public RegistryKey OpenSubKey(string name, RegistryRights rights)
	{
		return InternalOpenSubKey(name, checkMode, (int)rights);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights)
	{
		return InternalOpenSubKey(name, permissionCheck, (int)rights);
	}

	[SecurityCritical]
	private RegistryKey InternalOpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, int rights)
	{
		ValidateKeyName(name);
		ValidateKeyMode(permissionCheck);
		ValidateKeyRights(rights);
		EnsureNotDisposed();
		name = FixupName(name);
		CheckPermission(RegistryInternalCheck.CheckOpenSubKeyPermission, name, subKeyWritable: false, permissionCheck);
		CheckPermission(RegistryInternalCheck.CheckSubTreePermission, name, subKeyWritable: false, permissionCheck);
		SafeRegistryHandle hkResult = null;
		int num = Win32Native.RegOpenKeyEx(hkey, name, 0, rights | (int)regView, out hkResult);
		if (num == 0 && !hkResult.IsInvalid)
		{
			RegistryKey registryKey = new RegistryKey(hkResult, permissionCheck == RegistryKeyPermissionCheck.ReadWriteSubTree, systemkey: false, remoteKey, isPerfData: false, regView);
			registryKey.keyName = keyName + "\\" + name;
			registryKey.checkMode = permissionCheck;
			return registryKey;
		}
		if (num == 5 || num == 1346)
		{
			ThrowHelper.ThrowSecurityException(ExceptionResource.Security_RegistryPermission);
		}
		return null;
	}

	[SecurityCritical]
	internal RegistryKey InternalOpenSubKey(string name, bool writable)
	{
		ValidateKeyName(name);
		EnsureNotDisposed();
		SafeRegistryHandle hkResult = null;
		if (Win32Native.RegOpenKeyEx(hkey, name, 0, GetRegistryKeyAccess(writable) | (int)regView, out hkResult) == 0 && !hkResult.IsInvalid)
		{
			RegistryKey registryKey = new RegistryKey(hkResult, writable, systemkey: false, remoteKey, isPerfData: false, regView);
			registryKey.keyName = keyName + "\\" + name;
			return registryKey;
		}
		return null;
	}

	public RegistryKey OpenSubKey(string name)
	{
		return OpenSubKey(name, writable: false);
	}

	[SecurityCritical]
	[ComVisible(false)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static RegistryKey FromHandle(SafeRegistryHandle handle)
	{
		return FromHandle(handle, RegistryView.Default);
	}

	[SecurityCritical]
	[ComVisible(false)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public static RegistryKey FromHandle(SafeRegistryHandle handle, RegistryView view)
	{
		if (handle == null)
		{
			throw new ArgumentNullException("handle");
		}
		ValidateKeyView(view);
		return new RegistryKey(handle, writable: true, view);
	}

	[SecurityCritical]
	internal int InternalSubKeyCount()
	{
		EnsureNotDisposed();
		int lpcSubKeys = 0;
		int lpcValues = 0;
		int num = Win32Native.RegQueryInfoKey(hkey, null, null, IntPtr.Zero, ref lpcSubKeys, null, null, ref lpcValues, null, null, null, null);
		if (num != 0)
		{
			Win32Error(num, null);
		}
		return lpcSubKeys;
	}

	[SecuritySafeCritical]
	public string[] GetSubKeyNames()
	{
		CheckPermission(RegistryInternalCheck.CheckKeyReadPermission, null, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		return InternalGetSubKeyNames();
	}

	[SecurityCritical]
	internal unsafe string[] InternalGetSubKeyNames()
	{
		EnsureNotDisposed();
		int num = InternalSubKeyCount();
		string[] array = new string[num];
		if (num > 0)
		{
			char[] array2 = new char[256];
			fixed (char* ptr = &array2[0])
			{
				for (int i = 0; i < num; i++)
				{
					int lpcbName = array2.Length;
					int num2 = Win32Native.RegEnumKeyEx(hkey, i, ptr, ref lpcbName, null, null, null, null);
					if (num2 != 0)
					{
						Win32Error(num2, null);
					}
					array[i] = new string(ptr);
				}
			}
		}
		return array;
	}

	[SecurityCritical]
	internal int InternalValueCount()
	{
		EnsureNotDisposed();
		int lpcValues = 0;
		int lpcSubKeys = 0;
		int num = Win32Native.RegQueryInfoKey(hkey, null, null, IntPtr.Zero, ref lpcSubKeys, null, null, ref lpcValues, null, null, null, null);
		if (num != 0)
		{
			Win32Error(num, null);
		}
		return lpcValues;
	}

	[SecuritySafeCritical]
	public unsafe string[] GetValueNames()
	{
		CheckPermission(RegistryInternalCheck.CheckKeyReadPermission, null, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		EnsureNotDisposed();
		int num = InternalValueCount();
		string[] array = new string[num];
		if (num > 0)
		{
			char[] array2 = new char[16384];
			fixed (char* ptr = &array2[0])
			{
				for (int i = 0; i < num; i++)
				{
					int lpcbValueName = array2.Length;
					int num2 = Win32Native.RegEnumValue(hkey, i, ptr, ref lpcbValueName, IntPtr.Zero, null, null, null);
					if (num2 != 0 && (!IsPerfDataKey() || num2 != 234))
					{
						Win32Error(num2, null);
					}
					array[i] = new string(ptr);
				}
			}
		}
		return array;
	}

	[SecuritySafeCritical]
	public object GetValue(string name)
	{
		CheckPermission(RegistryInternalCheck.CheckValueReadPermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		return InternalGetValue(name, null, doNotExpand: false, checkSecurity: true);
	}

	[SecuritySafeCritical]
	public object GetValue(string name, object defaultValue)
	{
		CheckPermission(RegistryInternalCheck.CheckValueReadPermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		return InternalGetValue(name, defaultValue, doNotExpand: false, checkSecurity: true);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public object GetValue(string name, object defaultValue, RegistryValueOptions options)
	{
		if (options < RegistryValueOptions.None || options > RegistryValueOptions.DoNotExpandEnvironmentNames)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)options), "options");
		}
		bool doNotExpand = options == RegistryValueOptions.DoNotExpandEnvironmentNames;
		CheckPermission(RegistryInternalCheck.CheckValueReadPermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		return InternalGetValue(name, defaultValue, doNotExpand, checkSecurity: true);
	}

	[SecurityCritical]
	internal object InternalGetValue(string name, object defaultValue, bool doNotExpand, bool checkSecurity)
	{
		if (checkSecurity)
		{
			EnsureNotDisposed();
		}
		object obj = defaultValue;
		int lpType = 0;
		int lpcbData = 0;
		int num = Win32Native.RegQueryValueEx(hkey, name, (int[])null, ref lpType, (byte[])null, ref lpcbData);
		if (num != 0)
		{
			if (IsPerfDataKey())
			{
				int num2 = 65000;
				int lpcbData2 = num2;
				byte[] array = new byte[num2];
				int num3;
				while (234 == (num3 = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, array, ref lpcbData2)))
				{
					if (num2 == int.MaxValue)
					{
						Win32Error(num3, name);
					}
					else
					{
						num2 = ((num2 <= 1073741823) ? (num2 * 2) : int.MaxValue);
					}
					lpcbData2 = num2;
					array = new byte[num2];
				}
				if (num3 != 0)
				{
					Win32Error(num3, name);
				}
				return array;
			}
			if (num != 234)
			{
				return obj;
			}
		}
		if (lpcbData < 0)
		{
			lpcbData = 0;
		}
		switch (lpType)
		{
		case 0:
		case 3:
		case 5:
		{
			byte[] array5 = new byte[lpcbData];
			num = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, array5, ref lpcbData);
			obj = array5;
			break;
		}
		case 11:
			if (lpcbData <= 8)
			{
				long lpData2 = 0L;
				num = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, ref lpData2, ref lpcbData);
				obj = lpData2;
				break;
			}
			goto case 0;
		case 4:
			if (lpcbData <= 4)
			{
				int lpData = 0;
				num = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, ref lpData, ref lpcbData);
				obj = lpData;
				break;
			}
			goto case 11;
		case 1:
		{
			if (lpcbData % 2 == 1)
			{
				try
				{
					lpcbData = checked(lpcbData + 1);
				}
				catch (OverflowException innerException4)
				{
					throw new IOException(Environment.GetResourceString("Arg_RegGetOverflowBug"), innerException4);
				}
			}
			char[] array6 = new char[lpcbData / 2];
			num = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, array6, ref lpcbData);
			obj = ((array6.Length == 0 || array6[array6.Length - 1] != 0) ? new string(array6) : new string(array6, 0, array6.Length - 1));
			break;
		}
		case 2:
		{
			if (lpcbData % 2 == 1)
			{
				try
				{
					lpcbData = checked(lpcbData + 1);
				}
				catch (OverflowException innerException3)
				{
					throw new IOException(Environment.GetResourceString("Arg_RegGetOverflowBug"), innerException3);
				}
			}
			char[] array4 = new char[lpcbData / 2];
			num = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, array4, ref lpcbData);
			obj = ((array4.Length == 0 || array4[array4.Length - 1] != 0) ? new string(array4) : new string(array4, 0, array4.Length - 1));
			if (!doNotExpand)
			{
				obj = Environment.ExpandEnvironmentVariables((string)obj);
			}
			break;
		}
		case 7:
		{
			if (lpcbData % 2 == 1)
			{
				try
				{
					lpcbData = checked(lpcbData + 1);
				}
				catch (OverflowException innerException)
				{
					throw new IOException(Environment.GetResourceString("Arg_RegGetOverflowBug"), innerException);
				}
			}
			char[] array2 = new char[lpcbData / 2];
			num = Win32Native.RegQueryValueEx(hkey, name, null, ref lpType, array2, ref lpcbData);
			if (array2.Length != 0 && array2[array2.Length - 1] != 0)
			{
				try
				{
					char[] array3 = new char[checked(array2.Length + 1)];
					for (int i = 0; i < array2.Length; i++)
					{
						array3[i] = array2[i];
					}
					array3[array3.Length - 1] = '\0';
					array2 = array3;
				}
				catch (OverflowException innerException2)
				{
					throw new IOException(Environment.GetResourceString("Arg_RegGetOverflowBug"), innerException2);
				}
				array2[array2.Length - 1] = '\0';
			}
			IList<string> list = new List<string>();
			int num4 = 0;
			int num5 = array2.Length;
			while (num == 0 && num4 < num5)
			{
				int j;
				for (j = num4; j < num5 && array2[j] != 0; j++)
				{
				}
				if (j < num5)
				{
					if (j - num4 > 0)
					{
						list.Add(new string(array2, num4, j - num4));
					}
					else if (j != num5 - 1)
					{
						list.Add(string.Empty);
					}
				}
				else
				{
					list.Add(new string(array2, num4, num5 - num4));
				}
				num4 = j + 1;
			}
			obj = new string[list.Count];
			list.CopyTo((string[])obj, 0);
			break;
		}
		}
		return obj;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public RegistryValueKind GetValueKind(string name)
	{
		CheckPermission(RegistryInternalCheck.CheckValueReadPermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		EnsureNotDisposed();
		int lpType = 0;
		int lpcbData = 0;
		int num = Win32Native.RegQueryValueEx(hkey, name, (int[])null, ref lpType, (byte[])null, ref lpcbData);
		if (num != 0)
		{
			Win32Error(num, null);
		}
		if (lpType == 0)
		{
			return RegistryValueKind.None;
		}
		if (!Enum.IsDefined(typeof(RegistryValueKind), lpType))
		{
			return RegistryValueKind.Unknown;
		}
		return (RegistryValueKind)lpType;
	}

	private bool IsDirty()
	{
		return (state & 1) != 0;
	}

	private bool IsSystemKey()
	{
		return (state & 2) != 0;
	}

	private bool IsWritable()
	{
		return (state & 4) != 0;
	}

	private bool IsPerfDataKey()
	{
		return (state & 8) != 0;
	}

	private void SetDirty()
	{
		state |= 1;
	}

	public void SetValue(string name, object value)
	{
		SetValue(name, value, RegistryValueKind.Unknown);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public unsafe void SetValue(string name, object value, RegistryValueKind valueKind)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if (name != null && name.Length > 16383)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RegValStrLenBug"));
		}
		if (!Enum.IsDefined(typeof(RegistryValueKind), valueKind))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RegBadKeyKind"), "valueKind");
		}
		EnsureWriteable();
		if (!remoteKey && ContainsRegistryValue(name))
		{
			CheckPermission(RegistryInternalCheck.CheckValueWritePermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		}
		else
		{
			CheckPermission(RegistryInternalCheck.CheckValueCreatePermission, name, subKeyWritable: false, RegistryKeyPermissionCheck.Default);
		}
		if (valueKind == RegistryValueKind.Unknown)
		{
			valueKind = CalculateValueKind(value);
		}
		int num = 0;
		try
		{
			switch (valueKind)
			{
			case RegistryValueKind.String:
			case RegistryValueKind.ExpandString:
			{
				string text = value.ToString();
				num = Win32Native.RegSetValueEx(hkey, name, 0, valueKind, text, checked(text.Length * 2 + 2));
				break;
			}
			case RegistryValueKind.MultiString:
			{
				string[] array2 = (string[])((string[])value).Clone();
				int num2 = 0;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] == null)
					{
						ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSetStrArrNull);
					}
					num2 = checked(num2 + (array2[i].Length + 1) * 2);
				}
				num2 = checked(num2 + 2);
				byte[] array3 = new byte[num2];
				fixed (byte* value2 = array3)
				{
					IntPtr intPtr = new IntPtr(value2);
					for (int j = 0; j < array2.Length; j++)
					{
						string.InternalCopy(array2[j], intPtr, checked(array2[j].Length * 2));
						intPtr = new IntPtr((long)intPtr + checked(array2[j].Length * 2));
						*(short*)intPtr.ToPointer() = 0;
						intPtr = new IntPtr((long)intPtr + 2);
					}
					*(short*)intPtr.ToPointer() = 0;
					intPtr = new IntPtr((long)intPtr + 2);
					num = Win32Native.RegSetValueEx(hkey, name, 0, RegistryValueKind.MultiString, array3, num2);
				}
				break;
			}
			case RegistryValueKind.None:
			case RegistryValueKind.Binary:
			{
				byte[] array = (byte[])value;
				num = Win32Native.RegSetValueEx(hkey, name, 0, (valueKind != RegistryValueKind.None) ? RegistryValueKind.Binary : RegistryValueKind.Unknown, array, array.Length);
				break;
			}
			case RegistryValueKind.DWord:
			{
				int lpData2 = Convert.ToInt32(value, CultureInfo.InvariantCulture);
				num = Win32Native.RegSetValueEx(hkey, name, 0, RegistryValueKind.DWord, ref lpData2, 4);
				break;
			}
			case RegistryValueKind.QWord:
			{
				long lpData = Convert.ToInt64(value, CultureInfo.InvariantCulture);
				num = Win32Native.RegSetValueEx(hkey, name, 0, RegistryValueKind.QWord, ref lpData, 8);
				break;
			}
			case RegistryValueKind.Unknown:
			case (RegistryValueKind)5:
			case (RegistryValueKind)6:
			case (RegistryValueKind)8:
			case (RegistryValueKind)9:
			case (RegistryValueKind)10:
				break;
			}
		}
		catch (OverflowException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSetMismatchedKind);
		}
		catch (InvalidOperationException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSetMismatchedKind);
		}
		catch (FormatException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSetMismatchedKind);
		}
		catch (InvalidCastException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegSetMismatchedKind);
		}
		if (num == 0)
		{
			SetDirty();
		}
		else
		{
			Win32Error(num, null);
		}
	}

	private RegistryValueKind CalculateValueKind(object value)
	{
		if (value is int)
		{
			return RegistryValueKind.DWord;
		}
		if (value is Array)
		{
			if (value is byte[])
			{
				return RegistryValueKind.Binary;
			}
			if (value is string[])
			{
				return RegistryValueKind.MultiString;
			}
			throw new ArgumentException(Environment.GetResourceString("Arg_RegSetBadArrType", value.GetType().Name));
		}
		return RegistryValueKind.String;
	}

	[SecuritySafeCritical]
	public override string ToString()
	{
		EnsureNotDisposed();
		return keyName;
	}

	public RegistrySecurity GetAccessControl()
	{
		return GetAccessControl(AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group);
	}

	[SecuritySafeCritical]
	public RegistrySecurity GetAccessControl(AccessControlSections includeSections)
	{
		EnsureNotDisposed();
		return new RegistrySecurity(hkey, keyName, includeSections);
	}

	[SecuritySafeCritical]
	public void SetAccessControl(RegistrySecurity registrySecurity)
	{
		EnsureWriteable();
		if (registrySecurity == null)
		{
			throw new ArgumentNullException("registrySecurity");
		}
		registrySecurity.Persist(hkey, keyName);
	}

	[SecuritySafeCritical]
	internal void Win32Error(int errorCode, string str)
	{
		switch (errorCode)
		{
		case 5:
			if (str != null)
			{
				throw new UnauthorizedAccessException(Environment.GetResourceString("UnauthorizedAccess_RegistryKeyGeneric_Key", str));
			}
			throw new UnauthorizedAccessException();
		case 6:
			if (!IsPerfDataKey())
			{
				hkey.SetHandleAsInvalid();
				hkey = null;
			}
			break;
		case 2:
			throw new IOException(Environment.GetResourceString("Arg_RegKeyNotFound"), errorCode);
		}
		throw new IOException(Win32Native.GetMessage(errorCode), errorCode);
	}

	[SecuritySafeCritical]
	internal static void Win32ErrorStatic(int errorCode, string str)
	{
		if (errorCode == 5)
		{
			if (str != null)
			{
				throw new UnauthorizedAccessException(Environment.GetResourceString("UnauthorizedAccess_RegistryKeyGeneric_Key", str));
			}
			throw new UnauthorizedAccessException();
		}
		throw new IOException(Win32Native.GetMessage(errorCode), errorCode);
	}

	internal static string FixupName(string name)
	{
		if (name.IndexOf('\\') == -1)
		{
			return name;
		}
		StringBuilder stringBuilder = new StringBuilder(name);
		FixupPath(stringBuilder);
		int num = stringBuilder.Length - 1;
		if (num >= 0 && stringBuilder[num] == '\\')
		{
			stringBuilder.Length = num;
		}
		return stringBuilder.ToString();
	}

	private static void FixupPath(StringBuilder path)
	{
		int length = path.Length;
		bool flag = false;
		char c = '\uffff';
		int i;
		for (i = 1; i < length - 1; i++)
		{
			if (path[i] == '\\')
			{
				i++;
				while (i < length && path[i] == '\\')
				{
					path[i] = c;
					i++;
					flag = true;
				}
			}
		}
		if (!flag)
		{
			return;
		}
		i = 0;
		int num = 0;
		while (i < length)
		{
			if (path[i] == c)
			{
				i++;
				continue;
			}
			path[num] = path[i];
			i++;
			num++;
		}
		path.Length += num - i;
	}

	private void GetSubKeyReadPermission(string subkeyName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Read;
		path = keyName + "\\" + subkeyName + "\\.";
	}

	private void GetSubKeyWritePermission(string subkeyName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Write;
		path = keyName + "\\" + subkeyName + "\\.";
	}

	private void GetSubKeyCreatePermission(string subkeyName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Create;
		path = keyName + "\\" + subkeyName + "\\.";
	}

	private void GetSubTreeReadPermission(string subkeyName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Read;
		path = keyName + "\\" + subkeyName + "\\";
	}

	private void GetSubTreeWritePermission(string subkeyName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Write;
		path = keyName + "\\" + subkeyName + "\\";
	}

	private void GetSubTreeReadWritePermission(string subkeyName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Read | RegistryPermissionAccess.Write;
		path = keyName + "\\" + subkeyName;
	}

	private void GetValueReadPermission(string valueName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Read;
		path = keyName + "\\" + valueName;
	}

	private void GetValueWritePermission(string valueName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Write;
		path = keyName + "\\" + valueName;
	}

	private void GetValueCreatePermission(string valueName, out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Create;
		path = keyName + "\\" + valueName;
	}

	private void GetKeyReadPermission(out RegistryPermissionAccess access, out string path)
	{
		access = RegistryPermissionAccess.Read;
		path = keyName + "\\.";
	}

	[SecurityCritical]
	private void CheckPermission(RegistryInternalCheck check, string item, bool subKeyWritable, RegistryKeyPermissionCheck subKeyCheck)
	{
		bool flag = false;
		RegistryPermissionAccess access = RegistryPermissionAccess.NoAccess;
		string path = null;
		if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			return;
		}
		switch (check)
		{
		case RegistryInternalCheck.CheckSubKeyReadPermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
				break;
			}
			flag = true;
			GetSubKeyReadPermission(item, out access, out path);
			break;
		case RegistryInternalCheck.CheckSubKeyWritePermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
			}
			else if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetSubKeyWritePermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckSubKeyCreatePermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
			}
			else if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetSubKeyCreatePermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckSubTreeReadPermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
			}
			else if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetSubTreeReadPermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckSubTreeWritePermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
			}
			else if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetSubTreeWritePermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckSubTreeReadWritePermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
				break;
			}
			flag = true;
			GetSubTreeReadWritePermission(item, out access, out path);
			break;
		case RegistryInternalCheck.CheckValueReadPermission:
			if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetValueReadPermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckValueWritePermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
			}
			else if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetValueWritePermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckValueCreatePermission:
			if (remoteKey)
			{
				CheckUnmanagedCodePermission();
			}
			else if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetValueCreatePermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckKeyReadPermission:
			if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				flag = true;
				GetKeyReadPermission(out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckSubTreePermission:
			switch (subKeyCheck)
			{
			case RegistryKeyPermissionCheck.ReadSubTree:
				if (checkMode == RegistryKeyPermissionCheck.Default)
				{
					if (remoteKey)
					{
						CheckUnmanagedCodePermission();
						break;
					}
					flag = true;
					GetSubTreeReadPermission(item, out access, out path);
				}
				break;
			case RegistryKeyPermissionCheck.ReadWriteSubTree:
				if (checkMode != RegistryKeyPermissionCheck.ReadWriteSubTree)
				{
					if (remoteKey)
					{
						CheckUnmanagedCodePermission();
						break;
					}
					flag = true;
					GetSubTreeReadWritePermission(item, out access, out path);
				}
				break;
			}
			break;
		case RegistryInternalCheck.CheckOpenSubKeyWithWritablePermission:
			if (checkMode == RegistryKeyPermissionCheck.Default)
			{
				if (remoteKey)
				{
					CheckUnmanagedCodePermission();
					break;
				}
				flag = true;
				GetSubKeyReadPermission(item, out access, out path);
			}
			else if (subKeyWritable && checkMode == RegistryKeyPermissionCheck.ReadSubTree)
			{
				if (remoteKey)
				{
					CheckUnmanagedCodePermission();
					break;
				}
				flag = true;
				GetSubTreeReadWritePermission(item, out access, out path);
			}
			break;
		case RegistryInternalCheck.CheckOpenSubKeyPermission:
			if (subKeyCheck == RegistryKeyPermissionCheck.Default && checkMode == RegistryKeyPermissionCheck.Default)
			{
				if (remoteKey)
				{
					CheckUnmanagedCodePermission();
					break;
				}
				flag = true;
				GetSubKeyReadPermission(item, out access, out path);
			}
			break;
		}
		if (flag)
		{
			new RegistryPermission(access, path).Demand();
		}
	}

	[SecurityCritical]
	private static void CheckUnmanagedCodePermission()
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
	}

	[SecurityCritical]
	private bool ContainsRegistryValue(string name)
	{
		int lpType = 0;
		int lpcbData = 0;
		int num = Win32Native.RegQueryValueEx(hkey, name, (int[])null, ref lpType, (byte[])null, ref lpcbData);
		return num == 0;
	}

	[SecurityCritical]
	private void EnsureNotDisposed()
	{
		if (hkey == null)
		{
			ThrowHelper.ThrowObjectDisposedException(keyName, ExceptionResource.ObjectDisposed_RegKeyClosed);
		}
	}

	[SecurityCritical]
	private void EnsureWriteable()
	{
		EnsureNotDisposed();
		if (!IsWritable())
		{
			ThrowHelper.ThrowUnauthorizedAccessException(ExceptionResource.UnauthorizedAccess_RegistryNoWrite);
		}
	}

	private static int GetRegistryKeyAccess(bool isWritable)
	{
		if (!isWritable)
		{
			return 131097;
		}
		return 131103;
	}

	private static int GetRegistryKeyAccess(RegistryKeyPermissionCheck mode)
	{
		int result = 0;
		switch (mode)
		{
		case RegistryKeyPermissionCheck.Default:
		case RegistryKeyPermissionCheck.ReadSubTree:
			result = 131097;
			break;
		case RegistryKeyPermissionCheck.ReadWriteSubTree:
			result = 131103;
			break;
		}
		return result;
	}

	private RegistryKeyPermissionCheck GetSubKeyPermissonCheck(bool subkeyWritable)
	{
		if (checkMode == RegistryKeyPermissionCheck.Default)
		{
			return checkMode;
		}
		if (subkeyWritable)
		{
			return RegistryKeyPermissionCheck.ReadWriteSubTree;
		}
		return RegistryKeyPermissionCheck.ReadSubTree;
	}

	private static void ValidateKeyName(string name)
	{
		if (name == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.name);
		}
		int num = name.IndexOf("\\", StringComparison.OrdinalIgnoreCase);
		int num2 = 0;
		while (num != -1)
		{
			if (num - num2 > 255)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegKeyStrLenBug);
			}
			num2 = num + 1;
			num = name.IndexOf("\\", num2, StringComparison.OrdinalIgnoreCase);
		}
		if (name.Length - num2 > 255)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RegKeyStrLenBug);
		}
	}

	private static void ValidateKeyMode(RegistryKeyPermissionCheck mode)
	{
		if (mode < RegistryKeyPermissionCheck.Default || mode > RegistryKeyPermissionCheck.ReadWriteSubTree)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidRegistryKeyPermissionCheck, ExceptionArgument.mode);
		}
	}

	private static void ValidateKeyOptions(RegistryOptions options)
	{
		if (options < RegistryOptions.None || options > RegistryOptions.Volatile)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidRegistryOptionsCheck, ExceptionArgument.options);
		}
	}

	private static void ValidateKeyView(RegistryView view)
	{
		if (view != RegistryView.Default && view != RegistryView.Registry32 && view != RegistryView.Registry64)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidRegistryViewCheck, ExceptionArgument.view);
		}
	}

	private static void ValidateKeyRights(int rights)
	{
		if ((rights & -983104) != 0)
		{
			ThrowHelper.ThrowSecurityException(ExceptionResource.Security_RegistryPermission);
		}
	}
}
