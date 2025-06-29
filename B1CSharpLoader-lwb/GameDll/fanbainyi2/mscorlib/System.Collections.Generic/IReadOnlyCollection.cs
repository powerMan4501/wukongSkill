using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[TypeDependency("System.SZArrayHelper")]
[__DynamicallyInvokable]
public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
{
	[__DynamicallyInvokable]
	int Count
	{
		[__DynamicallyInvokable]
		get;
	}
}
