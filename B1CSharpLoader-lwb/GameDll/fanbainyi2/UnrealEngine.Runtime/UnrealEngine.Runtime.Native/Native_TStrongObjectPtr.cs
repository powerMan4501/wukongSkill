using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_TStrongObjectPtr
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_New();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Delete(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reset(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get(IntPtr instance);

	public static Del_New New;

	public static Del_Delete Delete;

	public static Del_Reset Reset;

	public static Del_Get Get;
}
