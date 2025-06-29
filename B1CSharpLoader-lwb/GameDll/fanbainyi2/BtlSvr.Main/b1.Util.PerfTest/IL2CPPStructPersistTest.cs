using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Util.PerfTest;

[UClass]
[USharpPath("/Script/b1-Managed.IL2CPPStructPersistTest")]
public class IL2CPPStructPersistTest : AActor
{
	private static bool TestStruct_IsValid;

	private static int TestStruct_Offset;

	private static bool PrintStruct_IsValid;

	private static IntPtr PrintStruct_FunctionAddress;

	private static int PrintStruct_ParamsSize;

	private static bool PrintStruct_Input_IsValid;

	private static int PrintStruct_Input_Offset;

	private static FFieldAddress PrintStruct_Input_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.IL2CPPStructPersistTest:TestStruct")]
	public IL2CPPUnitTestStructOuter TestStruct
	{
		get
		{
			CheckDestroyed();
			if (!TestStruct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPStructPersistTest:TestStruct");
				return default(IL2CPPUnitTestStructOuter);
			}
			return IL2CPPUnitTestStructOuter.FromNative(IntPtr.Add(base.Address, TestStruct_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TestStruct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.IL2CPPStructPersistTest:TestStruct");
			}
			else
			{
				IL2CPPUnitTestStructOuter.ToNative(IntPtr.Add(base.Address, TestStruct_Offset), value);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.IL2CPPStructPersistTest:PrintStruct")]
	public void PrintStruct(FCppTestStructOuter Input)
	{
		USystemLibrary.PrintString(this, "usharp c++ to C# struct array test:" + TestStruct.ItemStructs[0].ItemInts[0].ToString(), bPrintToScreen: true, bPrintToLog: true, FLinearColor.White, 2f, FName.None);
	}

	[UFunctionInvoker("/Script/b1-Managed.IL2CPPStructPersistTest:PrintStruct")]
	private static void PrintStruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		IL2CPPStructPersistTest iL2CPPStructPersistTest = GCHelper.Find<IL2CPPStructPersistTest>(obj);
		FCppTestStructOuter input = FCppTestStructOuter.FromNative(IntPtr.Add(buffer, PrintStruct_Input_Offset));
		iL2CPPStructPersistTest.PrintStruct(input);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.IL2CPPStructPersistTest");
		TestStruct_Offset = NativeReflection.GetPropertyOffset(intPtr, "TestStruct");
		TestStruct_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TestStruct", Classes.FStructProperty);
		PrintStruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrintStruct");
		PrintStruct_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintStruct_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PrintStruct_Input_PropertyAddress, PrintStruct_FunctionAddress, "Input");
		PrintStruct_Input_Offset = NativeReflection.GetPropertyOffset(PrintStruct_FunctionAddress, "Input");
		PrintStruct_Input_IsValid = NativeReflection.ValidatePropertyClass(PrintStruct_FunctionAddress, "Input", Classes.FStructProperty);
		PrintStruct_IsValid = PrintStruct_FunctionAddress != IntPtr.Zero && PrintStruct_Input_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.IL2CPPStructPersistTest:PrintStruct", PrintStruct_IsValid);
	}

	static IL2CPPStructPersistTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(IL2CPPStructPersistTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IL2CPPStructPersistTest));
	}
}
