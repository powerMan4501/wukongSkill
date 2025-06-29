using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Diagnostics.Contracts;

[__DynamicallyInvokable]
public sealed class ContractFailedEventArgs : EventArgs
{
	private ContractFailureKind _failureKind;

	private string _message;

	private string _condition;

	private Exception _originalException;

	private bool _handled;

	private bool _unwind;

	internal Exception thrownDuringHandler;

	[__DynamicallyInvokable]
	public string Message
	{
		[__DynamicallyInvokable]
		get
		{
			return _message;
		}
	}

	[__DynamicallyInvokable]
	public string Condition
	{
		[__DynamicallyInvokable]
		get
		{
			return _condition;
		}
	}

	[__DynamicallyInvokable]
	public ContractFailureKind FailureKind
	{
		[__DynamicallyInvokable]
		get
		{
			return _failureKind;
		}
	}

	[__DynamicallyInvokable]
	public Exception OriginalException
	{
		[__DynamicallyInvokable]
		get
		{
			return _originalException;
		}
	}

	[__DynamicallyInvokable]
	public bool Handled
	{
		[__DynamicallyInvokable]
		get
		{
			return _handled;
		}
	}

	[__DynamicallyInvokable]
	public bool Unwind
	{
		[__DynamicallyInvokable]
		get
		{
			return _unwind;
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public ContractFailedEventArgs(ContractFailureKind failureKind, string message, string condition, Exception originalException)
	{
		_failureKind = failureKind;
		_message = message;
		_condition = condition;
		_originalException = originalException;
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public void SetHandled()
	{
		_handled = true;
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public void SetUnwind()
	{
		_unwind = true;
	}
}
