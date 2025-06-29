using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_LineTraceFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_RequestAsyncLineTraceByObjectTypeSingleStatic(IntPtr InLineTraceObject, int ReqID, FVector Start, FVector End, EObjectTypeQuery[] ObjectTypes, bool bTraceComplex, bool bDebug);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RequestAsyncLineTraceByChannelSingleStatic(IntPtr InLineTraceObject, int ReqID, FVector Start, FVector End, ECollisionChannel TraceChannel, bool bTraceComplex, bool bDebug);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RequestAsyncLineTraceByObjectTypeSingleStatic_Batch(IntPtr InLineTraceObject, IntPtr ReqList, EObjectTypeQuery[] ObjectTypes, bool bTraceComplex, bool bDebug);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RequestAsyncLineTraceByChannelSingleStatic_Batch(IntPtr InLineTraceObject, IntPtr ReqList, ECollisionChannel TraceChannel, bool bTraceComplex, bool bDebug);

	static GSE_LineTraceFuncs()
	{
		Type typeFromHandle = typeof(LineTraceFuncLib);
		Dictionary<string, FIntPtr> lineTraceFuncAsMap = UGSE_CppExport.GetLineTraceFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (lineTraceFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
