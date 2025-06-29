using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

[TypeDependency("System.SZArrayHelper")]
[__DynamicallyInvokable]
public interface IReadOnlyList<out T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable
{
	[__DynamicallyInvokable]
	T this[int index]
	{
		[__DynamicallyInvokable]
		get;
	}
}
