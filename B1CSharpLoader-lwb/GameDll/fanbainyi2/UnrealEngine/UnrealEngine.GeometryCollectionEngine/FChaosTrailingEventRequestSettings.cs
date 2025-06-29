using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GeometryCollectionEngine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings", "GeometryCollectionEngine", UnrealModuleType.Engine)]
public struct FChaosTrailingEventRequestSettings
{
	private static bool MaxNumberOfResults_IsValid;

	private static int MaxNumberOfResults_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MaxNumberOfResults")]
	public int MaxNumberOfResults;

	private static bool MinMass_IsValid;

	private static int MinMass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MinMass")]
	public float MinMass;

	private static bool MinSpeed_IsValid;

	private static int MinSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MinSpeed")]
	public float MinSpeed;

	private static bool MinAngularSpeed_IsValid;

	private static int MinAngularSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MinAngularSpeed")]
	public float MinAngularSpeed;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:MaxDistance")]
	public float MaxDistance;

	private static bool SortMethod_IsValid;

	private static FFieldAddress SortMethod_PropertyAddress;

	private static int SortMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings:SortMethod")]
	public EChaosTrailingSortMethod SortMethod;

	private static bool FChaosTrailingEventRequestSettings_IsValid;

	private static int FChaosTrailingEventRequestSettings_StructSize;

	public FChaosTrailingEventRequestSettings Copy()
	{
		return this;
	}

	public static FChaosTrailingEventRequestSettings FromNative(IntPtr nativeBuffer)
	{
		return new FChaosTrailingEventRequestSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FChaosTrailingEventRequestSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FChaosTrailingEventRequestSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FChaosTrailingEventRequestSettings(nativeBuffer + arrayIndex * FChaosTrailingEventRequestSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FChaosTrailingEventRequestSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FChaosTrailingEventRequestSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FChaosTrailingEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxNumberOfResults_Offset), MaxNumberOfResults);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinMass_Offset), MinMass);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSpeed_Offset), MinSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinAngularSpeed_Offset), MinAngularSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Offset), MaxDistance);
		EnumMarshaler<EChaosTrailingSortMethod>.ToNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address, SortMethod);
	}

	public FChaosTrailingEventRequestSettings(IntPtr nativeStruct)
	{
		if (!FChaosTrailingEventRequestSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings");
			MaxNumberOfResults = 0;
			MinMass = 0f;
			MinSpeed = 0f;
			MinAngularSpeed = 0f;
			MaxDistance = 0f;
			SortMethod = EChaosTrailingSortMethod.SortNone;
		}
		else
		{
			MaxNumberOfResults = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxNumberOfResults_Offset));
			MinMass = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinMass_Offset));
			MinSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSpeed_Offset));
			MinAngularSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinAngularSpeed_Offset));
			MaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Offset));
			SortMethod = EnumMarshaler<EChaosTrailingSortMethod>.FromNative(IntPtr.Add(nativeStruct, SortMethod_Offset), 0, SortMethod_PropertyAddress.Address);
		}
	}

	static FChaosTrailingEventRequestSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FChaosTrailingEventRequestSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FChaosTrailingEventRequestSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings");
		FChaosTrailingEventRequestSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MaxNumberOfResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxNumberOfResults");
		MaxNumberOfResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxNumberOfResults", Classes.FIntProperty);
		MinMass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinMass");
		MinMass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinMass", Classes.FFloatProperty);
		MinSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSpeed");
		MinSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSpeed", Classes.FFloatProperty);
		MinAngularSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinAngularSpeed");
		MinAngularSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinAngularSpeed", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SortMethod_PropertyAddress, intPtr, "SortMethod");
		SortMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SortMethod");
		SortMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SortMethod", Classes.FEnumProperty);
		FChaosTrailingEventRequestSettings_IsValid = intPtr != IntPtr.Zero && MaxNumberOfResults_IsValid && MinMass_IsValid && MinSpeed_IsValid && MinAngularSpeed_IsValid && MaxDistance_IsValid && SortMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryCollectionEngine.ChaosTrailingEventRequestSettings", FChaosTrailingEventRequestSettings_IsValid);
	}
}
