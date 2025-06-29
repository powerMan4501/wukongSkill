using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FTicker
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_RegisterTicker(float deltaTime);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_CoreTicker(IntPtr instance, Del_RegisterTicker handler, ref FDelegateHandle handle, csbool enable, float delay);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Tick(float deltaTime);

	public static Del_Reg_CoreTicker Reg_CoreTicker;

	public static Del_Tick Tick;
}
