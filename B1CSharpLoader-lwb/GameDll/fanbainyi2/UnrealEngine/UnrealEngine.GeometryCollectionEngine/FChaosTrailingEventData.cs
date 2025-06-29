using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosTrailingEventData
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData:Location")]
	public FVector Location;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData:Velocity")]
	public FVector Velocity;

	private static bool AngularVelocity_IsValid;

	private static int AngularVelocity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData:AngularVelocity")]
	public FVector AngularVelocity;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData:Mass")]
	public float Mass;

	private static bool ParticleIndex_IsValid;

	private static int ParticleIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventData:ParticleIndex")]
	public int ParticleIndex;

	private static bool FChaosTrailingEventData_IsValid;

	private static int FChaosTrailingEventData_StructSize;

	public FChaosTrailingEventData Copy()
	{
		return this;
	}

	public static FChaosTrailingEventData FromNative(IntPtr nativeBuffer)
	{
		return new FChaosTrailingEventData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosTrailingEventData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosTrailingEventData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosTrailingEventData(nativeBuffer + arrayIndex * FChaosTrailingEventData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosTrailingEventData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosTrailingEventData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosTrailingEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosTrailingEventData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity_Offset), Velocity);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AngularVelocity_Offset), AngularVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParticleIndex_Offset), ParticleIndex);
	}

	public FChaosTrailingEventData(IntPtr nativeStruct)
	{
		if (!FChaosTrailingEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosTrailingEventData");
			Location = default(FVector);
			Velocity = default(FVector);
			AngularVelocity = default(FVector);
			Mass = 0f;
			ParticleIndex = 0;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Velocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity_Offset));
			AngularVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AngularVelocity_Offset));
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
			ParticleIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParticleIndex_Offset));
		}
	}

	static FChaosTrailingEventData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosTrailingEventData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosTrailingEventData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosTrailingEventData");
		FChaosTrailingEventData_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		AngularVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularVelocity");
		AngularVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularVelocity", Classes.FStructProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		ParticleIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleIndex");
		ParticleIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleIndex", Classes.FIntProperty);
		FChaosTrailingEventData_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Velocity_IsValid && AngularVelocity_IsValid && Mass_IsValid && ParticleIndex_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosTrailingEventData", FChaosTrailingEventData_IsValid);
	}
}
