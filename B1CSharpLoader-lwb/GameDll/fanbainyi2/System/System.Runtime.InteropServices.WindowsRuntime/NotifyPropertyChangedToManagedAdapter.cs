using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class NotifyPropertyChangedToManagedAdapter
{
	internal event PropertyChangedEventHandler PropertyChanged
	{
		[SecurityCritical]
		add
		{
			INotifyPropertyChanged_WinRT notifyPropertyChanged_WinRT = JitHelpers.UnsafeCast<INotifyPropertyChanged_WinRT>(this);
			Func<PropertyChangedEventHandler, EventRegistrationToken> addMethod = notifyPropertyChanged_WinRT.add_PropertyChanged;
			Action<EventRegistrationToken> removeMethod = notifyPropertyChanged_WinRT.remove_PropertyChanged;
			WindowsRuntimeMarshal.AddEventHandler(addMethod, removeMethod, value);
		}
		[SecurityCritical]
		remove
		{
			INotifyPropertyChanged_WinRT notifyPropertyChanged_WinRT = JitHelpers.UnsafeCast<INotifyPropertyChanged_WinRT>(this);
			Action<EventRegistrationToken> removeMethod = notifyPropertyChanged_WinRT.remove_PropertyChanged;
			WindowsRuntimeMarshal.RemoveEventHandler(removeMethod, value);
		}
	}

	private NotifyPropertyChangedToManagedAdapter()
	{
	}
}
