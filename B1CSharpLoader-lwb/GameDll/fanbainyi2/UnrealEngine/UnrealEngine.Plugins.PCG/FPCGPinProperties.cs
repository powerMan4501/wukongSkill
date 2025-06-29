using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPinProperties", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGPinProperties
{
	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPinProperties:Label")]
	public FName Label;

	private static bool AllowedTypes_IsValid;

	private static FFieldAddress AllowedTypes_PropertyAddress;

	private static int AllowedTypes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPinProperties:AllowedTypes")]
	public EPCGDataType AllowedTypes;

	private static bool AllowMultipleData_IsValid;

	private static FFieldAddress AllowMultipleData_PropertyAddress;

	private static int AllowMultipleData_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPinProperties:bAllowMultipleData")]
	public bool AllowMultipleData;

	private static bool AllowMultipleConnections_IsValid;

	private static FFieldAddress AllowMultipleConnections_PropertyAddress;

	private static int AllowMultipleConnections_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPinProperties:bAllowMultipleConnections")]
	public bool AllowMultipleConnections;

	private static bool AdvancedPin_IsValid;

	private static FFieldAddress AdvancedPin_PropertyAddress;

	private static int AdvancedPin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPinProperties:bAdvancedPin")]
	public bool AdvancedPin;

	private static bool FPCGPinProperties_IsValid;

	private static int FPCGPinProperties_StructSize;

	public FPCGPinProperties Copy()
	{
		return this;
	}

	public static FPCGPinProperties FromNative(IntPtr nativeBuffer)
	{
		return new FPCGPinProperties(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGPinProperties value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGPinProperties FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGPinProperties(nativeBuffer + arrayIndex * FPCGPinProperties_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGPinProperties value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGPinProperties_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGPinProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPinProperties");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Label_Offset), Label);
		EnumMarshaler<EPCGDataType>.ToNative(IntPtr.Add(nativeStruct, AllowedTypes_Offset), 0, AllowedTypes_PropertyAddress.Address, AllowedTypes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowMultipleData_Offset), 0, AllowMultipleData_PropertyAddress.Address, AllowMultipleData);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowMultipleConnections_Offset), 0, AllowMultipleConnections_PropertyAddress.Address, AllowMultipleConnections);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AdvancedPin_Offset), 0, AdvancedPin_PropertyAddress.Address, AdvancedPin);
	}

	public FPCGPinProperties(IntPtr nativeStruct)
	{
		if (!FPCGPinProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPinProperties");
			Label = default(FName);
			AllowedTypes = EPCGDataType.None;
			AllowMultipleData = false;
			AllowMultipleConnections = false;
			AdvancedPin = false;
		}
		else
		{
			Label = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Label_Offset));
			AllowedTypes = EnumMarshaler<EPCGDataType>.FromNative(IntPtr.Add(nativeStruct, AllowedTypes_Offset), 0, AllowedTypes_PropertyAddress.Address);
			AllowMultipleData = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowMultipleData_Offset), 0, AllowMultipleData_PropertyAddress.Address);
			AllowMultipleConnections = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowMultipleConnections_Offset), 0, AllowMultipleConnections_PropertyAddress.Address);
			AdvancedPin = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AdvancedPin_Offset), 0, AdvancedPin_PropertyAddress.Address);
		}
	}

	static FPCGPinProperties()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGPinProperties)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGPinProperties));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGPinProperties");
		FPCGPinProperties_StructSize = NativeReflection.GetStructSize(intPtr);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Label", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowedTypes_PropertyAddress, intPtr, "AllowedTypes");
		AllowedTypes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AllowedTypes");
		AllowedTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AllowedTypes", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowMultipleData_PropertyAddress, intPtr, "bAllowMultipleData");
		AllowMultipleData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowMultipleData");
		AllowMultipleData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowMultipleData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowMultipleConnections_PropertyAddress, intPtr, "bAllowMultipleConnections");
		AllowMultipleConnections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowMultipleConnections");
		AllowMultipleConnections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowMultipleConnections", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvancedPin_PropertyAddress, intPtr, "bAdvancedPin");
		AdvancedPin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAdvancedPin");
		AdvancedPin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAdvancedPin", Classes.FBoolProperty);
		FPCGPinProperties_IsValid = intPtr != IntPtr.Zero && Label_IsValid && AllowedTypes_IsValid && AllowMultipleData_IsValid && AllowMultipleConnections_IsValid && AdvancedPin_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGPinProperties", FPCGPinProperties_IsValid);
	}
}
