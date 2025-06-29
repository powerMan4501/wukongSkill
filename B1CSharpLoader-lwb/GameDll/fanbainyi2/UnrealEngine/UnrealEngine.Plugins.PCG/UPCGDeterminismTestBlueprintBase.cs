using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGDeterminismTestBlueprintBase", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDeterminismTestBlueprintBase : UObject
{
	private static bool ExecuteTest_IsValid;

	private IntPtr ExecuteTest_InstanceFunctionAddress;

	private static IntPtr ExecuteTest_FunctionAddress;

	private static int ExecuteTest_ParamsSize;

	private static bool ExecuteTest_InOutTestResult_IsValid;

	private static FFieldAddress ExecuteTest_InOutTestResult_PropertyAddress;

	private static int ExecuteTest_InOutTestResult_Offset;

	private static bool ExecuteTest_InPCGNode_IsValid;

	private static FFieldAddress ExecuteTest_InPCGNode_PropertyAddress;

	private static int ExecuteTest_InPCGNode_Offset;

	[UFunction(Flags = 474090496u)]
	[UMetaPath("/Script/PCG.PCGDeterminismTestBlueprintBase:ExecuteTest")]
	public unsafe void ExecuteTest(ref FDeterminismTestResult InOutTestResult, UPCGNode InPCGNode)
	{
		CheckDestroyed();
		if (!ExecuteTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDeterminismTestBlueprintBase:ExecuteTest");
			return;
		}
		if (ExecuteTest_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExecuteTest_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExecuteTest");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExecuteTest_InOutTestResult_PropertyAddress.Address, intPtr);
		FDeterminismTestResult.ToNative(IntPtr.Add(intPtr, ExecuteTest_InOutTestResult_Offset), 0, ExecuteTest_InOutTestResult_PropertyAddress.Address, InOutTestResult);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, ExecuteTest_InPCGNode_Offset), 0, ExecuteTest_InPCGNode_PropertyAddress.Address, InPCGNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteTest_InstanceFunctionAddress, intPtr, ExecuteTest_ParamsSize);
		InOutTestResult = FDeterminismTestResult.FromNative(IntPtr.Add(intPtr, ExecuteTest_InOutTestResult_Offset), 0, ExecuteTest_InOutTestResult_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExecuteTest_InOutTestResult_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ExecuteTest_Implementation(ref FDeterminismTestResult InOutTestResult, UPCGNode InPCGNode)
	{
		CheckDestroyed();
		if (!ExecuteTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDeterminismTestBlueprintBase:ExecuteTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExecuteTest_InOutTestResult_PropertyAddress.Address, intPtr);
		FDeterminismTestResult.ToNative(IntPtr.Add(intPtr, ExecuteTest_InOutTestResult_Offset), 0, ExecuteTest_InOutTestResult_PropertyAddress.Address, InOutTestResult);
		UObjectMarshaler<UPCGNode>.ToNative(IntPtr.Add(intPtr, ExecuteTest_InPCGNode_Offset), 0, ExecuteTest_InPCGNode_PropertyAddress.Address, InPCGNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteTest_FunctionAddress, intPtr, ExecuteTest_ParamsSize);
		InOutTestResult = FDeterminismTestResult.FromNative(IntPtr.Add(intPtr, ExecuteTest_InOutTestResult_Offset), 0, ExecuteTest_InOutTestResult_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExecuteTest_InOutTestResult_PropertyAddress.Address, intPtr);
	}

	static UPCGDeterminismTestBlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDeterminismTestBlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDeterminismTestBlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGDeterminismTestBlueprintBase");
		ExecuteTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExecuteTest");
		ExecuteTest_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteTest_InOutTestResult_PropertyAddress, ExecuteTest_FunctionAddress, "InOutTestResult");
		ExecuteTest_InOutTestResult_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteTest_FunctionAddress, "InOutTestResult");
		ExecuteTest_InOutTestResult_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteTest_FunctionAddress, "InOutTestResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteTest_InPCGNode_PropertyAddress, ExecuteTest_FunctionAddress, "InPCGNode");
		ExecuteTest_InPCGNode_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteTest_FunctionAddress, "InPCGNode");
		ExecuteTest_InPCGNode_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteTest_FunctionAddress, "InPCGNode", Classes.FObjectProperty);
		ExecuteTest_IsValid = ExecuteTest_FunctionAddress != IntPtr.Zero && ExecuteTest_InOutTestResult_IsValid && ExecuteTest_InPCGNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDeterminismTestBlueprintBase:ExecuteTest", ExecuteTest_IsValid);
	}
}
