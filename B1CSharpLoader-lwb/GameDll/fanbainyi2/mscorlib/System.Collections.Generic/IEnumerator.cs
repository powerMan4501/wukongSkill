namespace System.Collections.Generic;

[__DynamicallyInvokable]
public interface IEnumerator<out T> : IDisposable, IEnumerator
{
	[__DynamicallyInvokable]
	new T Current
	{
		[__DynamicallyInvokable]
		get;
	}
}
