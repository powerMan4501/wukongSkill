using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FUObjectThreadContext
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_PopInitializer();

	[MonoNativeFunctionWrapper]
	public delegate void Del_PushInitializer(IntPtr initializer);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_TopInitializer();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_IsInConstructor();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_ConstructedObject();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_SerializedObject();

	public static Del_PopInitializer PopInitializer;

	public static Del_PushInitializer PushInitializer;

	public static Del_TopInitializer TopInitializer;

	public static Del_Get_IsInConstructor Get_IsInConstructor;

	public static Del_Get_ConstructedObject Get_ConstructedObject;

	public static Del_Get_SerializedObject Get_SerializedObject;
}
