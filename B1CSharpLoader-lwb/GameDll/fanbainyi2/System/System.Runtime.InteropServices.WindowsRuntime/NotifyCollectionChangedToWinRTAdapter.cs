using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal sealed class NotifyCollectionChangedToWinRTAdapter
{
	private static ConditionalWeakTable<INotifyCollectionChanged, EventRegistrationTokenTable<NotifyCollectionChangedEventHandler>> m_weakTable = new ConditionalWeakTable<INotifyCollectionChanged, EventRegistrationTokenTable<NotifyCollectionChangedEventHandler>>();

	private NotifyCollectionChangedToWinRTAdapter()
	{
	}

	[SecurityCritical]
	internal EventRegistrationToken add_CollectionChanged(NotifyCollectionChangedEventHandler value)
	{
		INotifyCollectionChanged notifyCollectionChanged = JitHelpers.UnsafeCast<INotifyCollectionChanged>(this);
		EventRegistrationTokenTable<NotifyCollectionChangedEventHandler> orCreateValue = m_weakTable.GetOrCreateValue(notifyCollectionChanged);
		EventRegistrationToken result = orCreateValue.AddEventHandler(value);
		notifyCollectionChanged.CollectionChanged += value;
		return result;
	}

	[SecurityCritical]
	internal void remove_CollectionChanged(EventRegistrationToken token)
	{
		INotifyCollectionChanged notifyCollectionChanged = JitHelpers.UnsafeCast<INotifyCollectionChanged>(this);
		EventRegistrationTokenTable<NotifyCollectionChangedEventHandler> orCreateValue = m_weakTable.GetOrCreateValue(notifyCollectionChanged);
		NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = orCreateValue.ExtractHandler(token);
		if (notifyCollectionChangedEventHandler != null)
		{
			notifyCollectionChanged.CollectionChanged -= notifyCollectionChangedEventHandler;
		}
	}
}
