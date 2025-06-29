using System.Collections;
using System.Collections.Specialized;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("4cf68d33-e3f2-4964-b85e-945b4f7e2f21")]
internal interface INotifyCollectionChangedEventArgs
{
	NotifyCollectionChangedAction Action { get; }

	IList NewItems { get; }

	IList OldItems { get; }

	int NewStartingIndex { get; }

	int OldStartingIndex { get; }
}
