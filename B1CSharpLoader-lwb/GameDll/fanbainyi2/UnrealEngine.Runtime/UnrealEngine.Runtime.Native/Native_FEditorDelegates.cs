using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FEditorDelegates
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_OnPIEEvent(csbool simulating);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OnPIEMapOpenedEvent(string filename, bool bAsTemplate);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PreBeginPIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_BeginPIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PostPIEStarted(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PrePIEEnded(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_EndPIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PausePIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_ResumePIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_SingleStepPIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnPreSwitchBeginPIEAndSIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnSwitchBeginPIEAndSIE(IntPtr instance, Del_OnPIEEvent handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnMapOpened(IntPtr instance, Del_OnPIEMapOpenedEvent handler, ref FDelegateHandle handle, csbool enable);

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PreBeginPIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_BeginPIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PostPIEStarted;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PrePIEEnded;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_EndPIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PausePIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_ResumePIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_SingleStepPIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnPreSwitchBeginPIEAndSIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnSwitchBeginPIEAndSIE;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnMapOpened;
}
