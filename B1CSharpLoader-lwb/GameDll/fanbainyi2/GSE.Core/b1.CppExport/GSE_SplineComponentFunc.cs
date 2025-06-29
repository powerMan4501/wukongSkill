using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_SplineComponentFunc
{
	[MonoNativeFunctionWrapper]
	public delegate FVector Del_FindLocationClosestToWorldLocation(IntPtr Comp, FVector WorldLocation, bool bLocalSpace);

	[MonoNativeFunctionWrapper]
	public delegate FVector Del_FindRightVectorClosestToWorldLocation(IntPtr Comp, FVector WorldLocation, bool bLocalSpace);

	static GSE_SplineComponentFunc()
	{
		Type typeFromHandle = typeof(SplineComponentFuncLib);
		Dictionary<string, FIntPtr> splineComponentFuncAsMap = UGSE_CppExport.GetSplineComponentFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (splineComponentFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
