namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
[__DynamicallyInvokable]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute
{
	[__DynamicallyInvokable]
	public IteratorStateMachineAttribute(Type stateMachineType)
		: base(stateMachineType)
	{
	}
}
