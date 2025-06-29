using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FDelegateHandle
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GenerateNewHandle(ref FDelegateHandle result);

	public static Del_GenerateNewHandle GenerateNewHandle;
}
