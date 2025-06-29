using System;
using System.Collections.Generic;
using System.IO;
using ILRuntime.Runtime.Enviorment;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ILRuntimeCrossBinding")]
public class BGW_ILRuntimeCrossBinding : UObject
{
	private static List<Type> types;

	private static bool GenerateCrossBindingCode_AutoTest_IsValid;

	private static IntPtr GenerateCrossBindingCode_AutoTest_FunctionAddress;

	private static int GenerateCrossBindingCode_AutoTest_ParamsSize;

	private static void InitTypeList()
	{
	}

	private static void GenerateCrossbindAdapter()
	{
		foreach (Type type in types)
		{
			string text = type.ToString() + ".cs";
			using StreamWriter streamWriter = new StreamWriter(USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "\\Managed\\BtlSvr.Main\\Util\\ILRuntime\\ILRuntimeAdapter\\AutoGenCrossBinding\\" + text);
			streamWriter.WriteLine(CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(type, "b1"));
		}
	}

	[BlueprintCallable]
	[Category("CLRBindingGen")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_ILRuntimeCrossBinding:GenerateCrossBindingCode_AutoTest")]
	public static void GenerateCrossBindingCode_AutoTest()
	{
		InitTypeList();
		GenerateCrossbindAdapter();
	}

	static BGW_ILRuntimeCrossBinding()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ILRuntimeCrossBinding)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ILRuntimeCrossBinding));
		types = new List<Type>();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ILRuntimeCrossBinding:GenerateCrossBindingCode_AutoTest")]
	private static void GenerateCrossBindingCode_AutoTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		GenerateCrossBindingCode_AutoTest();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_ILRuntimeCrossBinding");
		GenerateCrossBindingCode_AutoTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateCrossBindingCode_AutoTest");
		GenerateCrossBindingCode_AutoTest_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateCrossBindingCode_AutoTest_FunctionAddress);
		GenerateCrossBindingCode_AutoTest_IsValid = GenerateCrossBindingCode_AutoTest_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ILRuntimeCrossBinding:GenerateCrossBindingCode_AutoTest", GenerateCrossBindingCode_AutoTest_IsValid);
	}
}
