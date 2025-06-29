using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;

namespace b1.CppExport;

public class GSE_GSCVarFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GSVar_GetData(IntPtr CVar);

	static GSE_GSCVarFuncs()
	{
		Type typeFromHandle = typeof(GsCvarFuncLib);
		Dictionary<string, FIntPtr> gSCVarFuncAsMap = UGSE_CppExport.GetGSCVarFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (gSCVarFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
