using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FThreading
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInGameThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInSlateThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInRenderingThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInParallelRenderingThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInActualRenderingThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInAsyncLoadingThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInRHIThread();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRenderingThreadGameThread();

	public static Del_IsInGameThread IsInGameThread;

	public static Del_IsInSlateThread IsInSlateThread;

	public static Del_IsInRenderingThread IsInRenderingThread;

	public static Del_IsInParallelRenderingThread IsInParallelRenderingThread;

	public static Del_IsInActualRenderingThread IsInActualRenderingThread;

	public static Del_IsInAsyncLoadingThread IsInAsyncLoadingThread;

	public static Del_IsInRHIThread IsInRHIThread;

	public static Del_IsRenderingThreadGameThread IsRenderingThreadGameThread;
}
