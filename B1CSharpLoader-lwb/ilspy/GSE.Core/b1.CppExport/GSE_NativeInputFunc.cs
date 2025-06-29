using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_NativeInputFunc
{
	[MonoNativeFunctionWrapper]
	public delegate FVector Del_GetInputActionValue(IntPtr PlayerControllerPtr, IntPtr InputActionPtr);

	static GSE_NativeInputFunc()
	{
		Type typeFromHandle = typeof(InputFuncLib);
		Dictionary<string, FIntPtr> inputFuncAsMap = UGSE_CppExport.GetInputFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (inputFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
