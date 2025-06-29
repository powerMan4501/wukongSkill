using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class FCoreNet
{
	public static void RPC_ResetLastFailedReason()
	{
		Native_FCoreNet.RPC_ResetLastFailedReason();
	}

	public static void RPC_ValidateFailed(string reason)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(reason);
		Native_FCoreNet.RPC_ValidateFailed(ref fStringUnsafe.Array);
	}

	public static string RPC_GetLastFailedReason()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FCoreNet.RPC_GetLastFailedReason(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}
}
