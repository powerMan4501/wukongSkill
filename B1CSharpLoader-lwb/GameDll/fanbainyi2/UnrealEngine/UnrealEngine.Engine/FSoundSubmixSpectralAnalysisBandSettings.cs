using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundSubmixSpectralAnalysisBandSettings
{
	private static bool BandFrequency_IsValid;

	private static int BandFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings:BandFrequency")]
	public float BandFrequency;

	private static bool AttackTimeMsec_IsValid;

	private static int AttackTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings:AttackTimeMsec")]
	public int AttackTimeMsec;

	private static bool ReleaseTimeMsec_IsValid;

	private static int ReleaseTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings:ReleaseTimeMsec")]
	public int ReleaseTimeMsec;

	private static bool QFactor_IsValid;

	private static int QFactor_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings:QFactor")]
	public float QFactor;

	private static bool FSoundSubmixSpectralAnalysisBandSettings_IsValid;

	private static int FSoundSubmixSpectralAnalysisBandSettings_StructSize;

	public FSoundSubmixSpectralAnalysisBandSettings Copy()
	{
		return this;
	}

	public static FSoundSubmixSpectralAnalysisBandSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundSubmixSpectralAnalysisBandSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundSubmixSpectralAnalysisBandSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundSubmixSpectralAnalysisBandSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundSubmixSpectralAnalysisBandSettings(nativeBuffer + arrayIndex * FSoundSubmixSpectralAnalysisBandSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundSubmixSpectralAnalysisBandSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundSubmixSpectralAnalysisBandSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundSubmixSpectralAnalysisBandSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BandFrequency_Offset), BandFrequency);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset), AttackTimeMsec);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset), ReleaseTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, QFactor_Offset), QFactor);
	}

	public FSoundSubmixSpectralAnalysisBandSettings(IntPtr nativeStruct)
	{
		if (!FSoundSubmixSpectralAnalysisBandSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings");
			BandFrequency = 0f;
			AttackTimeMsec = 0;
			ReleaseTimeMsec = 0;
			QFactor = 0f;
		}
		else
		{
			BandFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BandFrequency_Offset));
			AttackTimeMsec = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset));
			ReleaseTimeMsec = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset));
			QFactor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, QFactor_Offset));
		}
	}

	static FSoundSubmixSpectralAnalysisBandSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundSubmixSpectralAnalysisBandSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundSubmixSpectralAnalysisBandSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings");
		FSoundSubmixSpectralAnalysisBandSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		BandFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BandFrequency");
		BandFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BandFrequency", Classes.FFloatProperty);
		AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttackTimeMsec");
		AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttackTimeMsec", Classes.FIntProperty);
		ReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReleaseTimeMsec");
		ReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReleaseTimeMsec", Classes.FIntProperty);
		QFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QFactor");
		QFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QFactor", Classes.FFloatProperty);
		FSoundSubmixSpectralAnalysisBandSettings_IsValid = intPtr != IntPtr.Zero && BandFrequency_IsValid && AttackTimeMsec_IsValid && ReleaseTimeMsec_IsValid && QFactor_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundSubmixSpectralAnalysisBandSettings", FSoundSubmixSpectralAnalysisBandSettings_IsValid);
	}
}
