using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt", "AnimGraphRuntime", UnrealModuleType.Engine)]
public struct FAnimNode_AimOffsetLookAt
{
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

	private static bool BasePose_IsValid;

	private static int BasePose_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:BasePose")]
	public FPoseLink BasePose;

	private static bool LODThreshold_IsValid;

	private static int LODThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:LODThreshold")]
	public int LODThreshold;

	private static bool SourceSocketName_IsValid;

	private static int SourceSocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:SourceSocketName")]
	public FName SourceSocketName;

	private static bool PivotSocketName_IsValid;

	private static int PivotSocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:PivotSocketName")]
	public FName PivotSocketName;

	private static bool LookAtLocation_IsValid;

	private static int LookAtLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:LookAtLocation")]
	public FVector LookAtLocation;

	private static bool SocketAxis_IsValid;

	private static int SocketAxis_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:SocketAxis")]
	public FVector SocketAxis;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:Alpha")]
	public float Alpha;

	private static bool FAnimNode_AimOffsetLookAt_IsValid;

	private static int FAnimNode_AimOffsetLookAt_StructSize;

	public FAnimNode_AimOffsetLookAt Copy()
	{
		return this;
	}

	public static FAnimNode_AimOffsetLookAt FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNode_AimOffsetLookAt(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNode_AimOffsetLookAt value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNode_AimOffsetLookAt FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNode_AimOffsetLookAt(nativeBuffer + arrayIndex * FAnimNode_AimOffsetLookAt_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNode_AimOffsetLookAt value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNode_AimOffsetLookAt_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNode_AimOffsetLookAt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt");
			return;
		}
		FPoseLink.ToNative(IntPtr.Add(nativeStruct, BasePose_Offset), BasePose);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODThreshold_Offset), LODThreshold);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SourceSocketName_Offset), SourceSocketName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, PivotSocketName_Offset), PivotSocketName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LookAtLocation_Offset), LookAtLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SocketAxis_Offset), SocketAxis);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Alpha_Offset), Alpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendWeight_Offset), BlendWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset), InternalTimeAccumulator);
	}

	public FAnimNode_AimOffsetLookAt(IntPtr nativeStruct)
	{
		if (!FAnimNode_AimOffsetLookAt_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt");
			BasePose = default(FPoseLink);
			LODThreshold = 0;
			SourceSocketName = default(FName);
			PivotSocketName = default(FName);
			LookAtLocation = default(FVector);
			SocketAxis = default(FVector);
			Alpha = 0f;
			BlendWeight = 0f;
			InternalTimeAccumulator = 0f;
		}
		else
		{
			BasePose = FPoseLink.FromNative(IntPtr.Add(nativeStruct, BasePose_Offset));
			LODThreshold = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODThreshold_Offset));
			SourceSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SourceSocketName_Offset));
			PivotSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, PivotSocketName_Offset));
			LookAtLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LookAtLocation_Offset));
			SocketAxis = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SocketAxis_Offset));
			Alpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Alpha_Offset));
			BlendWeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendWeight_Offset));
			InternalTimeAccumulator = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InternalTimeAccumulator_Offset));
		}
	}

	static FAnimNode_AimOffsetLookAt()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNode_AimOffsetLookAt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNode_AimOffsetLookAt));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt");
		FAnimNode_AimOffsetLookAt_StructSize = NativeReflection.GetStructSize(intPtr);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendWeight", Classes.FFloatProperty);
		InternalTimeAccumulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InternalTimeAccumulator");
		InternalTimeAccumulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InternalTimeAccumulator", Classes.FFloatProperty);
		BasePose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BasePose");
		BasePose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BasePose", Classes.FStructProperty);
		LODThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODThreshold");
		LODThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODThreshold", Classes.FIntProperty);
		SourceSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceSocketName");
		SourceSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceSocketName", Classes.FNameProperty);
		PivotSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PivotSocketName");
		PivotSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PivotSocketName", Classes.FNameProperty);
		LookAtLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LookAtLocation");
		LookAtLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LookAtLocation", Classes.FStructProperty);
		SocketAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketAxis");
		SocketAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketAxis", Classes.FStructProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Alpha", Classes.FFloatProperty);
		FAnimNode_AimOffsetLookAt_IsValid = intPtr != IntPtr.Zero && BasePose_IsValid && LODThreshold_IsValid && SourceSocketName_IsValid && PivotSocketName_IsValid && LookAtLocation_IsValid && SocketAxis_IsValid && Alpha_IsValid && BlendWeight_IsValid && InternalTimeAccumulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt", FAnimNode_AimOffsetLookAt_IsValid);
	}
}
