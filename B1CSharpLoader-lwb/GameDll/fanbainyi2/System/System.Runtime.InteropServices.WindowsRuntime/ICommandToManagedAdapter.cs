using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

[SecurityCritical]
internal sealed class ICommandToManagedAdapter
{
	private static ConditionalWeakTable<EventHandler, EventHandler<object>> m_weakTable = new ConditionalWeakTable<EventHandler, EventHandler<object>>();

	private event EventHandler CanExecuteChanged
	{
		add
		{
			ICommand_WinRT command_WinRT = JitHelpers.UnsafeCast<ICommand_WinRT>(this);
			Func<EventHandler<object>, EventRegistrationToken> addMethod = command_WinRT.add_CanExecuteChanged;
			Action<EventRegistrationToken> removeMethod = command_WinRT.remove_CanExecuteChanged;
			EventHandler<object> value2 = m_weakTable.GetValue(value, ICommandAdapterHelpers.CreateWrapperHandler);
			WindowsRuntimeMarshal.AddEventHandler(addMethod, removeMethod, value2);
		}
		remove
		{
			ICommand_WinRT command_WinRT = JitHelpers.UnsafeCast<ICommand_WinRT>(this);
			Action<EventRegistrationToken> removeMethod = command_WinRT.remove_CanExecuteChanged;
			EventHandler<object> valueFromEquivalentKey = ICommandAdapterHelpers.GetValueFromEquivalentKey(m_weakTable, value, ICommandAdapterHelpers.CreateWrapperHandler);
			WindowsRuntimeMarshal.RemoveEventHandler(removeMethod, valueFromEquivalentKey);
		}
	}

	private ICommandToManagedAdapter()
	{
	}

	private bool CanExecute(object parameter)
	{
		ICommand_WinRT command_WinRT = JitHelpers.UnsafeCast<ICommand_WinRT>(this);
		return command_WinRT.CanExecute(parameter);
	}

	private void Execute(object parameter)
	{
		ICommand_WinRT command_WinRT = JitHelpers.UnsafeCast<ICommand_WinRT>(this);
		command_WinRT.Execute(parameter);
	}
}
