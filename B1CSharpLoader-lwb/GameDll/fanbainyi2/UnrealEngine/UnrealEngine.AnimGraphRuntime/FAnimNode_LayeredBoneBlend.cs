using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_LayeredBoneBlend
{
	private static bool BasePose_IsValid;

	private static int BasePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:BasePose")]
	public FPoseLink BasePose;

	private static bool BlendPoses_IsValid;

	private static FFieldAddress BlendPoses_PropertyAddress;

	private static int BlendPoses_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:BlendPoses")]
	public List<FPoseLink> BlendPoses;

	private static bool BlendWeights_IsValid;

	private static FFieldAddress BlendWeights_PropertyAddress;

	private static int BlendWeights_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:BlendWeights")]
	public List<float> BlendWeights;

	private static bool MeshSpaceRotationBlend_IsValid;

	private static FFieldAddress MeshSpaceRotationBlend_PropertyAddress;

	private static int MeshSpaceRotationBlend_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:bMeshSpaceRotationBlend")]
	public bool MeshSpaceRotationBlend;

	private static bool MeshSpaceScaleBlend_IsValid;

	private static FFieldAddress MeshSpaceScaleBlend_PropertyAddress;

	private static int MeshSpaceScaleBlend_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:bMeshSpaceScaleBlend")]
	public bool MeshSpaceScaleBlend;

	private static bool CurveBlendOption_IsValid;

	private static FFieldAddress CurveBlendOption_PropertyAddress;

	private static int CurveBlendOption_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:CurveBlendOption")]
	public ECurveBlendOption CurveBlendOption;

	private static bool LODThreshold_IsValid;

	private static int LODThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend:LODThreshold")]
	public int LODThreshold;

	private static bool FAnimNode_LayeredBoneBlend_IsValid;

	private static int FAnimNode_LayeredBoneBlend_StructSize;

	public FAnimNode_LayeredBoneBlend Copy()
	{
		FAnimNode_LayeredBoneBlend result = this;
		if (BlendPoses != null)
		{
			result.BlendPoses = new List<FPoseLink>(BlendPoses);
		}
		if (BlendWeights != null)
		{
			result.BlendWeights = new List<float>(BlendWeights);
		}
		return result;
	}

	public static FAnimNode_LayeredBoneBlend FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_LayeredBoneBlend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_LayeredBoneBlend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_LayeredBoneBlend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_LayeredBoneBlend(nativeBuffer + arrayIndex * FAnimNode_LayeredBoneBlend_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_LayeredBoneBlend value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_LayeredBoneBlend_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_LayeredBoneBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, BasePose_Offset), BasePose);
		new TArrayCopyMarshaler<FPoseLink>(1, BlendPoses_PropertyAddress, CachedMarshalingDelegates<FPoseLink, FPoseLink>.FromNative, CachedMarshalingDelegates<FPoseLink, FPoseLink>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlendPoses_Offset), BlendPoses);
		new TArrayCopyMarshaler<float>(1, BlendWeights_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BlendWeights_Offset), BlendWeights);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MeshSpaceRotationBlend_Offset), 0, MeshSpaceRotationBlend_PropertyAddress.Address, MeshSpaceRotationBlend);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MeshSpaceScaleBlend_Offset), 0, MeshSpaceScaleBlend_PropertyAddress.Address, MeshSpaceScaleBlend);
		EnumMarshaler<ECurveBlendOption>.ToNative(IntPtr.Add(nativeStruct, CurveBlendOption_Offset), 0, CurveBlendOption_PropertyAddress.Address, CurveBlendOption);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODThreshold_Offset), LODThreshold);
	}

	public FAnimNode_LayeredBoneBlend(IntPtr nativeStruct)
	{
		if (!FAnimNode_LayeredBoneBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend");
			BasePose = default(FPoseLink);
			BlendPoses = null;
			BlendWeights = null;
			MeshSpaceRotationBlend = false;
			MeshSpaceScaleBlend = false;
			CurveBlendOption = ECurveBlendOption.Override;
			LODThreshold = 0;
		}
		else
		{
			BasePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, BasePose_Offset));
			BlendPoses = new TArrayCopyMarshaler<FPoseLink>(1, BlendPoses_PropertyAddress, CachedMarshalingDelegates<FPoseLink, FPoseLink>.FromNative, CachedMarshalingDelegates<FPoseLink, FPoseLink>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlendPoses_Offset));
			BlendWeights = new TArrayCopyMarshaler<float>(1, BlendWeights_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BlendWeights_Offset));
			MeshSpaceRotationBlend = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MeshSpaceRotationBlend_Offset), 0, MeshSpaceRotationBlend_PropertyAddress.Address);
			MeshSpaceScaleBlend = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MeshSpaceScaleBlend_Offset), 0, MeshSpaceScaleBlend_PropertyAddress.Address);
			CurveBlendOption = EnumMarshaler<ECurveBlendOption>.FromNative(IntPtr.Add(nativeStruct, CurveBlendOption_Offset), 0, CurveBlendOption_PropertyAddress.Address);
			LODThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODThreshold_Offset));
		}
	}

	static FAnimNode_LayeredBoneBlend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_LayeredBoneBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_LayeredBoneBlend));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend");
		FAnimNode_LayeredBoneBlend_StructSize = NativeReflection.GetStructSize(intPtr);
		BasePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BasePose");
		BasePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BasePose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendPoses_PropertyAddress, intPtr, "BlendPoses");
		BlendPoses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendPoses");
		BlendPoses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendPoses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendWeights_PropertyAddress, intPtr, "BlendWeights");
		BlendWeights_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeights");
		BlendWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeights", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshSpaceRotationBlend_PropertyAddress, intPtr, "bMeshSpaceRotationBlend");
		MeshSpaceRotationBlend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMeshSpaceRotationBlend");
		MeshSpaceRotationBlend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMeshSpaceRotationBlend", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshSpaceScaleBlend_PropertyAddress, intPtr, "bMeshSpaceScaleBlend");
		MeshSpaceScaleBlend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMeshSpaceScaleBlend");
		MeshSpaceScaleBlend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMeshSpaceScaleBlend", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CurveBlendOption_PropertyAddress, intPtr, "CurveBlendOption");
		CurveBlendOption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveBlendOption");
		CurveBlendOption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveBlendOption", Classes.FByteProperty);
		LODThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODThreshold");
		LODThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODThreshold", Classes.FIntProperty);
		FAnimNode_LayeredBoneBlend_IsValid = intPtr != IntPtr.Zero && BasePose_IsValid && BlendPoses_IsValid && BlendWeights_IsValid && MeshSpaceRotationBlend_IsValid && MeshSpaceScaleBlend_IsValid && CurveBlendOption_IsValid && LODThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_LayeredBoneBlend", FAnimNode_LayeredBoneBlend_IsValid);
	}
}
