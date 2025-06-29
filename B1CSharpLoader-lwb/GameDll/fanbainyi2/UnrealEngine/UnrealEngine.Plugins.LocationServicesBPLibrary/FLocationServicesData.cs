using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LocationServicesBPLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData", "LocationServicesBPLibrary", UnrealModuleType.EnginePlugin)]
public struct FLocationServicesData
{
	private static bool Timestamp_IsValid;

	private static int Timestamp_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData:Timestamp")]
	public float Timestamp;

	private static bool Longitude_IsValid;

	private static int Longitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData:Longitude")]
	public float Longitude;

	private static bool Latitude_IsValid;

	private static int Latitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData:Latitude")]
	public float Latitude;

	private static bool HorizontalAccuracy_IsValid;

	private static int HorizontalAccuracy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData:HorizontalAccuracy")]
	public float HorizontalAccuracy;

	private static bool VerticalAccuracy_IsValid;

	private static int VerticalAccuracy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData:VerticalAccuracy")]
	public float VerticalAccuracy;

	private static bool Altitude_IsValid;

	private static int Altitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesData:Altitude")]
	public float Altitude;

	private static bool FLocationServicesData_IsValid;

	private static int FLocationServicesData_StructSize;

	public FLocationServicesData Copy()
	{
		return this;
	}

	public static FLocationServicesData FromNative(IntPtr nativeBuffer)
	{
		return new FLocationServicesData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLocationServicesData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLocationServicesData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLocationServicesData(nativeBuffer + arrayIndex * FLocationServicesData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLocationServicesData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLocationServicesData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLocationServicesData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LocationServicesBPLibrary.LocationServicesData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Timestamp_Offset), Timestamp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Longitude_Offset), Longitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Latitude_Offset), Latitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HorizontalAccuracy_Offset), HorizontalAccuracy);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VerticalAccuracy_Offset), VerticalAccuracy);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Altitude_Offset), Altitude);
	}

	public FLocationServicesData(IntPtr nativeStruct)
	{
		if (!FLocationServicesData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LocationServicesBPLibrary.LocationServicesData");
			Timestamp = 0f;
			Longitude = 0f;
			Latitude = 0f;
			HorizontalAccuracy = 0f;
			VerticalAccuracy = 0f;
			Altitude = 0f;
		}
		else
		{
			Timestamp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Timestamp_Offset));
			Longitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Longitude_Offset));
			Latitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Latitude_Offset));
			HorizontalAccuracy = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HorizontalAccuracy_Offset));
			VerticalAccuracy = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VerticalAccuracy_Offset));
			Altitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Altitude_Offset));
		}
	}

	static FLocationServicesData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLocationServicesData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLocationServicesData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LocationServicesBPLibrary.LocationServicesData");
		FLocationServicesData_StructSize = NativeReflection.GetStructSize(intPtr);
		Timestamp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Timestamp");
		Timestamp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Timestamp", Classes.FFloatProperty);
		Longitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Longitude");
		Longitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Longitude", Classes.FFloatProperty);
		Latitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Latitude");
		Latitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Latitude", Classes.FFloatProperty);
		HorizontalAccuracy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAccuracy");
		HorizontalAccuracy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAccuracy", Classes.FFloatProperty);
		VerticalAccuracy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAccuracy");
		VerticalAccuracy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAccuracy", Classes.FFloatProperty);
		Altitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Altitude");
		Altitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Altitude", Classes.FFloatProperty);
		FLocationServicesData_IsValid = intPtr != IntPtr.Zero && Timestamp_IsValid && Longitude_IsValid && Latitude_IsValid && HorizontalAccuracy_IsValid && VerticalAccuracy_IsValid && Altitude_IsValid;
		NativeReflection.LogStructIsValid("/Script/LocationServicesBPLibrary.LocationServicesData", FLocationServicesData_IsValid);
	}
}
