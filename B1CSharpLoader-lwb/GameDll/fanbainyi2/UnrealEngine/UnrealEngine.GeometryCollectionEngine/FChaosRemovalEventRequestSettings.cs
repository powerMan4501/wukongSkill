using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosRemovalEventRequestSettings
{
	private static bool MaxNumberOfResults_IsValid;

	private static int MaxNumberOfResults_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:MaxNumberOfResults")]
	public int MaxNumberOfResults;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:MinMass")]
	public float MinMass;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:MaxDistance")]
	public float MaxDistance;

	private static bool SortMethod_IsValid;

	private static FFieldAddress SortMethod_PropertyAddress;

	private static int SortMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings:SortMethod")]
	public EChaosRemovalSortMethod SortMethod;

	private static bool FChaosRemovalEventRequestSettings_IsValid;

	private static int FChaosRemovalEventRequestSettings_StructSize;

	public FChaosRemovalEventRequestSettings Copy()
	{
		return this;
	}

	public static FChaosRemovalEventRequestSettings FromNative(IntPtr nativeBuffer)
	{
		return new FChaosRemovalEventRequestSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosRemovalEventRequestSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosRemovalEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosRemovalEventRequestSettings(nativeBuffer + arrayIndex * FChaosRemovalEventRequestSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosRemovalEventRequestSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosRemovalEventRequestSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosRemovalEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxNumberOfResults_Offset), MaxNumberOfResults);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		EnumMarshaler<EChaosRemovalSortMethod>.ToNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address, SortMethod);
	}

	public FChaosRemovalEventRequestSettings(IntPtr nativeStruct)
	{
		if (!FChaosRemovalEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings");
			MaxNumberOfResults = 0;
			MinMass = 0f;
			MaxDistance = 0f;
			SortMethod = EChaosRemovalSortMethod.SortNone;
		}
		else
		{
			MaxNumberOfResults = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxNumberOfResults_Offset));
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			SortMethod = EnumMarshaler<EChaosRemovalSortMethod>.FromNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address);
		}
	}

	static FChaosRemovalEventRequestSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosRemovalEventRequestSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosRemovalEventRequestSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings");
		FChaosRemovalEventRequestSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxNumberOfResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxNumberOfResults");
		MaxNumberOfResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxNumberOfResults", Classes.FIntProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SortMethod_PropertyAddress, intPtr, "SortMethod");
		SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SortMethod");
		SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SortMethod", Classes.FEnumProperty);
		FChaosRemovalEventRequestSettings_IsValid = intPtr != IntPtr.Zero && MaxNumberOfResults_IsValid && MinMass_IsValid && MaxDistance_IsValid && SortMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosRemovalEventRequestSettings", FChaosRemovalEventRequestSettings_IsValid);
	}
}
