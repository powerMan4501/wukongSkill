using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Markup;

namespace System.Windows.Input;

[TypeForwardedFrom("PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
[TypeConverter("System.Windows.Input.CommandConverter, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, Custom=null")]
[ValueSerializer("System.Windows.Input.CommandValueSerializer, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, Custom=null")]
[global::__DynamicallyInvokable]
public interface ICommand
{
	[global::__DynamicallyInvokable]
	event EventHandler CanExecuteChanged;

	[global::__DynamicallyInvokable]
	bool CanExecute(object parameter);

	[global::__DynamicallyInvokable]
	void Execute(object parameter);
}
