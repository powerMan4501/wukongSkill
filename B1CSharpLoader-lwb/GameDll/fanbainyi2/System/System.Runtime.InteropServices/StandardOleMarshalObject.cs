using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Runtime.InteropServices;

[ComVisible(true)]
public class StandardOleMarshalObject : MarshalByRefObject, Microsoft.Win32.UnsafeNativeMethods.IMarshal
{
	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int GetMarshalSizeMax_Delegate(IntPtr _this, ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out int pSize);

	[SuppressUnmanagedCodeSecurity]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int MarshalInterface_Delegate(IntPtr _this, IntPtr pStm, ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags);

	private static readonly Guid CLSID_StdMarshal = new Guid("00000017-0000-0000-c000-000000000046");

	protected StandardOleMarshalObject()
	{
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	private IntPtr GetStdMarshaler(ref Guid riid, int dwDestContext, int mshlflags)
	{
		IntPtr ppMarshal = IntPtr.Zero;
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(this);
		if (iUnknownForObject != IntPtr.Zero)
		{
			try
			{
				if (Microsoft.Win32.UnsafeNativeMethods.CoGetStandardMarshal(ref riid, iUnknownForObject, dwDestContext, IntPtr.Zero, mshlflags, out ppMarshal) == 0)
				{
					return ppMarshal;
				}
			}
			finally
			{
				Marshal.Release(iUnknownForObject);
			}
		}
		throw new InvalidOperationException(SR.GetString("StandardOleMarshalObjectGetMarshalerFailed", riid.ToString()));
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	int Microsoft.Win32.UnsafeNativeMethods.IMarshal.GetUnmarshalClass(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out Guid pCid)
	{
		pCid = CLSID_StdMarshal;
		return 0;
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	unsafe int Microsoft.Win32.UnsafeNativeMethods.IMarshal.GetMarshalSizeMax(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out int pSize)
	{
		IntPtr stdMarshaler = GetStdMarshaler(ref riid, dwDestContext, mshlflags);
		try
		{
			IntPtr intPtr = *(IntPtr*)stdMarshaler.ToPointer();
			IntPtr ptr = ((IntPtr*)intPtr.ToPointer())[4];
			GetMarshalSizeMax_Delegate getMarshalSizeMax_Delegate = (GetMarshalSizeMax_Delegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(GetMarshalSizeMax_Delegate));
			return getMarshalSizeMax_Delegate(stdMarshaler, ref riid, pv, dwDestContext, pvDestContext, mshlflags, out pSize);
		}
		finally
		{
			Marshal.Release(stdMarshaler);
		}
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	unsafe int Microsoft.Win32.UnsafeNativeMethods.IMarshal.MarshalInterface(IntPtr pStm, ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags)
	{
		IntPtr stdMarshaler = GetStdMarshaler(ref riid, dwDestContext, mshlflags);
		try
		{
			IntPtr intPtr = *(IntPtr*)stdMarshaler.ToPointer();
			IntPtr ptr = ((IntPtr*)intPtr.ToPointer())[5];
			MarshalInterface_Delegate marshalInterface_Delegate = (MarshalInterface_Delegate)Marshal.GetDelegateForFunctionPointer(ptr, typeof(MarshalInterface_Delegate));
			return marshalInterface_Delegate(stdMarshaler, pStm, ref riid, pv, dwDestContext, pvDestContext, mshlflags);
		}
		finally
		{
			Marshal.Release(stdMarshaler);
		}
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	int Microsoft.Win32.UnsafeNativeMethods.IMarshal.UnmarshalInterface(IntPtr pStm, ref Guid riid, out IntPtr ppv)
	{
		ppv = IntPtr.Zero;
		return -2147467263;
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	int Microsoft.Win32.UnsafeNativeMethods.IMarshal.ReleaseMarshalData(IntPtr pStm)
	{
		return -2147467263;
	}

	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	int Microsoft.Win32.UnsafeNativeMethods.IMarshal.DisconnectObject(int dwReserved)
	{
		return -2147467263;
	}
}
