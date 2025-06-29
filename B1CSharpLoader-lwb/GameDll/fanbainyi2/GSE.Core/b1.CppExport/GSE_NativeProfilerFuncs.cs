using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;

namespace b1.CppExport;

public class GSE_NativeProfilerFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_CreateStatID(string StatName);

	[MonoNativeFunctionWrapper]
	public delegate int Del_CreateStatIDInSlateGroup(string StatName);

	[MonoNativeFunctionWrapper]
	public delegate int Del_CreateStatIDInGSCustomGroup(string StatName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BeginSampleWithUObject(IntPtr ObjAddress);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BeginSampleWithStatID(int StatID);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EndSample();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_BeginSampleCycleCounterWithStatID(int StatID);

	[MonoNativeFunctionWrapper]
	public delegate void Del_EndSampleCycleCounter(IntPtr CycleCounter);

	static GSE_NativeProfilerFuncs()
	{
		Type typeFromHandle = typeof(ProfilerFuncLib);
		Dictionary<string, FIntPtr> profilerFuncAsMap = UGSE_CppExport.GetProfilerFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (profilerFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
