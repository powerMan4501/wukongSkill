using System.Runtime.InteropServices;

namespace System;

[ComVisible(true)]
[__DynamicallyInvokable]
public interface IComparable
{
	[__DynamicallyInvokable]
	int CompareTo(object obj);
}
[__DynamicallyInvokable]
public interface IComparable<in T>
{
	[__DynamicallyInvokable]
	int CompareTo(T other);
}
