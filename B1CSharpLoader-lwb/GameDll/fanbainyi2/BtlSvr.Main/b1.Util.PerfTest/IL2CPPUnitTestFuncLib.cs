using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UClass]
[USharpPath("/Script/b1-Managed.IL2CPPUnitTestFuncLib")]
public class IL2CPPUnitTestFuncLib : UBlueprintFunctionLibrary
{
	private static bool GetIL2CPPTestValue_IsValid;

	private static IntPtr GetIL2CPPTestValue_FunctionAddress;

	private static int GetIL2CPPTestValue_ParamsSize;

	private static bool GetIL2CPPTestValue_TestVal_IsValid;

	private static int GetIL2CPPTestValue_TestVal_Offset;

	private static bool GetIL2CPPTestValue_ReturnValue_IsValid;

	private static int GetIL2CPPTestValue_ReturnValue_Offset;

	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.IL2CPPUnitTestFuncLib:GetIL2CPPTestValue")]
	public static int GetIL2CPPTestValue(int TestVal)
	{
		return TestVal * 2;
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPUnitTestFuncLib:GetIL2CPPTestValue")]
	private static void GetIL2CPPTestValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		int testVal = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GetIL2CPPTestValue_TestVal_Offset));
		int iL2CPPTestValue = GetIL2CPPTestValue(testVal);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetIL2CPPTestValue_ReturnValue_Offset), iL2CPPTestValue);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.IL2CPPUnitTestFuncLib");
		GetIL2CPPTestValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetIL2CPPTestValue");
		GetIL2CPPTestValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIL2CPPTestValue_FunctionAddress);
		GetIL2CPPTestValue_TestVal_Offset = NativeReflection.GetPropertyOffset(GetIL2CPPTestValue_FunctionAddress, "TestVal");
		GetIL2CPPTestValue_TestVal_IsValid = NativeReflection.ValidatePropertyClass(GetIL2CPPTestValue_FunctionAddress, "TestVal", Classes.FIntProperty);
		GetIL2CPPTestValue_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetIL2CPPTestValue_FunctionAddress, "ReturnValue");
		GetIL2CPPTestValue_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetIL2CPPTestValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIL2CPPTestValue_IsValid = GetIL2CPPTestValue_FunctionAddress != IntPtr.Zero && GetIL2CPPTestValue_TestVal_IsValid && GetIL2CPPTestValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPUnitTestFuncLib:GetIL2CPPTestValue", GetIL2CPPTestValue_IsValid);
	}

	static IL2CPPUnitTestFuncLib()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPUnitTestFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPUnitTestFuncLib));
	}
}
