using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UBlueprintCore
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_SkeletonGeneratedClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_SkeletonGeneratedClass(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GeneratedClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_GeneratedClass(IntPtr instance, IntPtr value);

	public static Del_Get_SkeletonGeneratedClass Get_SkeletonGeneratedClass;

	public static Del_Set_SkeletonGeneratedClass Set_SkeletonGeneratedClass;

	public static Del_Get_GeneratedClass Get_GeneratedClass;

	public static Del_Set_GeneratedClass Set_GeneratedClass;
}
