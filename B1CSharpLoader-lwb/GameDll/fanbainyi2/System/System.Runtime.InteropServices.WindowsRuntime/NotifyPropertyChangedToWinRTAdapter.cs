using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class NotifyPropertyChangedToWinRTAdapter
{
	private static ConditionalWeakTable<INotifyPropertyChanged, EventRegistrationTokenTable<PropertyChangedEventHandler>> m_weakTable = new ConditionalWeakTable<INotifyPropertyChanged, EventRegistrationTokenTable<PropertyChangedEventHandler>>();

	private NotifyPropertyChangedToWinRTAdapter()
	{
	}

	[SecurityCritical]
	internal EventRegistrationToken add_PropertyChanged(PropertyChangedEventHandler value)
	{
		INotifyPropertyChanged notifyPropertyChanged = JitHelpers.UnsafeCast<INotifyPropertyChanged>(this);
		EventRegistrationTokenTable<PropertyChangedEventHandler> orCreateValue = m_weakTable.GetOrCreateValue(notifyPropertyChanged);
		EventRegistrationToken result = orCreateValue.AddEventHandler(value);
		notifyPropertyChanged.PropertyChanged += value;
		return result;
	}

	[SecurityCritical]
	internal void remove_PropertyChanged(EventRegistrationToken token)
	{
		INotifyPropertyChanged notifyPropertyChanged = JitHelpers.UnsafeCast<INotifyPropertyChanged>(this);
		EventRegistrationTokenTable<PropertyChangedEventHandler> orCreateValue = m_weakTable.GetOrCreateValue(notifyPropertyChanged);
		PropertyChangedEventHandler propertyChangedEventHandler = orCreateValue.ExtractHandler(token);
		if (propertyChangedEventHandler != null)
		{
			notifyPropertyChanged.PropertyChanged -= propertyChangedEventHandler;
		}
	}
}
