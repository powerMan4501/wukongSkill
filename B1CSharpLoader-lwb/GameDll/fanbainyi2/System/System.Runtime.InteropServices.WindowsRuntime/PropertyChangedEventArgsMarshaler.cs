using System.ComponentModel;
using System.Security;
using System.StubHelpers;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal static class PropertyChangedEventArgsMarshaler
{
	[SecurityCritical]
	internal static IntPtr ConvertToNative(PropertyChangedEventArgs managedArgs)
	{
		if (managedArgs == null)
		{
			return IntPtr.Zero;
		}
		return EventArgsMarshaler.CreateNativePCEventArgsInstance(managedArgs.PropertyName);
	}

	[SecurityCritical]
	internal static PropertyChangedEventArgs ConvertToManaged(IntPtr nativeArgsIP)
	{
		if (nativeArgsIP == IntPtr.Zero)
		{
			return null;
		}
		object obj = InterfaceMarshaler.ConvertToManagedWithoutUnboxing(nativeArgsIP);
		IPropertyChangedEventArgs e = (IPropertyChangedEventArgs)obj;
		return new PropertyChangedEventArgs(e.PropertyName);
	}
}
