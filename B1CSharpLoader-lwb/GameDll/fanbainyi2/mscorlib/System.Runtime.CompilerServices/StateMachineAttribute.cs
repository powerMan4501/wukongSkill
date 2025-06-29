namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
[__DynamicallyInvokable]
public class StateMachineAttribute : Attribute
{
	[__DynamicallyInvokable]
	public Type StateMachineType
	{
		[__DynamicallyInvokable]
		get;
		private set; }

	[__DynamicallyInvokable]
	public StateMachineAttribute(Type stateMachineType)
	{
		StateMachineType = stateMachineType;
	}
}
