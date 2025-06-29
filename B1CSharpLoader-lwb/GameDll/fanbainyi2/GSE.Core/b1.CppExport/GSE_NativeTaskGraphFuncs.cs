using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;

namespace b1.CppExport;

public class GSE_NativeTaskGraphFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_CreateUSharpSimpleTask(IntPtr Prerequistes, IntPtr Func, int Arg1);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FGraphEventArrayCreate();

	[MonoNativeFunctionWrapper]
	public delegate void Del_FGraphEventArrayDestroy(IntPtr GraphEventArray);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FGraphEventArrayAdd(IntPtr GraphEventArray, IntPtr GraphEventItem);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FGraphEventWait(IntPtr GraphEvent);

	private class SimpleTestCase
	{
		private delegate void TestFuncDel(int Arg1);

		private static TestFuncDel TestFuncInst;

		private static void TestFunc(int Arg1)
		{
		}

		public void CallMe()
		{
			TestFuncInst = TestFunc;
			IntPtr functionPointerForDelegate = Marshal.GetFunctionPointerForDelegate(TestFuncInst);
			IntPtr intPtr = FGraphEventArrayCreate();
			for (int i = 0; i < 100; i++)
			{
				IntPtr graphEventItem = CreateUSharpSimpleTask(IntPtr.Zero, functionPointerForDelegate, i);
				FGraphEventArrayAdd(intPtr, graphEventItem);
			}
			CreateUSharpSimpleTask(intPtr, functionPointerForDelegate, 1001);
			FGraphEventArrayDestroy(intPtr);
		}
	}

	public static Del_CreateUSharpSimpleTask CreateUSharpSimpleTask;

	public static Del_FGraphEventArrayCreate FGraphEventArrayCreate;

	public static Del_FGraphEventArrayDestroy FGraphEventArrayDestroy;

	public static Del_FGraphEventArrayAdd FGraphEventArrayAdd;

	public static Del_FGraphEventWait FGraphEventWait;

	static GSE_NativeTaskGraphFuncs()
	{
		Type typeFromHandle = typeof(GSE_NativeTaskGraphFuncs);
		Dictionary<string, FIntPtr> taskGraphFuncAsMap = UGSE_CppExport.GetTaskGraphFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (taskGraphFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
