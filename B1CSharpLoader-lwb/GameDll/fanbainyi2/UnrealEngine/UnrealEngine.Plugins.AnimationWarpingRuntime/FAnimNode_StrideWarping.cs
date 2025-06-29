using System;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationWarpingRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping", "AnimationWarpingRuntime", UnrealModuleType.EnginePlugin)]
public struct FAnimNode_StrideWarping
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

	private static bool StrideDirection_IsValid;

	private static int StrideDirection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping:StrideDirection")]
	public FVector StrideDirection;

	private static bool StrideScale_IsValid;

	private static int StrideScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping:StrideScale")]
	public float StrideScale;

	private static bool LocomotionSpeed_IsValid;

	private static int LocomotionSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping:LocomotionSpeed")]
	public float LocomotionSpeed;

	private static bool MinLocomotionSpeedThreshold_IsValid;

	private static int MinLocomotionSpeedThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping:MinLocomotionSpeedThreshold")]
	public float MinLocomotionSpeedThreshold;

	private static bool FloorNormalDirection_IsValid;

	private static int FloorNormalDirection_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping:FloorNormalDirection")]
	public FWarpingVectorValue FloorNormalDirection;

	private static bool GravityDirection_IsValid;

	private static int GravityDirection_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping:GravityDirection")]
	public FWarpingVectorValue GravityDirection;

	private static bool FAnimNode_StrideWarping_IsValid;

	private static int FAnimNode_StrideWarping_StructSize;

	public FAnimNode_StrideWarping Copy()
	{
		return this;
	}

	public static FAnimNode_StrideWarping FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_StrideWarping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_StrideWarping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_StrideWarping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_StrideWarping(nativeBuffer + arrayIndex * FAnimNode_StrideWarping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_StrideWarping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_StrideWarping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_StrideWarping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, StrideDirection_Offset), StrideDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrideScale_Offset), StrideScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LocomotionSpeed_Offset), LocomotionSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinLocomotionSpeedThreshold_Offset), MinLocomotionSpeedThreshold);
		FWarpingVectorValue.ToNative(IntPtr.Add(nativeStruct, FloorNormalDirection_Offset), FloorNormalDirection);
		FWarpingVectorValue.ToNative(IntPtr.Add(nativeStruct, GravityDirection_Offset), GravityDirection);
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

	public FAnimNode_StrideWarping(IntPtr nativeStruct)
	{
		if (!FAnimNode_StrideWarping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping");
			StrideDirection = default(FVector);
			StrideScale = 0f;
			LocomotionSpeed = 0f;
			MinLocomotionSpeedThreshold = 0f;
			FloorNormalDirection = default(FWarpingVectorValue);
			GravityDirection = default(FWarpingVectorValue);
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
			StrideDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, StrideDirection_Offset));
			StrideScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrideScale_Offset));
			LocomotionSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LocomotionSpeed_Offset));
			MinLocomotionSpeedThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinLocomotionSpeedThreshold_Offset));
			FloorNormalDirection = FWarpingVectorValue.FromNative(IntPtr.Add(nativeStruct, FloorNormalDirection_Offset));
			GravityDirection = FWarpingVectorValue.FromNative(IntPtr.Add(nativeStruct, GravityDirection_Offset));
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

	static FAnimNode_StrideWarping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_StrideWarping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_StrideWarping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping");
		FAnimNode_StrideWarping_StructSize = NativeReflection.GetStructSize(intPtr);
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
		StrideDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrideDirection");
		StrideDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrideDirection", Classes.FStructProperty);
		StrideScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrideScale");
		StrideScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrideScale", Classes.FFloatProperty);
		LocomotionSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocomotionSpeed");
		LocomotionSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocomotionSpeed", Classes.FFloatProperty);
		MinLocomotionSpeedThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLocomotionSpeedThreshold");
		MinLocomotionSpeedThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLocomotionSpeedThreshold", Classes.FFloatProperty);
		FloorNormalDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorNormalDirection");
		FloorNormalDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorNormalDirection", Classes.FStructProperty);
		GravityDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GravityDirection");
		GravityDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GravityDirection", Classes.FStructProperty);
		FAnimNode_StrideWarping_IsValid = intPtr != IntPtr.Zero && StrideDirection_IsValid && StrideScale_IsValid && LocomotionSpeed_IsValid && MinLocomotionSpeedThreshold_IsValid && FloorNormalDirection_IsValid && GravityDirection_IsValid && ComponentPose_IsValid && LODThreshold_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationWarpingRuntime.AnimNode_StrideWarping", FAnimNode_StrideWarping_IsValid);
	}
}
