using System.Collections.Specialized;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("28b167d5-1a31-465b-9b25-d5c3ae686c40")]
internal interface INotifyCollectionChanged_WinRT
{
	EventRegistrationToken add_CollectionChanged(NotifyCollectionChangedEventHandler value);

	void remove_CollectionChanged(EventRegistrationToken token);
}
