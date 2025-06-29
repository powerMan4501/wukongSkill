using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.GroundTruthData", "FunctionalTesting", UnrealModuleType.Engine)]
public class UGroundTruthData : UObject
{
	private static bool SaveObject_IsValid;

	private static IntPtr SaveObject_FunctionAddress;

	private static int SaveObject_ParamsSize;

	private static bool SaveObject_GroundTruth_IsValid;

	private static FFieldAddress SaveObject_GroundTruth_PropertyAddress;

	private static int SaveObject_GroundTruth_Offset;

	private static bool LoadObject_IsValid;

	private static IntPtr LoadObject_FunctionAddress;

	private static int LoadObject_ParamsSize;

	private static bool LoadObject_ReturnValue_IsValid;

	private static FFieldAddress LoadObject_ReturnValue_PropertyAddress;

	private static int LoadObject_ReturnValue_Offset;

	private static bool CanModify_IsValid;

	private static IntPtr CanModify_FunctionAddress;

	private static int CanModify_ParamsSize;

	private static bool CanModify_ReturnValue_IsValid;

	private static FFieldAddress CanModify_ReturnValue_PropertyAddress;

	private static int CanModify_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.GroundTruthData:SaveObject")]
	public unsafe void SaveObject(UObject GroundTruth)
	{
		CheckDestroyed();
		if (!SaveObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.GroundTruthData:SaveObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SaveObject_GroundTruth_Offset), 0, SaveObject_GroundTruth_PropertyAddress.Address, GroundTruth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveObject_FunctionAddress, intPtr, SaveObject_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FunctionalTesting.GroundTruthData:LoadObject")]
	public unsafe UObject LoadObject()
	{
		CheckDestroyed();
		if (!LoadObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.GroundTruthData:LoadObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadObject_FunctionAddress, intPtr, LoadObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, LoadObject_ReturnValue_Offset), 0, LoadObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/FunctionalTesting.GroundTruthData:CanModify")]
	public unsafe bool CanModify()
	{
		CheckDestroyed();
		if (!CanModify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FunctionalTesting.GroundTruthData:CanModify");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanModify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanModify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanModify_FunctionAddress, intPtr, CanModify_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanModify_ReturnValue_Offset), 0, CanModify_ReturnValue_PropertyAddress.Address);
	}

	static UGroundTruthData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroundTruthData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroundTruthData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FunctionalTesting.GroundTruthData");
		SaveObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveObject");
		SaveObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveObject_GroundTruth_PropertyAddress, SaveObject_FunctionAddress, "GroundTruth");
		SaveObject_GroundTruth_Offset = NativeReflectionCached.GetPropertyOffset(SaveObject_FunctionAddress, "GroundTruth");
		SaveObject_GroundTruth_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveObject_FunctionAddress, "GroundTruth", Classes.FObjectProperty);
		SaveObject_IsValid = SaveObject_FunctionAddress != IntPtr.Zero && SaveObject_GroundTruth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.GroundTruthData:SaveObject", SaveObject_IsValid);
		LoadObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LoadObject");
		LoadObject_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadObject_ReturnValue_PropertyAddress, LoadObject_FunctionAddress, "ReturnValue");
		LoadObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadObject_FunctionAddress, "ReturnValue");
		LoadObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadObject_IsValid = LoadObject_FunctionAddress != IntPtr.Zero && LoadObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.GroundTruthData:LoadObject", LoadObject_IsValid);
		CanModify_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanModify");
		CanModify_ParamsSize = NativeReflection.GetFunctionParamsSize(CanModify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanModify_ReturnValue_PropertyAddress, CanModify_FunctionAddress, "ReturnValue");
		CanModify_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanModify_FunctionAddress, "ReturnValue");
		CanModify_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanModify_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanModify_IsValid = CanModify_FunctionAddress != IntPtr.Zero && CanModify_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FunctionalTesting.GroundTruthData:CanModify", CanModify_IsValid);
	}
}
