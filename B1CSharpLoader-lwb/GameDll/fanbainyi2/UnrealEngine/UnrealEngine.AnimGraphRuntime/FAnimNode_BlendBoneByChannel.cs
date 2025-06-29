using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_BlendBoneByChannel
{
	private static bool A_IsValid;

	private static int A_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:A")]
	public FPoseLink A;

	private static bool B_IsValid;

	private static int B_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:B")]
	public FPoseLink B;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:Alpha")]
	public float Alpha;

	private static bool AlphaScaleBias_IsValid;

	private static int AlphaScaleBias_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel:AlphaScaleBias")]
	public FInputScaleBias AlphaScaleBias;

	private static bool FAnimNode_BlendBoneByChannel_IsValid;

	private static int FAnimNode_BlendBoneByChannel_StructSize;

	public FAnimNode_BlendBoneByChannel Copy()
	{
		return this;
	}

	public static FAnimNode_BlendBoneByChannel FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_BlendBoneByChannel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_BlendBoneByChannel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_BlendBoneByChannel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_BlendBoneByChannel(nativeBuffer + arrayIndex * FAnimNode_BlendBoneByChannel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_BlendBoneByChannel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_BlendBoneByChannel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendBoneByChannel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, A_Offset), A);
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, B_Offset), B);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		FInputScaleBias.ToNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset), AlphaScaleBias);
	}

	public FAnimNode_BlendBoneByChannel(IntPtr nativeStruct)
	{
		if (!FAnimNode_BlendBoneByChannel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel");
			A = default(FPoseLink);
			B = default(FPoseLink);
			Alpha = 0f;
			AlphaScaleBias = default(FInputScaleBias);
		}
		else
		{
			A = FPoseLink.FromNative(IntPtr.Add(nativeStruct, A_Offset));
			B = FPoseLink.FromNative(IntPtr.Add(nativeStruct, B_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			AlphaScaleBias = FInputScaleBias.FromNative(IntPtr.Add(nativeStruct, AlphaScaleBias_Offset));
		}
	}

	static FAnimNode_BlendBoneByChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_BlendBoneByChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_BlendBoneByChannel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel");
		FAnimNode_BlendBoneByChannel_StructSize = NativeReflection.GetStructSize(intPtr);
		A_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "A", Classes.FStructProperty);
		B_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "B", Classes.FStructProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		AlphaScaleBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AlphaScaleBias");
		AlphaScaleBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AlphaScaleBias", Classes.FStructProperty);
		FAnimNode_BlendBoneByChannel_IsValid = intPtr != IntPtr.Zero && A_IsValid && B_IsValid && Alpha_IsValid && AlphaScaleBias_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_BlendBoneByChannel", FAnimNode_BlendBoneByChannel_IsValid);
	}
}
