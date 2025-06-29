using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_UEngineDelegates
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_OnWorldAdded(IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OnWorldDestroyed(IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnWorldAdded(IntPtr instance, Del_OnWorldAdded handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnWorldDestroyed(IntPtr instance, Del_OnWorldDestroyed handler, ref FDelegateHandle handle, csbool enable);

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnWorldAdded;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnWorldDestroyed;
}
