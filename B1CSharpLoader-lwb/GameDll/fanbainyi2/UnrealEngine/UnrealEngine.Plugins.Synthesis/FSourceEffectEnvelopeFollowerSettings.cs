using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectEnvelopeFollowerSettings
{
	private static bool AttackTime_IsValid;

	private static int AttackTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings:AttackTime")]
	public float AttackTime;

	private static bool ReleaseTime_IsValid;

	private static int ReleaseTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings:ReleaseTime")]
	public float ReleaseTime;

	private static bool PeakMode_IsValid;

	private static FFieldAddress PeakMode_PropertyAddress;

	private static int PeakMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings:PeakMode")]
	public EEnvelopeFollowerPeakMode PeakMode;

	private static bool IsAnalogMode_IsValid;

	private static FFieldAddress IsAnalogMode_PropertyAddress;

	private static int IsAnalogMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings:bIsAnalogMode")]
	public bool IsAnalogMode;

	private static bool FSourceEffectEnvelopeFollowerSettings_IsValid;

	private static int FSourceEffectEnvelopeFollowerSettings_StructSize;

	public FSourceEffectEnvelopeFollowerSettings Copy()
	{
		return this;
	}

	public static FSourceEffectEnvelopeFollowerSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectEnvelopeFollowerSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectEnvelopeFollowerSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectEnvelopeFollowerSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectEnvelopeFollowerSettings(nativeBuffer + arrayIndex * FSourceEffectEnvelopeFollowerSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectEnvelopeFollowerSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectEnvelopeFollowerSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectEnvelopeFollowerSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackTime_Offset), AttackTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReleaseTime_Offset), ReleaseTime);
		EnumMarshaler<EEnvelopeFollowerPeakMode>.ToNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address, PeakMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsAnalogMode_Offset), 0, IsAnalogMode_PropertyAddress.Address, IsAnalogMode);
	}

	public FSourceEffectEnvelopeFollowerSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectEnvelopeFollowerSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings");
			AttackTime = 0f;
			ReleaseTime = 0f;
			PeakMode = EEnvelopeFollowerPeakMode.MeanSquared;
			IsAnalogMode = false;
		}
		else
		{
			AttackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackTime_Offset));
			ReleaseTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReleaseTime_Offset));
			PeakMode = EnumMarshaler<EEnvelopeFollowerPeakMode>.FromNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address);
			IsAnalogMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsAnalogMode_Offset), 0, IsAnalogMode_PropertyAddress.Address);
		}
	}

	static FSourceEffectEnvelopeFollowerSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectEnvelopeFollowerSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectEnvelopeFollowerSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings");
		FSourceEffectEnvelopeFollowerSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		AttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttackTime");
		AttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttackTime", Classes.FFloatProperty);
		ReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReleaseTime");
		ReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReleaseTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PeakMode_PropertyAddress, intPtr, "PeakMode");
		PeakMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PeakMode");
		PeakMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PeakMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAnalogMode_PropertyAddress, intPtr, "bIsAnalogMode");
		IsAnalogMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsAnalogMode");
		IsAnalogMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsAnalogMode", Classes.FBoolProperty);
		FSourceEffectEnvelopeFollowerSettings_IsValid = intPtr != IntPtr.Zero && AttackTime_IsValid && ReleaseTime_IsValid && PeakMode_IsValid && IsAnalogMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectEnvelopeFollowerSettings", FSourceEffectEnvelopeFollowerSettings_IsValid);
	}
}
