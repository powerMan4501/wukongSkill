using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;

namespace b1.CppExport;

public class GSE_NativeAIFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_SetAISenseConfig(IntPtr PerceptionCompAddress, float HearRange, float SightRange, float LoseSightRange, float VisionAngleDegrees, float ASRangeFromLastSeenLoc, bool IsSightDominantSense, out bool IsHearingSet, out bool IsSightSet);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SinglePerceptionSetEnable(IntPtr PerceptionCompAddress, bool IsHearing, bool bEnable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetPerceptionForgetAll(IntPtr PerceptionCompAddress);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ListenerForgetsActor(IntPtr PerceptionCompAddress, IntPtr ActorToForgetAddress);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetAIBTPause(IntPtr BrainComponentAddress, bool bEnable);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetAIBTStop(IntPtr BTCompAddress);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AISetBT(IntPtr ActorAddress, IntPtr BTAssetAddress);

	static GSE_NativeAIFuncs()
	{
		Type typeFromHandle = typeof(AIFuncLib);
		Dictionary<string, FIntPtr> aIFuncAsMap = UGSE_CppExport.GetAIFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (aIFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
