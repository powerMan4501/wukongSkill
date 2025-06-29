using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FInterfaceProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_InterfaceClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_InterfaceClass(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetInterfaceClass(IntPtr instance, IntPtr newMetaClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_InterfaceClass Get_InterfaceClass;

	public static Del_Set_InterfaceClass Set_InterfaceClass;

	public static Del_SetInterfaceClass SetInterfaceClass;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
