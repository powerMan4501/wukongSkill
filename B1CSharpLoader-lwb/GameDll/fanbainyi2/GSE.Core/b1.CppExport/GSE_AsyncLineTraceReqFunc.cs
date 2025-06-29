using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;

namespace b1.CppExport;

public class GSE_AsyncLineTraceReqFunc
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_AsyncLineTraceReqArrayRef_Allocate();

	[MonoNativeFunctionWrapper]
	public delegate void Del_AsyncLineTraceReqArrayRef_Add(IntPtr ReqArray, FAsyncLineTraceReq Req);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AsyncLineTraceReqArrayRef_Destroy(IntPtr ReqArray);

	[MonoNativeFunctionWrapper]
	public delegate int Del_AsyncLineTraceReqArrayRef_GetReqID(IntPtr ReqArray, int Index);

	[MonoNativeFunctionWrapper]
	public delegate int Del_AsyncLineTraceReqArrayRef_GetReqNum(IntPtr ReqArray);

	static GSE_AsyncLineTraceReqFunc()
	{
		Type typeFromHandle = typeof(AsyncLineTraceReqLib);
		Dictionary<string, FIntPtr> asyncLineTraceReqFuncAsMap = UGSE_CppExport.GetAsyncLineTraceReqFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (asyncLineTraceReqFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
