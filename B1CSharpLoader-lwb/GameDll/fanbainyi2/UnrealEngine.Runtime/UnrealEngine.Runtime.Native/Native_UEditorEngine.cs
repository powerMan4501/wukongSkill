using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UEditorEngine
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetTimerManager(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetEditorWorldContext(IntPtr instance, csbool ensureIsGWorld);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetPIEWorldContext(IntPtr instance);

	public static Del_GetTimerManager GetTimerManager;

	public static Del_GetEditorWorldContext GetEditorWorldContext;

	public static Del_GetPIEWorldContext GetPIEWorldContext;
}
