using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_ScaleChainLength
{
	private static bool DefaultChainLength_IsValid;

	private static int DefaultChainLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength:DefaultChainLength")]
	public float DefaultChainLength;

	private static bool TargetLocation_IsValid;

	private static int TargetLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength:TargetLocation")]
	public FVector TargetLocation;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength:Alpha")]
	public float Alpha;

	private static bool FAnimNode_ScaleChainLength_IsValid;

	private static int FAnimNode_ScaleChainLength_StructSize;

	public FAnimNode_ScaleChainLength Copy()
	{
		return this;
	}

	public static FAnimNode_ScaleChainLength FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_ScaleChainLength(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_ScaleChainLength value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_ScaleChainLength FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_ScaleChainLength(nativeBuffer + arrayIndex * FAnimNode_ScaleChainLength_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_ScaleChainLength value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_ScaleChainLength_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_ScaleChainLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DefaultChainLength_Offset), DefaultChainLength);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, TargetLocation_Offset), TargetLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
	}

	public FAnimNode_ScaleChainLength(IntPtr nativeStruct)
	{
		if (!FAnimNode_ScaleChainLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength");
			DefaultChainLength = 0f;
			TargetLocation = default(FVector);
			Alpha = 0f;
		}
		else
		{
			DefaultChainLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DefaultChainLength_Offset));
			TargetLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, TargetLocation_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
		}
	}

	static FAnimNode_ScaleChainLength()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_ScaleChainLength)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_ScaleChainLength));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength");
		FAnimNode_ScaleChainLength_StructSize = NativeReflection.GetStructSize(intPtr);
		DefaultChainLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultChainLength");
		DefaultChainLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultChainLength", Classes.FFloatProperty);
		TargetLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetLocation");
		TargetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetLocation", Classes.FStructProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		FAnimNode_ScaleChainLength_IsValid = intPtr != IntPtr.Zero && DefaultChainLength_IsValid && TargetLocation_IsValid && Alpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_ScaleChainLength", FAnimNode_ScaleChainLength_IsValid);
	}
}
