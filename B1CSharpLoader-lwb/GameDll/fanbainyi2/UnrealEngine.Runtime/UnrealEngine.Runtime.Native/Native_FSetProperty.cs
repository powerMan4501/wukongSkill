using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FSetProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_ElementProp(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ElementProp(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate FScriptSetLayout Del_Get_SetLayout(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_SetLayout(IntPtr instance, FScriptSetLayout value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_ElementProp Get_ElementProp;

	public static Del_Set_ElementProp Set_ElementProp;

	public static Del_Get_SetLayout Get_SetLayout;

	public static Del_Set_SetLayout Set_SetLayout;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
