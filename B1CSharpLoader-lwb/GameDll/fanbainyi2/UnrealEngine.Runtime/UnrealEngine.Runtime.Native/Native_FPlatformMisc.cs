namespace UnrealEngine.Runtime.Native;

internal static class Native_FPlatformMisc
{
	public delegate void Del_RequestExit(csbool force);

	public static Del_RequestExit RequestExit;
}
