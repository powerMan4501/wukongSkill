using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_FCoreUObjectDelegates
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_OnObjectModified(IntPtr objectBeingModified);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OnAssetLoaded(IntPtr asset);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OnObjectSaved(IntPtr savedObject);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreLoadMap(ref FScriptArray mapName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostLoadMapWithWorld(IntPtr loadedWorld);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnObjectModified(IntPtr instance, Del_OnObjectModified handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnAssetLoaded(IntPtr instance, Del_OnAssetLoaded handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_OnObjectSaved(IntPtr instance, Del_OnObjectSaved handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PreLoadMap(IntPtr instance, Del_PreLoadMap handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PostLoadMapWithWorld(IntPtr instance, Del_PostLoadMapWithWorld handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PostDemoPlay(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PreGarbageCollect(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Reg_PostGarbageCollect(IntPtr instance, FSimpleMulticastDelegate handler, ref FDelegateHandle handle, csbool enable);

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnObjectModified;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnAssetLoaded;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_OnObjectSaved;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PreLoadMap;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PostLoadMapWithWorld;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PostDemoPlay;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PreGarbageCollect;

	public static Native_FCoreDelegates.Del_Reg_CoreDelegates Reg_PostGarbageCollect;
}
