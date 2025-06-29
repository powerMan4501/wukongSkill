using System.ComponentModel;

namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("cf75d69c-f2f4-486b-b302-bb4c09baebfa")]
internal interface INotifyPropertyChanged_WinRT
{
	EventRegistrationToken add_PropertyChanged(PropertyChangedEventHandler value);

	void remove_PropertyChanged(EventRegistrationToken token);
}
