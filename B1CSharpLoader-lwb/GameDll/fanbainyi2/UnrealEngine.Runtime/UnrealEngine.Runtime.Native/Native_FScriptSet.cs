using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FScriptSet
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValidIndex(ref FScriptSet instance, int index);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Num(ref FScriptSet instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetMaxIndex(ref FScriptSet instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetData(ref FScriptSet instance, int index, ref FScriptSetLayout layout);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Empty(ref FScriptSet instance, int slack, ref FScriptSetLayout layout);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveAt(ref FScriptSet instance, int index, ref FScriptSetLayout layout);

	[MonoNativeFunctionWrapper]
	public delegate int Del_AddUninitialized(ref FScriptSet instance, ref FScriptSetLayout layout);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Rehash(ref FScriptSet instance, ref FScriptSetLayout layout, HashDelegates.GetKeyHash getKeyHash);

	[MonoNativeFunctionWrapper]
	public delegate int Del_FindIndex(ref FScriptSet instance, IntPtr element, ref FScriptSetLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality equalityFn);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Add(ref FScriptSet instance, IntPtr element, ref FScriptSetLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality equalityFn, HashDelegates.Construct constructFn, HashDelegates.Destruct destructFn);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Destroy(ref FScriptSet instance);

	[MonoNativeFunctionWrapper]
	public delegate FScriptSetLayout Del_GetScriptLayout(int elementSize, int elementAlignment);

	public static Del_IsValidIndex IsValidIndex;

	public static Del_Num Num;

	public static Del_GetMaxIndex GetMaxIndex;

	public static Del_GetData GetData;

	public static Del_Empty Empty;

	public static Del_RemoveAt RemoveAt;

	public static Del_FindIndex FindIndex;

	public static Del_AddUninitialized AddUninitialized;

	public static Del_Rehash Rehash;

	public static Del_Add Add;

	public static Del_Destroy Destroy;

	public static Del_GetScriptLayout GetScriptLayout;
}
