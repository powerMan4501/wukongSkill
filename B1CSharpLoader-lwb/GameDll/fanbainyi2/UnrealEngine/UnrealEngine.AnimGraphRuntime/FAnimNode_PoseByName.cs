using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseByName", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_PoseByName
{
	private static bool PoseAsset_IsValid;

	private static int PoseAsset_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseHandler:PoseAsset")]
	public UPoseAsset PoseAsset;

	private static bool BlendWeight_IsValid;

	private static int BlendWeight_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase:BlendWeight")]
	public float BlendWeight;

	private static bool InternalTimeAccumulator_IsValid;

	private static int InternalTimeAccumulator_Offset;

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/Engine.AnimNode_AssetPlayerBase:InternalTimeAccumulator")]
	public float InternalTimeAccumulator;

	private static bool PoseName_IsValid;

	private static int PoseName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseByName:PoseName")]
	public FName PoseName;

	private static bool PoseWeight_IsValid;

	private static int PoseWeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_PoseByName:PoseWeight")]
	public float PoseWeight;

	private static bool FAnimNode_PoseByName_IsValid;

	private static int FAnimNode_PoseByName_StructSize;

	public FAnimNode_PoseByName Copy()
	{
		return this;
	}

	public static FAnimNode_PoseByName FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_PoseByName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_PoseByName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_PoseByName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_PoseByName(nativeBuffer + arrayIndex * FAnimNode_PoseByName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_PoseByName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_PoseByName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseByName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseByName");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PoseName_Offset), PoseName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PoseWeight_Offset), PoseWeight);
		UObjectMarshaler<UPoseAsset>.ToNative(IntPtr.Add(nativeStruct, PoseAsset_Offset), PoseAsset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_PoseByName(IntPtr nativeStruct)
	{
		if (!FAnimNode_PoseByName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_PoseByName");
			PoseName = default(FName);
			PoseWeight = 0f;
			PoseAsset = null;
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			PoseName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PoseName_Offset));
			PoseWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PoseWeight_Offset));
			PoseAsset = UObjectMarshaler<UPoseAsset>.FromNative(IntPtr.Add(nativeStruct, PoseAsset_Offset));
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_PoseByName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_PoseByName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_PoseByName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_PoseByName");
		FAnimNode_PoseByName_StructSize = NativeReflection.GetStructSize(intPtr);
		PoseAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PoseAsset");
		PoseAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PoseAsset", Classes.FObjectProperty);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		PoseName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PoseName");
		PoseName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PoseName", Classes.FNameProperty);
		PoseWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PoseWeight");
		PoseWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PoseWeight", Classes.FFloatProperty);
		FAnimNode_PoseByName_IsValid = intPtr != IntPtr.Zero && PoseName_IsValid && PoseWeight_IsValid && PoseAsset_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_PoseByName", FAnimNode_PoseByName_IsValid);
	}
}
