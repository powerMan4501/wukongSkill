using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;

namespace System.StubHelpers;

[FriendAccessAllowed]
internal static class EventArgsMarshaler
{
	[SecurityCritical]
	[FriendAccessAllowed]
	internal static IntPtr CreateNativeNCCEventArgsInstance(int action, object newItems, object oldItems, int newIndex, int oldIndex)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (newItems != null)
			{
				intPtr = Marshal.GetComInterfaceForObject(newItems, typeof(IBindableVector));
			}
			if (oldItems != null)
			{
				intPtr2 = Marshal.GetComInterfaceForObject(oldItems, typeof(IBindableVector));
			}
			return CreateNativeNCCEventArgsInstanceHelper(action, intPtr, intPtr2, newIndex, oldIndex);
		}
		finally
		{
			if (!intPtr2.IsNull())
			{
				Marshal.Release(intPtr2);
			}
			if (!intPtr.IsNull())
			{
				Marshal.Release(intPtr);
			}
		}
	}

	[DllImport("QCall")]
	[SecurityCritical]
	[FriendAccessAllowed]
	[SuppressUnmanagedCodeSecurity]
	internal static extern IntPtr CreateNativePCEventArgsInstance([MarshalAs(UnmanagedType.HString)] string name);

	[DllImport("QCall")]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static extern IntPtr CreateNativeNCCEventArgsInstanceHelper(int action, IntPtr newItem, IntPtr oldItem, int newIndex, int oldIndex);
}
