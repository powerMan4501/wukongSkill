using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32;

namespace System.Security.AccessControl;

internal static class Win32
{
	internal const int TRUE = 1;

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	internal static int ConvertSdToSddl(byte[] binaryForm, int requestedRevision, SecurityInfos si, out string resultSddl)
	{
		uint resultStringLength = 0u;
		if (1 != Win32Native.ConvertSdToStringSd(binaryForm, (uint)requestedRevision, (uint)si, out var resultString, ref resultStringLength))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			resultSddl = null;
			if (lastWin32Error == 8)
			{
				throw new OutOfMemoryException();
			}
			return lastWin32Error;
		}
		resultSddl = Marshal.PtrToStringUni(resultString);
		Win32Native.LocalFree(resultString);
		return 0;
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static int GetSecurityInfo(ResourceType resourceType, string name, SafeHandle handle, AccessControlSections accessControlSections, out RawSecurityDescriptor resultSd)
	{
		resultSd = null;
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		SecurityInfos securityInfos = (SecurityInfos)0;
		Privilege privilege = null;
		if ((accessControlSections & AccessControlSections.Owner) != AccessControlSections.None)
		{
			securityInfos |= SecurityInfos.Owner;
		}
		if ((accessControlSections & AccessControlSections.Group) != AccessControlSections.None)
		{
			securityInfos |= SecurityInfos.Group;
		}
		if ((accessControlSections & AccessControlSections.Access) != AccessControlSections.None)
		{
			securityInfos |= SecurityInfos.DiscretionaryAcl;
		}
		if ((accessControlSections & AccessControlSections.Audit) != AccessControlSections.None)
		{
			securityInfos |= SecurityInfos.SystemAcl;
			privilege = new Privilege("SeSecurityPrivilege");
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		int num;
		IntPtr securityDescriptor;
		try
		{
			if (privilege != null)
			{
				try
				{
					privilege.Enable();
				}
				catch (PrivilegeNotHeldException)
				{
				}
			}
			IntPtr sidOwner;
			IntPtr sidGroup;
			IntPtr dacl;
			IntPtr sacl;
			if (name != null)
			{
				num = (int)Win32Native.GetSecurityInfoByName(name, (uint)resourceType, (uint)securityInfos, out sidOwner, out sidGroup, out dacl, out sacl, out securityDescriptor);
			}
			else
			{
				if (handle == null)
				{
					throw new SystemException();
				}
				if (handle.IsInvalid)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSafeHandle"), "handle");
				}
				num = (int)Win32Native.GetSecurityInfoByHandle(handle, (uint)resourceType, (uint)securityInfos, out sidOwner, out sidGroup, out dacl, out sacl, out securityDescriptor);
			}
			if (num == 0 && IntPtr.Zero.Equals(securityDescriptor))
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NoSecurityDescriptor"));
			}
			switch (num)
			{
			case 1300:
			case 1314:
				throw new PrivilegeNotHeldException("SeSecurityPrivilege");
			case 5:
			case 1347:
				throw new UnauthorizedAccessException();
			case 0:
				break;
			default:
				goto IL_0162;
			}
		}
		catch
		{
			privilege?.Revert();
			throw;
		}
		finally
		{
			privilege?.Revert();
		}
		uint securityDescriptorLength = Win32Native.GetSecurityDescriptorLength(securityDescriptor);
		byte[] array = new byte[securityDescriptorLength];
		Marshal.Copy(securityDescriptor, array, 0, (int)securityDescriptorLength);
		Win32Native.LocalFree(securityDescriptor);
		resultSd = new RawSecurityDescriptor(array, 0);
		return 0;
		IL_0162:
		if (num == 8)
		{
			throw new OutOfMemoryException();
		}
		return num;
	}

	[SecuritySafeCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static int SetSecurityInfo(ResourceType type, string name, SafeHandle handle, SecurityInfos securityInformation, SecurityIdentifier owner, SecurityIdentifier group, GenericAcl sacl, GenericAcl dacl)
	{
		byte[] array = null;
		byte[] array2 = null;
		byte[] array3 = null;
		byte[] array4 = null;
		Privilege privilege = null;
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		if (owner != null)
		{
			int binaryLength = owner.BinaryLength;
			array = new byte[binaryLength];
			owner.GetBinaryForm(array, 0);
		}
		if (group != null)
		{
			int binaryLength = group.BinaryLength;
			array2 = new byte[binaryLength];
			group.GetBinaryForm(array2, 0);
		}
		if (dacl != null)
		{
			int binaryLength = dacl.BinaryLength;
			array4 = new byte[binaryLength];
			dacl.GetBinaryForm(array4, 0);
		}
		if (sacl != null)
		{
			int binaryLength = sacl.BinaryLength;
			array3 = new byte[binaryLength];
			sacl.GetBinaryForm(array3, 0);
		}
		if ((securityInformation & SecurityInfos.SystemAcl) != 0)
		{
			privilege = new Privilege("SeSecurityPrivilege");
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		int num;
		try
		{
			if (privilege != null)
			{
				try
				{
					privilege.Enable();
				}
				catch (PrivilegeNotHeldException)
				{
				}
			}
			if (name != null)
			{
				num = (int)Win32Native.SetSecurityInfoByName(name, (uint)type, (uint)securityInformation, array, array2, array4, array3);
			}
			else
			{
				if (handle == null)
				{
					throw new InvalidProgramException();
				}
				if (handle.IsInvalid)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSafeHandle"), "handle");
				}
				num = (int)Win32Native.SetSecurityInfoByHandle(handle, (uint)type, (uint)securityInformation, array, array2, array4, array3);
			}
			switch (num)
			{
			case 1300:
			case 1314:
				throw new PrivilegeNotHeldException("SeSecurityPrivilege");
			case 5:
			case 1347:
				throw new UnauthorizedAccessException();
			case 0:
				break;
			default:
				goto IL_0159;
			}
		}
		catch
		{
			privilege?.Revert();
			throw;
		}
		finally
		{
			privilege?.Revert();
		}
		return 0;
		IL_0159:
		if (num == 8)
		{
			throw new OutOfMemoryException();
		}
		return num;
	}
}
