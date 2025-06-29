using System;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

internal class TFixedSizeArrayDebugView<T>
{
	private TFixedSizeArrayBase<T> fixedSizeArray;

	[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
	public T[] Items => fixedSizeArray.ToArray();

	public TFixedSizeArrayDebugView(TFixedSizeArrayBase<T> fixedSizeArray)
	{
		if (fixedSizeArray == null)
		{
			throw new ArgumentNullException("fixedSizeArray");
		}
		this.fixedSizeArray = fixedSizeArray;
	}
}
