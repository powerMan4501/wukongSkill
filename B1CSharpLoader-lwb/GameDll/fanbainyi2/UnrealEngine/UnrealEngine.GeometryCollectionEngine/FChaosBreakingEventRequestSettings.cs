using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosBreakingEventRequestSettings
{
	private static bool MaxNumberOfResults_IsValid;

	private static int MaxNumberOfResults_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MaxNumberOfResults")]
	public int MaxNumberOfResults;

	private static bool MinRadius_IsValid;

	private static int MinRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MinRadius")]
	public float MinRadius;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MinSpeed")]
	public float MinSpeed;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MinMass")]
	public float MinMass;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:MaxDistance")]
	public float MaxDistance;

	private static bool SortMethod_IsValid;

	private static FFieldAddress SortMethod_PropertyAddress;

	private static int SortMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings:SortMethod")]
	public EChaosBreakingSortMethod SortMethod;

	private static bool FChaosBreakingEventRequestSettings_IsValid;

	private static int FChaosBreakingEventRequestSettings_StructSize;

	public FChaosBreakingEventRequestSettings Copy()
	{
		return this;
	}

	public static FChaosBreakingEventRequestSettings FromNative(IntPtr nativeBuffer)
	{
		return new FChaosBreakingEventRequestSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosBreakingEventRequestSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosBreakingEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosBreakingEventRequestSettings(nativeBuffer + arrayIndex * FChaosBreakingEventRequestSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosBreakingEventRequestSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosBreakingEventRequestSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosBreakingEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxNumberOfResults_Offset), MaxNumberOfResults);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinRadius_Offset), MinRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSpeed_Offset), MinSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		EnumMarshaler<EChaosBreakingSortMethod>.ToNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address, SortMethod);
	}

	public FChaosBreakingEventRequestSettings(IntPtr nativeStruct)
	{
		if (!FChaosBreakingEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings");
			MaxNumberOfResults = 0;
			MinRadius = 0f;
			MinSpeed = 0f;
			MinMass = 0f;
			MaxDistance = 0f;
			SortMethod = EChaosBreakingSortMethod.SortNone;
		}
		else
		{
			MaxNumberOfResults = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxNumberOfResults_Offset));
			MinRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinRadius_Offset));
			MinSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSpeed_Offset));
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			SortMethod = EnumMarshaler<EChaosBreakingSortMethod>.FromNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address);
		}
	}

	static FChaosBreakingEventRequestSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosBreakingEventRequestSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosBreakingEventRequestSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings");
		FChaosBreakingEventRequestSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxNumberOfResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxNumberOfResults");
		MaxNumberOfResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxNumberOfResults", Classes.FIntProperty);
		MinRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinRadius");
		MinRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinRadius", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SortMethod_PropertyAddress, intPtr, "SortMethod");
		SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SortMethod");
		SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SortMethod", Classes.FEnumProperty);
		FChaosBreakingEventRequestSettings_IsValid = intPtr != IntPtr.Zero && MaxNumberOfResults_IsValid && MinRadius_IsValid && MinSpeed_IsValid && MinMass_IsValid && MaxDistance_IsValid && SortMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosBreakingEventRequestSettings", FChaosBreakingEventRequestSettings_IsValid);
	}
}
