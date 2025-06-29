using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FMessageDialog
{
	[MonoNativeFunctionWrapper]
	public delegate EAppReturnType Del_Open(EAppMsgType messageType, ref FScriptArray message, ref FScriptArray optTitle);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Log(ref FScriptArray message, ref FScriptArray categoryName, ELogVerbosity verbosity);

	public static Del_Open Open;

	public static Del_Log Log;

	public static Del_Log LogShipping;
}
