using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.DynamicsBandSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FDynamicsBandSettings
{
	private static bool CrossoverTopFrequency_IsValid;

	private static int CrossoverTopFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:CrossoverTopFrequency")]
	public float CrossoverTopFrequency;

	private static bool AttackTimeMsec_IsValid;

	private static int AttackTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:AttackTimeMsec")]
	public float AttackTimeMsec;

	private static bool ReleaseTimeMsec_IsValid;

	private static int ReleaseTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:ReleaseTimeMsec")]
	public float ReleaseTimeMsec;

	private static bool ThresholdDb_IsValid;

	private static int ThresholdDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:ThresholdDb")]
	public float ThresholdDb;

	private static bool Ratio_IsValid;

	private static int Ratio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:Ratio")]
	public float Ratio;

	private static bool KneeBandwidthDb_IsValid;

	private static int KneeBandwidthDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:KneeBandwidthDb")]
	public float KneeBandwidthDb;

	private static bool InputGainDb_IsValid;

	private static int InputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:InputGainDb")]
	public float InputGainDb;

	private static bool OutputGainDb_IsValid;

	private static int OutputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.DynamicsBandSettings:OutputGainDb")]
	public float OutputGainDb;

	private static bool FDynamicsBandSettings_IsValid;

	private static int FDynamicsBandSettings_StructSize;

	public FDynamicsBandSettings Copy()
	{
		return this;
	}

	public static FDynamicsBandSettings FromNative(IntPtr nativeBuffer)
	{
		return new FDynamicsBandSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDynamicsBandSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDynamicsBandSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDynamicsBandSettings(nativeBuffer + arrayIndex * FDynamicsBandSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDynamicsBandSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDynamicsBandSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDynamicsBandSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.DynamicsBandSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CrossoverTopFrequency_Offset), CrossoverTopFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset), AttackTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset), ReleaseTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset), ThresholdDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Ratio_Offset), Ratio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KneeBandwidthDb_Offset), KneeBandwidthDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InputGainDb_Offset), InputGainDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset), OutputGainDb);
	}

	public FDynamicsBandSettings(IntPtr nativeStruct)
	{
		if (!FDynamicsBandSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.DynamicsBandSettings");
			CrossoverTopFrequency = 0f;
			AttackTimeMsec = 0f;
			ReleaseTimeMsec = 0f;
			ThresholdDb = 0f;
			Ratio = 0f;
			KneeBandwidthDb = 0f;
			InputGainDb = 0f;
			OutputGainDb = 0f;
		}
		else
		{
			CrossoverTopFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CrossoverTopFrequency_Offset));
			AttackTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset));
			ReleaseTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset));
			ThresholdDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset));
			Ratio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Ratio_Offset));
			KneeBandwidthDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KneeBandwidthDb_Offset));
			InputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InputGainDb_Offset));
			OutputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset));
		}
	}

	static FDynamicsBandSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDynamicsBandSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDynamicsBandSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.DynamicsBandSettings");
		FDynamicsBandSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		CrossoverTopFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CrossoverTopFrequency");
		CrossoverTopFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CrossoverTopFrequency", Classes.FFloatProperty);
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
		FDynamicsBandSettings_IsValid = intPtr != IntPtr.Zero && CrossoverTopFrequency_IsValid && AttackTimeMsec_IsValid && ReleaseTimeMsec_IsValid && ThresholdDb_IsValid && Ratio_IsValid && KneeBandwidthDb_IsValid && InputGainDb_IsValid && OutputGainDb_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.DynamicsBandSettings", FDynamicsBandSettings_IsValid);
	}
}
