using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FCoreNet
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_RPC_ResetLastFailedReason();

	[MonoNativeFunctionWrapper]
	public delegate void Del_RPC_ValidateFailed(ref FScriptArray reason);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RPC_GetLastFailedReason(ref FScriptArray result);

	public static Del_RPC_ResetLastFailedReason RPC_ResetLastFailedReason;

	public static Del_RPC_ValidateFailed RPC_ValidateFailed;

	public static Del_RPC_GetLastFailedReason RPC_GetLastFailedReason;
}
