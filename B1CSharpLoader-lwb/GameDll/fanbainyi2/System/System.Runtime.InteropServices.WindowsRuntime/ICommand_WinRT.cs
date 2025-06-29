namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("e5af3542-ca67-4081-995b-709dd13792df")]
internal interface ICommand_WinRT
{
	EventRegistrationToken add_CanExecuteChanged(EventHandler<object> value);

	void remove_CanExecuteChanged(EventRegistrationToken token);

	bool CanExecute(object parameter);

	void Execute(object parameter);
}
