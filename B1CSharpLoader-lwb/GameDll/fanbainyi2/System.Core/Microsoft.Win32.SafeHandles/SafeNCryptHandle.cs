using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
public abstract class SafeNCryptHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private enum OwnershipState
	{
		Owner,
		Duplicate,
		Holder
	}

	private OwnershipState m_ownershipState;

	private SafeNCryptHandle m_holder;

	private SafeHandle _parentHandle;

	private SafeNCryptHandle Holder
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return m_holder;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			m_holder = value;
			m_ownershipState = OwnershipState.Duplicate;
		}
	}

	protected SafeNCryptHandle()
		: base(ownsHandle: true)
	{
	}

	protected SafeNCryptHandle(IntPtr handle, SafeHandle parentHandle)
		: base(ownsHandle: true)
	{
		if (parentHandle == null)
		{
			throw new ArgumentNullException("parentHandle");
		}
		if (parentHandle.IsClosed || parentHandle.IsInvalid)
		{
			throw new ArgumentException("Argument_Invalid_SafeHandleInvalidOrClosed", "parentHandle");
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			bool success = false;
			parentHandle.DangerousAddRef(ref success);
			if (success)
			{
				_parentHandle = parentHandle;
				SetHandle(handle);
				if (IsInvalid)
				{
					_parentHandle.DangerousRelease();
					_parentHandle = null;
				}
			}
		}
	}

	internal T Duplicate<T>() where T : SafeNCryptHandle, new()
	{
		if (m_ownershipState == OwnershipState.Owner)
		{
			return DuplicateOwnerHandle<T>();
		}
		return DuplicateDuplicatedHandle<T>();
	}

	private T DuplicateDuplicatedHandle<T>() where T : SafeNCryptHandle, new()
	{
		bool success = false;
		T val = new T();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			Holder.DangerousAddRef(ref success);
			val.SetHandle(Holder.DangerousGetHandle());
			val.Holder = Holder;
		}
		return val;
	}

	private T DuplicateOwnerHandle<T>() where T : SafeNCryptHandle, new()
	{
		bool success = false;
		T val = new T();
		T val2 = new T();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			val.m_ownershipState = OwnershipState.Holder;
			val.SetHandle(DangerousGetHandle());
			GC.SuppressFinalize(val);
			if (_parentHandle != null)
			{
				val._parentHandle = _parentHandle;
				_parentHandle = null;
			}
			Holder = val;
			val.DangerousAddRef(ref success);
			val2.SetHandle(val.DangerousGetHandle());
			val2.Holder = val;
		}
		return val2;
	}

	protected override bool ReleaseHandle()
	{
		if (m_ownershipState == OwnershipState.Duplicate)
		{
			Holder.DangerousRelease();
			return true;
		}
		if (_parentHandle != null)
		{
			_parentHandle.DangerousRelease();
			return true;
		}
		return ReleaseNativeHandle();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected abstract bool ReleaseNativeHandle();
}
