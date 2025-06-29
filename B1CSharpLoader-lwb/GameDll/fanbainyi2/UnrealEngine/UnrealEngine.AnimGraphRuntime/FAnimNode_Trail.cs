using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Trail", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_Trail
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

	private static bool RelaxationSpeedScale_IsValid;

	private static int RelaxationSpeedScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Trail:RelaxationSpeedScale")]
	public float RelaxationSpeedScale;

	private static bool RelaxationSpeedScaleInputProcessor_IsValid;

	private static int RelaxationSpeedScaleInputProcessor_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Trail:RelaxationSpeedScaleInputProcessor")]
	public FInputScaleBiasClamp RelaxationSpeedScaleInputProcessor;

	private static bool RotationOffsets_IsValid;

	private static FFieldAddress RotationOffsets_PropertyAddress;

	private static int RotationOffsets_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_Trail:RotationOffsets")]
	public List<FVector> RotationOffsets;

	private static bool FAnimNode_Trail_IsValid;

	private static int FAnimNode_Trail_StructSize;

	public FAnimNode_Trail Copy()
	{
		FAnimNode_Trail result = this;
		if (RotationOffsets != null)
		{
			result.RotationOffsets = new List<FVector>(RotationOffsets);
		}
		return result;
	}

	public static FAnimNode_Trail FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_Trail(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_Trail value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_Trail FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_Trail(nativeBuffer + arrayIndex * FAnimNode_Trail_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_Trail value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_Trail_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_Trail_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Trail");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RelaxationSpeedScale_Offset), RelaxationSpeedScale);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, RelaxationSpeedScaleInputProcessor_Offset), RelaxationSpeedScaleInputProcessor);
		new TArrayCopyMarshaler<FVector>(1, RotationOffsets_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, RotationOffsets_Offset), RotationOffsets);
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

	public FAnimNode_Trail(IntPtr nativeStruct)
	{
		if (!FAnimNode_Trail_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_Trail");
			RelaxationSpeedScale = 0f;
			RelaxationSpeedScaleInputProcessor = default(FInputScaleBiasClamp);
			RotationOffsets = null;
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
			RelaxationSpeedScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RelaxationSpeedScale_Offset));
			RelaxationSpeedScaleInputProcessor = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, RelaxationSpeedScaleInputProcessor_Offset));
			RotationOffsets = new TArrayCopyMarshaler<FVector>(1, RotationOffsets_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, RotationOffsets_Offset));
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

	static FAnimNode_Trail()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_Trail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_Trail));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_Trail");
		FAnimNode_Trail_StructSize = NativeReflection.GetStructSize(intPtr);
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
		RelaxationSpeedScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelaxationSpeedScale");
		RelaxationSpeedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelaxationSpeedScale", Classes.FFloatProperty);
		RelaxationSpeedScaleInputProcessor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelaxationSpeedScaleInputProcessor");
		RelaxationSpeedScaleInputProcessor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelaxationSpeedScaleInputProcessor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RotationOffsets_PropertyAddress, intPtr, "RotationOffsets");
		RotationOffsets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationOffsets");
		RotationOffsets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationOffsets", Classes.FArrayProperty);
		FAnimNode_Trail_IsValid = intPtr != IntPtr.Zero && RelaxationSpeedScale_IsValid && RelaxationSpeedScaleInputProcessor_IsValid && RotationOffsets_IsValid && ComponentPose_IsValid && LODThreshold_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_Trail", FAnimNode_Trail_IsValid);
	}
}
