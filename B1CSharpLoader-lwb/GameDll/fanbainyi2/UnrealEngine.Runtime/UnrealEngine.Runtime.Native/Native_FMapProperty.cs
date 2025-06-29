using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FMapProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_KeyProp(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_KeyProp(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_ValueProp(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ValueProp(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate FScriptMapLayout Del_Get_MapLayout(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_MapLayout(IntPtr instance, FScriptMapLayout value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_KeyProp Get_KeyProp;

	public static Del_Set_KeyProp Set_KeyProp;

	public static Del_Get_ValueProp Get_ValueProp;

	public static Del_Set_ValueProp Set_ValueProp;

	public static Del_Get_MapLayout Get_MapLayout;

	public static Del_Set_MapLayout Set_MapLayout;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
