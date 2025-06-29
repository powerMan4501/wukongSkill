using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectIndividualFilterSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectIndividualFilterSettings
{
	private static bool FilterCircuit_IsValid;

	private static FFieldAddress FilterCircuit_PropertyAddress;

	private static int FilterCircuit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectIndividualFilterSettings:FilterCircuit")]
	public ESourceEffectMotionFilterCircuit FilterCircuit;

	private static bool FilterType_IsValid;

	private static FFieldAddress FilterType_PropertyAddress;

	private static int FilterType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectIndividualFilterSettings:FilterType")]
	public ESourceEffectMotionFilterType FilterType;

	private static bool CutoffFrequency_IsValid;

	private static int CutoffFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectIndividualFilterSettings:CutoffFrequency")]
	public float CutoffFrequency;

	private static bool FilterQ_IsValid;

	private static int FilterQ_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectIndividualFilterSettings:FilterQ")]
	public float FilterQ;

	private static bool FSourceEffectIndividualFilterSettings_IsValid;

	private static int FSourceEffectIndividualFilterSettings_StructSize;

	public FSourceEffectIndividualFilterSettings Copy()
	{
		return this;
	}

	public static FSourceEffectIndividualFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectIndividualFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectIndividualFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectIndividualFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectIndividualFilterSettings(nativeBuffer + arrayIndex * FSourceEffectIndividualFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectIndividualFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectIndividualFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectIndividualFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectIndividualFilterSettings");
			return;
		}
		EnumMarshaler<ESourceEffectMotionFilterCircuit>.ToNative(IntPtr.Add(nativeStruct, FilterCircuit_Offset), 0, FilterCircuit_PropertyAddress.Address, FilterCircuit);
		EnumMarshaler<ESourceEffectMotionFilterType>.ToNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address, FilterType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CutoffFrequency_Offset), CutoffFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterQ_Offset), FilterQ);
	}

	public FSourceEffectIndividualFilterSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectIndividualFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectIndividualFilterSettings");
			FilterCircuit = ESourceEffectMotionFilterCircuit.OnePole;
			FilterType = ESourceEffectMotionFilterType.LowPass;
			CutoffFrequency = 0f;
			FilterQ = 0f;
		}
		else
		{
			FilterCircuit = EnumMarshaler<ESourceEffectMotionFilterCircuit>.FromNative(IntPtr.Add(nativeStruct, FilterCircuit_Offset), 0, FilterCircuit_PropertyAddress.Address);
			FilterType = EnumMarshaler<ESourceEffectMotionFilterType>.FromNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
			CutoffFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CutoffFrequency_Offset));
			FilterQ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterQ_Offset));
		}
	}

	static FSourceEffectIndividualFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectIndividualFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectIndividualFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectIndividualFilterSettings");
		FSourceEffectIndividualFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterCircuit_PropertyAddress, intPtr, "FilterCircuit");
		FilterCircuit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterCircuit");
		FilterCircuit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterCircuit", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterType", Classes.FEnumProperty);
		CutoffFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CutoffFrequency");
		CutoffFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CutoffFrequency", Classes.FFloatProperty);
		FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterQ");
		FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterQ", Classes.FFloatProperty);
		FSourceEffectIndividualFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterCircuit_IsValid && FilterType_IsValid && CutoffFrequency_IsValid && FilterQ_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectIndividualFilterSettings", FSourceEffectIndividualFilterSettings_IsValid);
	}
}
