using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FSoftClassProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_MetaClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_MetaClass(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetMetaClass(IntPtr instance, IntPtr newMetaClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_MetaClass Get_MetaClass;

	public static Del_Set_MetaClass Set_MetaClass;

	public static Del_SetMetaClass SetMetaClass;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
