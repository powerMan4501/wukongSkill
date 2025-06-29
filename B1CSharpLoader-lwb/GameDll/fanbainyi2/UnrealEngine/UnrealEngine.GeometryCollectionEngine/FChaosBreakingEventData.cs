using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventData", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosBreakingEventData
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventData:Location")]
	public FVector Location;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventData:Velocity")]
	public FVector Velocity;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventData:Mass")]
	public float Mass;

	private static bool FChaosBreakingEventData_IsValid;

	private static int FChaosBreakingEventData_StructSize;

	public FChaosBreakingEventData Copy()
	{
		return this;
	}

	public static FChaosBreakingEventData FromNative(IntPtr nativeBuffer)
	{
		return new FChaosBreakingEventData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosBreakingEventData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosBreakingEventData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosBreakingEventData(nativeBuffer + arrayIndex * FChaosBreakingEventData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosBreakingEventData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosBreakingEventData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosBreakingEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosBreakingEventData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
	}

	public FChaosBreakingEventData(IntPtr nativeStruct)
	{
		if (!FChaosBreakingEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosBreakingEventData");
			Location = default(FVector);
			Velocity = default(FVector);
			Mass = 0f;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Velocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
		}
	}

	static FChaosBreakingEventData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosBreakingEventData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosBreakingEventData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosBreakingEventData");
		FChaosBreakingEventData_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		FChaosBreakingEventData_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Velocity_IsValid && Mass_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosBreakingEventData", FChaosBreakingEventData_IsValid);
	}
}
