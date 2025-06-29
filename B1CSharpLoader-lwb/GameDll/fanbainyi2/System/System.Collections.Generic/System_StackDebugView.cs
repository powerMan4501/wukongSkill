using System.Diagnostics;

namespace System.Collections.Generic;

internal sealed class System_StackDebugView<T>
{
	private Stack<T> stack;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items => stack.ToArray();

	public System_StackDebugView(Stack<T> stack)
	{
		if (stack == null)
		{
			throw new ArgumentNullException("stack");
		}
		this.stack = stack;
	}
}
