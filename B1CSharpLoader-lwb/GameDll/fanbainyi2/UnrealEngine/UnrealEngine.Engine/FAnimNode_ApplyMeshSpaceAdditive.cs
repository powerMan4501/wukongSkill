using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive", "Engine", UnrealModuleType.Engine)]
public struct FAnimNode_ApplyMeshSpaceAdditive
{
	private static bool Base__IsValid;

	private static int Base__Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:Base")]
	public FPoseLink Base_;

	private static bool Additive_IsValid;

	private static int Additive_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:Additive")]
	public FPoseLink Additive;

	private static bool AlphaInputType_IsValid;

	private static FFieldAddress AlphaInputType_PropertyAddress;

	private static int AlphaInputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaInputType")]
	public EAnimAlphaInputType AlphaInputType;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:Alpha")]
	public float Alpha;

	private static bool AlphaBoolEnabled_IsValid;

	private static FFieldAddress AlphaBoolEnabled_PropertyAddress;

	private static int AlphaBoolEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:bAlphaBoolEnabled")]
	public bool AlphaBoolEnabled;

	private static bool AlphaBoolBlend_IsValid;

	private static int AlphaBoolBlend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaBoolBlend")]
	public FInputAlphaBoolBlend AlphaBoolBlend;

	private static bool AlphaCurveName_IsValid;

	private static int AlphaCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaCurveName")]
	public FName AlphaCurveName;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool AlphaScaleBiasClamp_IsValid;

	private static int AlphaScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:AlphaScaleBiasClamp")]
	public FInputScaleBiasClamp AlphaScaleBiasClamp;

	private static bool LODThreshold_IsValid;

	private static int LODThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive:LODThreshold")]
	public int LODThreshold;

	private static bool FAnimNode_ApplyMeshSpaceAdditive_IsValid;

	private static int FAnimNode_ApplyMeshSpaceAdditive_StructSize;

	public FAnimNode_ApplyMeshSpaceAdditive Copy()
	{
		return this;
	}

	public static FAnimNode_ApplyMeshSpaceAdditive FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_ApplyMeshSpaceAdditive(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_ApplyMeshSpaceAdditive value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_ApplyMeshSpaceAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_ApplyMeshSpaceAdditive(nativeBuffer + arrayIndex * FAnimNode_ApplyMeshSpaceAdditive_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_ApplyMeshSpaceAdditive value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_ApplyMeshSpaceAdditive_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_ApplyMeshSpaceAdditive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Base__Offset), Base_);
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, Additive_Offset), Additive);
		EnumMarshaler<EAnimAlphaInputType>.ToNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address, AlphaInputType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address, AlphaBoolEnabled);
		FInputAlphaBoolBlend.ToNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset), AlphaBoolBlend);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset), AlphaCurveName);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset), AlphaScaleBiasClamp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODThreshold_Offset), LODThreshold);
	}

	public FAnimNode_ApplyMeshSpaceAdditive(IntPtr nativeStruct)
	{
		if (!FAnimNode_ApplyMeshSpaceAdditive_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive");
			Base_ = default(FPoseLink);
			Additive = default(FPoseLink);
			AlphaInputType = EAnimAlphaInputType.Float;
			Alpha = 0f;
			AlphaBoolEnabled = false;
			AlphaBoolBlend = default(FInputAlphaBoolBlend);
			AlphaCurveName = default(FName);
			AlphaScaleBias = default(FInputScaleBias);
			AlphaScaleBiasClamp = default(FInputScaleBiasClamp);
			LODThreshold = 0;
		}
		else
		{
			Base_ = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Base__Offset));
			Additive = FPoseLink.FromNative(IntPtr.Add(nativeStruct, Additive_Offset));
			AlphaInputType = EnumMarshaler<EAnimAlphaInputType>.FromNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address);
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaBoolEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address);
			AlphaBoolBlend = FInputAlphaBoolBlend.FromNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset));
			AlphaCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			AlphaScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset));
			LODThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODThreshold_Offset));
		}
	}

	static FAnimNode_ApplyMeshSpaceAdditive()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_ApplyMeshSpaceAdditive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_ApplyMeshSpaceAdditive));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive");
		FAnimNode_ApplyMeshSpaceAdditive_StructSize = NativeReflection.GetStructSize(intPtr);
		Base__Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Base");
		Base__IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Base", Classes.FStructProperty);
		Additive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Additive");
		Additive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Additive", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaInputType_PropertyAddress, intPtr, "AlphaInputType");
		AlphaInputType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaInputType");
		AlphaInputType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaInputType", Classes.FEnumProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AlphaBoolEnabled_PropertyAddress, intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlphaBoolEnabled");
		AlphaBoolEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlphaBoolEnabled", Classes.FBoolProperty);
		AlphaBoolBlend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaBoolBlend");
		AlphaBoolBlend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaBoolBlend", Classes.FStructProperty);
		AlphaCurveName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaCurveName");
		AlphaCurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaCurveName", Classes.FNameProperty);
		AlphaScaleBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBias");
		AlphaScaleBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBias", Classes.FStructProperty);
		AlphaScaleBiasClamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBiasClamp");
		AlphaScaleBiasClamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBiasClamp", Classes.FStructProperty);
		LODThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODThreshold");
		LODThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODThreshold", Classes.FIntProperty);
		FAnimNode_ApplyMeshSpaceAdditive_IsValid = intPtr != IntPtr.Zero && Base__IsValid && Additive_IsValid && AlphaInputType_IsValid && Alpha_IsValid && AlphaBoolEnabled_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBias_IsValid && AlphaScaleBiasClamp_IsValid && LODThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive", FAnimNode_ApplyMeshSpaceAdditive_IsValid);
	}
}
