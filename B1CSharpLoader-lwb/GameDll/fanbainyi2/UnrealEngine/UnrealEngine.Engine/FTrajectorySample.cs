using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.TrajectorySample", "Engine", UnrealModuleType.Engine)]
public struct FTrajectorySample
{
	private static bool AccumulatedSeconds_IsValid;

	private static int AccumulatedSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TrajectorySample:AccumulatedSeconds")]
	public float AccumulatedSeconds;

	private static bool AccumulatedDistance_IsValid;

	private static int AccumulatedDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TrajectorySample:AccumulatedDistance")]
	public float AccumulatedDistance;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TrajectorySample:Position")]
	public FVector Position;

	private static bool LocalLinearVelocity_IsValid;

	private static int LocalLinearVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TrajectorySample:LocalLinearVelocity")]
	public FVector LocalLinearVelocity;

	private static bool LocalLinearAcceleration_IsValid;

	private static int LocalLinearAcceleration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TrajectorySample:LocalLinearAcceleration")]
	public FVector LocalLinearAcceleration;

	private static bool FTrajectorySample_IsValid;

	private static int FTrajectorySample_StructSize;

	public FTrajectorySample Copy()
	{
		return this;
	}

	public static FTrajectorySample FromNative(IntPtr nativeBuffer)
	{
		return new FTrajectorySample(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTrajectorySample value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTrajectorySample FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTrajectorySample(nativeBuffer + arrayIndex * FTrajectorySample_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTrajectorySample value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTrajectorySample_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTrajectorySample_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TrajectorySample");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AccumulatedSeconds_Offset), AccumulatedSeconds);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AccumulatedDistance_Offset), AccumulatedDistance);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocalLinearVelocity_Offset), LocalLinearVelocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocalLinearAcceleration_Offset), LocalLinearAcceleration);
	}

	public FTrajectorySample(IntPtr nativeStruct)
	{
		if (!FTrajectorySample_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TrajectorySample");
			AccumulatedSeconds = 0f;
			AccumulatedDistance = 0f;
			Position = default(FVector);
			LocalLinearVelocity = default(FVector);
			LocalLinearAcceleration = default(FVector);
		}
		else
		{
			AccumulatedSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AccumulatedSeconds_Offset));
			AccumulatedDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AccumulatedDistance_Offset));
			Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
			LocalLinearVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocalLinearVelocity_Offset));
			LocalLinearAcceleration = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocalLinearAcceleration_Offset));
		}
	}

	static FTrajectorySample()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTrajectorySample)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTrajectorySample));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TrajectorySample");
		FTrajectorySample_StructSize = NativeReflection.GetStructSize(intPtr);
		AccumulatedSeconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AccumulatedSeconds");
		AccumulatedSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AccumulatedSeconds", Classes.FFloatProperty);
		AccumulatedDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AccumulatedDistance");
		AccumulatedDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AccumulatedDistance", Classes.FFloatProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		LocalLinearVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalLinearVelocity");
		LocalLinearVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalLinearVelocity", Classes.FStructProperty);
		LocalLinearAcceleration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalLinearAcceleration");
		LocalLinearAcceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalLinearAcceleration", Classes.FStructProperty);
		FTrajectorySample_IsValid = intPtr != IntPtr.Zero && AccumulatedSeconds_IsValid && AccumulatedDistance_IsValid && Position_IsValid && LocalLinearVelocity_IsValid && LocalLinearAcceleration_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TrajectorySample", FTrajectorySample_IsValid);
	}
}
