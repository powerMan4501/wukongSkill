using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FAnimNode_SpeedWarping
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

	private static bool FeetDefinitions_IsValid;

	private static FFieldAddress FeetDefinitions_PropertyAddress;

	private static int FeetDefinitions_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:FeetDefinitions")]
	public List<FIKBones> FeetDefinitions;

	private static bool SpeedWarpingAxisMode_IsValid;

	private static FFieldAddress SpeedWarpingAxisMode_PropertyAddress;

	private static int SpeedWarpingAxisMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:SpeedWarpingAxisMode")]
	public EIKFootRootLocalAxis SpeedWarpingAxisMode;

	private static bool SpeedScaling_IsValid;

	private static int SpeedScaling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:SpeedScaling")]
	public float SpeedScaling;

	private static bool PelvisAdjustmentAlpha_IsValid;

	private static int PelvisAdjustmentAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:PelvisAdjustmentAlpha")]
	public float PelvisAdjustmentAlpha;

	private static bool MaxIter_IsValid;

	private static int MaxIter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:MaxIter")]
	public float MaxIter;

	private static bool PelvisAdjustmentInterp_IsValid;

	private static int PelvisAdjustmentInterp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:PelvisAdjustmentInterp")]
	public FPelvisAdjustmentInterp PelvisAdjustmentInterp;

	private static bool ClampIKUsingFKLeg_IsValid;

	private static FFieldAddress ClampIKUsingFKLeg_PropertyAddress;

	private static int ClampIKUsingFKLeg_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.AnimNode_SpeedWarping:ClampIKUsingFKLeg")]
	public bool ClampIKUsingFKLeg;

	private static bool FAnimNode_SpeedWarping_IsValid;

	private static int FAnimNode_SpeedWarping_StructSize;

	public FAnimNode_SpeedWarping Copy()
	{
		FAnimNode_SpeedWarping result = this;
		if (FeetDefinitions != null)
		{
			result.FeetDefinitions = new List<FIKBones>(FeetDefinitions);
		}
		return result;
	}

	public static FAnimNode_SpeedWarping FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SpeedWarping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SpeedWarping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SpeedWarping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SpeedWarping(nativeBuffer + arrayIndex * FAnimNode_SpeedWarping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SpeedWarping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SpeedWarping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SpeedWarping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AnimNode_SpeedWarping");
			return;
		}
		new TArrayCopyMarshaler<FIKBones>(1, FeetDefinitions_PropertyAddress, CachedMarshalingDelegates<FIKBones, FIKBones>.FromNative, CachedMarshalingDelegates<FIKBones, FIKBones>.ToNative).ToNative(IntPtr.Add(nativeStruct, FeetDefinitions_Offset), FeetDefinitions);
		EnumMarshaler<EIKFootRootLocalAxis>.ToNative(IntPtr.Add(nativeStruct, SpeedWarpingAxisMode_Offset), 0, SpeedWarpingAxisMode_PropertyAddress.Address, SpeedWarpingAxisMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpeedScaling_Offset), SpeedScaling);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PelvisAdjustmentAlpha_Offset), PelvisAdjustmentAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxIter_Offset), MaxIter);
		FPelvisAdjustmentInterp.ToNative(IntPtr.Add(nativeStruct, PelvisAdjustmentInterp_Offset), PelvisAdjustmentInterp);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ClampIKUsingFKLeg_Offset), 0, ClampIKUsingFKLeg_PropertyAddress.Address, ClampIKUsingFKLeg);
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

	public FAnimNode_SpeedWarping(IntPtr nativeStruct)
	{
		if (!FAnimNode_SpeedWarping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.AnimNode_SpeedWarping");
			FeetDefinitions = null;
			SpeedWarpingAxisMode = EIKFootRootLocalAxis.NONE;
			SpeedScaling = 0f;
			PelvisAdjustmentAlpha = 0f;
			MaxIter = 0f;
			PelvisAdjustmentInterp = default(FPelvisAdjustmentInterp);
			ClampIKUsingFKLeg = false;
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
			FeetDefinitions = new TArrayCopyMarshaler<FIKBones>(1, FeetDefinitions_PropertyAddress, CachedMarshalingDelegates<FIKBones, FIKBones>.FromNative, CachedMarshalingDelegates<FIKBones, FIKBones>.ToNative).FromNative(IntPtr.Add(nativeStruct, FeetDefinitions_Offset));
			SpeedWarpingAxisMode = EnumMarshaler<EIKFootRootLocalAxis>.FromNative(IntPtr.Add(nativeStruct, SpeedWarpingAxisMode_Offset), 0, SpeedWarpingAxisMode_PropertyAddress.Address);
			SpeedScaling = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpeedScaling_Offset));
			PelvisAdjustmentAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PelvisAdjustmentAlpha_Offset));
			MaxIter = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxIter_Offset));
			PelvisAdjustmentInterp = FPelvisAdjustmentInterp.FromNative(IntPtr.Add(nativeStruct, PelvisAdjustmentInterp_Offset));
			ClampIKUsingFKLeg = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ClampIKUsingFKLeg_Offset), 0, ClampIKUsingFKLeg_PropertyAddress.Address);
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

	static FAnimNode_SpeedWarping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SpeedWarping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SpeedWarping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.AnimNode_SpeedWarping");
		FAnimNode_SpeedWarping_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref FeetDefinitions_PropertyAddress, intPtr, "FeetDefinitions");
		FeetDefinitions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FeetDefinitions");
		FeetDefinitions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FeetDefinitions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SpeedWarpingAxisMode_PropertyAddress, intPtr, "SpeedWarpingAxisMode");
		SpeedWarpingAxisMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedWarpingAxisMode");
		SpeedWarpingAxisMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedWarpingAxisMode", Classes.FEnumProperty);
		SpeedScaling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpeedScaling");
		SpeedScaling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpeedScaling", Classes.FFloatProperty);
		PelvisAdjustmentAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PelvisAdjustmentAlpha");
		PelvisAdjustmentAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PelvisAdjustmentAlpha", Classes.FFloatProperty);
		MaxIter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxIter");
		MaxIter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxIter", Classes.FFloatProperty);
		PelvisAdjustmentInterp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PelvisAdjustmentInterp");
		PelvisAdjustmentInterp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PelvisAdjustmentInterp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClampIKUsingFKLeg_PropertyAddress, intPtr, "ClampIKUsingFKLeg");
		ClampIKUsingFKLeg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClampIKUsingFKLeg");
		ClampIKUsingFKLeg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClampIKUsingFKLeg", Classes.FBoolProperty);
		FAnimNode_SpeedWarping_IsValid = intPtr != IntPtr.Zero && FeetDefinitions_IsValid && SpeedWarpingAxisMode_IsValid && SpeedScaling_IsValid && PelvisAdjustmentAlpha_IsValid && MaxIter_IsValid && PelvisAdjustmentInterp_IsValid && ClampIKUsingFKLeg_IsValid && ComponentPose_IsValid && LODThreshold_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.AnimNode_SpeedWarping", FAnimNode_SpeedWarping_IsValid);
	}
}
