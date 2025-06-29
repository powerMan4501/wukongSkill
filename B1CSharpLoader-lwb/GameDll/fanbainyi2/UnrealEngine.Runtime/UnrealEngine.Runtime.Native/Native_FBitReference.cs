using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FBitReference
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get(ref FBitReference instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set(ref FBitReference instance, csbool value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AtomicSet(ref FBitReference instance, csbool value);

	public static Del_Get Get;

	public static Del_Set Set;

	public static Del_AtomicSet AtomicSet;
}
