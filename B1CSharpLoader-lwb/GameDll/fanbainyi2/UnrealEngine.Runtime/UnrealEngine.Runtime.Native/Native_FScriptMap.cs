using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FScriptMap
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_FindPairIndex(IntPtr instance, IntPtr key, ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality keyEqualityFn);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindValue(IntPtr instance, IntPtr key, ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality keyEqualityFn);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Add(IntPtr instance, IntPtr key, IntPtr value, ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality keyEqualityFn, HashDelegates.ConstructAndAssign keyConstructAndAssignFn, HashDelegates.ConstructAndAssign valueConstructAndAssignFn, HashDelegates.Assign valueAssignFn, HashDelegates.Destruct destructKeyFn, HashDelegates.Destruct destructValueFn);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Destroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate FScriptMapLayout Del_GetScriptLayout(int keySize, int keyAlignment, int valueSize, int valueAlignment);

	public static Del_FindPairIndex FindPairIndex;

	public static Del_FindValue FindValue;

	public static Del_Add Add;

	public static Del_Destroy Destroy;

	public static Del_GetScriptLayout GetScriptLayout;
}
