using System.Security.Permissions;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class DoWorkEventArgs : CancelEventArgs
{
	private object result;

	private object argument;

	[SRDescription("BackgroundWorker_DoWorkEventArgs_Argument")]
	[global::__DynamicallyInvokable]
	public object Argument
	{
		[global::__DynamicallyInvokable]
		get
		{
			return argument;
		}
	}

	[SRDescription("BackgroundWorker_DoWorkEventArgs_Result")]
	[global::__DynamicallyInvokable]
	public object Result
	{
		[global::__DynamicallyInvokable]
		get
		{
			return result;
		}
		[global::__DynamicallyInvokable]
		set
		{
			result = value;
		}
	}

	[global::__DynamicallyInvokable]
	public DoWorkEventArgs(object argument)
	{
		this.argument = argument;
	}
}
