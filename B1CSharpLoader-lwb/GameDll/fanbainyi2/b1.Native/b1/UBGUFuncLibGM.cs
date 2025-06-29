using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibGM", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibGM : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TestIntPtr_IsValid;

	private static IntPtr TestIntPtr_FunctionAddress;

	private static int TestIntPtr_ParamsSize;

	private static bool TestIntPtr_Count_IsValid;

	private static FFieldAddress TestIntPtr_Count_PropertyAddress;

	private static int TestIntPtr_Count_Offset;

	private static bool TestIntPtr_InputPtr_IsValid;

	private static FFieldAddress TestIntPtr_InputPtr_PropertyAddress;

	private static int TestIntPtr_InputPtr_Offset;

	private static bool TestIntPtr_ReturnValue_IsValid;

	private static FFieldAddress TestIntPtr_ReturnValue_PropertyAddress;

	private static int TestIntPtr_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibGM:TestIntPtr")]
	public unsafe static FIntPtr TestIntPtr(int Count, FIntPtr InputPtr)
	{
		if (!TestIntPtr_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibGM:TestIntPtr");
			return default(FIntPtr);
		}
		byte* ptr = stackalloc byte[(int)(uint)(TestIntPtr_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TestIntPtr_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TestIntPtr_Count_Offset), 0, TestIntPtr_Count_PropertyAddress.Address, Count);
		BlittableTypeMarshaler<FIntPtr>.ToNative(IntPtr.Add(intPtr, TestIntPtr_InputPtr_Offset), 0, TestIntPtr_InputPtr_PropertyAddress.Address, InputPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TestIntPtr_FunctionAddress, intPtr, TestIntPtr_ParamsSize);
		return BlittableTypeMarshaler<FIntPtr>.FromNative(IntPtr.Add(intPtr, TestIntPtr_ReturnValue_Offset), 0, TestIntPtr_ReturnValue_PropertyAddress.Address);
	}

	static UBGUFuncLibGM()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibGM)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibGM));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibGM");
		TestIntPtr_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TestIntPtr");
		TestIntPtr_ParamsSize = NativeReflection.GetFunctionParamsSize(TestIntPtr_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TestIntPtr_Count_PropertyAddress, TestIntPtr_FunctionAddress, "Count");
		TestIntPtr_Count_Offset = NativeReflectionCached.GetPropertyOffset(TestIntPtr_FunctionAddress, "Count");
		TestIntPtr_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(TestIntPtr_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TestIntPtr_InputPtr_PropertyAddress, TestIntPtr_FunctionAddress, "InputPtr");
		TestIntPtr_InputPtr_Offset = NativeReflectionCached.GetPropertyOffset(TestIntPtr_FunctionAddress, "InputPtr");
		TestIntPtr_InputPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(TestIntPtr_FunctionAddress, "InputPtr", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TestIntPtr_ReturnValue_PropertyAddress, TestIntPtr_FunctionAddress, "ReturnValue");
		TestIntPtr_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TestIntPtr_FunctionAddress, "ReturnValue");
		TestIntPtr_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TestIntPtr_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		TestIntPtr_IsValid = TestIntPtr_FunctionAddress != IntPtr.Zero && TestIntPtr_Count_IsValid && TestIntPtr_InputPtr_IsValid && TestIntPtr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibGM:TestIntPtr", TestIntPtr_IsValid);
	}
}
