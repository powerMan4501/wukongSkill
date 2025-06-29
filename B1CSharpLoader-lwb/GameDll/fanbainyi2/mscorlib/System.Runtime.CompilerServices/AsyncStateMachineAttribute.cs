namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
[__DynamicallyInvokable]
public sealed class AsyncStateMachineAttribute : StateMachineAttribute
{
	[__DynamicallyInvokable]
	public AsyncStateMachineAttribute(Type stateMachineType)
		: base(stateMachineType)
	{
	}
}
