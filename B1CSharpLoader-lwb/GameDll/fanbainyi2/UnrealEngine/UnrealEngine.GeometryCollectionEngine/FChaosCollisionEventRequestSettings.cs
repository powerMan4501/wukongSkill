using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosCollisionEventRequestSettings
{
	private static bool MaxNumberResults_IsValid;

	private static int MaxNumberResults_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MaxNumberResults")]
	public int MaxNumberResults;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MinMass")]
	public float MinMass;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MinSpeed")]
	public float MinSpeed;

	private static bool MinImpulse_IsValid;

	private static int MinImpulse_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MinImpulse")]
	public float MinImpulse;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:MaxDistance")]
	public float MaxDistance;

	private static bool SortMethod_IsValid;

	private static FFieldAddress SortMethod_PropertyAddress;

	private static int SortMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings:SortMethod")]
	public EChaosCollisionSortMethod SortMethod;

	private static bool FChaosCollisionEventRequestSettings_IsValid;

	private static int FChaosCollisionEventRequestSettings_StructSize;

	public FChaosCollisionEventRequestSettings Copy()
	{
		return this;
	}

	public static FChaosCollisionEventRequestSettings FromNative(IntPtr nativeBuffer)
	{
		return new FChaosCollisionEventRequestSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosCollisionEventRequestSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosCollisionEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosCollisionEventRequestSettings(nativeBuffer + arrayIndex * FChaosCollisionEventRequestSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosCollisionEventRequestSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosCollisionEventRequestSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosCollisionEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxNumberResults_Offset), MaxNumberResults);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSpeed_Offset), MinSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinImpulse_Offset), MinImpulse);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		EnumMarshaler<EChaosCollisionSortMethod>.ToNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address, SortMethod);
	}

	public FChaosCollisionEventRequestSettings(IntPtr nativeStruct)
	{
		if (!FChaosCollisionEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings");
			MaxNumberResults = 0;
			MinMass = 0f;
			MinSpeed = 0f;
			MinImpulse = 0f;
			MaxDistance = 0f;
			SortMethod = EChaosCollisionSortMethod.SortNone;
		}
		else
		{
			MaxNumberResults = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxNumberResults_Offset));
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MinSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSpeed_Offset));
			MinImpulse = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinImpulse_Offset));
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			SortMethod = EnumMarshaler<EChaosCollisionSortMethod>.FromNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address);
		}
	}

	static FChaosCollisionEventRequestSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosCollisionEventRequestSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosCollisionEventRequestSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings");
		FChaosCollisionEventRequestSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxNumberResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxNumberResults");
		MaxNumberResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxNumberResults", Classes.FIntProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		MinImpulse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinImpulse");
		MinImpulse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinImpulse", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SortMethod_PropertyAddress, intPtr, "SortMethod");
		SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SortMethod");
		SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SortMethod", Classes.FEnumProperty);
		FChaosCollisionEventRequestSettings_IsValid = intPtr != IntPtr.Zero && MaxNumberResults_IsValid && MinMass_IsValid && MinSpeed_IsValid && MinImpulse_IsValid && MaxDistance_IsValid && SortMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings", FChaosCollisionEventRequestSettings_IsValid);
	}
}
