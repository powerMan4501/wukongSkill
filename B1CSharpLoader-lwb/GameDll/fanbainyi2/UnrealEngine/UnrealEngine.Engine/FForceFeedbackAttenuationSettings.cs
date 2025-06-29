using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.ForceFeedbackAttenuationSettings", "Engine", UnrealModuleType.Engine)]
public struct FForceFeedbackAttenuationSettings
{
	private static bool DistanceAlgorithm_IsValid;

	private static FFieldAddress DistanceAlgorithm_PropertyAddress;

	private static int DistanceAlgorithm_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:DistanceAlgorithm")]
	public EAttenuationDistanceModel DistanceAlgorithm;

	private static bool AttenuationShape_IsValid;

	private static FFieldAddress AttenuationShape_PropertyAddress;

	private static int AttenuationShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:AttenuationShape")]
	public EAttenuationShape AttenuationShape;

	private static bool dBAttenuationAtMax_IsValid;

	private static int dBAttenuationAtMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:dBAttenuationAtMax")]
	public float dBAttenuationAtMax;

	private static bool FalloffMode_IsValid;

	private static FFieldAddress FalloffMode_PropertyAddress;

	private static int FalloffMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:FalloffMode")]
	public ENaturalSoundFalloffMode FalloffMode;

	private static bool AttenuationShapeExtents_IsValid;

	private static int AttenuationShapeExtents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:AttenuationShapeExtents")]
	public FVector AttenuationShapeExtents;

	private static bool ConeOffset_IsValid;

	private static int ConeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:ConeOffset")]
	public float ConeOffset;

	private static bool FalloffDistance_IsValid;

	private static int FalloffDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:FalloffDistance")]
	public float FalloffDistance;

	private static bool ConeSphereRadius_IsValid;

	private static int ConeSphereRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:ConeSphereRadius")]
	public float ConeSphereRadius;

	private static bool ConeSphereFalloffDistance_IsValid;

	private static int ConeSphereFalloffDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:ConeSphereFalloffDistance")]
	public float ConeSphereFalloffDistance;

	private static bool CustomAttenuationCurve_IsValid;

	private static int CustomAttenuationCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:CustomAttenuationCurve")]
	public FRuntimeFloatCurve CustomAttenuationCurve;

	private static bool FForceFeedbackAttenuationSettings_IsValid;

	private static int FForceFeedbackAttenuationSettings_StructSize;

	public FForceFeedbackAttenuationSettings Copy()
	{
		return this;
	}

	public static FForceFeedbackAttenuationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FForceFeedbackAttenuationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FForceFeedbackAttenuationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FForceFeedbackAttenuationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FForceFeedbackAttenuationSettings(nativeBuffer + arrayIndex * FForceFeedbackAttenuationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FForceFeedbackAttenuationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FForceFeedbackAttenuationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FForceFeedbackAttenuationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ForceFeedbackAttenuationSettings");
			return;
		}
		EnumMarshaler<EAttenuationDistanceModel>.ToNative(IntPtr.Add(nativeStruct, DistanceAlgorithm_Offset), 0, DistanceAlgorithm_PropertyAddress.Address, DistanceAlgorithm);
		EnumMarshaler<EAttenuationShape>.ToNative(IntPtr.Add(nativeStruct, AttenuationShape_Offset), 0, AttenuationShape_PropertyAddress.Address, AttenuationShape);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, dBAttenuationAtMax_Offset), dBAttenuationAtMax);
		EnumMarshaler<ENaturalSoundFalloffMode>.ToNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address, FalloffMode);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AttenuationShapeExtents_Offset), AttenuationShapeExtents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConeOffset_Offset), ConeOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffDistance_Offset), FalloffDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConeSphereRadius_Offset), ConeSphereRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConeSphereFalloffDistance_Offset), ConeSphereFalloffDistance);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomAttenuationCurve_Offset), CustomAttenuationCurve);
	}

	public FForceFeedbackAttenuationSettings(IntPtr nativeStruct)
	{
		if (!FForceFeedbackAttenuationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ForceFeedbackAttenuationSettings");
			DistanceAlgorithm = EAttenuationDistanceModel.Linear;
			AttenuationShape = EAttenuationShape.Sphere;
			dBAttenuationAtMax = 0f;
			FalloffMode = ENaturalSoundFalloffMode.Continues;
			AttenuationShapeExtents = default(FVector);
			ConeOffset = 0f;
			FalloffDistance = 0f;
			ConeSphereRadius = 0f;
			ConeSphereFalloffDistance = 0f;
			CustomAttenuationCurve = default(FRuntimeFloatCurve);
		}
		else
		{
			DistanceAlgorithm = EnumMarshaler<EAttenuationDistanceModel>.FromNative(IntPtr.Add(nativeStruct, DistanceAlgorithm_Offset), 0, DistanceAlgorithm_PropertyAddress.Address);
			AttenuationShape = EnumMarshaler<EAttenuationShape>.FromNative(IntPtr.Add(nativeStruct, AttenuationShape_Offset), 0, AttenuationShape_PropertyAddress.Address);
			dBAttenuationAtMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, dBAttenuationAtMax_Offset));
			FalloffMode = EnumMarshaler<ENaturalSoundFalloffMode>.FromNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address);
			AttenuationShapeExtents = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AttenuationShapeExtents_Offset));
			ConeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConeOffset_Offset));
			FalloffDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffDistance_Offset));
			ConeSphereRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConeSphereRadius_Offset));
			ConeSphereFalloffDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConeSphereFalloffDistance_Offset));
			CustomAttenuationCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomAttenuationCurve_Offset));
		}
	}

	static FForceFeedbackAttenuationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FForceFeedbackAttenuationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FForceFeedbackAttenuationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ForceFeedbackAttenuationSettings");
		FForceFeedbackAttenuationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DistanceAlgorithm_PropertyAddress, intPtr, "DistanceAlgorithm");
		DistanceAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceAlgorithm");
		DistanceAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceAlgorithm", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttenuationShape_PropertyAddress, intPtr, "AttenuationShape");
		AttenuationShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationShape");
		AttenuationShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationShape", Classes.FByteProperty);
		dBAttenuationAtMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "dBAttenuationAtMax");
		dBAttenuationAtMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "dBAttenuationAtMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FalloffMode_PropertyAddress, intPtr, "FalloffMode");
		FalloffMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffMode");
		FalloffMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffMode", Classes.FEnumProperty);
		AttenuationShapeExtents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationShapeExtents");
		AttenuationShapeExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationShapeExtents", Classes.FStructProperty);
		ConeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConeOffset");
		ConeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConeOffset", Classes.FFloatProperty);
		FalloffDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffDistance");
		FalloffDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffDistance", Classes.FFloatProperty);
		ConeSphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConeSphereRadius");
		ConeSphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConeSphereRadius", Classes.FFloatProperty);
		ConeSphereFalloffDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConeSphereFalloffDistance");
		ConeSphereFalloffDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConeSphereFalloffDistance", Classes.FFloatProperty);
		CustomAttenuationCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomAttenuationCurve");
		CustomAttenuationCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomAttenuationCurve", Classes.FStructProperty);
		FForceFeedbackAttenuationSettings_IsValid = intPtr != IntPtr.Zero && DistanceAlgorithm_IsValid && AttenuationShape_IsValid && dBAttenuationAtMax_IsValid && FalloffMode_IsValid && AttenuationShapeExtents_IsValid && ConeOffset_IsValid && FalloffDistance_IsValid && ConeSphereRadius_IsValid && ConeSphereFalloffDistance_IsValid && CustomAttenuationCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ForceFeedbackAttenuationSettings", FForceFeedbackAttenuationSettings_IsValid);
	}
}
