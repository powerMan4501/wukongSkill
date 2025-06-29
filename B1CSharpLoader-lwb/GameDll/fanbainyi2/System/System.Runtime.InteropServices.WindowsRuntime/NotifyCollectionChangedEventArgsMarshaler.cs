using System.Collections.Specialized;
using System.Security;
using System.StubHelpers;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal static class NotifyCollectionChangedEventArgsMarshaler
{
	[SecurityCritical]
	internal static IntPtr ConvertToNative(NotifyCollectionChangedEventArgs managedArgs)
	{
		if (managedArgs == null)
		{
			return IntPtr.Zero;
		}
		return EventArgsMarshaler.CreateNativeNCCEventArgsInstance((int)managedArgs.Action, managedArgs.NewItems, managedArgs.OldItems, managedArgs.NewStartingIndex, managedArgs.OldStartingIndex);
	}

	[SecurityCritical]
	internal static NotifyCollectionChangedEventArgs ConvertToManaged(IntPtr nativeArgsIP)
	{
		if (nativeArgsIP == IntPtr.Zero)
		{
			return null;
		}
		object obj = InterfaceMarshaler.ConvertToManagedWithoutUnboxing(nativeArgsIP);
		INotifyCollectionChangedEventArgs e = (INotifyCollectionChangedEventArgs)obj;
		return new NotifyCollectionChangedEventArgs(e.Action, e.NewItems, e.OldItems, e.NewStartingIndex, e.OldStartingIndex);
	}
}
