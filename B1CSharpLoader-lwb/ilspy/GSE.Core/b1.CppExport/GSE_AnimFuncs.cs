using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_AnimFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate float Del_ABPStateMachineGetGlobalWeight(IntPtr AnimInstance, ref FName StateMachineName, ref FName StateName);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetActiveMontageInstanceID(IntPtr AnimInstance);

	[MonoNativeFunctionWrapper]
	public delegate float Del_CalcSlotMontageLocalWeight(IntPtr AnimInstance, ref FName SlotNodeName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetCurveValueFromAnimInstance(IntPtr AnimInstance, ref FName CurveName, out bool OutIsActive, out float OutValue);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_IsMontageInstancePlaying(IntPtr Character, int MontageInstanceID);

	static GSE_AnimFuncs()
	{
		Type typeFromHandle = typeof(AnimFuncLib);
		Dictionary<string, FIntPtr> animFuncAsMap = UGSE_CppExport.GetAnimFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (animFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
