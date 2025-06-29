using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosCollisionEventData
{
	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Location")]
	public FVector Location;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Normal")]
	public FVector Normal;

	private static bool Velocity1_IsValid;

	private static int Velocity1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Velocity1")]
	public FVector Velocity1;

	private static bool Velocity2_IsValid;

	private static int Velocity2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Velocity2")]
	public FVector Velocity2;

	private static bool Mass1_IsValid;

	private static int Mass1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Mass1")]
	public float Mass1;

	private static bool Mass2_IsValid;

	private static int Mass2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Mass2")]
	public float Mass2;

	private static bool Impulse_IsValid;

	private static int Impulse_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData:Impulse")]
	public FVector Impulse;

	private static bool FChaosCollisionEventData_IsValid;

	private static int FChaosCollisionEventData_StructSize;

	public FChaosCollisionEventData Copy()
	{
		return this;
	}

	public static FChaosCollisionEventData FromNative(IntPtr nativeBuffer)
	{
		return new FChaosCollisionEventData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosCollisionEventData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosCollisionEventData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosCollisionEventData(nativeBuffer + arrayIndex * FChaosCollisionEventData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosCollisionEventData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosCollisionEventData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosCollisionEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosCollisionEventData");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity1_Offset), Velocity1);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Velocity2_Offset), Velocity2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass1_Offset), Mass1);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Mass2_Offset), Mass2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Impulse_Offset), Impulse);
	}

	public FChaosCollisionEventData(IntPtr nativeStruct)
	{
		if (!FChaosCollisionEventData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosCollisionEventData");
			Location = default(FVector);
			Normal = default(FVector);
			Velocity1 = default(FVector);
			Velocity2 = default(FVector);
			Mass1 = 0f;
			Mass2 = 0f;
			Impulse = default(FVector);
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Normal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			Velocity1 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity1_Offset));
			Velocity2 = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Velocity2_Offset));
			Mass1 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass1_Offset));
			Mass2 = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Mass2_Offset));
			Impulse = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Impulse_Offset));
		}
	}

	static FChaosCollisionEventData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosCollisionEventData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosCollisionEventData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosCollisionEventData");
		FChaosCollisionEventData_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		Velocity1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity1");
		Velocity1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity1", Classes.FStructProperty);
		Velocity2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity2");
		Velocity2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity2", Classes.FStructProperty);
		Mass1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass1");
		Mass1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass1", Classes.FFloatProperty);
		Mass2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mass2");
		Mass2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mass2", Classes.FFloatProperty);
		Impulse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Impulse");
		Impulse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Impulse", Classes.FStructProperty);
		FChaosCollisionEventData_IsValid = intPtr != IntPtr.Zero && Location_IsValid && Normal_IsValid && Velocity1_IsValid && Velocity2_IsValid && Mass1_IsValid && Mass2_IsValid && Impulse_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosCollisionEventData", FChaosCollisionEventData_IsValid);
	}
}
