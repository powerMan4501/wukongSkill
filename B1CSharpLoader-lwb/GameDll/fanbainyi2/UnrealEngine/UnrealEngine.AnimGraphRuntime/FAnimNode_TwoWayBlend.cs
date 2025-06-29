using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_TwoWayBlend
{
	private static bool A_IsValid;

	private static int A_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:A")]
	public FPoseLink A;

	private static bool B_IsValid;

	private static int B_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:B")]
	public FPoseLink B;

	private static bool AlphaInputType_IsValid;

	private static FFieldAddress AlphaInputType_PropertyAddress;

	private static int AlphaInputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:AlphaInputType")]
	public EAnimAlphaInputType AlphaInputType;

	private static bool AlphaBoolEnabled_IsValid;

	private static FFieldAddress AlphaBoolEnabled_PropertyAddress;

	private static int AlphaBoolEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:bAlphaBoolEnabled")]
	public bool AlphaBoolEnabled;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:Alpha")]
	public float Alpha;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool AlphaBoolBlend_IsValid;

	private static int AlphaBoolBlend_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:AlphaBoolBlend")]
	public FInputAlphaBoolBlend AlphaBoolBlend;

	private static bool AlphaCurveName_IsValid;

	private static int AlphaCurveName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:AlphaCurveName")]
	public FName AlphaCurveName;

	private static bool AlphaScaleBiasClamp_IsValid;

	private static int AlphaScaleBiasClamp_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend:AlphaScaleBiasClamp")]
	public FInputScaleBiasClamp AlphaScaleBiasClamp;

	private static bool FAnimNode_TwoWayBlend_IsValid;

	private static int FAnimNode_TwoWayBlend_StructSize;

	public FAnimNode_TwoWayBlend Copy()
	{
		return this;
	}

	public static FAnimNode_TwoWayBlend FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_TwoWayBlend(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_TwoWayBlend value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_TwoWayBlend FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_TwoWayBlend(nativeBuffer + arrayIndex * FAnimNode_TwoWayBlend_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_TwoWayBlend value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_TwoWayBlend_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_TwoWayBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, A_Offset), A);
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, B_Offset), B);
		EnumMarshaler<EAnimAlphaInputType>.ToNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address, AlphaInputType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address, AlphaBoolEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
		FInputAlphaBoolBlend.ToNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset), AlphaBoolBlend);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset), AlphaCurveName);
		FInputScaleBiasClamp.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset), AlphaScaleBiasClamp);
	}

	public FAnimNode_TwoWayBlend(IntPtr nativeStruct)
	{
		if (!FAnimNode_TwoWayBlend_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend");
			A = default(FPoseLink);
			B = default(FPoseLink);
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
			A = FPoseLink.FromNative(IntPtr.Add(nativeStruct, A_Offset));
			B = FPoseLink.FromNative(IntPtr.Add(nativeStruct, B_Offset));
			AlphaInputType = EnumMarshaler<EAnimAlphaInputType>.FromNative(IntPtr.Add(nativeStruct, AlphaInputType_Offset), 0, AlphaInputType_PropertyAddress.Address);
			AlphaBoolEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlphaBoolEnabled_Offset), 0, AlphaBoolEnabled_PropertyAddress.Address);
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
			AlphaBoolBlend = FInputAlphaBoolBlend.FromNative(IntPtr.Add(nativeStruct, AlphaBoolBlend_Offset));
			AlphaCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AlphaCurveName_Offset));
			AlphaScaleBiasClamp = FInputScaleBiasClamp.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBiasClamp_Offset));
		}
	}

	static FAnimNode_TwoWayBlend()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_TwoWayBlend)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_TwoWayBlend));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend");
		FAnimNode_TwoWayBlend_StructSize = NativeReflection.GetStructSize(intPtr);
		A_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "A", Classes.FStructProperty);
		B_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "B", Classes.FStructProperty);
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
		FAnimNode_TwoWayBlend_IsValid = intPtr != IntPtr.Zero && A_IsValid && B_IsValid && AlphaInputType_IsValid && AlphaBoolEnabled_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid && AlphaBoolBlend_IsValid && AlphaCurveName_IsValid && AlphaScaleBiasClamp_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_TwoWayBlend", FAnimNode_TwoWayBlend_IsValid);
	}
}
