using System;

namespace UnrealEngine.Runtime;

public static class MarshalingDelegates<T>
{
	public delegate T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop);

	public delegate void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value);

	public delegate void Destroy(IntPtr nativeBuffer, int arrayIndex, IntPtr prop);
}
