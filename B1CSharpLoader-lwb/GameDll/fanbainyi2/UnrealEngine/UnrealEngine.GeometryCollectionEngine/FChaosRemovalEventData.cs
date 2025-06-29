using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventData", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosRemovalEventData
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventData:Location")]
	public FVector Location;

	private static bool Mass_IsValid;

	private static int Mass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventData:Mass")]
	public float Mass;

	private static bool ParticleIndex_IsValid;

	private static int ParticleIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventData:ParticleIndex")]
	public int ParticleIndex;

	private static bool FChaosRemovalEventData_IsValid;

	private static int FChaosRemovalEventData_StructSize;

	public FChaosRemovalEventData Copy()
	{
		return this;
	}

	public static FChaosRemovalEventData FromNative(IntPtr nativeBuffer)
	{
		return new FChaosRemovalEventData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosRemovalEventData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosRemovalEventData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosRemovalEventData(nativeBuffer + arrayIndex * FChaosRemovalEventData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosRemovalEventData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosRemovalEventData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosRemovalEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosRemovalEventData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass_Offset), Mass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ParticleIndex_Offset), ParticleIndex);
	}

	public FChaosRemovalEventData(IntPtr nativeStruct)
	{
		if (!FChaosRemovalEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosRemovalEventData");
			Location = default(FVector);
			Mass = 0f;
			ParticleIndex = 0;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Mass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass_Offset));
			ParticleIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ParticleIndex_Offset));
		}
	}

	static FChaosRemovalEventData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosRemovalEventData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosRemovalEventData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosRemovalEventData");
		FChaosRemovalEventData_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Mass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass");
		Mass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass", Classes.FFloatProperty);
		ParticleIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleIndex");
		ParticleIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleIndex", Classes.FIntProperty);
		FChaosRemovalEventData_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Mass_IsValid && ParticleIndex_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosRemovalEventData", FChaosRemovalEventData_IsValid);
	}
}
