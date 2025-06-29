using System;

namespace UnrealEngine.Runtime;

public class HashDelegates
{
	public delegate uint GetKeyHash(IntPtr element);

	public delegate csbool Equality(IntPtr a, IntPtr b);

	public delegate void Construct(IntPtr element);

	public delegate void Destruct(IntPtr element);

	public delegate void ConstructAndAssign(IntPtr element);

	public delegate void Assign(IntPtr element);
}
