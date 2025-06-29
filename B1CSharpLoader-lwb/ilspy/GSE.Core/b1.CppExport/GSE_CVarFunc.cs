using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using b1.Plugins.ConsoleVariableManager;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_CVarFunc
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_CreateHandle(ref FScriptArray Name);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetByHandle(int Handle, float Value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetByHandleWithPriority(int Handle, float Value, EConsoleVariablePriority Priority, int ExtendPriority);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DestroyHandle(int Handle);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_SetIsIgnored(ref FScriptArray Name, bool bIgnore);

	static GSE_CVarFunc()
	{
		Type typeFromHandle = typeof(CVarFuncLib);
		Dictionary<string, FIntPtr> cVarFuncAsMap = UGSE_CppExport.GetCVarFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (cVarFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
