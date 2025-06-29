using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class NotifyCollectionChangedToManagedAdapter
{
	internal event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[SecurityCritical]
		add
		{
			INotifyCollectionChanged_WinRT notifyCollectionChanged_WinRT = JitHelpers.UnsafeCast<INotifyCollectionChanged_WinRT>(this);
			Func<NotifyCollectionChangedEventHandler, EventRegistrationToken> addMethod = notifyCollectionChanged_WinRT.add_CollectionChanged;
			Action<EventRegistrationToken> removeMethod = notifyCollectionChanged_WinRT.remove_CollectionChanged;
			WindowsRuntimeMarshal.AddEventHandler(addMethod, removeMethod, value);
		}
		[SecurityCritical]
		remove
		{
			INotifyCollectionChanged_WinRT notifyCollectionChanged_WinRT = JitHelpers.UnsafeCast<INotifyCollectionChanged_WinRT>(this);
			Action<EventRegistrationToken> removeMethod = notifyCollectionChanged_WinRT.remove_CollectionChanged;
			WindowsRuntimeMarshal.RemoveEventHandler(removeMethod, value);
		}
	}

	private NotifyCollectionChangedToManagedAdapter()
	{
	}
}
