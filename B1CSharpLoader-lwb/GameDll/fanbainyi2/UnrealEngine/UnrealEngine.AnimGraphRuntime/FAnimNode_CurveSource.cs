using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CurveSource", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_CurveSource
{
	private static bool SourcePose_IsValid;

	private static int SourcePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CurveSource:SourcePose")]
	public FPoseLink SourcePose;

	private static bool SourceBinding_IsValid;

	private static int SourceBinding_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CurveSource:SourceBinding")]
	public FName SourceBinding;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_CurveSource:Alpha")]
	public float Alpha;

	private static bool FAnimNode_CurveSource_IsValid;

	private static int FAnimNode_CurveSource_StructSize;

	public FAnimNode_CurveSource Copy()
	{
		return this;
	}

	public static FAnimNode_CurveSource FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_CurveSource(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_CurveSource value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_CurveSource FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_CurveSource(nativeBuffer + arrayIndex * FAnimNode_CurveSource_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_CurveSource value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_CurveSource_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_CurveSource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CurveSource");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, SourcePose_Offset), SourcePose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SourceBinding_Offset), SourceBinding);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
	}

	public FAnimNode_CurveSource(IntPtr nativeStruct)
	{
		if (!FAnimNode_CurveSource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_CurveSource");
			SourcePose = default(FPoseLink);
			SourceBinding = default(FName);
			Alpha = 0f;
		}
		else
		{
			SourcePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, SourcePose_Offset));
			SourceBinding = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SourceBinding_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
		}
	}

	static FAnimNode_CurveSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_CurveSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_CurveSource));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_CurveSource");
		FAnimNode_CurveSource_StructSize = NativeReflection.GetStructSize(intPtr);
		SourcePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourcePose");
		SourcePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourcePose", Classes.FStructProperty);
		SourceBinding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceBinding");
		SourceBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceBinding", Classes.FNameProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		FAnimNode_CurveSource_IsValid = intPtr != IntPtr.Zero && SourcePose_IsValid && SourceBinding_IsValid && Alpha_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_CurveSource", FAnimNode_CurveSource_IsValid);
	}
}
