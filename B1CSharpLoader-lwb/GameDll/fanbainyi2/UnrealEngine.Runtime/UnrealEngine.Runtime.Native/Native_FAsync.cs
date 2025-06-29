using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FAsync
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_AsyncTask(FSimpleDelegate func, EAsyncThreadType threadType);

	public static Del_AsyncTask AsyncTask;
}
