using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGMatchAndSetBase", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGMatchAndSetBase : UObject
{
	private static bool ValidatePreconditions_IsValid;

	private IntPtr ValidatePreconditions_InstanceFunctionAddress;

	private static IntPtr ValidatePreconditions_FunctionAddress;

	private static int ValidatePreconditions_ParamsSize;

	private static bool ValidatePreconditions_InPointData_IsValid;

	private static FFieldAddress ValidatePreconditions_InPointData_PropertyAddress;

	private static int ValidatePreconditions_InPointData_Offset;

	private static bool ValidatePreconditions_ReturnValue_IsValid;

	private static FFieldAddress ValidatePreconditions_ReturnValue_PropertyAddress;

	private static int ValidatePreconditions_ReturnValue_Offset;

	private static bool MatchAndSet_IsValid;

	private IntPtr MatchAndSet_InstanceFunctionAddress;

	private static IntPtr MatchAndSet_FunctionAddress;

	private static int MatchAndSet_ParamsSize;

	private static bool MatchAndSet_Context_IsValid;

	private static FFieldAddress MatchAndSet_Context_PropertyAddress;

	private static int MatchAndSet_Context_Offset;

	private static bool MatchAndSet_InSettings_IsValid;

	private static FFieldAddress MatchAndSet_InSettings_PropertyAddress;

	private static int MatchAndSet_InSettings_Offset;

	private static bool MatchAndSet_InPointData_IsValid;

	private static FFieldAddress MatchAndSet_InPointData_PropertyAddress;

	private static int MatchAndSet_InPointData_Offset;

	private static bool MatchAndSet_OutPointData_IsValid;

	private static FFieldAddress MatchAndSet_OutPointData_PropertyAddress;

	private static int MatchAndSet_OutPointData_Offset;

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetBase:ValidatePreconditions")]
	public unsafe bool ValidatePreconditions(UPCGPointData InPointData)
	{
		CheckDestroyed();
		if (!ValidatePreconditions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMatchAndSetBase:ValidatePreconditions");
			return false;
		}
		if (ValidatePreconditions_InstanceFunctionAddress == IntPtr.Zero)
		{
			ValidatePreconditions_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ValidatePreconditions");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidatePreconditions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidatePreconditions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, ValidatePreconditions_InPointData_Offset), 0, ValidatePreconditions_InPointData_PropertyAddress.Address, InPointData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ValidatePreconditions_InstanceFunctionAddress, intPtr, ValidatePreconditions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ValidatePreconditions_ReturnValue_Offset), 0, ValidatePreconditions_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ValidatePreconditions_Implementation(UPCGPointData InPointData)
	{
		CheckDestroyed();
		if (!ValidatePreconditions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMatchAndSetBase:ValidatePreconditions");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ValidatePreconditions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ValidatePreconditions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, ValidatePreconditions_InPointData_Offset), 0, ValidatePreconditions_InPointData_PropertyAddress.Address, InPointData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ValidatePreconditions_FunctionAddress, intPtr, ValidatePreconditions_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ValidatePreconditions_ReturnValue_Offset), 0, ValidatePreconditions_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetBase:MatchAndSet")]
	public unsafe void MatchAndSet(ref FPCGContext Context, UPCGPointMatchAndSetSettings InSettings, UPCGPointData InPointData, UPCGPointData OutPointData)
	{
		CheckDestroyed();
		if (!MatchAndSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMatchAndSetBase:MatchAndSet");
			return;
		}
		if (MatchAndSet_InstanceFunctionAddress == IntPtr.Zero)
		{
			MatchAndSet_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "MatchAndSet");
		}
		byte* ptr = stackalloc byte[(int)(uint)(MatchAndSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MatchAndSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MatchAndSet_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, MatchAndSet_Context_Offset), 0, MatchAndSet_Context_PropertyAddress.Address, Context);
		UObjectMarshaler<UPCGPointMatchAndSetSettings>.ToNative(IntPtr.Add(intPtr, MatchAndSet_InSettings_Offset), 0, MatchAndSet_InSettings_PropertyAddress.Address, InSettings);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, MatchAndSet_InPointData_Offset), 0, MatchAndSet_InPointData_PropertyAddress.Address, InPointData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, MatchAndSet_OutPointData_Offset), 0, MatchAndSet_OutPointData_PropertyAddress.Address, OutPointData);
		NativeReflection.InvokeFunctionOptimized(base.Address, MatchAndSet_InstanceFunctionAddress, intPtr, MatchAndSet_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, MatchAndSet_Context_Offset), 0, MatchAndSet_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MatchAndSet_Context_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void MatchAndSet_Implementation(ref FPCGContext Context, UPCGPointMatchAndSetSettings InSettings, UPCGPointData InPointData, UPCGPointData OutPointData)
	{
		CheckDestroyed();
		if (!MatchAndSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGMatchAndSetBase:MatchAndSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MatchAndSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MatchAndSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MatchAndSet_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, MatchAndSet_Context_Offset), 0, MatchAndSet_Context_PropertyAddress.Address, Context);
		UObjectMarshaler<UPCGPointMatchAndSetSettings>.ToNative(IntPtr.Add(intPtr, MatchAndSet_InSettings_Offset), 0, MatchAndSet_InSettings_PropertyAddress.Address, InSettings);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, MatchAndSet_InPointData_Offset), 0, MatchAndSet_InPointData_PropertyAddress.Address, InPointData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, MatchAndSet_OutPointData_Offset), 0, MatchAndSet_OutPointData_PropertyAddress.Address, OutPointData);
		NativeReflection.InvokeFunctionOptimized(base.Address, MatchAndSet_FunctionAddress, intPtr, MatchAndSet_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, MatchAndSet_Context_Offset), 0, MatchAndSet_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MatchAndSet_Context_PropertyAddress.Address, intPtr);
	}

	static UPCGMatchAndSetBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGMatchAndSetBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGMatchAndSetBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGMatchAndSetBase");
		ValidatePreconditions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ValidatePreconditions");
		ValidatePreconditions_ParamsSize = NativeReflection.GetFunctionParamsSize(ValidatePreconditions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ValidatePreconditions_InPointData_PropertyAddress, ValidatePreconditions_FunctionAddress, "InPointData");
		ValidatePreconditions_InPointData_Offset = NativeReflectionCached.GetPropertyOffset(ValidatePreconditions_FunctionAddress, "InPointData");
		ValidatePreconditions_InPointData_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidatePreconditions_FunctionAddress, "InPointData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ValidatePreconditions_ReturnValue_PropertyAddress, ValidatePreconditions_FunctionAddress, "ReturnValue");
		ValidatePreconditions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ValidatePreconditions_FunctionAddress, "ReturnValue");
		ValidatePreconditions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ValidatePreconditions_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ValidatePreconditions_IsValid = ValidatePreconditions_FunctionAddress != IntPtr.Zero && ValidatePreconditions_InPointData_IsValid && ValidatePreconditions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMatchAndSetBase:ValidatePreconditions", ValidatePreconditions_IsValid);
		MatchAndSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MatchAndSet");
		MatchAndSet_ParamsSize = NativeReflection.GetFunctionParamsSize(MatchAndSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MatchAndSet_Context_PropertyAddress, MatchAndSet_FunctionAddress, "Context");
		MatchAndSet_Context_Offset = NativeReflectionCached.GetPropertyOffset(MatchAndSet_FunctionAddress, "Context");
		MatchAndSet_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAndSet_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAndSet_InSettings_PropertyAddress, MatchAndSet_FunctionAddress, "InSettings");
		MatchAndSet_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(MatchAndSet_FunctionAddress, "InSettings");
		MatchAndSet_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAndSet_FunctionAddress, "InSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAndSet_InPointData_PropertyAddress, MatchAndSet_FunctionAddress, "InPointData");
		MatchAndSet_InPointData_Offset = NativeReflectionCached.GetPropertyOffset(MatchAndSet_FunctionAddress, "InPointData");
		MatchAndSet_InPointData_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAndSet_FunctionAddress, "InPointData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAndSet_OutPointData_PropertyAddress, MatchAndSet_FunctionAddress, "OutPointData");
		MatchAndSet_OutPointData_Offset = NativeReflectionCached.GetPropertyOffset(MatchAndSet_FunctionAddress, "OutPointData");
		MatchAndSet_OutPointData_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAndSet_FunctionAddress, "OutPointData", Classes.FObjectProperty);
		MatchAndSet_IsValid = MatchAndSet_FunctionAddress != IntPtr.Zero && MatchAndSet_Context_IsValid && MatchAndSet_InSettings_IsValid && MatchAndSet_InPointData_IsValid && MatchAndSet_OutPointData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGMatchAndSetBase:MatchAndSet", MatchAndSet_IsValid);
	}
}
