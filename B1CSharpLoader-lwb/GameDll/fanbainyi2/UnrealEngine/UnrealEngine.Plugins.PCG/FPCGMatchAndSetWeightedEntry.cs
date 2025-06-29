using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedEntry", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGMatchAndSetWeightedEntry
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedEntry:Value")]
	public FPCGMetadataTypesConstantStruct Value;

	private static bool Weight_IsValid;

	private static int Weight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGMatchAndSetWeightedEntry:Weight")]
	public int Weight;

	private static bool FPCGMatchAndSetWeightedEntry_IsValid;

	private static int FPCGMatchAndSetWeightedEntry_StructSize;

	public FPCGMatchAndSetWeightedEntry Copy()
	{
		return this;
	}

	public static FPCGMatchAndSetWeightedEntry FromNative(IntPtr nativeBuffer)
	{
		return new FPCGMatchAndSetWeightedEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGMatchAndSetWeightedEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGMatchAndSetWeightedEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGMatchAndSetWeightedEntry(nativeBuffer + arrayIndex * FPCGMatchAndSetWeightedEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGMatchAndSetWeightedEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGMatchAndSetWeightedEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGMatchAndSetWeightedEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMatchAndSetWeightedEntry");
			return;
		}
		FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Weight_Offset), Weight);
	}

	public FPCGMatchAndSetWeightedEntry(IntPtr nativeStruct)
	{
		if (!FPCGMatchAndSetWeightedEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMatchAndSetWeightedEntry");
			Value = default(FPCGMetadataTypesConstantStruct);
			Weight = 0;
		}
		else
		{
			Value = FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Weight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Weight_Offset));
		}
	}

	static FPCGMatchAndSetWeightedEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGMatchAndSetWeightedEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGMatchAndSetWeightedEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGMatchAndSetWeightedEntry");
		FPCGMatchAndSetWeightedEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FStructProperty);
		Weight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weight");
		Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weight", Classes.FIntProperty);
		FPCGMatchAndSetWeightedEntry_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Weight_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGMatchAndSetWeightedEntry", FPCGMatchAndSetWeightedEntry_IsValid);
	}
}
