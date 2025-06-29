using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_ApplyAdditive
{
	private static bool Base__IsValid;

	private static int Base__Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:Base")]
	public FPoseLink Base_;

	private static bool Additive_IsValid;

	private static int Additive_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:Additive")]
	public FPoseLink Additive;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:Alpha")]
	public float Alpha;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool LODThreshold_IsValid;

	private static int LODThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:LODThreshold")]
	public int LODThreshold;

	private static bool AlphaBoolBlend_IsValid;

	private static int AlphaBoolBlend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaBoolBlend")]
	public FInputAlphaBoolBlend AlphaBoolBlend;

	private static bool AlphaCurveName_IsValid;

	private static int AlphaCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaCurveName")]
	public FName AlphaCurveName;

	private static bool AlphaScaleBiasClamp_IsValid;

	private static int AlphaScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaScaleBiasClamp")]
	public FInputScaleBiasClamp AlphaScaleBiasClamp;

	private static bool AlphaInputType_IsValid;

	private static FFieldAddress AlphaInputType_PropertyAddress;

	private static int AlphaInputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:AlphaInputType")]
	public EAnimAlphaInputType AlphaInputType;

	private static bool AlphaBoolEnabled_IsValid;

	private static FFieldAddress AlphaBoolEnabled_PropertyAddress;

	private static int AlphaBoolEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive:bAlphaBoolEnabled")]
	public bool AlphaBoolEnabled;

	private static bool FAnimNode_ApplyAdditive_IsValid;

	private static int FAnimNode_ApplyAdditive_StructSize;

	public FAnimNode_ApplyAdditive Copy()
	{
		return this;
	}

	public static FAnimNode_ApplyAdditive FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_ApplyAdditive(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_ApplyAdditive value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_ApplyAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_ApplyAdditive(nativeBuffer + arrayIndex * FAnimNode_ApplyAdditive_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_ApplyAdditive value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_ApplyAdditive_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_ApplyAdditive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Base__Offset), Base_);
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Additive_Offset), Additive);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODThreshold_Offset), LODThreshold);
		FInputAlphaBoolBlend.ToNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset), AlphaBoolBlend);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset), AlphaCurveName);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset), AlphaScaleBiasClamp);
		EnumMarshaler<EAnimAlphaInputType>.ToNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address, AlphaInputType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address, AlphaBoolEnabled);
	}

	public FAnimNode_ApplyAdditive(IntPtr nativeStruct)
	{
		if (!FAnimNode_ApplyAdditive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive");
			Base_ = default(FPoseLink);
			Additive = default(FPoseLink);
			Alpha = 0f;
			AlphaScaleBias = default(FInputScaleBias);
			LODThreshold = 0;
			AlphaBoolBlend = default(FInputAlphaBoolBlend);
			AlphaCurveName = default(FName);
			AlphaScaleBiasClamp = default(FInputScaleBiasClamp);
			AlphaInputType = EAnimAlphaInputType.Float;
			AlphaBoolEnabled = false;
		}
		else
		{
			Base_ = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Base__Offset));
			Additive = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Additive_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			LODThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODThreshold_Offset));
			AlphaBoolBlend = FInputAlphaBoolBlend.FromNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset));
			AlphaCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset));
			AlphaScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset));
			AlphaInputType = EnumMarshaler<EAnimAlphaInputType>.FromNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address);
			AlphaBoolEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address);
		}
	}

	static FAnimNode_ApplyAdditive()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_ApplyAdditive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_ApplyAdditive));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive");
		FAnimNode_ApplyAdditive_StructSize = NativeReflection.GetStructSize(intPtr);
		Base__Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Base");
		Base__IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Base", Classes.FStructProperty);
		Additive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Additive");
		Additive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Additive", Classes.FStructProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		AlphaScaleBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBias");
		AlphaScaleBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBias", Classes.FStructProperty);
		LODThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODThreshold");
		LODThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODThreshold", Classes.FIntProperty);
		AlphaBoolBlend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaBoolBlend");
		AlphaBoolBlend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaBoolBlend", Classes.FStructProperty);
		AlphaCurveName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaCurveName");
		AlphaCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaCurveName", Classes.FNameProperty);
		AlphaScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBiasClamp");
		AlphaScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBiasClamp", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaInputType_PropertyAddress, intPtr, "AlphaInputType");
		AlphaInputType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaInputType");
		AlphaInputType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaInputType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaBoolEnabled_PropertyAddress, intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlphaBoolEnabled", Classes.FBoolProperty);
		FAnimNode_ApplyAdditive_IsValid = intPtr != IntPtr.Zero && Base__IsValid && Additive_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && LODThreshold_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive", FAnimNode_ApplyAdditive_IsValid);
	}
}
