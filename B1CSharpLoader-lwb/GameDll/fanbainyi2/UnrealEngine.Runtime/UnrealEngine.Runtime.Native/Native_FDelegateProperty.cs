using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FDelegateProperty
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_SignatureFunction(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_SignatureFunction(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithUObjectOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_ConstructWithFPropertyOuter(IntPtr Outer, ref FName InName, EObjectFlags InObjectFlags);

	public static Del_Get_SignatureFunction Get_SignatureFunction;

	public static Del_Set_SignatureFunction Set_SignatureFunction;

	public static Del_ConstructWithUObjectOuter ConstructWithUObjectOuter;

	public static Del_ConstructWithFPropertyOuter ConstructWithFPropertyOuter;
}
