using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.PredictProjectilePathPointData", "Engine", UnrealModuleType.Engine)]
public struct FPredictProjectilePathPointData
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathPointData:Location")]
	public FVector Location;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathPointData:Velocity")]
	public FVector Velocity;

	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathPointData:Time")]
	public float Time;

	private static bool FPredictProjectilePathPointData_IsValid;

	private static int FPredictProjectilePathPointData_StructSize;

	public FPredictProjectilePathPointData Copy()
	{
		return this;
	}

	public static FPredictProjectilePathPointData FromNative(IntPtr nativeBuffer)
	{
		return new FPredictProjectilePathPointData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPredictProjectilePathPointData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPredictProjectilePathPointData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPredictProjectilePathPointData(nativeBuffer + arrayIndex * FPredictProjectilePathPointData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPredictProjectilePathPointData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPredictProjectilePathPointData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPredictProjectilePathPointData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PredictProjectilePathPointData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
	}

	public FPredictProjectilePathPointData(IntPtr nativeStruct)
	{
		if (!FPredictProjectilePathPointData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PredictProjectilePathPointData");
			Location = default(FVector);
			Velocity = default(FVector);
			Time = 0f;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Velocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
		}
	}

	static FPredictProjectilePathPointData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPredictProjectilePathPointData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPredictProjectilePathPointData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PredictProjectilePathPointData");
		FPredictProjectilePathPointData_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		FPredictProjectilePathPointData_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Velocity_IsValid && Time_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PredictProjectilePathPointData", FPredictProjectilePathPointData_IsValid);
	}
}
