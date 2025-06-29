using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMatchAndSetByAttributeEntry", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGMatchAndSetByAttributeEntry
{
	private static bool ValueToMatch_IsValid;

	private static int ValueToMatch_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetByAttributeEntry:ValueToMatch")]
	public FPCGMetadataTypesConstantStruct ValueToMatch;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetByAttributeEntry:Value")]
	public FPCGMetadataTypesConstantStruct Value;

	private static bool FPCGMatchAndSetByAttributeEntry_IsValid;

	private static int FPCGMatchAndSetByAttributeEntry_StructSize;

	public FPCGMatchAndSetByAttributeEntry Copy()
	{
		return this;
	}

	public static FPCGMatchAndSetByAttributeEntry FromNative(IntPtr nativeBuffer)
	{
		return new FPCGMatchAndSetByAttributeEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGMatchAndSetByAttributeEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGMatchAndSetByAttributeEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGMatchAndSetByAttributeEntry(nativeBuffer + arrayIndex * FPCGMatchAndSetByAttributeEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGMatchAndSetByAttributeEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGMatchAndSetByAttributeEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGMatchAndSetByAttributeEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMatchAndSetByAttributeEntry");
			return;
		}
		FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(nativeStruct, ValueToMatch_Offset), ValueToMatch);
		FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FPCGMatchAndSetByAttributeEntry(IntPtr nativeStruct)
	{
		if (!FPCGMatchAndSetByAttributeEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMatchAndSetByAttributeEntry");
			ValueToMatch = default(FPCGMetadataTypesConstantStruct);
			Value = default(FPCGMetadataTypesConstantStruct);
		}
		else
		{
			ValueToMatch = FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(nativeStruct, ValueToMatch_Offset));
			Value = FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FPCGMatchAndSetByAttributeEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGMatchAndSetByAttributeEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGMatchAndSetByAttributeEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGMatchAndSetByAttributeEntry");
		FPCGMatchAndSetByAttributeEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		ValueToMatch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValueToMatch");
		ValueToMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValueToMatch", Classes.FStructProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		FPCGMatchAndSetByAttributeEntry_IsValid = intPtr != IntPtr.Zero && ValueToMatch_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGMatchAndSetByAttributeEntry", FPCGMatchAndSetByAttributeEntry_IsValid);
	}
}
