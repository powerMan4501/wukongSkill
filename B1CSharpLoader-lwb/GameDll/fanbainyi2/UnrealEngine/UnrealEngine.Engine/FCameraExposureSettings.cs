using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.CameraExposureSettings", "Engine", UnrealModuleType.Engine)]
public struct FCameraExposureSettings
{
	private static bool Method_IsValid;

	private static FFieldAddress Method_PropertyAddress;

	private static int Method_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:Method")]
	public EAutoExposureMethod Method;

	private static bool LowPercent_IsValid;

	private static int LowPercent_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:LowPercent")]
	public float LowPercent;

	private static bool HighPercent_IsValid;

	private static int HighPercent_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:HighPercent")]
	public float HighPercent;

	private static bool MinBrightness_IsValid;

	private static int MinBrightness_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:MinBrightness")]
	public float MinBrightness;

	private static bool MaxBrightness_IsValid;

	private static int MaxBrightness_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:MaxBrightness")]
	public float MaxBrightness;

	private static bool SpeedUp_IsValid;

	private static int SpeedUp_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:SpeedUp")]
	public float SpeedUp;

	private static bool SpeedDown_IsValid;

	private static int SpeedDown_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:SpeedDown")]
	public float SpeedDown;

	private static bool Bias_IsValid;

	private static int Bias_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:Bias")]
	public float Bias;

	private static bool BiasCurve_IsValid;

	private static int BiasCurve_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:BiasCurve")]
	public UCurveFloat BiasCurve;

	private static bool SceneEV100_IsValid;

	private static int SceneEV100_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:SceneEV100")]
	public float SceneEV100;

	private static bool MeterMask_IsValid;

	private static int MeterMask_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:MeterMask")]
	public UTexture MeterMask;

	private static bool HistogramLogMin_IsValid;

	private static int HistogramLogMin_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:HistogramLogMin")]
	public float HistogramLogMin;

	private static bool HistogramLogMax_IsValid;

	private static int HistogramLogMax_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:HistogramLogMax")]
	public float HistogramLogMax;

	private static bool CalibrationConstant_IsValid;

	private static int CalibrationConstant_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:CalibrationConstant")]
	public float CalibrationConstant;

	private static bool ApplyPhysicalCameraExposure_IsValid;

	private static FFieldAddress ApplyPhysicalCameraExposure_PropertyAddress;

	private static int ApplyPhysicalCameraExposure_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CameraExposureSettings:ApplyPhysicalCameraExposure")]
	public bool ApplyPhysicalCameraExposure;

	private static bool FCameraExposureSettings_IsValid;

	private static int FCameraExposureSettings_StructSize;

	public FCameraExposureSettings Copy()
	{
		return this;
	}

	public static FCameraExposureSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCameraExposureSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraExposureSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraExposureSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraExposureSettings(nativeBuffer + arrayIndex * FCameraExposureSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraExposureSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraExposureSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraExposureSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraExposureSettings");
			return;
		}
		EnumMarshaler<EAutoExposureMethod>.ToNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address, Method);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LowPercent_Offset), LowPercent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HighPercent_Offset), HighPercent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinBrightness_Offset), MinBrightness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxBrightness_Offset), MaxBrightness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpeedUp_Offset), SpeedUp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpeedDown_Offset), SpeedDown);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Bias_Offset), Bias);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, BiasCurve_Offset), BiasCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SceneEV100_Offset), SceneEV100);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(nativeStruct, MeterMask_Offset), MeterMask);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HistogramLogMin_Offset), HistogramLogMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HistogramLogMax_Offset), HistogramLogMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CalibrationConstant_Offset), CalibrationConstant);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyPhysicalCameraExposure_Offset), 0, ApplyPhysicalCameraExposure_PropertyAddress.Address, ApplyPhysicalCameraExposure);
	}

	public FCameraExposureSettings(IntPtr nativeStruct)
	{
		if (!FCameraExposureSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CameraExposureSettings");
			Method = EAutoExposureMethod.AEM_Histogram;
			LowPercent = 0f;
			HighPercent = 0f;
			MinBrightness = 0f;
			MaxBrightness = 0f;
			SpeedUp = 0f;
			SpeedDown = 0f;
			Bias = 0f;
			BiasCurve = null;
			SceneEV100 = 0f;
			MeterMask = null;
			HistogramLogMin = 0f;
			HistogramLogMax = 0f;
			CalibrationConstant = 0f;
			ApplyPhysicalCameraExposure = false;
		}
		else
		{
			Method = EnumMarshaler<EAutoExposureMethod>.FromNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address);
			LowPercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LowPercent_Offset));
			HighPercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HighPercent_Offset));
			MinBrightness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinBrightness_Offset));
			MaxBrightness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxBrightness_Offset));
			SpeedUp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpeedUp_Offset));
			SpeedDown = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpeedDown_Offset));
			Bias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Bias_Offset));
			BiasCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, BiasCurve_Offset));
			SceneEV100 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SceneEV100_Offset));
			MeterMask = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(nativeStruct, MeterMask_Offset));
			HistogramLogMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HistogramLogMin_Offset));
			HistogramLogMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HistogramLogMax_Offset));
			CalibrationConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CalibrationConstant_Offset));
			ApplyPhysicalCameraExposure = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyPhysicalCameraExposure_Offset), 0, ApplyPhysicalCameraExposure_PropertyAddress.Address);
		}
	}

	static FCameraExposureSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraExposureSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraExposureSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CameraExposureSettings");
		FCameraExposureSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Method_PropertyAddress, intPtr, "Method");
		Method_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Method");
		Method_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Method", Classes.FByteProperty);
		LowPercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowPercent");
		LowPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowPercent", Classes.FFloatProperty);
		HighPercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighPercent");
		HighPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighPercent", Classes.FFloatProperty);
		MinBrightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinBrightness");
		MinBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinBrightness", Classes.FFloatProperty);
		MaxBrightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxBrightness");
		MaxBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxBrightness", Classes.FFloatProperty);
		SpeedUp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedUp");
		SpeedUp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedUp", Classes.FFloatProperty);
		SpeedDown_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedDown");
		SpeedDown_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedDown", Classes.FFloatProperty);
		Bias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bias");
		Bias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bias", Classes.FFloatProperty);
		BiasCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BiasCurve");
		BiasCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BiasCurve", Classes.FObjectProperty);
		SceneEV100_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneEV100");
		SceneEV100_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneEV100", Classes.FFloatProperty);
		MeterMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeterMask");
		MeterMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeterMask", Classes.FObjectProperty);
		HistogramLogMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HistogramLogMin");
		HistogramLogMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HistogramLogMin", Classes.FFloatProperty);
		HistogramLogMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HistogramLogMax");
		HistogramLogMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HistogramLogMax", Classes.FFloatProperty);
		CalibrationConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CalibrationConstant");
		CalibrationConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CalibrationConstant", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicalCameraExposure_PropertyAddress, intPtr, "ApplyPhysicalCameraExposure");
		ApplyPhysicalCameraExposure_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ApplyPhysicalCameraExposure");
		ApplyPhysicalCameraExposure_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ApplyPhysicalCameraExposure", Classes.FBoolProperty);
		FCameraExposureSettings_IsValid = intPtr != IntPtr.Zero && Method_IsValid && LowPercent_IsValid && HighPercent_IsValid && MinBrightness_IsValid && MaxBrightness_IsValid && SpeedUp_IsValid && SpeedDown_IsValid && Bias_IsValid && BiasCurve_IsValid && SceneEV100_IsValid && MeterMask_IsValid && HistogramLogMin_IsValid && HistogramLogMax_IsValid && CalibrationConstant_IsValid && ApplyPhysicalCameraExposure_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CameraExposureSettings", FCameraExposureSettings_IsValid);
	}
}
