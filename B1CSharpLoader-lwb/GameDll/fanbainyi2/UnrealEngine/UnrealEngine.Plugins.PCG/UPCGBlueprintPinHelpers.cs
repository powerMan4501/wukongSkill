using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGBlueprintPinHelpers", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBlueprintPinHelpers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MakePinProperty_IsValid;

	private static IntPtr MakePinProperty_FunctionAddress;

	private static int MakePinProperty_ParamsSize;

	private static bool MakePinProperty_Label_IsValid;

	private static FFieldAddress MakePinProperty_Label_PropertyAddress;

	private static int MakePinProperty_Label_Offset;

	private static bool MakePinProperty_bAllowMultipleData_IsValid;

	private static FFieldAddress MakePinProperty_bAllowMultipleData_PropertyAddress;

	private static int MakePinProperty_bAllowMultipleData_Offset;

	private static bool MakePinProperty_bAllowMultipleConnections_IsValid;

	private static FFieldAddress MakePinProperty_bAllowMultipleConnections_PropertyAddress;

	private static int MakePinProperty_bAllowMultipleConnections_Offset;

	private static bool MakePinProperty_bAdvancedPin_IsValid;

	private static FFieldAddress MakePinProperty_bAdvancedPin_PropertyAddress;

	private static int MakePinProperty_bAdvancedPin_Offset;

	private static bool MakePinProperty_AllowedType_IsValid;

	private static FFieldAddress MakePinProperty_AllowedType_PropertyAddress;

	private static int MakePinProperty_AllowedType_Offset;

	private static bool MakePinProperty_ReturnValue_IsValid;

	private static FFieldAddress MakePinProperty_ReturnValue_PropertyAddress;

	private static int MakePinProperty_ReturnValue_Offset;

	private static bool BreakPinProperty_IsValid;

	private static IntPtr BreakPinProperty_FunctionAddress;

	private static int BreakPinProperty_ParamsSize;

	private static bool BreakPinProperty_PinProperty_IsValid;

	private static FFieldAddress BreakPinProperty_PinProperty_PropertyAddress;

	private static int BreakPinProperty_PinProperty_Offset;

	private static bool BreakPinProperty_Label_IsValid;

	private static FFieldAddress BreakPinProperty_Label_PropertyAddress;

	private static int BreakPinProperty_Label_Offset;

	private static bool BreakPinProperty_bAllowMultipleData_IsValid;

	private static FFieldAddress BreakPinProperty_bAllowMultipleData_PropertyAddress;

	private static int BreakPinProperty_bAllowMultipleData_Offset;

	private static bool BreakPinProperty_bAllowMultipleConnections_IsValid;

	private static FFieldAddress BreakPinProperty_bAllowMultipleConnections_PropertyAddress;

	private static int BreakPinProperty_bAllowMultipleConnections_Offset;

	private static bool BreakPinProperty_bAdvancedPin_IsValid;

	private static FFieldAddress BreakPinProperty_bAdvancedPin_PropertyAddress;

	private static int BreakPinProperty_bAdvancedPin_Offset;

	private static bool BreakPinProperty_AllowedType_IsValid;

	private static FFieldAddress BreakPinProperty_AllowedType_PropertyAddress;

	private static int BreakPinProperty_AllowedType_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/PCG.PCGBlueprintPinHelpers:MakePinProperty")]
	public unsafe static FPCGPinProperties MakePinProperty(FName Label, bool bAllowMultipleData, bool bAllowMultipleConnections, bool bAdvancedPin, EPCGExclusiveDataType AllowedType = EPCGExclusiveDataType.Any)
	{
		if (!MakePinProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintPinHelpers:MakePinProperty");
			return default(FPCGPinProperties);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakePinProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakePinProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MakePinProperty_Label_Offset), 0, MakePinProperty_Label_PropertyAddress.Address, Label);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakePinProperty_bAllowMultipleData_Offset), 0, MakePinProperty_bAllowMultipleData_PropertyAddress.Address, bAllowMultipleData);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakePinProperty_bAllowMultipleConnections_Offset), 0, MakePinProperty_bAllowMultipleConnections_PropertyAddress.Address, bAllowMultipleConnections);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakePinProperty_bAdvancedPin_Offset), 0, MakePinProperty_bAdvancedPin_PropertyAddress.Address, bAdvancedPin);
		EnumMarshaler<EPCGExclusiveDataType>.ToNative(IntPtr.Add(intPtr, MakePinProperty_AllowedType_Offset), 0, MakePinProperty_AllowedType_PropertyAddress.Address, AllowedType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakePinProperty_FunctionAddress, intPtr, MakePinProperty_ParamsSize);
		FPCGPinProperties result = FPCGPinProperties.FromNative(IntPtr.Add(intPtr, MakePinProperty_ReturnValue_Offset), 0, MakePinProperty_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakePinProperty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/PCG.PCGBlueprintPinHelpers:BreakPinProperty")]
	public unsafe static void BreakPinProperty(FPCGPinProperties PinProperty, out FName Label, out bool bAllowMultipleData, out bool bAllowMultipleConnections, out bool bAdvancedPin, out EPCGExclusiveDataType AllowedType)
	{
		if (!BreakPinProperty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintPinHelpers:BreakPinProperty");
			Label = default(FName);
			bAllowMultipleData = false;
			bAllowMultipleConnections = false;
			bAdvancedPin = false;
			AllowedType = EPCGExclusiveDataType.None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakPinProperty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakPinProperty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakPinProperty_PinProperty_PropertyAddress.Address, intPtr);
		FPCGPinProperties.ToNative(IntPtr.Add(intPtr, BreakPinProperty_PinProperty_Offset), 0, BreakPinProperty_PinProperty_PropertyAddress.Address, PinProperty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakPinProperty_FunctionAddress, intPtr, BreakPinProperty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BreakPinProperty_PinProperty_PropertyAddress.Address, intPtr);
		Label = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, BreakPinProperty_Label_Offset), 0, BreakPinProperty_Label_PropertyAddress.Address);
		bAllowMultipleData = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakPinProperty_bAllowMultipleData_Offset), 0, BreakPinProperty_bAllowMultipleData_PropertyAddress.Address);
		bAllowMultipleConnections = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakPinProperty_bAllowMultipleConnections_Offset), 0, BreakPinProperty_bAllowMultipleConnections_PropertyAddress.Address);
		bAdvancedPin = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakPinProperty_bAdvancedPin_Offset), 0, BreakPinProperty_bAdvancedPin_PropertyAddress.Address);
		AllowedType = EnumMarshaler<EPCGExclusiveDataType>.FromNative(IntPtr.Add(intPtr, BreakPinProperty_AllowedType_Offset), 0, BreakPinProperty_AllowedType_PropertyAddress.Address);
	}

	static UPCGBlueprintPinHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBlueprintPinHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBlueprintPinHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/PCG.PCGBlueprintPinHelpers");
		MakePinProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakePinProperty");
		MakePinProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(MakePinProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakePinProperty_Label_PropertyAddress, MakePinProperty_FunctionAddress, "Label");
		MakePinProperty_Label_Offset = NativeReflectionCached.GetPropertyOffset(MakePinProperty_FunctionAddress, "Label");
		MakePinProperty_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePinProperty_FunctionAddress, "Label", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePinProperty_bAllowMultipleData_PropertyAddress, MakePinProperty_FunctionAddress, "bAllowMultipleData");
		MakePinProperty_bAllowMultipleData_Offset = NativeReflectionCached.GetPropertyOffset(MakePinProperty_FunctionAddress, "bAllowMultipleData");
		MakePinProperty_bAllowMultipleData_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePinProperty_FunctionAddress, "bAllowMultipleData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePinProperty_bAllowMultipleConnections_PropertyAddress, MakePinProperty_FunctionAddress, "bAllowMultipleConnections");
		MakePinProperty_bAllowMultipleConnections_Offset = NativeReflectionCached.GetPropertyOffset(MakePinProperty_FunctionAddress, "bAllowMultipleConnections");
		MakePinProperty_bAllowMultipleConnections_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePinProperty_FunctionAddress, "bAllowMultipleConnections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePinProperty_bAdvancedPin_PropertyAddress, MakePinProperty_FunctionAddress, "bAdvancedPin");
		MakePinProperty_bAdvancedPin_Offset = NativeReflectionCached.GetPropertyOffset(MakePinProperty_FunctionAddress, "bAdvancedPin");
		MakePinProperty_bAdvancedPin_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePinProperty_FunctionAddress, "bAdvancedPin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePinProperty_AllowedType_PropertyAddress, MakePinProperty_FunctionAddress, "AllowedType");
		MakePinProperty_AllowedType_Offset = NativeReflectionCached.GetPropertyOffset(MakePinProperty_FunctionAddress, "AllowedType");
		MakePinProperty_AllowedType_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePinProperty_FunctionAddress, "AllowedType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePinProperty_ReturnValue_PropertyAddress, MakePinProperty_FunctionAddress, "ReturnValue");
		MakePinProperty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakePinProperty_FunctionAddress, "ReturnValue");
		MakePinProperty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePinProperty_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakePinProperty_IsValid = MakePinProperty_FunctionAddress != IntPtr.Zero && MakePinProperty_Label_IsValid && MakePinProperty_bAllowMultipleData_IsValid && MakePinProperty_bAllowMultipleConnections_IsValid && MakePinProperty_bAdvancedPin_IsValid && MakePinProperty_AllowedType_IsValid && MakePinProperty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintPinHelpers:MakePinProperty", MakePinProperty_IsValid);
		BreakPinProperty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakPinProperty");
		BreakPinProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakPinProperty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakPinProperty_PinProperty_PropertyAddress, BreakPinProperty_FunctionAddress, "PinProperty");
		BreakPinProperty_PinProperty_Offset = NativeReflectionCached.GetPropertyOffset(BreakPinProperty_FunctionAddress, "PinProperty");
		BreakPinProperty_PinProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPinProperty_FunctionAddress, "PinProperty", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakPinProperty_Label_PropertyAddress, BreakPinProperty_FunctionAddress, "Label");
		BreakPinProperty_Label_Offset = NativeReflectionCached.GetPropertyOffset(BreakPinProperty_FunctionAddress, "Label");
		BreakPinProperty_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPinProperty_FunctionAddress, "Label", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakPinProperty_bAllowMultipleData_PropertyAddress, BreakPinProperty_FunctionAddress, "bAllowMultipleData");
		BreakPinProperty_bAllowMultipleData_Offset = NativeReflectionCached.GetPropertyOffset(BreakPinProperty_FunctionAddress, "bAllowMultipleData");
		BreakPinProperty_bAllowMultipleData_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPinProperty_FunctionAddress, "bAllowMultipleData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakPinProperty_bAllowMultipleConnections_PropertyAddress, BreakPinProperty_FunctionAddress, "bAllowMultipleConnections");
		BreakPinProperty_bAllowMultipleConnections_Offset = NativeReflectionCached.GetPropertyOffset(BreakPinProperty_FunctionAddress, "bAllowMultipleConnections");
		BreakPinProperty_bAllowMultipleConnections_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPinProperty_FunctionAddress, "bAllowMultipleConnections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakPinProperty_bAdvancedPin_PropertyAddress, BreakPinProperty_FunctionAddress, "bAdvancedPin");
		BreakPinProperty_bAdvancedPin_Offset = NativeReflectionCached.GetPropertyOffset(BreakPinProperty_FunctionAddress, "bAdvancedPin");
		BreakPinProperty_bAdvancedPin_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPinProperty_FunctionAddress, "bAdvancedPin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakPinProperty_AllowedType_PropertyAddress, BreakPinProperty_FunctionAddress, "AllowedType");
		BreakPinProperty_AllowedType_Offset = NativeReflectionCached.GetPropertyOffset(BreakPinProperty_FunctionAddress, "AllowedType");
		BreakPinProperty_AllowedType_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakPinProperty_FunctionAddress, "AllowedType", Classes.FEnumProperty);
		BreakPinProperty_IsValid = BreakPinProperty_FunctionAddress != IntPtr.Zero && BreakPinProperty_PinProperty_IsValid && BreakPinProperty_Label_IsValid && BreakPinProperty_bAllowMultipleData_IsValid && BreakPinProperty_bAllowMultipleConnections_IsValid && BreakPinProperty_bAdvancedPin_IsValid && BreakPinProperty_AllowedType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintPinHelpers:BreakPinProperty", BreakPinProperty_IsValid);
	}
}
