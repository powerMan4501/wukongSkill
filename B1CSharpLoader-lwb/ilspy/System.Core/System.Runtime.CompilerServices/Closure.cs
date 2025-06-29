using System.ComponentModel;
using System.Diagnostics;

namespace System.Runtime.CompilerServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[DebuggerStepThrough]
[global::__DynamicallyInvokable]
public sealed class Closure
{
	[global::__DynamicallyInvokable]
	public readonly object[] Constants;

	[global::__DynamicallyInvokable]
	public readonly object[] Locals;

	[global::__DynamicallyInvokable]
	public Closure(object[] constants, object[] locals)
	{
		Constants = constants;
		Locals = locals;
	}
}
