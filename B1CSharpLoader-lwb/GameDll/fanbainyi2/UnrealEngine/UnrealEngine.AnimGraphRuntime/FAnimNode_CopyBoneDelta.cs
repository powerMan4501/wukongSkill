using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_CopyBoneDelta
{
	private static bool ComponentPose_IsValid;

	private static int ComponentPose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:ComponentPose")]
	public FComponentSpacePoseLink ComponentPose;

	private static bool LODThreshold_IsValid;

	private static int LODThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:LODThreshold")]
	public int LODThreshold;

	private static bool AlphaInputType_IsValid;

	private static FFieldAddress AlphaInputType_PropertyAddress;

	private static int AlphaInputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaInputType")]
	public EAnimAlphaInputType AlphaInputType;

	private static bool AlphaBoolEnabled_IsValid;

	private static FFieldAddress AlphaBoolEnabled_PropertyAddress;

	private static int AlphaBoolEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:bAlphaBoolEnabled")]
	public bool AlphaBoolEnabled;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:Alpha")]
	public float Alpha;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool AlphaBoolBlend_IsValid;

	private static int AlphaBoolBlend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaBoolBlend")]
	public FInputAlphaBoolBlend AlphaBoolBlend;

	private static bool AlphaCurveName_IsValid;

	private static int AlphaCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaCurveName")]
	public FName AlphaCurveName;

	private static bool AlphaScaleBiasClamp_IsValid;

	private static int AlphaScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SkeletalControlBase:AlphaScaleBiasClamp")]
	public FInputScaleBiasClamp AlphaScaleBiasClamp;

	private static bool CopyTranslation_IsValid;

	private static FFieldAddress CopyTranslation_PropertyAddress;

	private static int CopyTranslation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:bCopyTranslation")]
	public bool CopyTranslation;

	private static bool CopyRotation_IsValid;

	private static FFieldAddress CopyRotation_PropertyAddress;

	private static int CopyRotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:bCopyRotation")]
	public bool CopyRotation;

	private static bool CopyScale_IsValid;

	private static FFieldAddress CopyScale_PropertyAddress;

	private static int CopyScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:bCopyScale")]
	public bool CopyScale;

	private static bool TranslationMultiplier_IsValid;

	private static int TranslationMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:TranslationMultiplier")]
	public float TranslationMultiplier;

	private static bool RotationMultiplier_IsValid;

	private static int RotationMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:RotationMultiplier")]
	public float RotationMultiplier;

	private static bool ScaleMultiplier_IsValid;

	private static int ScaleMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta:ScaleMultiplier")]
	public float ScaleMultiplier;

	private static bool FAnimNode_CopyBoneDelta_IsValid;

	private static int FAnimNode_CopyBoneDelta_StructSize;

	public FAnimNode_CopyBoneDelta Copy()
	{
		return this;
	}

	public static FAnimNode_CopyBoneDelta FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_CopyBoneDelta(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_CopyBoneDelta value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_CopyBoneDelta FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_CopyBoneDelta(nativeBuffer + arrayIndex * FAnimNode_CopyBoneDelta_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_CopyBoneDelta value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_CopyBoneDelta_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_CopyBoneDelta_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CopyTranslation_Offset), 0, CopyTranslation_PropertyAddress.Address, CopyTranslation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CopyRotation_Offset), 0, CopyRotation_PropertyAddress.Address, CopyRotation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CopyScale_Offset), 0, CopyScale_PropertyAddress.Address, CopyScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TranslationMultiplier_Offset), TranslationMultiplier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RotationMultiplier_Offset), RotationMultiplier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScaleMultiplier_Offset), ScaleMultiplier);
		FComponentSpacePoseLink.ToNative(IntPtr.Add(nativeStruct, ComponentPose_Offset), ComponentPose);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODThreshold_Offset), LODThreshold);
		EnumMarshaler<EAnimAlphaInputType>.ToNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address, AlphaInputType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address, AlphaBoolEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		FInputAlphaBoolBlend.ToNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset), AlphaBoolBlend);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset), AlphaCurveName);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset), AlphaScaleBiasClamp);
	}

	public FAnimNode_CopyBoneDelta(IntPtr nativeStruct)
	{
		if (!FAnimNode_CopyBoneDelta_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta");
			CopyTranslation = false;
			CopyRotation = false;
			CopyScale = false;
			TranslationMultiplier = 0f;
			RotationMultiplier = 0f;
			ScaleMultiplier = 0f;
			ComponentPose = default(FComponentSpacePoseLink);
			LODThreshold = 0;
			AlphaInputType = EAnimAlphaInputType.Float;
			AlphaBoolEnabled = false;
			Alpha = 0f;
			AlphaScaleBias = default(FInputScaleBias);
			AlphaBoolBlend = default(FInputAlphaBoolBlend);
			AlphaCurveName = default(FName);
			AlphaScaleBiasClamp = default(FInputScaleBiasClamp);
		}
		else
		{
			CopyTranslation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CopyTranslation_Offset), 0, CopyTranslation_PropertyAddress.Address);
			CopyRotation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CopyRotation_Offset), 0, CopyRotation_PropertyAddress.Address);
			CopyScale = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CopyScale_Offset), 0, CopyScale_PropertyAddress.Address);
			TranslationMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TranslationMultiplier_Offset));
			RotationMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RotationMultiplier_Offset));
			ScaleMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScaleMultiplier_Offset));
			ComponentPose = FComponentSpacePoseLink.FromNative(IntPtr.Add(nativeStruct, ComponentPose_Offset));
			LODThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODThreshold_Offset));
			AlphaInputType = EnumMarshaler<EAnimAlphaInputType>.FromNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address);
			AlphaBoolEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address);
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			AlphaBoolBlend = FInputAlphaBoolBlend.FromNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset));
			AlphaCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset));
			AlphaScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset));
		}
	}

	static FAnimNode_CopyBoneDelta()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_CopyBoneDelta)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_CopyBoneDelta));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta");
		FAnimNode_CopyBoneDelta_StructSize = NativeReflection.GetStructSize(intPtr);
		ComponentPose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComponentPose");
		ComponentPose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComponentPose", Classes.FStructProperty);
		LODThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODThreshold");
		LODThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODThreshold", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaInputType_PropertyAddress, intPtr, "AlphaInputType");
		AlphaInputType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaInputType");
		AlphaInputType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaInputType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaBoolEnabled_PropertyAddress, intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlphaBoolEnabled", Classes.FBoolProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		AlphaScaleBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBias");
		AlphaScaleBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBias", Classes.FStructProperty);
		AlphaBoolBlend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaBoolBlend");
		AlphaBoolBlend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaBoolBlend", Classes.FStructProperty);
		AlphaCurveName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaCurveName");
		AlphaCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaCurveName", Classes.FNameProperty);
		AlphaScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBiasClamp");
		AlphaScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBiasClamp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyTranslation_PropertyAddress, intPtr, "bCopyTranslation");
		CopyTranslation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCopyTranslation");
		CopyTranslation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCopyTranslation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyRotation_PropertyAddress, intPtr, "bCopyRotation");
		CopyRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCopyRotation");
		CopyRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCopyRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyScale_PropertyAddress, intPtr, "bCopyScale");
		CopyScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCopyScale");
		CopyScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCopyScale", Classes.FBoolProperty);
		TranslationMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TranslationMultiplier");
		TranslationMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TranslationMultiplier", Classes.FFloatProperty);
		RotationMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationMultiplier");
		RotationMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationMultiplier", Classes.FFloatProperty);
		ScaleMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScaleMultiplier");
		ScaleMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScaleMultiplier", Classes.FFloatProperty);
		FAnimNode_CopyBoneDelta_IsValid = intPtr != IntPtr.Zero && CopyTranslation_IsValid && CopyRotation_IsValid && CopyScale_IsValid && TranslationMultiplier_IsValid && RotationMultiplier_IsValid && ScaleMultiplier_IsValid && ComponentPose_IsValid && LODThreshold_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta", FAnimNode_CopyBoneDelta_IsValid);
	}
}
