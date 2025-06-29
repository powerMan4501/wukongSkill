using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPreConfiguredSettingsInfo", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGPreConfiguredSettingsInfo
{
	private static bool PreconfiguredIndex_IsValid;

	private static int PreconfiguredIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPreConfiguredSettingsInfo:PreconfiguredIndex")]
	public int PreconfiguredIndex;

	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPreConfiguredSettingsInfo:Label")]
	public FText Label;

	private static bool FPCGPreConfiguredSettingsInfo_IsValid;

	private static int FPCGPreConfiguredSettingsInfo_StructSize;

	public FPCGPreConfiguredSettingsInfo Copy()
	{
		return this;
	}

	public static FPCGPreConfiguredSettingsInfo FromNative(IntPtr nativeBuffer)
	{
		return new FPCGPreConfiguredSettingsInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGPreConfiguredSettingsInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGPreConfiguredSettingsInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGPreConfiguredSettingsInfo(nativeBuffer + arrayIndex * FPCGPreConfiguredSettingsInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGPreConfiguredSettingsInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGPreConfiguredSettingsInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGPreConfiguredSettingsInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPreConfiguredSettingsInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PreconfiguredIndex_Offset), PreconfiguredIndex);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Label_Offset), Label);
	}

	public FPCGPreConfiguredSettingsInfo(IntPtr nativeStruct)
	{
		if (!FPCGPreConfiguredSettingsInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPreConfiguredSettingsInfo");
			PreconfiguredIndex = 0;
			Label = null;
		}
		else
		{
			PreconfiguredIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PreconfiguredIndex_Offset));
			Label = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Label_Offset));
		}
	}

	static FPCGPreConfiguredSettingsInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGPreConfiguredSettingsInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGPreConfiguredSettingsInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGPreConfiguredSettingsInfo");
		FPCGPreConfiguredSettingsInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		PreconfiguredIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreconfiguredIndex");
		PreconfiguredIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreconfiguredIndex", Classes.FIntProperty);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Label", Classes.FTextProperty);
		FPCGPreConfiguredSettingsInfo_IsValid = intPtr != IntPtr.Zero && PreconfiguredIndex_IsValid && Label_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGPreConfiguredSettingsInfo", FPCGPreConfiguredSettingsInfo_IsValid);
	}
}
