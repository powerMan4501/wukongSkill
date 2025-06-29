using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectFilterSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectFilterSettings
{
	private static bool FilterType_IsValid;

	private static FFieldAddress FilterType_PropertyAddress;

	private static int FilterType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterSettings:FilterType")]
	public ESubmixFilterType FilterType;

	private static bool FilterAlgorithm_IsValid;

	private static FFieldAddress FilterAlgorithm_PropertyAddress;

	private static int FilterAlgorithm_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterSettings:FilterAlgorithm")]
	public ESubmixFilterAlgorithm FilterAlgorithm;

	private static bool FilterFrequency_IsValid;

	private static int FilterFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterSettings:FilterFrequency")]
	public float FilterFrequency;

	private static bool FilterQ_IsValid;

	private static int FilterQ_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectFilterSettings:FilterQ")]
	public float FilterQ;

	private static bool FSubmixEffectFilterSettings_IsValid;

	private static int FSubmixEffectFilterSettings_StructSize;

	public FSubmixEffectFilterSettings Copy()
	{
		return this;
	}

	public static FSubmixEffectFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectFilterSettings(nativeBuffer + arrayIndex * FSubmixEffectFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectFilterSettings");
			return;
		}
		EnumMarshaler<ESubmixFilterType>.ToNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address, FilterType);
		EnumMarshaler<ESubmixFilterAlgorithm>.ToNative(IntPtr.Add(nativeStruct, FilterAlgorithm_Offset), 0, FilterAlgorithm_PropertyAddress.Address, FilterAlgorithm);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterFrequency_Offset), FilterFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterQ_Offset), FilterQ);
	}

	public FSubmixEffectFilterSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectFilterSettings");
			FilterType = ESubmixFilterType.LowPass;
			FilterAlgorithm = ESubmixFilterAlgorithm.OnePole;
			FilterFrequency = 0f;
			FilterQ = 0f;
		}
		else
		{
			FilterType = EnumMarshaler<ESubmixFilterType>.FromNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
			FilterAlgorithm = EnumMarshaler<ESubmixFilterAlgorithm>.FromNative(IntPtr.Add(nativeStruct, FilterAlgorithm_Offset), 0, FilterAlgorithm_PropertyAddress.Address);
			FilterFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterFrequency_Offset));
			FilterQ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterQ_Offset));
		}
	}

	static FSubmixEffectFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectFilterSettings");
		FSubmixEffectFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterAlgorithm_PropertyAddress, intPtr, "FilterAlgorithm");
		FilterAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterAlgorithm");
		FilterAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterAlgorithm", Classes.FEnumProperty);
		FilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterFrequency");
		FilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterFrequency", Classes.FFloatProperty);
		FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterQ");
		FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterQ", Classes.FFloatProperty);
		FSubmixEffectFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterType_IsValid && FilterAlgorithm_IsValid && FilterFrequency_IsValid && FilterQ_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectFilterSettings", FSubmixEffectFilterSettings_IsValid);
	}
}
