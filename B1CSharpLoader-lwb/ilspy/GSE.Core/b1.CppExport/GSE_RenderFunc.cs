using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_RenderFunc
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_MaterialSetScalarParameterValue(IntPtr WorldCtx, IntPtr MPC, FName OverrideName, float Val);

	[MonoNativeFunctionWrapper]
	public delegate int Del_MaterialSetVectorParameterValue(IntPtr WorldCtx, IntPtr MPC, FName OverrideName, ref FLinearColor Val);

	public static Del_MaterialSetScalarParameterValue MaterialSetScalarParameterValue;

	public static Del_MaterialSetVectorParameterValue MaterialSetVectorParameterValue;

	static GSE_RenderFunc()
	{
		Type typeFromHandle = typeof(GSE_RenderFunc);
		Dictionary<string, FIntPtr> renderFuncAsMap = UGSE_CppExport.GetRenderFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (renderFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
