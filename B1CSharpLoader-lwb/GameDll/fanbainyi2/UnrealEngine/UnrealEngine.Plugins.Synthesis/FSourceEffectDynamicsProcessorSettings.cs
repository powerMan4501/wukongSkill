using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectDynamicsProcessorSettings
{
	private static bool DynamicsProcessorType_IsValid;

	private static FFieldAddress DynamicsProcessorType_PropertyAddress;

	private static int DynamicsProcessorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:DynamicsProcessorType")]
	public ESourceEffectDynamicsProcessorType DynamicsProcessorType;

	private static bool PeakMode_IsValid;

	private static FFieldAddress PeakMode_PropertyAddress;

	private static int PeakMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:PeakMode")]
	public ESourceEffectDynamicsPeakMode PeakMode;

	private static bool LookAheadMsec_IsValid;

	private static int LookAheadMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:LookAheadMsec")]
	public float LookAheadMsec;

	private static bool AttackTimeMsec_IsValid;

	private static int AttackTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:AttackTimeMsec")]
	public float AttackTimeMsec;

	private static bool ReleaseTimeMsec_IsValid;

	private static int ReleaseTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:ReleaseTimeMsec")]
	public float ReleaseTimeMsec;

	private static bool ThresholdDb_IsValid;

	private static int ThresholdDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:ThresholdDb")]
	public float ThresholdDb;

	private static bool Ratio_IsValid;

	private static int Ratio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:Ratio")]
	public float Ratio;

	private static bool KneeBandwidthDb_IsValid;

	private static int KneeBandwidthDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:KneeBandwidthDb")]
	public float KneeBandwidthDb;

	private static bool InputGainDb_IsValid;

	private static int InputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:InputGainDb")]
	public float InputGainDb;

	private static bool OutputGainDb_IsValid;

	private static int OutputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:OutputGainDb")]
	public float OutputGainDb;

	private static bool StereoLinked_IsValid;

	private static FFieldAddress StereoLinked_PropertyAddress;

	private static int StereoLinked_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:bStereoLinked")]
	public bool StereoLinked;

	private static bool AnalogMode_IsValid;

	private static FFieldAddress AnalogMode_PropertyAddress;

	private static int AnalogMode_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectDynamicsProcessorSettings:bAnalogMode")]
	public bool AnalogMode;

	private static bool FSourceEffectDynamicsProcessorSettings_IsValid;

	private static int FSourceEffectDynamicsProcessorSettings_StructSize;

	public FSourceEffectDynamicsProcessorSettings Copy()
	{
		return this;
	}

	public static FSourceEffectDynamicsProcessorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectDynamicsProcessorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectDynamicsProcessorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectDynamicsProcessorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectDynamicsProcessorSettings(nativeBuffer + arrayIndex * FSourceEffectDynamicsProcessorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectDynamicsProcessorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectDynamicsProcessorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectDynamicsProcessorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectDynamicsProcessorSettings");
			return;
		}
		EnumMarshaler<ESourceEffectDynamicsProcessorType>.ToNative(IntPtr.Add(nativeStruct, DynamicsProcessorType_Offset), 0, DynamicsProcessorType_PropertyAddress.Address, DynamicsProcessorType);
		EnumMarshaler<ESourceEffectDynamicsPeakMode>.ToNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address, PeakMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LookAheadMsec_Offset), LookAheadMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset), AttackTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset), ReleaseTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset), ThresholdDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Ratio_Offset), Ratio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KneeBandwidthDb_Offset), KneeBandwidthDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InputGainDb_Offset), InputGainDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset), OutputGainDb);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StereoLinked_Offset), 0, StereoLinked_PropertyAddress.Address, StereoLinked);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AnalogMode_Offset), 0, AnalogMode_PropertyAddress.Address, AnalogMode);
	}

	public FSourceEffectDynamicsProcessorSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectDynamicsProcessorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectDynamicsProcessorSettings");
			DynamicsProcessorType = ESourceEffectDynamicsProcessorType.Compressor;
			PeakMode = ESourceEffectDynamicsPeakMode.MeanSquared;
			LookAheadMsec = 0f;
			AttackTimeMsec = 0f;
			ReleaseTimeMsec = 0f;
			ThresholdDb = 0f;
			Ratio = 0f;
			KneeBandwidthDb = 0f;
			InputGainDb = 0f;
			OutputGainDb = 0f;
			StereoLinked = false;
			AnalogMode = false;
		}
		else
		{
			DynamicsProcessorType = EnumMarshaler<ESourceEffectDynamicsProcessorType>.FromNative(IntPtr.Add(nativeStruct, DynamicsProcessorType_Offset), 0, DynamicsProcessorType_PropertyAddress.Address);
			PeakMode = EnumMarshaler<ESourceEffectDynamicsPeakMode>.FromNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address);
			LookAheadMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LookAheadMsec_Offset));
			AttackTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset));
			ReleaseTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset));
			ThresholdDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset));
			Ratio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Ratio_Offset));
			KneeBandwidthDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KneeBandwidthDb_Offset));
			InputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InputGainDb_Offset));
			OutputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset));
			StereoLinked = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StereoLinked_Offset), 0, StereoLinked_PropertyAddress.Address);
			AnalogMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AnalogMode_Offset), 0, AnalogMode_PropertyAddress.Address);
		}
	}

	static FSourceEffectDynamicsProcessorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectDynamicsProcessorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectDynamicsProcessorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectDynamicsProcessorSettings");
		FSourceEffectDynamicsProcessorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DynamicsProcessorType_PropertyAddress, intPtr, "DynamicsProcessorType");
		DynamicsProcessorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicsProcessorType");
		DynamicsProcessorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicsProcessorType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PeakMode_PropertyAddress, intPtr, "PeakMode");
		PeakMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PeakMode");
		PeakMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PeakMode", Classes.FEnumProperty);
		LookAheadMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LookAheadMsec");
		LookAheadMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LookAheadMsec", Classes.FFloatProperty);
		AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttackTimeMsec");
		AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttackTimeMsec", Classes.FFloatProperty);
		ReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReleaseTimeMsec");
		ReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReleaseTimeMsec", Classes.FFloatProperty);
		ThresholdDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdDb");
		ThresholdDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdDb", Classes.FFloatProperty);
		Ratio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Ratio");
		Ratio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Ratio", Classes.FFloatProperty);
		KneeBandwidthDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KneeBandwidthDb");
		KneeBandwidthDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KneeBandwidthDb", Classes.FFloatProperty);
		InputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputGainDb");
		InputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputGainDb", Classes.FFloatProperty);
		OutputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputGainDb");
		OutputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputGainDb", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StereoLinked_PropertyAddress, intPtr, "bStereoLinked");
		StereoLinked_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStereoLinked");
		StereoLinked_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStereoLinked", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AnalogMode_PropertyAddress, intPtr, "bAnalogMode");
		AnalogMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnalogMode");
		AnalogMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnalogMode", Classes.FBoolProperty);
		FSourceEffectDynamicsProcessorSettings_IsValid = intPtr != IntPtr.Zero && DynamicsProcessorType_IsValid && PeakMode_IsValid && LookAheadMsec_IsValid && AttackTimeMsec_IsValid && ReleaseTimeMsec_IsValid && ThresholdDb_IsValid && Ratio_IsValid && KneeBandwidthDb_IsValid && InputGainDb_IsValid && OutputGainDb_IsValid && StereoLinked_IsValid && AnalogMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectDynamicsProcessorSettings", FSourceEffectDynamicsProcessorSettings_IsValid);
	}
}
