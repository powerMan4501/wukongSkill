using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;

namespace b1.CppExport;

public class GSE_UMGFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate bool Del_IsWidgetVisiableWithParent(IntPtr TargetWidget);

	[MonoNativeFunctionWrapper]
	public delegate void Del_IsWidgetVisiableWithParentInListPureM(IntPtr InWidgetList, IntPtr OutWidgetList);

	static GSE_UMGFuncs()
	{
		Type typeFromHandle = typeof(UMGQuickFuncLib);
		Dictionary<string, FIntPtr> uMGFuncAsMap = UGSE_CppExport.GetUMGFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (uMGFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
