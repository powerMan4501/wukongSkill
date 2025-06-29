using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Input;

namespace System.Runtime.InteropServices.WindowsRuntime;

[SecurityCritical]
internal sealed class ICommandToWinRTAdapter
{
	private static ConditionalWeakTable<ICommand, EventRegistrationTokenTable<EventHandler>> m_weakTable = new ConditionalWeakTable<ICommand, EventRegistrationTokenTable<EventHandler>>();

	private ICommandToWinRTAdapter()
	{
	}

	private EventRegistrationToken add_CanExecuteChanged(EventHandler<object> value)
	{
		ICommand command = JitHelpers.UnsafeCast<ICommand>(this);
		EventRegistrationTokenTable<EventHandler> orCreateValue = m_weakTable.GetOrCreateValue(command);
		EventHandler eventHandler = ICommandAdapterHelpers.CreateWrapperHandler(value);
		EventRegistrationToken result = orCreateValue.AddEventHandler(eventHandler);
		command.CanExecuteChanged += eventHandler;
		return result;
	}

	private void remove_CanExecuteChanged(EventRegistrationToken token)
	{
		ICommand command = JitHelpers.UnsafeCast<ICommand>(this);
		EventRegistrationTokenTable<EventHandler> orCreateValue = m_weakTable.GetOrCreateValue(command);
		EventHandler eventHandler = orCreateValue.ExtractHandler(token);
		if (eventHandler != null)
		{
			command.CanExecuteChanged -= eventHandler;
		}
	}

	private bool CanExecute(object parameter)
	{
		ICommand command = JitHelpers.UnsafeCast<ICommand>(this);
		return command.CanExecute(parameter);
	}

	private void Execute(object parameter)
	{
		ICommand command = JitHelpers.UnsafeCast<ICommand>(this);
		command.Execute(parameter);
	}
}
