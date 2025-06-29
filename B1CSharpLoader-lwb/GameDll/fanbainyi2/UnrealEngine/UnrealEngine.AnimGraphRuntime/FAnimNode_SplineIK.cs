using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_SplineIK
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

	private static bool ControlPoints_IsValid;

	private static FFieldAddress ControlPoints_PropertyAddress;

	private static int ControlPoints_Offset;

	[UProperty(Flags = (PropFlags)4503599627371077uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK:ControlPoints")]
	public List<FTransform> ControlPoints;

	private static bool Roll_IsValid;

	private static int Roll_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK:Roll")]
	public float Roll;

	private static bool TwistStart_IsValid;

	private static int TwistStart_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK:TwistStart")]
	public float TwistStart;

	private static bool TwistEnd_IsValid;

	private static int TwistEnd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK:TwistEnd")]
	public float TwistEnd;

	private static bool Stretch_IsValid;

	private static int Stretch_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK:Stretch")]
	public float Stretch;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_SplineIK:Offset")]
	public float Offset;

	private static bool FAnimNode_SplineIK_IsValid;

	private static int FAnimNode_SplineIK_StructSize;

	public FAnimNode_SplineIK Copy()
	{
		FAnimNode_SplineIK result = this;
		if (ControlPoints != null)
		{
			result.ControlPoints = new List<FTransform>(ControlPoints);
		}
		return result;
	}

	public static FAnimNode_SplineIK FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_SplineIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_SplineIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_SplineIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_SplineIK(nativeBuffer + arrayIndex * FAnimNode_SplineIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_SplineIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_SplineIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_SplineIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_SplineIK");
			return;
		}
		new TArrayCopyMarshaler<FTransform>(1, ControlPoints_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ControlPoints_Offset), ControlPoints);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Roll_Offset), Roll);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TwistStart_Offset), TwistStart);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TwistEnd_Offset), TwistEnd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Stretch_Offset), Stretch);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
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

	public FAnimNode_SplineIK(IntPtr nativeStruct)
	{
		if (!FAnimNode_SplineIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_SplineIK");
			ControlPoints = null;
			Roll = 0f;
			TwistStart = 0f;
			TwistEnd = 0f;
			Stretch = 0f;
			Offset = 0f;
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
			ControlPoints = new TArrayCopyMarshaler<FTransform>(1, ControlPoints_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ControlPoints_Offset));
			Roll = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Roll_Offset));
			TwistStart = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TwistStart_Offset));
			TwistEnd = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TwistEnd_Offset));
			Stretch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Stretch_Offset));
			Offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
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

	static FAnimNode_SplineIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_SplineIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_SplineIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_SplineIK");
		FAnimNode_SplineIK_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref ControlPoints_PropertyAddress, intPtr, "ControlPoints");
		ControlPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControlPoints");
		ControlPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControlPoints", Classes.FArrayProperty);
		Roll_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Roll");
		Roll_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Roll", Classes.FFloatProperty);
		TwistStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TwistStart");
		TwistStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TwistStart", Classes.FFloatProperty);
		TwistEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TwistEnd");
		TwistEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TwistEnd", Classes.FFloatProperty);
		Stretch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Stretch");
		Stretch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Stretch", Classes.FFloatProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FFloatProperty);
		FAnimNode_SplineIK_IsValid = intPtr != IntPtr.Zero && ControlPoints_IsValid && Roll_IsValid && TwistStart_IsValid && TwistEnd_IsValid && Stretch_IsValid && Offset_IsValid && ComponentPose_IsValid && LODThreshold_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_SplineIK", FAnimNode_SplineIK_IsValid);
	}
}
